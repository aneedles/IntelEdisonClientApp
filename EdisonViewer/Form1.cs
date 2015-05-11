using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Concurrent;

namespace EdisonViewer
{
    public partial class Form1 : Form
    {
// TBD: add volatile for Thread accessed data....

        ConfigDialog configDialog = new ConfigDialog();

        string targetIP;
        const int target_Tcp_Portnum = 10000;
        const int target_Udp_Portnum = 10001;
        const int our_Udp_Portnum = 10001;
        TcpClient tcpClient;
        NetworkStream stream;
        StreamWriter sw;
        StreamReader sr;

        bool attachedToRemoteServer = false;

        long timerTick = 0;
        String cmdResults;

        // UDP setup and control
        private static Thread udpThread = null;
        public static UdpClient ourUdpClient;
        private static IPEndPoint ourUdpRemoteEP;

        // Packet word16 offsets
        private const int PAC_OFS_ABCD_HEADER = 0;
        private const int PAC_OFS_SEQ_NUM = 2;
        private const int PAC_OFS_DIG_OUT = 3;
        private const int PAC_OFS_DIG_IN = 4;
        private const int PAC_OFS_ANA_IN = 5;

        // Packet counters
        private static long UdpRecvTotalCounter = 0;
        private static long UdpRecvValidCounter = 0;
        private static long UdpRecvSkippedCounter = 0;
        private static long UdpRecvDuplicateCounter = 0;

        // Counter for detecting incoming packet rate
        private static int pacCounterForRateIndicator = 0;

        // Last captured sequence number for comparison to next incoming sequence number
        private static UInt16 UdpRecvSeqNumLast = 0;

        // Charting
        const int SIZE_GRAPH_X = 200;
        const int NUM_DIG = 4;
        const int NUM_ANA = 4;
        int[,] pointsDig = new int[NUM_DIG,SIZE_GRAPH_X];
        int[,] pointsAna = new int[NUM_ANA,SIZE_GRAPH_X];

        // Timer variables
        private int stepper = 0;

        // Need to buffer this between chart updates?
        private static volatile UInt16[] incomingData = new UInt16[2560];

        // Charting pause state
        private bool pauseGraphState = false;

        // Thread-safe queue for passing incoming UDP data from "2nd-thread" context to the UI thread
        // Trying ... https://msdn.microsoft.com/en-us/library/dd267265.aspx
        // and ... http://geekswithblogs.net/simonc/archive/2012/01/24/inside-the-concurrent-collections-concurrentqueue.aspx
        // For a string ... http://www.codethinked.com/net-40-and-system_collections_concurrent_concurrentqueue
        private static volatile ConcurrentQueue<UInt16[]> dataQueue;
        private const int LENGTH_DATA = 9;

        private static bool doNotComplainOnLoopExit = false;

//=====================================================================================================================
// STARTUP and SHUTDOWN
//=====================================================================================================================

        public Form1()
        {
            InitializeComponent();
            targetIP = configDialog.ourTargetIP; // Get default IP from the dialog
            toolStripStatusLabel1.Text = "Default target IP is " + targetIP;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Construct a ConcurrentQueue.
            dataQueue = new ConcurrentQueue<UInt16[]>();
            initUI();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tcpClient != null)
            {
                //Socket soc = tcpClient.Client;
                //soc.Disconnect(false);
                //soc.Close();
                //Thread.Sleep(3000);
                toolStripStatusLabel1.Text = "Closing application...";

                // doNotComplainOnLoopExit is used to prevent a exception-driven message later

                // This sequence of "shutdown" took a bit of trial and error to determine
                // what would allow both UI and UDP threads to exit, showing no residual
                // EdisonViewer process on Task Manager.
                try
                {
                    tcpClient.Close();
                    ourUdpClient.Close();
                }
                catch (Exception ee)
                {
                    doNotComplainOnLoopExit = true;
                    MessageBox.Show("Exception in FormClosing()\r\n\r\n" + ee.ToString());
                }

                try
                {
                    if (udpThread.IsAlive)
                    {
                        doNotComplainOnLoopExit = true;
                        udpThread.Abort();
                        udpThread.Join(3000); // Block here as it dies, but release after 3 second timeout
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Exception in FormClosing() while Aborting UDP thread\r\n\r\n" + ee.ToString());
                }
            }
        }

//=====================================================================================================================
// MENU
//=====================================================================================================================
        private void attach_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attach();
        }

