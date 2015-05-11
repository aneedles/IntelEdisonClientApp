namespace EdisonViewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.attach_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detachToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_Commands = new System.Windows.Forms.GroupBox();
            this.label_debug1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_D5_in = new System.Windows.Forms.CheckBox();
            this.checkBox_D6_in = new System.Windows.Forms.CheckBox();
            this.checkBox_D7_in = new System.Windows.Forms.CheckBox();
            this.checkBox_D8_in = new System.Windows.Forms.CheckBox();
            this.button_GetDigitalInputs = new System.Windows.Forms.Button();
            this.checkBox_GetDigitalInputs = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_A0 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_A1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_A2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_GetAnalogInputs = new System.Windows.Forms.CheckBox();
            this.label_A3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_GetAnalogOutputs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_D2_out = new System.Windows.Forms.CheckBox();
            this.checkBox_D3_out = new System.Windows.Forms.CheckBox();
            this.checkBox_D4_out = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_PacRate = new System.Windows.Forms.ComboBox();
            this.label_RecvTotal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_Feedback = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label_graphD5 = new System.Windows.Forms.Label();
            this.label_graphD6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label_graphD7 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label_graphD8 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_graphA0 = new System.Windows.Forms.Label();
            this.label_graphA1 = new System.Windows.Forms.Label();
            this.label_graphA2 = new System.Windows.Forms.Label();
            this.label_graphA3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button_PauseGraphs = new System.Windows.Forms.Button();
            this.checkBox_A3_Ena = new System.Windows.Forms.CheckBox();
            this.checkBox_A2_Ena = new System.Windows.Forms.CheckBox();
            this.checkBox_A1_Ena = new System.Windows.Forms.CheckBox();
            this.checkBox_A0_Ena = new System.Windows.Forms.CheckBox();
            this.checkBox_D8_Ena = new System.Windows.Forms.CheckBox();
            this.checkBox_D7_Ena = new System.Windows.Forms.CheckBox();
            this.checkBox_D6_Ena = new System.Windows.Forms.CheckBox();
            this.checkBox_D5_Ena = new System.Windows.Forms.CheckBox();
            this.chart_AnalogInputs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_DigitalInputs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.label_PacketRate = new System.Windows.Forms.Label();
            this.button_ClearCounters = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_RecvDuplicate = new System.Windows.Forms.Label();
            this.label_RecvSkipped = new System.Windows.Forms.Label();
            this.label_RecvValid = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox_Commands.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Feedback.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_AnalogInputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DigitalInputs)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attach_ToolStripMenuItem,
            this.detachToolStripMenuItem1,
            this.configureToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // attach_ToolStripMenuItem
            // 
            this.attach_ToolStripMenuItem.Name = "attach_ToolStripMenuItem";
            this.attach_ToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.attach_ToolStripMenuItem.Text = "Attach";
            this.attach_ToolStripMenuItem.Click += new System.EventHandler(this.attach_ToolStripMenuItem_Click);
            // 
            // detachToolStripMenuItem1
            // 
            this.detachToolStripMenuItem1.Name = "detachToolStripMenuItem1";
            this.detachToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.detachToolStripMenuItem1.Text = "Detach";
            this.detachToolStripMenuItem1.Click += new System.EventHandler(this.detachToolStripMenuItem1_Click);
            // 
            // configureToolStripMenuItem1
            // 
            this.configureToolStripMenuItem1.Name = "configureToolStripMenuItem1";
            this.configureToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.configureToolStripMenuItem1.Text = "Configure...";
            this.configureToolStripMenuItem1.Click += new System.EventHandler(this.configureToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "no text";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(500, 17);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(400, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 15);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // groupBox_Commands
            // 
            this.groupBox_Commands.Controls.Add(this.label_debug1);
            this.groupBox_Commands.Controls.Add(this.groupBox3);
            this.groupBox_Commands.Controls.Add(this.groupBox2);
            this.groupBox_Commands.Controls.Add(this.groupBox1);
            this.groupBox_Commands.Controls.Add(this.label13);
            this.groupBox_Commands.Controls.Add(this.label12);
            this.groupBox_Commands.Controls.Add(this.comboBox_PacRate);
            this.groupBox_Commands.Enabled = false;
            this.groupBox_Commands.Location = new System.Drawing.Point(12, 41);
            this.groupBox_Commands.Name = "groupBox_Commands";
            this.groupBox_Commands.Size = new System.Drawing.Size(140, 596);
            this.groupBox_Commands.TabIndex = 2;
            this.groupBox_Commands.TabStop = false;
            this.groupBox_Commands.Text = "Commands (TCP):";
            // 
            // label_debug1
            // 
            this.label_debug1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_debug1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_debug1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_debug1.Location = new System.Drawing.Point(69, 572);
            this.label_debug1.Name = "label_debug1";
            this.label_debug1.Size = new System.Drawing.Size(49, 20);
            this.label_debug1.TabIndex = 51;
            this.label_debug1.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.checkBox_D5_in);
            this.groupBox3.Controls.Add(this.checkBox_D6_in);
            this.groupBox3.Controls.Add(this.checkBox_D7_in);
            this.groupBox3.Controls.Add(this.checkBox_D8_in);
            this.groupBox3.Controls.Add(this.button_GetDigitalInputs);
            this.groupBox3.Controls.Add(this.checkBox_GetDigitalInputs);
            this.groupBox3.Location = new System.Drawing.Point(9, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 145);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Get Digital Inputs";
            // 
            // checkBox_D5_in
            // 
            this.checkBox_D5_in.AutoSize = true;
            this.checkBox_D5_in.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_D5_in.Location = new System.Drawing.Point(15, 50);
            this.checkBox_D5_in.Name = "checkBox_D5_in";
            this.checkBox_D5_in.Size = new System.Drawing.Size(52, 17);
            this.checkBox_D5_in.TabIndex = 0;
            this.checkBox_D5_in.Text = "D5 In";
            this.checkBox_D5_in.UseVisualStyleBackColor = true;
            // 
            // checkBox_D6_in
            // 
            this.checkBox_D6_in.AutoSize = true;
            this.checkBox_D6_in.Location = new System.Drawing.Point(15, 73);
            this.checkBox_D6_in.Name = "checkBox_D6_in";
            this.checkBox_D6_in.Size = new System.Drawing.Size(52, 17);
            this.checkBox_D6_in.TabIndex = 3;
            this.checkBox_D6_in.Text = "D6 In";
            this.checkBox_D6_in.UseVisualStyleBackColor = true;
            // 
            // checkBox_D7_in
            // 
            this.checkBox_D7_in.AutoSize = true;
            this.checkBox_D7_in.Location = new System.Drawing.Point(15, 96);
            this.checkBox_D7_in.Name = "checkBox_D7_in";
            this.checkBox_D7_in.Size = new System.Drawing.Size(52, 17);
            this.checkBox_D7_in.TabIndex = 4;
            this.checkBox_D7_in.Text = "D7 In";
            this.checkBox_D7_in.UseVisualStyleBackColor = true;
            // 
            // checkBox_D8_in
            // 
            this.checkBox_D8_in.AutoSize = true;
            this.checkBox_D8_in.Location = new System.Drawing.Point(15, 119);
            this.checkBox_D8_in.Name = "checkBox_D8_in";
            this.checkBox_D8_in.Size = new System.Drawing.Size(52, 17);
            this.checkBox_D8_in.TabIndex = 17;
            this.checkBox_D8_in.Text = "D8 In";
            this.checkBox_D8_in.UseVisualStyleBackColor = true;
            // 
            // button_GetDigitalInputs
            // 
            this.button_GetDigitalInputs.Location = new System.Drawing.Point(6, 19);
            this.button_GetDigitalInputs.Name = "button_GetDigitalInputs";
            this.button_GetDigitalInputs.Size = new System.Drawing.Size(43, 23);
            this.button_GetDigitalInputs.TabIndex = 0;
            this.button_GetDigitalInputs.Text = "Once";
            this.button_GetDigitalInputs.UseVisualStyleBackColor = true;
            this.button_GetDigitalInputs.Click += new System.EventHandler(this.button_GetDigitalInputs_Click);
            // 
            // checkBox_GetDigitalInputs
            // 
            this.checkBox_GetDigitalInputs.AutoSize = true;
            this.checkBox_GetDigitalInputs.Location = new System.Drawing.Point(51, 23);
            this.checkBox_GetDigitalInputs.Name = "checkBox_GetDigitalInputs";
            this.checkBox_GetDigitalInputs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_GetDigitalInputs.Size = new System.Drawing.Size(61, 17);
            this.checkBox_GetDigitalInputs.TabIndex = 16;
            this.checkBox_GetDigitalInputs.Text = "Repeat";
            this.checkBox_GetDigitalInputs.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label_A0);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label_A1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label_A2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkBox_GetAnalogInputs);
            this.groupBox2.Controls.Add(this.label_A3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button_GetAnalogOutputs);
            this.groupBox2.Location = new System.Drawing.Point(9, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 159);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get Analog Inputs";
            // 
            // label_A0
            // 
            this.label_A0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_A0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_A0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_A0.Location = new System.Drawing.Point(41, 57);
            this.label_A0.Name = "label_A0";
            this.label_A0.Size = new System.Drawing.Size(69, 24);
            this.label_A0.TabIndex = 0;
            this.label_A0.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "A0:";
            // 
            // label_A1
            // 
            this.label_A1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_A1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_A1.Location = new System.Drawing.Point(41, 81);
            this.label_A1.Name = "label_A1";
            this.label_A1.Size = new System.Drawing.Size(69, 24);
            this.label_A1.TabIndex = 6;
            this.label_A1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "A1:";
            // 
            // label_A2
            // 
            this.label_A2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_A2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_A2.Location = new System.Drawing.Point(41, 105);
            this.label_A2.Name = "label_A2";
            this.label_A2.Size = new System.Drawing.Size(69, 24);
            this.label_A2.TabIndex = 8;
            this.label_A2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "A2:";
            // 
            // checkBox_GetAnalogInputs
            // 
            this.checkBox_GetAnalogInputs.AutoSize = true;
            this.checkBox_GetAnalogInputs.Location = new System.Drawing.Point(49, 23);
            this.checkBox_GetAnalogInputs.Name = "checkBox_GetAnalogInputs";
            this.checkBox_GetAnalogInputs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_GetAnalogInputs.Size = new System.Drawing.Size(61, 17);
            this.checkBox_GetAnalogInputs.TabIndex = 0;
            this.checkBox_GetAnalogInputs.Text = "Repeat";
            this.checkBox_GetAnalogInputs.UseVisualStyleBackColor = true;
            // 
            // label_A3
            // 
            this.label_A3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_A3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_A3.Location = new System.Drawing.Point(41, 129);
            this.label_A3.Name = "label_A3";
            this.label_A3.Size = new System.Drawing.Size(69, 24);
            this.label_A3.TabIndex = 10;
            this.label_A3.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "A3:";
            // 
            // button_GetAnalogOutputs
            // 
            this.button_GetAnalogOutputs.Location = new System.Drawing.Point(6, 19);
            this.button_GetAnalogOutputs.Name = "button_GetAnalogOutputs";
            this.button_GetAnalogOutputs.Size = new System.Drawing.Size(43, 23);
            this.button_GetAnalogOutputs.TabIndex = 5;
            this.button_GetAnalogOutputs.Text = "Once";
            this.button_GetAnalogOutputs.UseVisualStyleBackColor = true;
            this.button_GetAnalogOutputs.Click += new System.EventHandler(this.button_GetAnalogOutputs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.checkBox_D2_out);
            this.groupBox1.Controls.Add(this.checkBox_D3_out);
            this.groupBox1.Controls.Add(this.checkBox_D4_out);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 90);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Digital Outputs";
            // 
            // checkBox_D2_out
            // 
            this.checkBox_D2_out.AutoSize = true;
            this.checkBox_D2_out.Location = new System.Drawing.Point(15, 23);
            this.checkBox_D2_out.Name = "checkBox_D2_out";
            this.checkBox_D2_out.Size = new System.Drawing.Size(60, 17);
            this.checkBox_D2_out.TabIndex = 1;
            this.checkBox_D2_out.Text = "D2 Out";
            this.checkBox_D2_out.UseVisualStyleBackColor = true;
            this.checkBox_D2_out.CheckedChanged += new System.EventHandler(this.checkBox_D2_out_CheckedChanged);
            // 
            // checkBox_D3_out
            // 
            this.checkBox_D3_out.AutoSize = true;
            this.checkBox_D3_out.Location = new System.Drawing.Point(15, 46);
            this.checkBox_D3_out.Name = "checkBox_D3_out";
            this.checkBox_D3_out.Size = new System.Drawing.Size(60, 17);
            this.checkBox_D3_out.TabIndex = 13;
            this.checkBox_D3_out.Text = "D3 Out";
            this.checkBox_D3_out.UseVisualStyleBackColor = true;
            this.checkBox_D3_out.CheckedChanged += new System.EventHandler(this.checkBox_D3_out_CheckedChanged);
            // 
            // checkBox_D4_out
            // 
            this.checkBox_D4_out.AutoSize = true;
            this.checkBox_D4_out.Location = new System.Drawing.Point(15, 69);
            this.checkBox_D4_out.Name = "checkBox_D4_out";
            this.checkBox_D4_out.Size = new System.Drawing.Size(60, 17);
            this.checkBox_D4_out.TabIndex = 14;
            this.checkBox_D4_out.Text = "D4 Out";
            this.checkBox_D4_out.UseVisualStyleBackColor = true;
            this.checkBox_D4_out.CheckedChanged += new System.EventHandler(this.checkBox_D4_out_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 514);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "UPD rate (approx):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 575);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "# Buffered:";
            // 
            // comboBox_PacRate
            // 
            this.comboBox_PacRate.FormattingEnabled = true;
            this.comboBox_PacRate.Items.AddRange(new object[] {
            "1Hz",
            "5Hz",
            "10Hz",
            "50Hz",
            "100Hz",
            "500Hz",
            "1000Hz",
            "5000Hz",
            "10000Hz"});
            this.comboBox_PacRate.Location = new System.Drawing.Point(6, 534);
            this.comboBox_PacRate.Name = "comboBox_PacRate";
            this.comboBox_PacRate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_PacRate.TabIndex = 30;
            this.comboBox_PacRate.Text = "Select...";
            this.comboBox_PacRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_PacRate_SelectedIndexChanged);
            // 
            // label_RecvTotal
            // 
            this.label_RecvTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_RecvTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_RecvTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RecvTotal.Location = new System.Drawing.Point(76, 573);
            this.label_RecvTotal.Name = "label_RecvTotal";
            this.label_RecvTotal.Size = new System.Drawing.Size(83, 20);
            this.label_RecvTotal.TabIndex = 18;
            this.label_RecvTotal.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox_Feedback
            // 
            this.groupBox_Feedback.Controls.Add(this.groupBox5);
            this.groupBox_Feedback.Controls.Add(this.groupBox4);
            this.groupBox_Feedback.Controls.Add(this.button_PauseGraphs);
            this.groupBox_Feedback.Controls.Add(this.checkBox_A3_Ena);
            this.groupBox_Feedback.Controls.Add(this.checkBox_A2_Ena);
            this.groupBox_Feedback.Controls.Add(this.checkBox_A1_Ena);
            this.groupBox_Feedback.Controls.Add(this.checkBox_A0_Ena);
            this.groupBox_Feedback.Controls.Add(this.checkBox_D8_Ena);
            this.groupBox_Feedback.Controls.Add(this.checkBox_D7_Ena);
            this.groupBox_Feedback.Controls.Add(this.checkBox_D6_Ena);
            this.groupBox_Feedback.Controls.Add(this.checkBox_D5_Ena);
            this.groupBox_Feedback.Controls.Add(this.chart_AnalogInputs);
            this.groupBox_Feedback.Controls.Add(this.chart_DigitalInputs);
            this.groupBox_Feedback.Controls.Add(this.label11);
            this.groupBox_Feedback.Controls.Add(this.label_PacketRate);
            this.groupBox_Feedback.Controls.Add(this.button_ClearCounters);
            this.groupBox_Feedback.Controls.Add(this.label9);
            this.groupBox_Feedback.Controls.Add(this.label5);
            this.groupBox_Feedback.Controls.Add(this.label8);
            this.groupBox_Feedback.Controls.Add(this.label7);
            this.groupBox_Feedback.Controls.Add(this.label_RecvDuplicate);
            this.groupBox_Feedback.Controls.Add(this.label_RecvSkipped);
            this.groupBox_Feedback.Controls.Add(this.label_RecvValid);
            this.groupBox_Feedback.Controls.Add(this.label_RecvTotal);
            this.groupBox_Feedback.Enabled = false;
            this.groupBox_Feedback.Location = new System.Drawing.Point(158, 41);
            this.groupBox_Feedback.Name = "groupBox_Feedback";
            this.groupBox_Feedback.Size = new System.Drawing.Size(814, 596);
            this.groupBox_Feedback.TabIndex = 3;
            this.groupBox_Feedback.TabStop = false;
            this.groupBox_Feedback.Text = "Feedback (UDP):";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.label_graphD5);
            this.groupBox5.Controls.Add(this.label_graphD6);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label_graphD7);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label_graphD8);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Location = new System.Drawing.Point(13, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(110, 129);
            this.groupBox5.TabIndex = 58;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Digital Inputs";
            // 
            // label_graphD5
            // 
            this.label_graphD5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_graphD5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_graphD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_graphD5.Location = new System.Drawing.Point(54, 21);
            this.label_graphD5.Name = "label_graphD5";
            this.label_graphD5.Size = new System.Drawing.Size(23, 24);
            this.label_graphD5.TabIndex = 49;
            this.label_graphD5.Text = "0";
            // 
            // label_graphD6
            // 
            this.label_graphD6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_graphD6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_graphD6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_graphD6.Location = new System.Drawing.Point(54, 45);
            this.label_graphD6.Name = "label_graphD6";
            this.label_graphD6.Size = new System.Drawing.Size(23, 24);
            this.label_graphD6.TabIndex = 50;
            this.label_graphD6.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 13);
            this.label20.TabIndex = 56;
            this.label20.Text = "D8:";
            // 
            // label_graphD7
            // 
            this.label_graphD7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_graphD7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_graphD7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_graphD7.Location = new System.Drawing.Point(54, 69);
            this.label_graphD7.Name = "label_graphD7";
            this.label_graphD7.Size = new System.Drawing.Size(23, 24);
            this.label_graphD7.TabIndex = 51;
            this.label_graphD7.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(25, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 13);
            this.label21.TabIndex = 55;
            this.label21.Text = "D7:";
            // 
            // label_graphD8
            // 
            this.label_graphD8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_graphD8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_graphD8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_graphD8.Location = new System.Drawing.Point(54, 93);
            this.label_graphD8.Name = "label_graphD8";
            this.label_graphD8.Size = new System.Drawing.Size(23, 24);
            this.label_graphD8.TabIndex = 52;
            this.label_graphD8.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(25, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 54;
            this.label22.Text = "D6:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(25, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 13);
            this.label23.TabIndex = 53;
            this.label23.Text = "D5:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.label_graphA0);
            this.groupBox4.Controls.Add(this.label_graphA1);
            this.groupBox4.Controls.Add(this.label_graphA2);
            this.groupBox4.Controls.Add(this.label_graphA3);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(16, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(110, 122);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Analog Inputs";
            // 
            // label_graphA0
            // 
            this.label_graphA0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_graphA0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_graphA0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_graphA0.Location = new System.Drawing.Point(38, 19);
            this.label_graphA0.Name = "label_graphA0";
            this.label_graphA0.Size = new System.Drawing.Size(69, 24);
            this.label_graphA0.TabIndex = 41;
            this.label_graphA0.Text = "0";
            // 
            // label_graphA1
            // 
            this.label_graphA1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_graphA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_graphA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_graphA1.Location = new System.Drawing.Point(38, 43);
            this.label_graphA1.Name = "label_graphA1";
            this.label_graphA1.Size = new System.Drawing.Size(69, 24);
            this.label_graphA1.TabIndex = 42;
            this.label_graphA1.Text = "0";
            // 
            // label_graphA2
            // 
            this.label_graphA2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_graphA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_graphA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_graphA2.Location = new System.Drawing.Point(38, 67);
            this.label_graphA2.Name = "label_graphA2";
            this.label_graphA2.Size = new System.Drawing.Size(69, 24);
            this.label_graphA2.TabIndex = 43;
            this.label_graphA2.Text = "0";
            // 
            // label_graphA3
            // 
            this.label_graphA3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_graphA3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_graphA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_graphA3.Location = new System.Drawing.Point(38, 91);
            this.label_graphA3.Name = "label_graphA3";
            this.label_graphA3.Size = new System.Drawing.Size(69, 24);
            this.label_graphA3.TabIndex = 44;
            this.label_graphA3.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "A0:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 46;
            this.label18.Text = "A1:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "A2:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 48;
            this.label16.Text = "A3:";
            // 
            // button_PauseGraphs
            // 
            this.button_PauseGraphs.Location = new System.Drawing.Point(16, 514);
            this.button_PauseGraphs.Name = "button_PauseGraphs";
            this.button_PauseGraphs.Size = new System.Drawing.Size(110, 41);
            this.button_PauseGraphs.TabIndex = 40;
            this.button_PauseGraphs.Text = "Pause Graphs";
            this.button_PauseGraphs.UseVisualStyleBackColor = true;
            this.button_PauseGraphs.Click += new System.EventHandler(this.button_PauseGraphs_Click);
            // 
            // checkBox_A3_Ena
            // 
            this.checkBox_A3_Ena.AutoSize = true;
            this.checkBox_A3_Ena.Checked = true;
            this.checkBox_A3_Ena.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_A3_Ena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_A3_Ena.Location = new System.Drawing.Point(62, 486);
            this.checkBox_A3_Ena.Name = "checkBox_A3_Ena";
            this.checkBox_A3_Ena.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_A3_Ena.Size = new System.Drawing.Size(61, 17);
            this.checkBox_A3_Ena.TabIndex = 39;
            this.checkBox_A3_Ena.Text = "A3 Ena";
            this.checkBox_A3_Ena.UseVisualStyleBackColor = true;
            // 
            // checkBox_A2_Ena
            // 
            this.checkBox_A2_Ena.AutoSize = true;
            this.checkBox_A2_Ena.Checked = true;
            this.checkBox_A2_Ena.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_A2_Ena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_A2_Ena.Location = new System.Drawing.Point(62, 463);
            this.checkBox_A2_Ena.Name = "checkBox_A2_Ena";
            this.checkBox_A2_Ena.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_A2_Ena.Size = new System.Drawing.Size(61, 17);
            this.checkBox_A2_Ena.TabIndex = 38;
            this.checkBox_A2_Ena.Text = "A2 Ena";
            this.checkBox_A2_Ena.UseVisualStyleBackColor = true;
            // 
            // checkBox_A1_Ena
            // 
            this.checkBox_A1_Ena.AutoSize = true;
            this.checkBox_A1_Ena.Checked = true;
            this.checkBox_A1_Ena.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_A1_Ena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_A1_Ena.Location = new System.Drawing.Point(62, 440);
            this.checkBox_A1_Ena.Name = "checkBox_A1_Ena";
            this.checkBox_A1_Ena.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_A1_Ena.Size = new System.Drawing.Size(61, 17);
            this.checkBox_A1_Ena.TabIndex = 37;
            this.checkBox_A1_Ena.Text = "A1 Ena";
            this.checkBox_A1_Ena.UseVisualStyleBackColor = true;
            // 
            // checkBox_A0_Ena
            // 
            this.checkBox_A0_Ena.AutoSize = true;
            this.checkBox_A0_Ena.Checked = true;
            this.checkBox_A0_Ena.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_A0_Ena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_A0_Ena.Location = new System.Drawing.Point(62, 417);
            this.checkBox_A0_Ena.Name = "checkBox_A0_Ena";
            this.checkBox_A0_Ena.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_A0_Ena.Size = new System.Drawing.Size(61, 17);
            this.checkBox_A0_Ena.TabIndex = 36;
            this.checkBox_A0_Ena.Text = "A0 Ena";
            this.checkBox_A0_Ena.UseVisualStyleBackColor = true;
            // 
            // checkBox_D8_Ena
            // 
            this.checkBox_D8_Ena.AutoSize = true;
            this.checkBox_D8_Ena.Checked = true;
            this.checkBox_D8_Ena.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_D8_Ena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_D8_Ena.Location = new System.Drawing.Point(61, 242);
            this.checkBox_D8_Ena.Name = "checkBox_D8_Ena";
            this.checkBox_D8_Ena.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_D8_Ena.Size = new System.Drawing.Size(62, 17);
            this.checkBox_D8_Ena.TabIndex = 35;
            this.checkBox_D8_Ena.Text = "D8 Ena";
            this.checkBox_D8_Ena.UseVisualStyleBackColor = true;
            // 
            // checkBox_D7_Ena
            // 
            this.checkBox_D7_Ena.AutoSize = true;
            this.checkBox_D7_Ena.Checked = true;
            this.checkBox_D7_Ena.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_D7_Ena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_D7_Ena.Location = new System.Drawing.Point(61, 219);
            this.checkBox_D7_Ena.Name = "checkBox_D7_Ena";
            this.checkBox_D7_Ena.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_D7_Ena.Size = new System.Drawing.Size(62, 17);
            this.checkBox_D7_Ena.TabIndex = 34;
            this.checkBox_D7_Ena.Text = "D7 Ena";
            this.checkBox_D7_Ena.UseVisualStyleBackColor = true;
            // 
            // checkBox_D6_Ena
            // 
            this.checkBox_D6_Ena.AutoSize = true;
            this.checkBox_D6_Ena.Checked = true;
            this.checkBox_D6_Ena.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_D6_Ena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_D6_Ena.Location = new System.Drawing.Point(61, 196);
            this.checkBox_D6_Ena.Name = "checkBox_D6_Ena";
            this.checkBox_D6_Ena.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_D6_Ena.Size = new System.Drawing.Size(62, 17);
            this.checkBox_D6_Ena.TabIndex = 33;
            this.checkBox_D6_Ena.Text = "D6 Ena";
            this.checkBox_D6_Ena.UseVisualStyleBackColor = true;
            // 
            // checkBox_D5_Ena
            // 
            this.checkBox_D5_Ena.AutoSize = true;
            this.checkBox_D5_Ena.Checked = true;
            this.checkBox_D5_Ena.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_D5_Ena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_D5_Ena.Location = new System.Drawing.Point(61, 172);
            this.checkBox_D5_Ena.Name = "checkBox_D5_Ena";
            this.checkBox_D5_Ena.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_D5_Ena.Size = new System.Drawing.Size(62, 17);
            this.checkBox_D5_Ena.TabIndex = 32;
            this.checkBox_D5_Ena.Text = "D5 Ena";
            this.checkBox_D5_Ena.UseVisualStyleBackColor = true;
            // 
            // chart_AnalogInputs
            // 
            this.chart_AnalogInputs.BorderlineColor = System.Drawing.Color.Black;
            this.chart_AnalogInputs.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart_AnalogInputs.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chart_AnalogInputs.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_AnalogInputs.Legends.Add(legend1);
            this.chart_AnalogInputs.Location = new System.Drawing.Point(132, 286);
            this.chart_AnalogInputs.Name = "chart_AnalogInputs";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            this.chart_AnalogInputs.Series.Add(series1);
            this.chart_AnalogInputs.Series.Add(series2);
            this.chart_AnalogInputs.Series.Add(series3);
            this.chart_AnalogInputs.Series.Add(series4);
            this.chart_AnalogInputs.Size = new System.Drawing.Size(676, 269);
            this.chart_AnalogInputs.TabIndex = 31;
            this.chart_AnalogInputs.Text = "chart1";
            this.chart_AnalogInputs.DoubleClick += new System.EventHandler(this.chart_AnalogInputs_DoubleClick);
            // 
            // chart_DigitalInputs
            // 
            this.chart_DigitalInputs.BorderlineColor = System.Drawing.Color.Black;
            this.chart_DigitalInputs.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart_DigitalInputs.BorderlineWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chart_DigitalInputs.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_DigitalInputs.Legends.Add(legend2);
            this.chart_DigitalInputs.Location = new System.Drawing.Point(132, 19);
            this.chart_DigitalInputs.Name = "chart_DigitalInputs";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series7.Legend = "Legend1";
            series7.Name = "Series3";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series8.Legend = "Legend1";
            series8.Name = "Series4";
            this.chart_DigitalInputs.Series.Add(series5);
            this.chart_DigitalInputs.Series.Add(series6);
            this.chart_DigitalInputs.Series.Add(series7);
            this.chart_DigitalInputs.Series.Add(series8);
            this.chart_DigitalInputs.Size = new System.Drawing.Size(676, 260);
            this.chart_DigitalInputs.TabIndex = 30;
            this.chart_DigitalInputs.Text = "chart1";
            this.chart_DigitalInputs.DoubleClick += new System.EventHandler(this.chart_DigitalInputs_DoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(671, 576);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Packets/sec:";
            // 
            // label_PacketRate
            // 
            this.label_PacketRate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_PacketRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_PacketRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PacketRate.Location = new System.Drawing.Point(748, 573);
            this.label_PacketRate.Name = "label_PacketRate";
            this.label_PacketRate.Size = new System.Drawing.Size(60, 20);
            this.label_PacketRate.TabIndex = 28;
            this.label_PacketRate.Text = "0";
            // 
            // button_ClearCounters
            // 
            this.button_ClearCounters.Location = new System.Drawing.Point(591, 571);
            this.button_ClearCounters.Name = "button_ClearCounters";
            this.button_ClearCounters.Size = new System.Drawing.Size(56, 23);
            this.button_ClearCounters.TabIndex = 27;
            this.button_ClearCounters.Text = "Clear";
            this.button_ClearCounters.UseVisualStyleBackColor = true;
            this.button_ClearCounters.Click += new System.EventHandler(this.button_ClearCounters_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 576);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Duplicate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dropped:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 576);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Bad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 576);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "UDP Total:";
            // 
            // label_RecvDuplicate
            // 
            this.label_RecvDuplicate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_RecvDuplicate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_RecvDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RecvDuplicate.Location = new System.Drawing.Point(502, 573);
            this.label_RecvDuplicate.Name = "label_RecvDuplicate";
            this.label_RecvDuplicate.Size = new System.Drawing.Size(83, 20);
            this.label_RecvDuplicate.TabIndex = 21;
            this.label_RecvDuplicate.Text = "0";
            // 
            // label_RecvSkipped
            // 
            this.label_RecvSkipped.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_RecvSkipped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_RecvSkipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RecvSkipped.Location = new System.Drawing.Point(353, 573);
            this.label_RecvSkipped.Name = "label_RecvSkipped";
            this.label_RecvSkipped.Size = new System.Drawing.Size(83, 20);
            this.label_RecvSkipped.TabIndex = 20;
            this.label_RecvSkipped.Text = "0";
            // 
            // label_RecvValid
            // 
            this.label_RecvValid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_RecvValid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_RecvValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RecvValid.Location = new System.Drawing.Point(197, 573);
            this.label_RecvValid.Name = "label_RecvValid";
            this.label_RecvValid.Size = new System.Drawing.Size(83, 20);
            this.label_RecvValid.TabIndex = 19;
            this.label_RecvValid.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(548, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(425, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "IO names are relative to Intel Edison with Arduino breakout board and Grove Base " +
    "Shield";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox_Feedback);
            this.Controls.Add(this.groupBox_Commands);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.Text = "Edison Viewer - 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox_Commands.ResumeLayout(false);
            this.groupBox_Commands.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Feedback.ResumeLayout(false);
            this.groupBox_Feedback.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_AnalogInputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DigitalInputs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem attach_ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.GroupBox groupBox_Commands;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox_Feedback;
        private System.Windows.Forms.Button button_GetDigitalInputs;
        private System.Windows.Forms.Label label_A0;
        private System.Windows.Forms.Button button_GetAnalogOutputs;
        private System.Windows.Forms.CheckBox checkBox_D7_in;
        private System.Windows.Forms.CheckBox checkBox_D6_in;
        private System.Windows.Forms.CheckBox checkBox_D2_out;
        private System.Windows.Forms.CheckBox checkBox_D5_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_D4_out;
        private System.Windows.Forms.CheckBox checkBox_D3_out;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_A3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_A2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_A1;
        private System.Windows.Forms.CheckBox checkBox_GetAnalogInputs;
        private System.Windows.Forms.CheckBox checkBox_GetDigitalInputs;
        private System.Windows.Forms.CheckBox checkBox_D8_in;
        private System.Windows.Forms.Label label_RecvTotal;
        private System.Windows.Forms.Label label_RecvDuplicate;
        private System.Windows.Forms.Label label_RecvSkipped;
        private System.Windows.Forms.Label label_RecvValid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_ClearCounters;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_PacketRate;
        private System.Windows.Forms.ComboBox comboBox_PacRate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_AnalogInputs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DigitalInputs;
        private System.Windows.Forms.CheckBox checkBox_A3_Ena;
        private System.Windows.Forms.CheckBox checkBox_A2_Ena;
        private System.Windows.Forms.CheckBox checkBox_A1_Ena;
        private System.Windows.Forms.CheckBox checkBox_A0_Ena;
        private System.Windows.Forms.CheckBox checkBox_D8_Ena;
        private System.Windows.Forms.CheckBox checkBox_D7_Ena;
        private System.Windows.Forms.CheckBox checkBox_D6_Ena;
        private System.Windows.Forms.CheckBox checkBox_D5_Ena;
        private System.Windows.Forms.Button button_PauseGraphs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label_graphD8;
        private System.Windows.Forms.Label label_graphD7;
        private System.Windows.Forms.Label label_graphD6;
        private System.Windows.Forms.Label label_graphD5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label_graphA3;
        private System.Windows.Forms.Label label_graphA2;
        private System.Windows.Forms.Label label_graphA1;
        private System.Windows.Forms.Label label_graphA0;
        private System.Windows.Forms.ToolStripMenuItem detachToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_debug1;
    }
}

