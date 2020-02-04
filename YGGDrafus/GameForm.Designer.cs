namespace YGGDrafus
{
    partial class GameForm
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
            if (disposing)
            {
                if(components != null)
                    components.Dispose();
                if (popup != null)
                    popup.Dispose();
                
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPacket = new System.Windows.Forms.TextBox();
            this.lblTitlePacket = new System.Windows.Forms.Label();
            this.axShockwaveFlashGame = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlashGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuitToolStripMenuItem,
            this.sendToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1109, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // QuitToolStripMenuItem
            // 
            this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            this.QuitToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.QuitToolStripMenuItem.Text = "Quitter";
            this.QuitToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.sendToolStripMenuItem.Text = "Send";
            // 
            // txtPacket
            // 
            this.txtPacket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPacket.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPacket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPacket.Location = new System.Drawing.Point(2, 32);
            this.txtPacket.Multiline = true;
            this.txtPacket.Name = "txtPacket";
            this.txtPacket.ReadOnly = true;
            this.txtPacket.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPacket.Size = new System.Drawing.Size(355, 523);
            this.txtPacket.TabIndex = 2;
            this.txtPacket.TabStop = false;
            this.txtPacket.WordWrap = false;
            this.txtPacket.Enter += new System.EventHandler(this.TxtPacket_Enter);
            this.txtPacket.Leave += new System.EventHandler(this.TxtPacket_Leave);
            // 
            // lblTitlePacket
            // 
            this.lblTitlePacket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitlePacket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePacket.Location = new System.Drawing.Point(2, 6);
            this.lblTitlePacket.Name = "lblTitlePacket";
            this.lblTitlePacket.Size = new System.Drawing.Size(355, 23);
            this.lblTitlePacket.TabIndex = 3;
            this.lblTitlePacket.Text = "Packet";
            this.lblTitlePacket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axShockwaveFlashGame
            // 
            this.axShockwaveFlashGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axShockwaveFlashGame.Enabled = true;
            this.axShockwaveFlashGame.Location = new System.Drawing.Point(0, 0);
            this.axShockwaveFlashGame.Name = "axShockwaveFlashGame";
            this.axShockwaveFlashGame.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlashGame.OcxState")));
            this.axShockwaveFlashGame.Size = new System.Drawing.Size(742, 556);
            this.axShockwaveFlashGame.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.axShockwaveFlashGame);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lblTitlePacket);
            this.splitContainer.Panel2.Controls.Add(this.txtPacket);
            this.splitContainer.Size = new System.Drawing.Size(1109, 558);
            this.splitContainer.SplitterDistance = 744;
            this.splitContainer.TabIndex = 4;
            this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitContainer_SplitterMoved);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 582);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "YGGDrafus";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlashGame)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPacket;
        private System.Windows.Forms.Label lblTitlePacket;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlashGame;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}

