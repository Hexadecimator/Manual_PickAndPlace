namespace Manual_PnP_WinFormsDotNet472
{
    partial class MainForm
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
            this.txtCONTROLLEROUTPUT = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ftsTOPMENUSTRIP = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPTIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rECONNECTCONTROLLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMAINWINDOW = new System.Windows.Forms.TabControl();
            this.tabPageVideo = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.btnTOGGLE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSERIALPORTS = new System.Windows.Forms.ComboBox();
            this.btnDISCONNECTSERIAL = new System.Windows.Forms.Button();
            this.txtSERIALOUT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRESCANSERIAL = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabMAINWINDOW.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCONTROLLEROUTPUT
            // 
            this.txtCONTROLLEROUTPUT.Location = new System.Drawing.Point(3, 396);
            this.txtCONTROLLEROUTPUT.Margin = new System.Windows.Forms.Padding(2);
            this.txtCONTROLLEROUTPUT.Multiline = true;
            this.txtCONTROLLEROUTPUT.Name = "txtCONTROLLEROUTPUT";
            this.txtCONTROLLEROUTPUT.ReadOnly = true;
            this.txtCONTROLLEROUTPUT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCONTROLLEROUTPUT.Size = new System.Drawing.Size(557, 502);
            this.txtCONTROLLEROUTPUT.TabIndex = 0;
            this.txtCONTROLLEROUTPUT.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ftsTOPMENUSTRIP,
            this.oPTIONSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ftsTOPMENUSTRIP
            // 
            this.ftsTOPMENUSTRIP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.ftsTOPMENUSTRIP.Name = "ftsTOPMENUSTRIP";
            this.ftsTOPMENUSTRIP.Size = new System.Drawing.Size(82, 22);
            this.ftsTOPMENUSTRIP.Text = "OPERATION";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // oPTIONSToolStripMenuItem
            // 
            this.oPTIONSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rECONNECTCONTROLLERToolStripMenuItem});
            this.oPTIONSToolStripMenuItem.Name = "oPTIONSToolStripMenuItem";
            this.oPTIONSToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.oPTIONSToolStripMenuItem.Text = "INPUT";
            // 
            // rECONNECTCONTROLLERToolStripMenuItem
            // 
            this.rECONNECTCONTROLLERToolStripMenuItem.Name = "rECONNECTCONTROLLERToolStripMenuItem";
            this.rECONNECTCONTROLLERToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.rECONNECTCONTROLLERToolStripMenuItem.Text = "RECONNECT CONTROLLER";
            this.rECONNECTCONTROLLERToolStripMenuItem.Click += new System.EventHandler(this.rECONNECTCONTROLLERToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 376);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "program output";
            // 
            // tabMAINWINDOW
            // 
            this.tabMAINWINDOW.Controls.Add(this.tabPageVideo);
            this.tabMAINWINDOW.Controls.Add(this.tabPageSettings);
            this.tabMAINWINDOW.Location = new System.Drawing.Point(3, 32);
            this.tabMAINWINDOW.Margin = new System.Windows.Forms.Padding(2);
            this.tabMAINWINDOW.Name = "tabMAINWINDOW";
            this.tabMAINWINDOW.SelectedIndex = 0;
            this.tabMAINWINDOW.Size = new System.Drawing.Size(1085, 305);
            this.tabMAINWINDOW.TabIndex = 3;
            // 
            // tabPageVideo
            // 
            this.tabPageVideo.Location = new System.Drawing.Point(4, 22);
            this.tabPageVideo.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageVideo.Name = "tabPageVideo";
            this.tabPageVideo.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageVideo.Size = new System.Drawing.Size(1077, 294);
            this.tabPageVideo.TabIndex = 0;
            this.tabPageVideo.Text = "Video";
            this.tabPageVideo.UseVisualStyleBackColor = true;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.btnRESCANSERIAL);
            this.tabPageSettings.Controls.Add(this.btnDISCONNECTSERIAL);
            this.tabPageSettings.Controls.Add(this.btnTOGGLE);
            this.tabPageSettings.Controls.Add(this.label2);
            this.tabPageSettings.Controls.Add(this.cbSERIALPORTS);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageSettings.Size = new System.Drawing.Size(1077, 279);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // btnTOGGLE
            // 
            this.btnTOGGLE.Location = new System.Drawing.Point(272, 42);
            this.btnTOGGLE.Margin = new System.Windows.Forms.Padding(2);
            this.btnTOGGLE.Name = "btnTOGGLE";
            this.btnTOGGLE.Size = new System.Drawing.Size(116, 26);
            this.btnTOGGLE.TabIndex = 2;
            this.btnTOGGLE.Text = "TOGGLE";
            this.btnTOGGLE.UseVisualStyleBackColor = true;
            this.btnTOGGLE.Click += new System.EventHandler(this.btnTOGGLE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serial COM Port:";
            // 
            // cbSERIALPORTS
            // 
            this.cbSERIALPORTS.FormattingEnabled = true;
            this.cbSERIALPORTS.Location = new System.Drawing.Point(116, 11);
            this.cbSERIALPORTS.Margin = new System.Windows.Forms.Padding(2);
            this.cbSERIALPORTS.Name = "cbSERIALPORTS";
            this.cbSERIALPORTS.Size = new System.Drawing.Size(144, 21);
            this.cbSERIALPORTS.TabIndex = 0;
            // 
            // btnDISCONNECTSERIAL
            // 
            this.btnDISCONNECTSERIAL.Location = new System.Drawing.Point(272, 8);
            this.btnDISCONNECTSERIAL.Name = "btnDISCONNECTSERIAL";
            this.btnDISCONNECTSERIAL.Size = new System.Drawing.Size(116, 27);
            this.btnDISCONNECTSERIAL.TabIndex = 3;
            this.btnDISCONNECTSERIAL.Text = "DISCONNECT";
            this.btnDISCONNECTSERIAL.UseVisualStyleBackColor = true;
            this.btnDISCONNECTSERIAL.Click += new System.EventHandler(this.btnDISCONNECTSERIAL_Click);
            // 
            // txtSERIALOUT
            // 
            this.txtSERIALOUT.Location = new System.Drawing.Point(565, 396);
            this.txtSERIALOUT.Multiline = true;
            this.txtSERIALOUT.Name = "txtSERIALOUT";
            this.txtSERIALOUT.ReadOnly = true;
            this.txtSERIALOUT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSERIALOUT.Size = new System.Drawing.Size(519, 502);
            this.txtSERIALOUT.TabIndex = 4;
            this.txtSERIALOUT.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 375);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "serial log";
            // 
            // btnRESCANSERIAL
            // 
            this.btnRESCANSERIAL.Location = new System.Drawing.Point(272, 73);
            this.btnRESCANSERIAL.Name = "btnRESCANSERIAL";
            this.btnRESCANSERIAL.Size = new System.Drawing.Size(116, 27);
            this.btnRESCANSERIAL.TabIndex = 4;
            this.btnRESCANSERIAL.Text = "RE-SCAN PORTS";
            this.btnRESCANSERIAL.UseVisualStyleBackColor = true;
            this.btnRESCANSERIAL.Click += new System.EventHandler(this.btnRESCANSERIAL_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 900);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSERIALOUT);
            this.Controls.Add(this.tabMAINWINDOW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCONTROLLEROUTPUT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual Pick and Place";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMAINWINDOW.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCONTROLLEROUTPUT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ftsTOPMENUSTRIP;
        private System.Windows.Forms.ToolStripMenuItem oPTIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rECONNECTCONTROLLERToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMAINWINDOW;
        private System.Windows.Forms.TabPage tabPageVideo;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSERIALPORTS;
        private System.Windows.Forms.Button btnTOGGLE;
        private System.Windows.Forms.Button btnDISCONNECTSERIAL;
        private System.Windows.Forms.TextBox txtSERIALOUT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRESCANSERIAL;
    }
}

