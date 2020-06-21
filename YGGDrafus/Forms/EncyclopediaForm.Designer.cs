namespace YGGDrafus
{
    partial class EncyclopediaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncyclopediaForm));
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.axShockwaveFlash2 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash2)).BeginInit();
            this.SuspendLayout();
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(93, 99);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(192, 192);
            this.axShockwaveFlash1.TabIndex = 0;
            // 
            // axShockwaveFlash2
            // 
            this.axShockwaveFlash2.Enabled = true;
            this.axShockwaveFlash2.Location = new System.Drawing.Point(511, 99);
            this.axShockwaveFlash2.Name = "axShockwaveFlash2";
            this.axShockwaveFlash2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash2.OcxState")));
            this.axShockwaveFlash2.Size = new System.Drawing.Size(192, 192);
            this.axShockwaveFlash2.TabIndex = 1;
            // 
            // EncyclopediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axShockwaveFlash2);
            this.Controls.Add(this.axShockwaveFlash1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncyclopediaForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encyclopedie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EncyclopediaForm_FormClosing);
            this.Load += new System.EventHandler(this.EncyclopediaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash2;
    }
}