        private void attach()
        {
            int loopCount = 0;
            const int loopCountLimit = 40;

            if (attachedToRemoteServer)
            {
                MessageBox.Show("Already attached");
                return;
            }

            toolStripStatusLabel1.Text = "Attempting connect to target " + targetIP + " : " + target_Tcp_Portnum.ToString() + "...";
            // This text never displays, unless we run DoEvents()
            Application.DoEvents();

            try
            {
                tcpClient = new TcpClient();
                tcpClient.BeginConnect(targetIP, target_Tcp_Portnum, null, null);

                toolStripProgressBar1.Enabled = true;
                toolStripProgressBar1.Minimum = 0;
                toolStripProgressBar1.Maximum = loopCountLimit;
                toolStripProgressBar1.Value = 1;
                toolStripProgressBar1.Step = 1;

                while (true)
                {
                    Thread.Sleep(300);

                    if (tcpClient.Connected)
                    {
                        stream = new NetworkStream(tcpClient.Client);
                        sw = new StreamWriter(stream);
                        sr = new StreamReader(stream);
                        toolStripStatusLabel1.Text = "Connected to target " + targetIP + " : " + target_Tcp_Portnum.ToString();
                        groupBox_Commands.Enabled = true;
                        groupBox_Feedback.Enabled = true;
                        attachedToRemoteServer = true;

                        // Startup UDP handling as well, but on a seperate thread.
                        // Setup once, assuming no change to remote target during session.
                        InitUDP_Handler();
                        toolStripProgressBar1.Value = 0;
                        break;
                    }

                    // Advance
                    toolStripProgressBar1.PerformStep();
                    loopCount++;
                    if (loopCount >= loopCountLimit)
                    {
                        toolStripStatusLabel1.Text = "Not Connected to Target " + targetIP;
                        MessageBox.Show("Could not connect to target.");
                        toolStripProgressBar1.Value = 0;
                        tcpClient.Close(); // End the connection in case we connected afterall
                        return;
                    }
                }
                Clear_UPD_Counters();
                comboBox_PacRate.SelectedIndex = 2;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Exception in attach()\r\n\r\n" + ee.ToString());
            }
        }

        private void detachToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            detach();
        }

        private void detach()
        {
            if (!attachedToRemoteServer)
            {
                MessageBox.Show("Already detached");
                return;
            }

            toolStripStatusLabel1.Text = "Disconnected from target" + targetIP;
            groupBox_Commands.Enabled = false;
            groupBox_Feedback.Enabled = false;
            attachedToRemoteServer = false;
            tcpClient.Close();
        }

        private void configureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            configDialog.ShowDialog();
            targetIP = configDialog.ourTargetIP;
            toolStripStatusLabel1.Text = "New target IP is " + targetIP;
        }

        public static void ShowAvailableIP()
        {
            // Popup window of our local network interfaces...
            String locStr = "";
            IPAddress[] ipAddr;
            String hostname = Dns.GetHostName();

            ipAddr = Dns.GetHostAddresses(hostname);
            locStr += String.Format("Available IP addresses for {0}\r\n", hostname);

            int counter = 1;
            foreach (IPAddress ip in ipAddr)
            {
                locStr += String.Format("  {0}:  {1}\r\n", counter++, ip);
            }

            MessageBox.Show(locStr);
        }

