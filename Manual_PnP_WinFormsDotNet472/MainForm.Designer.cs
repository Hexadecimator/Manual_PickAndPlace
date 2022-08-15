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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCONTROLLEROUTPUT
            // 
            this.txtCONTROLLEROUTPUT.Location = new System.Drawing.Point(3, 374);
            this.txtCONTROLLEROUTPUT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCONTROLLEROUTPUT.Multiline = true;
            this.txtCONTROLLEROUTPUT.Name = "txtCONTROLLEROUTPUT";
            this.txtCONTROLLEROUTPUT.ReadOnly = true;
            this.txtCONTROLLEROUTPUT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCONTROLLEROUTPUT.Size = new System.Drawing.Size(1087, 441);
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
            this.oPTIONSToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.oPTIONSToolStripMenuItem.Text = "OPTIONS";
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
            this.label1.Location = new System.Drawing.Point(0, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "controller inputs";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 817);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCONTROLLEROUTPUT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual Pick and Place";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

