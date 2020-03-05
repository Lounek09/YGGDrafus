namespace YGGDrafus
{
    partial class PacketForm
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
            this.packetTextBox = new System.Windows.Forms.TextBox();
            this.packetMenuStrip = new System.Windows.Forms.MenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // packetTextBox
            // 
            this.packetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packetTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.packetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.packetTextBox.Location = new System.Drawing.Point(2, 25);
            this.packetTextBox.Multiline = true;
            this.packetTextBox.Name = "packetTextBox";
            this.packetTextBox.ReadOnly = true;
            this.packetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.packetTextBox.Size = new System.Drawing.Size(500, 500);
            this.packetTextBox.TabIndex = 0;
            this.packetTextBox.TabStop = false;
            // 
            // packetMenuStrip
            // 
            this.packetMenuStrip.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packetMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.packetMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.packetMenuStrip.Name = "packetMenuStrip";
            this.packetMenuStrip.Size = new System.Drawing.Size(504, 25);
            this.packetMenuStrip.TabIndex = 1;
            this.packetMenuStrip.Text = "packetMenuStrip";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // PacketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 526);
            this.Controls.Add(this.packetTextBox);
            this.Controls.Add(this.packetMenuStrip);
            this.MainMenuStrip = this.packetMenuStrip;
            this.Name = "PacketForm";
            this.Text = "Paquet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PacketForm_FormClosed);
            this.Load += new System.EventHandler(this.PacketForm_Load);
            this.packetMenuStrip.ResumeLayout(false);
            this.packetMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox packetTextBox;
        private System.Windows.Forms.MenuStrip packetMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}