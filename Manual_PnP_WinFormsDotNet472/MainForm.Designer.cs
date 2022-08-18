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
            this.btnRESCANSERIAL = new System.Windows.Forms.Button();
            this.btnDISCONNECTSERIAL = new System.Windows.Forms.Button();
            this.btnTOGGLE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSERIALPORTS = new System.Windows.Forms.ComboBox();
            this.txtSERIALOUT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSENDSERIAL = new System.Windows.Forms.Button();
            this.txtSERIALINPUT = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabMAINWINDOW.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCONTROLLEROUTPUT
            // 
            this.txtCONTROLLEROUTPUT.Location = new System.Drawing.Point(4, 609);
            this.txtCONTROLLEROUTPUT.Multiline = true;
            this.txtCONTROLLEROUTPUT.Name = "txtCONTROLLEROUTPUT";
            this.txtCONTROLLEROUTPUT.ReadOnly = true;
            this.txtCONTROLLEROUTPUT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCONTROLLEROUTPUT.Size = new System.Drawing.Size(834, 770);
            this.txtCONTROLLEROUTPUT.TabIndex = 0;
            this.txtCONTROLLEROUTPUT.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ftsTOPMENUSTRIP,
            this.oPTIONSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1632, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ftsTOPMENUSTRIP
            // 
            this.ftsTOPMENUSTRIP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.sendToolStripMenuItem});
            this.ftsTOPMENUSTRIP.Name = "ftsTOPMENUSTRIP";
            this.ftsTOPMENUSTRIP.Size = new System.Drawing.Size(124, 29);
            this.ftsTOPMENUSTRIP.Text = "OPERATION";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // oPTIONSToolStripMenuItem
            // 
            this.oPTIONSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rECONNECTCONTROLLERToolStripMenuItem});
            this.oPTIONSToolStripMenuItem.Name = "oPTIONSToolStripMenuItem";
            this.oPTIONSToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.oPTIONSToolStripMenuItem.Text = "INPUT";
            // 
            // rECONNECTCONTROLLERToolStripMenuItem
            // 
            this.rECONNECTCONTROLLERToolStripMenuItem.Name = "rECONNECTCONTROLLERToolStripMenuItem";
            this.rECONNECTCONTROLLERToolStripMenuItem.Size = new System.Drawing.Size(327, 34);
            this.rECONNECTCONTROLLERToolStripMenuItem.Text = "RECONNECT CONTROLLER";
            this.rECONNECTCONTROLLERToolStripMenuItem.Click += new System.EventHandler(this.rECONNECTCONTROLLERToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "program output";
            // 
            // tabMAINWINDOW
            // 
            this.tabMAINWINDOW.Controls.Add(this.tabPageVideo);
            this.tabMAINWINDOW.Controls.Add(this.tabPageSettings);
            this.tabMAINWINDOW.Location = new System.Drawing.Point(4, 49);
            this.tabMAINWINDOW.Name = "tabMAINWINDOW";
            this.tabMAINWINDOW.SelectedIndex = 0;
            this.tabMAINWINDOW.Size = new System.Drawing.Size(1628, 469);
            this.tabMAINWINDOW.TabIndex = 3;
            // 
            // tabPageVideo
            // 
            this.tabPageVideo.Location = new System.Drawing.Point(4, 29);
            this.tabPageVideo.Name = "tabPageVideo";
            this.tabPageVideo.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageVideo.Size = new System.Drawing.Size(1620, 436);
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
            this.tabPageSettings.Location = new System.Drawing.Point(4, 29);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageSettings.Size = new System.Drawing.Size(1620, 436);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // btnRESCANSERIAL
            // 
            this.btnRESCANSERIAL.Location = new System.Drawing.Point(408, 112);
            this.btnRESCANSERIAL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRESCANSERIAL.Name = "btnRESCANSERIAL";
            this.btnRESCANSERIAL.Size = new System.Drawing.Size(174, 42);
            this.btnRESCANSERIAL.TabIndex = 4;
            this.btnRESCANSERIAL.Text = "RE-SCAN PORTS";
            this.btnRESCANSERIAL.UseVisualStyleBackColor = true;
            this.btnRESCANSERIAL.Click += new System.EventHandler(this.btnRESCANSERIAL_Click);
            // 
            // btnDISCONNECTSERIAL
            // 
            this.btnDISCONNECTSERIAL.Location = new System.Drawing.Point(408, 12);
            this.btnDISCONNECTSERIAL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDISCONNECTSERIAL.Name = "btnDISCONNECTSERIAL";
            this.btnDISCONNECTSERIAL.Size = new System.Drawing.Size(174, 42);
            this.btnDISCONNECTSERIAL.TabIndex = 3;
            this.btnDISCONNECTSERIAL.Text = "DISCONNECT";
            this.btnDISCONNECTSERIAL.UseVisualStyleBackColor = true;
            this.btnDISCONNECTSERIAL.Click += new System.EventHandler(this.btnDISCONNECTSERIAL_Click);
            // 
            // btnTOGGLE
            // 
            this.btnTOGGLE.Location = new System.Drawing.Point(408, 65);
            this.btnTOGGLE.Name = "btnTOGGLE";
            this.btnTOGGLE.Size = new System.Drawing.Size(174, 40);
            this.btnTOGGLE.TabIndex = 2;
            this.btnTOGGLE.Text = "TOGGLE";
            this.btnTOGGLE.UseVisualStyleBackColor = true;
            this.btnTOGGLE.Click += new System.EventHandler(this.btnTOGGLE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serial COM Port:";
            // 
            // cbSERIALPORTS
            // 
            this.cbSERIALPORTS.FormattingEnabled = true;
            this.cbSERIALPORTS.Location = new System.Drawing.Point(174, 17);
            this.cbSERIALPORTS.Name = "cbSERIALPORTS";
            this.cbSERIALPORTS.Size = new System.Drawing.Size(214, 28);
            this.cbSERIALPORTS.TabIndex = 0;
            // 
            // txtSERIALOUT
            // 
            this.txtSERIALOUT.Location = new System.Drawing.Point(848, 609);
            this.txtSERIALOUT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSERIALOUT.Multiline = true;
            this.txtSERIALOUT.Name = "txtSERIALOUT";
            this.txtSERIALOUT.ReadOnly = true;
            this.txtSERIALOUT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSERIALOUT.Size = new System.Drawing.Size(776, 770);
            this.txtSERIALOUT.TabIndex = 4;
            this.txtSERIALOUT.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(843, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "serial log";
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sendToolStripMenuItem.Text = "Send $$";
            this.sendToolStripMenuItem.Click += new System.EventHandler(this.sendToolStripMenuItem_Click);
            // 
            // btnSENDSERIAL
            // 
            this.btnSENDSERIAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSENDSERIAL.Location = new System.Drawing.Point(1545, 553);
            this.btnSENDSERIAL.Name = "btnSENDSERIAL";
            this.btnSENDSERIAL.Size = new System.Drawing.Size(79, 42);
            this.btnSENDSERIAL.TabIndex = 6;
            this.btnSENDSERIAL.Text = "SEND";
            this.btnSENDSERIAL.UseVisualStyleBackColor = true;
            this.btnSENDSERIAL.Click += new System.EventHandler(this.btnSENDSERIAL_Click);
            // 
            // txtSERIALINPUT
            // 
            this.txtSERIALINPUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERIALINPUT.Location = new System.Drawing.Point(991, 559);
            this.txtSERIALINPUT.Name = "txtSERIALINPUT";
            this.txtSERIALINPUT.Size = new System.Drawing.Size(548, 30);
            this.txtSERIALINPUT.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 1570);
            this.Controls.Add(this.txtSERIALINPUT);
            this.Controls.Add(this.btnSENDSERIAL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSERIALOUT);
            this.Controls.Add(this.tabMAINWINDOW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCONTROLLEROUTPUT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
        private System.Windows.Forms.Button btnSENDSERIAL;
        private System.Windows.Forms.TextBox txtSERIALINPUT;
    }
}