//=====================================================================================================================
// Write/Read
//=====================================================================================================================

        String SendCommandToEdison(String cmd)
        {
            String results;

            try
            {
                byte[] buf = System.Text.Encoding.ASCII.GetBytes(cmd);
                stream.Write(buf, 0, buf.Length);
                // NO MESSAGE sw.WriteLine(buf);
                stream.Flush();
                //sw.WriteLine(cmd);
                results = sr.ReadLine(); // TBD: Need a timeout on this in case a packet is dropped !!!
            }
            catch (Exception ee)
            {
                attachedToRemoteServer = false;
                MessageBox.Show("Exception in SendCommandToEdison()\r\n\r\n" + ee.ToString());
                return ("");
            }

            return results;
        }

//=====================================================================================================================
// UDP
//=====================================================================================================================
 
        public static void InitUDP_Handler()
        {
            udpThread = new Thread(UdpHandlerProc);
            udpThread.Start();
        }
 
        public static void UdpHandlerProc()
        {
            try
            {
                // Take anything that comes to our port number
                ourUdpClient = new UdpClient(our_Udp_Portnum);

                ourUdpRemoteEP = new IPEndPoint(IPAddress.Any, 0);
                //ourUdpRemoteEP = new IPEndPoint(IPAddress.Parse("192.168.2.15"), target_Udp_Portnum);
                //ourUdpClient.Connect(ourUdpRemoteEP); // Only accept from this source
            }
            catch (Exception ee)
            {
                MessageBox.Show("Exception in UdpHandlerProc() setup\r\n(UDP receiving thread is being aborted)\r\n\r\n" + ee.ToString());
                return;
            }

            while (true)
            {
                try
                {
                    // Recieve UDP packets and convert to UInt16 format before saving contents
                    Byte[] recvBytes = ourUdpClient.Receive(ref ourUdpRemoteEP);
                    UdpRecvTotalCounter++;

                    UInt16 ourWordLen = (UInt16)(recvBytes.Length / 2);
                    UInt16[] recvWords = new UInt16[ourWordLen];
                    convertDatagramToUInt16(recvBytes, ref recvWords);

                    // Get remote address and portnum
//                    Byte[] ipAddress = ourUdpRemoteEP.Address.GetAddressBytes();
//                    int ipPortnum = ourUdpRemoteEP.Port;

                    // Pass data along
                    incomingUDP(recvWords);

                    // Save to global buffer
                    for (int i = 0; i < recvWords.Length; i++) {
                        incomingData[i] = recvWords[i];
                    }
                }
                catch (Exception ee)
                {
                    // FormClosing leads to this exception, so we surpress it for that particular case
                    // since we are closing down anyway.
                    if (!doNotComplainOnLoopExit)
                    {
                        MessageBox.Show("Exception in UdpHandlerProc() loop\r\n\r\n" + ee.ToString());
                    }
                    break; // Exit while on exception so we can shutdown this thread
                }
            }
        }

        // Called from UDP
        public static void incomingUDP(UInt16[] data)
        {
            UInt16 seqNum = data[2];
            UInt16 seqDiff = 0;

            try {
                // If a good packet
                if ((data[0] == 0xAAAA) || (data[1] == 0xAAAA))
                {
                    UdpRecvValidCounter++;
                    pacCounterForRateIndicator++;
                    // Check if duplicate sequence number
                    if (seqNum == UdpRecvSeqNumLast)
                    {
                        UdpRecvDuplicateCounter++;
                        return; // Discard the packet
                    }
                    // Check if sequence number has advanced just one step
                    seqDiff = (UInt16)(seqNum - 1 - UdpRecvSeqNumLast);
                    if (seqDiff != 0) {
                        UdpRecvSkippedCounter += seqDiff;
                    }

                    UdpRecvSeqNumLast = seqNum;

                    // We cannot call chart_Iterate() from here directly so we save the data
                    // to a thread-safe queue and pick it up on the other end.
                    dataQueue.Enqueue(data);
                }
            }
            catch (Exception ee)
            {
                // "Exception in ***()\r\n\r\n" + 
                throw ee;
            }
        }

        public static void convertDatagramToUInt16(Byte[] bytePac, ref UInt16[] wordPac)
        {
            for (int i = 0; i < bytePac.Length - 1; i += 2)
            {
                wordPac[i >> 1] = (UInt16)((bytePac[i + 1] << 8) + bytePac[i]);
            }
        }

        public static void convertUInt16ToDatagram(UInt16[] wordPac, ref Byte[] bytePac)
        {
            UInt16 aWord;

            for (int i = 0; i < (wordPac.Length * 2) - 1; i += 2)
            {
                aWord = wordPac[i >> 1];
                bytePac[i] = (Byte)aWord;
                bytePac[i + 1] = (Byte)(aWord >> 8);
            }
        }

        // Untested...
        UInt16 exampleOfSending()
        {
            Byte[] bytePac = new Byte[50];
            Byte[] ourAddr = new Byte[] { 192, 168, 2, 15 };
            int status;

            // Recreate each time for now, but perhaps we should avoid if this is called often.
            IPAddress specialLocalSimIP = new IPAddress(ourAddr);
            IPEndPoint specialLocalSimEP = new IPEndPoint(specialLocalSimIP, target_Udp_Portnum);

            bytePac[0] = 1; // Indicate Packet Type 
            bytePac[1] = 1; // "No-op" or connection request signal

            //SendBytePacket(ref bytePac, specialLocalSimEP);
            try
            {
                status = ourUdpClient.Send(bytePac, bytePac.Length, specialLocalSimEP);
                return (UInt16)status;
            }
            catch (Exception)
            {
                MessageBox.Show("Network communication error. Check connections and try again.");
                // We get here if an Ethernet link is lost or if other network errors have occured....
                return (0);
            }

        }

