using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EdisonViewer
{
    public partial class ConfigDialog : Form
    {
        public string ourTargetIP
        {
            get;
            private set;
        }
        private const int IP_OFFSET_IN_STRING = 8;

        public ConfigDialog()
        {
            InitializeComponent();

            // Set targetIP as first in the 
            string tmpStr = button_Preset1.Text;
            textBox_TargetIP.Text = tmpStr.Substring(IP_OFFSET_IN_STRING);
            ourTargetIP = textBox_TargetIP.Text;
        }

        private void button_Preset1_Click(object sender, EventArgs e)
        {
            string tmpStr = button_Preset1.Text;
            textBox_TargetIP.Text = tmpStr.Substring(IP_OFFSET_IN_STRING);
            ourTargetIP = textBox_TargetIP.Text;
        }

        private void button_Preset2_Click(object sender, EventArgs e)
        {
            string tmpStr = button_Preset2.Text;
            textBox_TargetIP.Text = tmpStr.Substring(IP_OFFSET_IN_STRING);
            ourTargetIP = textBox_TargetIP.Text;
        }

        private void button_Preset3_Click(object sender, EventArgs e)
        {
            string tmpStr = button_Preset3.Text;
            textBox_TargetIP.Text = tmpStr.Substring(IP_OFFSET_IN_STRING);
            ourTargetIP = textBox_TargetIP.Text;
        }

        private void button_Preset4_Click(object sender, EventArgs e)
        {
            string tmpStr = button_Preset4.Text;
            textBox_TargetIP.Text = tmpStr.Substring(IP_OFFSET_IN_STRING);
            ourTargetIP = textBox_TargetIP.Text;
        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            Close(); // Close dialog
        }

        private void textBox_TargetIP_TextChanged(object sender, EventArgs e)
        {
            // Grab text so we have it regardless of which method we use for an exit
            ourTargetIP = textBox_TargetIP.Text;
        }
    }
}
