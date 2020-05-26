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
                if (components != null)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.gameAxShockwaveFlash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.indexLabel = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameAxShockwaveFlash)).BeginInit();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gameAxShockwaveFlash
            // 
            this.gameAxShockwaveFlash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameAxShockwaveFlash.Enabled = true;
            this.gameAxShockwaveFlash.Location = new System.Drawing.Point(0, 0);
            this.gameAxShockwaveFlash.Margin = new System.Windows.Forms.Padding(0);
            this.gameAxShockwaveFlash.Name = "gameAxShockwaveFlash";
            this.gameAxShockwaveFlash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("gameAxShockwaveFlash.OcxState")));
            this.gameAxShockwaveFlash.Size = new System.Drawing.Size(742, 556);
            this.gameAxShockwaveFlash.TabIndex = 1;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Black;
            this.gamePanel.Controls.Add(this.indexLabel);
            this.gamePanel.Controls.Add(this.buttonClose);
            this.gamePanel.Controls.Add(this.pictureBoxLogo);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.gamePanel.Location = new System.Drawing.Point(740, 0);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(50, 556);
            this.gamePanel.TabIndex = 2;
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexLabel.ForeColor = System.Drawing.Color.White;
            this.indexLabel.Location = new System.Drawing.Point(7, 2);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(16, 20);
            this.indexLabel.TabIndex = 5;
            this.indexLabel.Text = "?";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Black;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(26, 2);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(20, 20);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxLogo.Location = new System.Drawing.Point(5, 30);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 556);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.gameAxShockwaveFlash);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "YGGDrafus";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameAxShockwaveFlash)).EndInit();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash gameAxShockwaveFlash;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label indexLabel;

        public AxShockwaveFlashObjects.AxShockwaveFlash GameAxShockwaveFlash { get => gameAxShockwaveFlash; }
        public System.Windows.Forms.Panel GamePanel { get => gamePanel; }
        public System.Windows.Forms.Label IndexLabel { get => indexLabel; }
    }
}