//=====================================================================================================================
// Timer
//=====================================================================================================================

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerTick++;
            toolStripStatusLabel2.Text = timerTick.ToString();

            if (!attachedToRemoteServer) return; // Skip out if not attached

            if (checkBox_GetDigitalInputs.Checked)
            {
                doGetDigitalInputs();
            }
            if (checkBox_GetAnalogInputs.Checked)
            {
                doGetAnalogInputs();
            }

            label_RecvTotal.Text = UdpRecvTotalCounter.ToString();
            long bad = UdpRecvTotalCounter - UdpRecvValidCounter;
            label_RecvValid.Text = bad.ToString();
            label_RecvSkipped.Text = UdpRecvSkippedCounter.ToString();
            label_RecvDuplicate.Text = UdpRecvDuplicateCounter.ToString();

            // Provide an esimtate of incoming packet rate.
            // A fudge factor was needed to improve this reporting. UPD rate was determined using Wireshark.
            // We are also limited in both resolution and the accuracy of the interval timer.
            const float fudgeFactor = 0.97f;
            int divisor = ((int)(fudgeFactor * 1000)) / timer1.Interval;
            // Look once per second
            if (timerTick % divisor == 0) {
                label_PacketRate.Text = pacCounterForRateIndicator.ToString();
                pacCounterForRateIndicator = 0;
            }

            // We run within the UI timer's context.
            chart_Iterate();
        }

