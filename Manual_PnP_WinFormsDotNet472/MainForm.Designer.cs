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
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPTIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rECONNECTCONTROLLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMAINWINDOW = new System.Windows.Forms.TabControl();
            this.tabPageVideo = new System.Windows.Forms.TabPage();
            this.pbVIDEOOUT = new System.Windows.Forms.PictureBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.btnRESCANSERIAL = new System.Windows.Forms.Button();
            this.btnDISCONNECTSERIAL = new System.Windows.Forms.Button();
            this.btnTOGGLE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSERIALPORTS = new System.Windows.Forms.ComboBox();
            this.txtSERIALOUT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSENDSERIAL = new System.Windows.Forms.Button();
            this.txtSERIALINPUT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbVIDEODEVICE = new System.Windows.Forms.ComboBox();
            this.btnVIDEOCONNECT = new System.Windows.Forms.Button();
            this.btnVIDEODISCONNECT = new System.Windows.Forms.Button();
            this.btnRESCANVIDEODEVICES = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFOCUSSLIDER = new System.Windows.Forms.TrackBar();
            this.chkAUTOFOCUS = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.tabMAINWINDOW.SuspendLayout();
            this.tabPageVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVIDEOOUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFOCUSSLIDER)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCONTROLLEROUTPUT
            // 
            this.txtCONTROLLEROUTPUT.Location = new System.Drawing.Point(1489, 548);
            this.txtCONTROLLEROUTPUT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCONTROLLEROUTPUT.Multiline = true;
            this.txtCONTROLLEROUTPUT.Name = "txtCONTROLLEROUTPUT";
            this.txtCONTROLLEROUTPUT.ReadOnly = true;
            this.txtCONTROLLEROUTPUT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCONTROLLEROUTPUT.Size = new System.Drawing.Size(605, 435);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(2106, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ftsTOPMENUSTRIP
            // 
            this.ftsTOPMENUSTRIP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ftsTOPMENUSTRIP.Name = "ftsTOPMENUSTRIP";
            this.ftsTOPMENUSTRIP.Size = new System.Drawing.Size(102, 24);
            this.ftsTOPMENUSTRIP.Text = "OPERATION";
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.sendToolStripMenuItem.Text = "Send $$";
            this.sendToolStripMenuItem.Click += new System.EventHandler(this.sendToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // oPTIONSToolStripMenuItem
            // 
            this.oPTIONSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rECONNECTCONTROLLERToolStripMenuItem});
            this.oPTIONSToolStripMenuItem.Name = "oPTIONSToolStripMenuItem";
            this.oPTIONSToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.oPTIONSToolStripMenuItem.Text = "INPUT";
            // 
            // rECONNECTCONTROLLERToolStripMenuItem
            // 
            this.rECONNECTCONTROLLERToolStripMenuItem.Name = "rECONNECTCONTROLLERToolStripMenuItem";
            this.rECONNECTCONTROLLERToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.rECONNECTCONTROLLERToolStripMenuItem.Text = "RECONNECT CONTROLLER";
            this.rECONNECTCONTROLLERToolStripMenuItem.Click += new System.EventHandler(this.rECONNECTCONTROLLERToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1485, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "program output";
            // 
            // tabMAINWINDOW
            // 
            this.tabMAINWINDOW.Controls.Add(this.tabPageVideo);
            this.tabMAINWINDOW.Controls.Add(this.tabPageSettings);
            this.tabMAINWINDOW.Location = new System.Drawing.Point(4, 39);
            this.tabMAINWINDOW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMAINWINDOW.Name = "tabMAINWINDOW";
            this.tabMAINWINDOW.SelectedIndex = 0;
            this.tabMAINWINDOW.Size = new System.Drawing.Size(1476, 944);
            this.tabMAINWINDOW.TabIndex = 3;
            // 
            // tabPageVideo
            // 
            this.tabPageVideo.Controls.Add(this.pbVIDEOOUT);
            this.tabPageVideo.Location = new System.Drawing.Point(4, 25);
            this.tabPageVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageVideo.Name = "tabPageVideo";
            this.tabPageVideo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageVideo.Size = new System.Drawing.Size(1468, 915);
            this.tabPageVideo.TabIndex = 0;
            this.tabPageVideo.Text = "Video";
            this.tabPageVideo.UseVisualStyleBackColor = true;
            // 
            // pbVIDEOOUT
            // 
            this.pbVIDEOOUT.Location = new System.Drawing.Point(1, 0);
            this.pbVIDEOOUT.Margin = new System.Windows.Forms.Padding(4);
            this.pbVIDEOOUT.Name = "pbVIDEOOUT";
            this.pbVIDEOOUT.Size = new System.Drawing.Size(1464, 917);
            this.pbVIDEOOUT.TabIndex = 0;
            this.pbVIDEOOUT.TabStop = false;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSettings.Size = new System.Drawing.Size(1468, 915);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // btnRESCANSERIAL
            // 
            this.btnRESCANSERIAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRESCANSERIAL.Location = new System.Drawing.Point(1916, 1020);
            this.btnRESCANSERIAL.Margin = new System.Windows.Forms.Padding(4);
            this.btnRESCANSERIAL.Name = "btnRESCANSERIAL";
            this.btnRESCANSERIAL.Size = new System.Drawing.Size(177, 33);
            this.btnRESCANSERIAL.TabIndex = 4;
            this.btnRESCANSERIAL.Text = "RE-SCAN PORTS";
            this.btnRESCANSERIAL.UseVisualStyleBackColor = true;
            this.btnRESCANSERIAL.Click += new System.EventHandler(this.btnRESCANSERIAL_Click);
            // 
            // btnDISCONNECTSERIAL
            // 
            this.btnDISCONNECTSERIAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDISCONNECTSERIAL.Location = new System.Drawing.Point(1741, 1020);
            this.btnDISCONNECTSERIAL.Margin = new System.Windows.Forms.Padding(4);
            this.btnDISCONNECTSERIAL.Name = "btnDISCONNECTSERIAL";
            this.btnDISCONNECTSERIAL.Size = new System.Drawing.Size(167, 33);
            this.btnDISCONNECTSERIAL.TabIndex = 3;
            this.btnDISCONNECTSERIAL.Text = "DISCONNECT";
            this.btnDISCONNECTSERIAL.UseVisualStyleBackColor = true;
            this.btnDISCONNECTSERIAL.Click += new System.EventHandler(this.btnDISCONNECTSERIAL_Click);
            // 
            // btnTOGGLE
            // 
            this.btnTOGGLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTOGGLE.Location = new System.Drawing.Point(1916, 986);
            this.btnTOGGLE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTOGGLE.Name = "btnTOGGLE";
            this.btnTOGGLE.Size = new System.Drawing.Size(177, 32);
            this.btnTOGGLE.TabIndex = 2;
            this.btnTOGGLE.Text = "TOGGLE";
            this.btnTOGGLE.UseVisualStyleBackColor = true;
            this.btnTOGGLE.Click += new System.EventHandler(this.btnTOGGLE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1600, 994);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "GRBL COM Port:";
            // 
            // cbSERIALPORTS
            // 
            this.cbSERIALPORTS.FormattingEnabled = true;
            this.cbSERIALPORTS.Location = new System.Drawing.Point(1741, 988);
            this.cbSERIALPORTS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSERIALPORTS.Name = "cbSERIALPORTS";
            this.cbSERIALPORTS.Size = new System.Drawing.Size(165, 24);
            this.cbSERIALPORTS.TabIndex = 0;
            // 
            // txtSERIALOUT
            // 
            this.txtSERIALOUT.Location = new System.Drawing.Point(1489, 84);
            this.txtSERIALOUT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSERIALOUT.Multiline = true;
            this.txtSERIALOUT.Name = "txtSERIALOUT";
            this.txtSERIALOUT.ReadOnly = true;
            this.txtSERIALOUT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSERIALOUT.Size = new System.Drawing.Size(605, 435);
            this.txtSERIALOUT.TabIndex = 4;
            this.txtSERIALOUT.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1485, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "serial log";
            // 
            // btnSENDSERIAL
            // 
            this.btnSENDSERIAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSENDSERIAL.Location = new System.Drawing.Point(2025, 43);
            this.btnSENDSERIAL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSENDSERIAL.Name = "btnSENDSERIAL";
            this.btnSENDSERIAL.Size = new System.Drawing.Size(71, 28);
            this.btnSENDSERIAL.TabIndex = 6;
            this.btnSENDSERIAL.Text = "SEND";
            this.btnSENDSERIAL.UseVisualStyleBackColor = true;
            this.btnSENDSERIAL.Click += new System.EventHandler(this.btnSENDSERIAL_Click);
            // 
            // txtSERIALINPUT
            // 
            this.txtSERIALINPUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERIALINPUT.Location = new System.Drawing.Point(1593, 43);
            this.txtSERIALINPUT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSERIALINPUT.Name = "txtSERIALINPUT";
            this.txtSERIALINPUT.Size = new System.Drawing.Size(427, 26);
            this.txtSERIALINPUT.TabIndex = 7;
            this.txtSERIALINPUT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSERIALINPUT_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 1019);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "STATUS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 1019);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1032, 992);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Video Capture Device:";
            // 
            // cbVIDEODEVICE
            // 
            this.cbVIDEODEVICE.FormattingEnabled = true;
            this.cbVIDEODEVICE.Location = new System.Drawing.Point(1219, 987);
            this.cbVIDEODEVICE.Margin = new System.Windows.Forms.Padding(4);
            this.cbVIDEODEVICE.Name = "cbVIDEODEVICE";
            this.cbVIDEODEVICE.Size = new System.Drawing.Size(255, 24);
            this.cbVIDEODEVICE.TabIndex = 11;
            // 
            // btnVIDEOCONNECT
            // 
            this.btnVIDEOCONNECT.Location = new System.Drawing.Point(1333, 1018);
            this.btnVIDEOCONNECT.Margin = new System.Windows.Forms.Padding(4);
            this.btnVIDEOCONNECT.Name = "btnVIDEOCONNECT";
            this.btnVIDEOCONNECT.Size = new System.Drawing.Size(141, 39);
            this.btnVIDEOCONNECT.TabIndex = 12;
            this.btnVIDEOCONNECT.Text = "VIDEO CONNECT";
            this.btnVIDEOCONNECT.UseVisualStyleBackColor = true;
            this.btnVIDEOCONNECT.Click += new System.EventHandler(this.btnVIDEOCONNECT_Click);
            // 
            // btnVIDEODISCONNECT
            // 
            this.btnVIDEODISCONNECT.Location = new System.Drawing.Point(1147, 1019);
            this.btnVIDEODISCONNECT.Margin = new System.Windows.Forms.Padding(4);
            this.btnVIDEODISCONNECT.Name = "btnVIDEODISCONNECT";
            this.btnVIDEODISCONNECT.Size = new System.Drawing.Size(179, 37);
            this.btnVIDEODISCONNECT.TabIndex = 13;
            this.btnVIDEODISCONNECT.Text = "VIDEO DISCONNECT";
            this.btnVIDEODISCONNECT.UseVisualStyleBackColor = true;
            this.btnVIDEODISCONNECT.Click += new System.EventHandler(this.btnVIDEODISCONNECT_Click);
            // 
            // btnRESCANVIDEODEVICES
            // 
            this.btnRESCANVIDEODEVICES.Location = new System.Drawing.Point(1039, 1018);
            this.btnRESCANVIDEODEVICES.Margin = new System.Windows.Forms.Padding(4);
            this.btnRESCANVIDEODEVICES.Name = "btnRESCANVIDEODEVICES";
            this.btnRESCANVIDEODEVICES.Size = new System.Drawing.Size(100, 38);
            this.btnRESCANVIDEODEVICES.TabIndex = 14;
            this.btnRESCANVIDEODEVICES.Text = "RE-SCAN";
            this.btnRESCANVIDEODEVICES.UseVisualStyleBackColor = true;
            this.btnRESCANVIDEODEVICES.Click += new System.EventHandler(this.btnRESCANVIDEODEVICES_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(712, 1029);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Focus:";
            // 
            // tbFOCUSSLIDER
            // 
            this.tbFOCUSSLIDER.BackColor = System.Drawing.SystemColors.Control;
            this.tbFOCUSSLIDER.Location = new System.Drawing.Point(771, 1019);
            this.tbFOCUSSLIDER.Maximum = 250;
            this.tbFOCUSSLIDER.Name = "tbFOCUSSLIDER";
            this.tbFOCUSSLIDER.Size = new System.Drawing.Size(255, 56);
            this.tbFOCUSSLIDER.SmallChange = 5;
            this.tbFOCUSSLIDER.TabIndex = 16;
            this.tbFOCUSSLIDER.TickFrequency = 5;
            this.tbFOCUSSLIDER.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbFOCUSSLIDER.Value = 125;
            this.tbFOCUSSLIDER.ValueChanged += new System.EventHandler(this.tbFOCUSSLIDER_ValueChanged);
            // 
            // chkAUTOFOCUS
            // 
            this.chkAUTOFOCUS.AutoSize = true;
            this.chkAUTOFOCUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAUTOFOCUS.Location = new System.Drawing.Point(715, 989);
            this.chkAUTOFOCUS.Name = "chkAUTOFOCUS";
            this.chkAUTOFOCUS.Size = new System.Drawing.Size(126, 24);
            this.chkAUTOFOCUS.TabIndex = 18;
            this.chkAUTOFOCUS.Text = "Auto Focus";
            this.chkAUTOFOCUS.UseVisualStyleBackColor = true;
            this.chkAUTOFOCUS.CheckedChanged += new System.EventHandler(this.chkAUTOFOCUS_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2106, 1077);
            this.Controls.Add(this.chkAUTOFOCUS);
            this.Controls.Add(this.tbFOCUSSLIDER);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRESCANVIDEODEVICES);
            this.Controls.Add(this.btnVIDEODISCONNECT);
            this.Controls.Add(this.btnVIDEOCONNECT);
            this.Controls.Add(this.cbVIDEODEVICE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRESCANSERIAL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTOGGLE);
            this.Controls.Add(this.btnDISCONNECTSERIAL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSERIALINPUT);
            this.Controls.Add(this.cbSERIALPORTS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSENDSERIAL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSERIALOUT);
            this.Controls.Add(this.tabMAINWINDOW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCONTROLLEROUTPUT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual Pick and Place";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMAINWINDOW.ResumeLayout(false);
            this.tabPageVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVIDEOOUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFOCUSSLIDER)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbVIDEOOUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbVIDEODEVICE;
        private System.Windows.Forms.Button btnVIDEOCONNECT;
        private System.Windows.Forms.Button btnVIDEODISCONNECT;
        private System.Windows.Forms.Button btnRESCANVIDEODEVICES;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tbFOCUSSLIDER;
        private System.Windows.Forms.CheckBox chkAUTOFOCUS;
    }
}

