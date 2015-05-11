namespace EdisonViewer
{
    partial class ConfigDialog
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
            this.textBox_TargetIP = new System.Windows.Forms.TextBox();
            this.button_Preset1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Preset2 = new System.Windows.Forms.Button();
            this.button_Preset3 = new System.Windows.Forms.Button();
            this.button_Preset4 = new System.Windows.Forms.Button();
            this.button_Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_TargetIP
            // 
            this.textBox_TargetIP.Location = new System.Drawing.Point(72, 12);
            this.textBox_TargetIP.Name = "textBox_TargetIP";
            this.textBox_TargetIP.Size = new System.Drawing.Size(100, 20);
            this.textBox_TargetIP.TabIndex = 0;
            this.textBox_TargetIP.TextChanged += new System.EventHandler(this.textBox_TargetIP_TextChanged);
            // 
            // button_Preset1
            // 
            this.button_Preset1.Location = new System.Drawing.Point(179, 10);
            this.button_Preset1.Name = "button_Preset1";
            this.button_Preset1.Size = new System.Drawing.Size(143, 23);
            this.button_Preset1.TabIndex = 1;
            this.button_Preset1.Text = "Preset: 192.168.0.7";
            this.button_Preset1.UseVisualStyleBackColor = true;
            this.button_Preset1.Click += new System.EventHandler(this.button_Preset1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Target IP:";
            // 
            // button_Preset2
            // 
            this.button_Preset2.Location = new System.Drawing.Point(179, 39);
            this.button_Preset2.Name = "button_Preset2";
            this.button_Preset2.Size = new System.Drawing.Size(143, 23);
            this.button_Preset2.TabIndex = 25;
            this.button_Preset2.Text = "Preset: 192.168.2.15";
            this.button_Preset2.UseVisualStyleBackColor = true;
            this.button_Preset2.Click += new System.EventHandler(this.button_Preset2_Click);
            // 
            // button_Preset3
            // 
            this.button_Preset3.Location = new System.Drawing.Point(179, 68);
            this.button_Preset3.Name = "button_Preset3";
            this.button_Preset3.Size = new System.Drawing.Size(143, 23);
            this.button_Preset3.TabIndex = 26;
            this.button_Preset3.Text = "Preset: 192.168.1.83";
            this.button_Preset3.UseVisualStyleBackColor = true;
            this.button_Preset3.Click += new System.EventHandler(this.button_Preset3_Click);
            // 
            // button_Preset4
            // 
            this.button_Preset4.Location = new System.Drawing.Point(179, 97);
            this.button_Preset4.Name = "button_Preset4";
            this.button_Preset4.Size = new System.Drawing.Size(143, 23);
            this.button_Preset4.TabIndex = 27;
            this.button_Preset4.Text = "Preset: 192.168.1.2";
            this.button_Preset4.UseVisualStyleBackColor = true;
            this.button_Preset4.Click += new System.EventHandler(this.button_Preset4_Click);
            // 
            // button_Done
            // 
            this.button_Done.Location = new System.Drawing.Point(259, 152);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(63, 23);
            this.button_Done.TabIndex = 28;
            this.button_Done.Text = "Done";
            this.button_Done.UseVisualStyleBackColor = true;
            this.button_Done.Click += new System.EventHandler(this.button_Done_Click);
            // 
            // ConfigDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 187);
            this.Controls.Add(this.button_Done);
            this.Controls.Add(this.button_Preset4);
            this.Controls.Add(this.button_Preset3);
            this.Controls.Add(this.button_Preset2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Preset1);
            this.Controls.Add(this.textBox_TargetIP);
            this.Name = "ConfigDialog";
            this.Text = "Configure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_TargetIP;
        private System.Windows.Forms.Button button_Preset1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Preset2;
        private System.Windows.Forms.Button button_Preset3;
        private System.Windows.Forms.Button button_Preset4;
        private System.Windows.Forms.Button button_Done;
    }
}