//=====================================================================================================================
// User Command Handlers
//=====================================================================================================================

        private void doGetDigitalInputs()
        {
            int intResult;
            cmdResults = SendCommandToEdison("rd\r\n");
            if ((cmdResults == null) || (cmdResults == "")) return;

            intResult = int.Parse(cmdResults);

            if ((intResult & (1 << 0)) == 0)
            {
                checkBox_D5_in.Checked = false;
            }
            else
            {
                checkBox_D5_in.Checked = true;
            }
            if ((intResult & (1 << 1)) == 0)
            {
                checkBox_D6_in.Checked = false;
            }
            else
            {
                checkBox_D6_in.Checked = true;
            }
            if ((intResult & (1 << 2)) == 0)
            {
                checkBox_D7_in.Checked = false;
            }
            else
            {
                checkBox_D7_in.Checked = true;
            }
            if ((intResult & (1 << 3)) == 0)
            {
                checkBox_D8_in.Checked = false;
            }
            else
            {
                checkBox_D8_in.Checked = true;
            }
        }

        private void button_GetDigitalInputs_Click(object sender, EventArgs e)
        {
            doGetDigitalInputs();
        }

        private void doGetAnalogInputs()
        {
            string[] resultsArray;
            cmdResults = SendCommandToEdison("ra\r\n");
            if ((cmdResults == null) || (cmdResults == "")) return;

            resultsArray = cmdResults.Split(',');
            resultsArray[0].Trim();
            resultsArray[1].Trim();
            resultsArray[2].Trim();
            resultsArray[3].Trim();
            label_A0.Text = resultsArray[0];
            label_A1.Text = resultsArray[1];
            label_A2.Text = resultsArray[2];
            label_A3.Text = resultsArray[3];
        }

        private void button_GetAnalogOutputs_Click(object sender, EventArgs e)
        {
            doGetAnalogInputs();
        }

        private void checkBox_D2_out_CheckedChanged(object sender, EventArgs e)
        {
            string cmdStr;

            if (checkBox_D2_out.Checked) {
                cmdStr = "wd0,1\r\n";
            }
            else {
                cmdStr = "wd0,0\r\n";
            }

            cmdResults = SendCommandToEdison(cmdStr);
            //if ((cmdResults == null) || (cmdResults == "")) return;
        }

        private void checkBox_D3_out_CheckedChanged(object sender, EventArgs e)
        {
            string cmdStr;

            if (checkBox_D3_out.Checked)
            {
                cmdStr = "wd1,1\r\n";
            }
            else
            {
                cmdStr = "wd1,0\r\n";
            }

            cmdResults = SendCommandToEdison(cmdStr);
            //if ((cmdResults == null) || (cmdResults == "")) return;
        }

        private void checkBox_D4_out_CheckedChanged(object sender, EventArgs e)
        {
            string cmdStr;

            if (checkBox_D4_out.Checked)
            {
                cmdStr = "wd2,1\r\n";
            }
            else
            {
                cmdStr = "wd2,0\r\n";
            }

            cmdResults = SendCommandToEdison(cmdStr);
            //if ((cmdResults == null) || (cmdResults == "")) return;
        }

        private void button_ClearCounters_Click(object sender, EventArgs e)
        {
            Clear_UPD_Counters();
            stepper = 0;
        }

        private void Clear_UPD_Counters()
        {
            UdpRecvTotalCounter = 0;
            UdpRecvValidCounter = 0;
            UdpRecvSkippedCounter = 0;
            UdpRecvDuplicateCounter = 0;
        }

        private void comboBox_PacRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmdStr;

            switch (comboBox_PacRate.SelectedIndex)
            {
                case 0:
                    cmdStr = "pu1\r\n";
                    break;
                case 1:
                    cmdStr = "pu2\r\n";
                    break;
                case 2:
                    cmdStr = "pu3\r\n";
                    break;
                case 3:
                    cmdStr = "pu4\r\n";
                    break;
                case 4:
                    cmdStr = "pu5\r\n";
                    break;
                case 5:
                    cmdStr = "pu6\r\n";
                    break;
                case 6:
                    cmdStr = "pu7\r\n";
                    break;
                case 7:
                    cmdStr = "pu8\r\n";
                    break;
                case 8:
                    cmdStr = "pu9\r\n";
                    break;
                default:
                    return;
            }

            cmdResults = SendCommandToEdison(cmdStr);
        }

        private void initUI()
        {
            toolStripStatusLabel2.Enabled = false; // To keep it grayed out, but visible

            for (int i = 0; i < NUM_DIG; i++)
            {
                chart_DigitalInputs.Series[i].ChartType = SeriesChartType.StepLine;
            }
            for (int i = 0; i < NUM_ANA; i++)
            {
                chart_AnalogInputs.Series[i].ChartType = SeriesChartType.FastLine;
            }

            chart_DigitalInputs.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart_DigitalInputs.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart_DigitalInputs.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart_DigitalInputs.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart_DigitalInputs.Series[0].LegendText = "D5 In";
            chart_DigitalInputs.Series[1].LegendText = "D6 In";
            chart_DigitalInputs.Series[2].LegendText = "D7 In";
            chart_DigitalInputs.Series[3].LegendText = "D8 In";

            chart_AnalogInputs.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart_AnalogInputs.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart_AnalogInputs.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart_AnalogInputs.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart_AnalogInputs.Series[0].LegendText = "A0 In";
            chart_AnalogInputs.Series[1].LegendText = "A1 In";
            chart_AnalogInputs.Series[2].LegendText = "A2 In";
            chart_AnalogInputs.Series[3].LegendText = "A3 In";
        }

        private void chart_DigitalInputs_DoubleClick(object sender, EventArgs e)
        {
            // Backs up by one zoom, eventually to beginning
            chart_DigitalInputs.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chart_DigitalInputs.ChartAreas[0].AxisY.ScaleView.ZoomReset();
        }

        private void chart_AnalogInputs_DoubleClick(object sender, EventArgs e)
        {
            // Backs up by one zoom, eventually to beginning
            chart_AnalogInputs.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chart_AnalogInputs.ChartAreas[0].AxisY.ScaleView.ZoomReset();
        }

        private void chart_Iterate()
        {
            double ii;
            UInt16[] localBuf;// = new UInt16[20];
            int lbsLen = 0;

            const int MAX_LEN_LOCAL_BUF_SET = 200;
            UInt16[,] localBufSet = new UInt16[MAX_LEN_LOCAL_BUF_SET, LENGTH_DATA];

            // Get incoming data
            while (dataQueue.TryDequeue(out localBuf))
            {
                for (int i = 0; i < LENGTH_DATA; i++)
                {
                    if (lbsLen < MAX_LEN_LOCAL_BUF_SET)
                    {
                        localBufSet[lbsLen, i] = localBuf[i];
                    }
                    // Else warn?
                }
                lbsLen++;
            }
            label_debug1.Text = lbsLen.ToString();
            //if (lbsLen > 10) { label_debug1.Text = "STOP"; } // "label..." is a place for a breakpoint

            if (pauseGraphState | (lbsLen == 0)) {
                return; // Without updating graphs
            }

            chart_DigitalInputs.Series[0].Enabled = checkBox_D5_Ena.Checked;
            chart_DigitalInputs.Series[1].Enabled = checkBox_D6_Ena.Checked;
            chart_DigitalInputs.Series[2].Enabled = checkBox_D7_Ena.Checked;
            chart_DigitalInputs.Series[3].Enabled = checkBox_D8_Ena.Checked;

            chart_AnalogInputs.Series[0].Enabled = checkBox_A0_Ena.Checked;
            chart_AnalogInputs.Series[1].Enabled = checkBox_A1_Ena.Checked;
            chart_AnalogInputs.Series[2].Enabled = checkBox_A2_Ena.Checked;
            chart_AnalogInputs.Series[3].Enabled = checkBox_A3_Ena.Checked;

            // X-axis counter
            stepper += lbsLen;

            // This puts latest data into the graph and prevents overflow
            if (lbsLen > SIZE_GRAPH_X)
            {
                lbsLen = SIZE_GRAPH_X; 
            }

            // DIGITAL INPUTS
            for (int i = 0; i < NUM_DIG; i++)
            {
                // Clear
                chart_DigitalInputs.Series[i].Points.Clear();
                // Shift points downstream (in time)
                // If lbsLen >= SIZE_GRAPH_X, then this loop will skip through, as it should
                for (int j = SIZE_GRAPH_X - lbsLen - 1; j >= 0; j--)
                {
                    pointsDig[i, j + lbsLen] = pointsDig[i, j];
                }
            }
            // Insert the one or more new points
            for (int i = 0; i < NUM_DIG; i++)
            {
                for (int j = 0; j < lbsLen; j++)
                {
                    UInt16 val = localBufSet[lbsLen - 1 - j, PAC_OFS_DIG_IN];
                    pointsDig[i, j] = (int)(((val >> i) & 0x0001) + 6 - 2 * i); // 2*i will shift data relative to each
                }
            }
            //Convert.ToInt16(dataGridView_Positions_JointJog.Rows[selectorJntJog].Cells[1].Value.ToString());

            for (int i = 0; i < NUM_DIG; i++)
            {
                for (int j = 0; j < SIZE_GRAPH_X; j++)
                {
                    ii = (double)(j + stepper);

                    //chart1.Series[0].Points.AddXY(ii, Math.Cos(ii/10));
                    chart_DigitalInputs.Series[i].Points.AddXY(ii, pointsDig[i, j]);
                }
            }

            // ANALOG INPUTS
            for (int i = 0; i < NUM_ANA; i++)
            {
                // Clear
                chart_AnalogInputs.Series[i].Points.Clear();
                // Shift points downstream (in time)
                for (int j = SIZE_GRAPH_X - lbsLen - 1; j >= 0; j--)
                {
                    pointsAna[i, j + lbsLen] = pointsAna[i, j];
                }
            }
            // Insert the one or more new points
            for (int i = 0; i < NUM_ANA; i++)
            {
                for (int j = 0; j < lbsLen; j++)
                {
                    UInt16 val = localBufSet[lbsLen - 1 - j, PAC_OFS_ANA_IN + i];
                    pointsAna[i, j] = (int)val;
                }
                //Convert.ToInt16(dataGridView_Positions_JointJog.Rows[selectorJntJog].Cells[1].Value.ToString());
            }

            for (int i = 0; i < NUM_ANA; i++)
            {
                for (int j = 0; j < SIZE_GRAPH_X; j++)
                {
                    ii = (double)(j + stepper);

                    //chart_AnalogInputs.Series[0].Points.AddXY(ii, Math.Cos(ii / 10));
                    chart_AnalogInputs.Series[i].Points.AddXY(ii, pointsAna[i, j]);
                }
            }

            // Update text fields with most current values
            int tmpInt;
            tmpInt = (int)((incomingData[PAC_OFS_DIG_IN] >> 0) & 0x0001);
            label_graphD5.Text = tmpInt.ToString();
            tmpInt = (int)((incomingData[PAC_OFS_DIG_IN] >> 1) & 0x0001);
            label_graphD6.Text = tmpInt.ToString();
            tmpInt = (int)((incomingData[PAC_OFS_DIG_IN] >> 2) & 0x0001);
            label_graphD7.Text = tmpInt.ToString();
            tmpInt = (int)((incomingData[PAC_OFS_DIG_IN] >> 3) & 0x0001);
            label_graphD8.Text = tmpInt.ToString();

            label_graphA0.Text = incomingData[PAC_OFS_ANA_IN + 0].ToString();
            label_graphA1.Text = incomingData[PAC_OFS_ANA_IN + 1].ToString();
            label_graphA2.Text = incomingData[PAC_OFS_ANA_IN + 2].ToString();
            label_graphA3.Text = incomingData[PAC_OFS_ANA_IN + 3].ToString();
        }

        private void button_PauseGraphs_Click(object sender, EventArgs e)
        {
            if (pauseGraphState)
            {
                button_PauseGraphs.Text = "Pause";
                pauseGraphState = false;
            }
            else
            {
                button_PauseGraphs.Text = "Restart";
                pauseGraphState = true;
            }
        }

    }
}
