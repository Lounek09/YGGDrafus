namespace YGGDrafus.Packet
{
    partial class FilterPacketForm
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
            this.includeLabel = new System.Windows.Forms.Label();
            this.notIncludeLabel = new System.Windows.Forms.Label();
            this.includeTextBox = new System.Windows.Forms.TextBox();
            this.notIncludeTextBox = new System.Windows.Forms.TextBox();
            this.informationLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // includeLabel
            // 
            this.includeLabel.AutoSize = true;
            this.includeLabel.Font = new System.Drawing.Font("Ebrima", 9F);
            this.includeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.includeLabel.Location = new System.Drawing.Point(12, 9);
            this.includeLabel.Name = "includeLabel";
            this.includeLabel.Size = new System.Drawing.Size(87, 15);
            this.includeLabel.TabIndex = 1;
            this.includeLabel.Text = "Doit contenir* :";
            // 
            // notIncludeLabel
            // 
            this.notIncludeLabel.AutoSize = true;
            this.notIncludeLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notIncludeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.notIncludeLabel.Location = new System.Drawing.Point(12, 140);
            this.notIncludeLabel.Name = "notIncludeLabel";
            this.notIncludeLabel.Size = new System.Drawing.Size(125, 15);
            this.notIncludeLabel.TabIndex = 3;
            this.notIncludeLabel.Text = "Ne doit pas contenir* :";
            // 
            // includeTextBox
            // 
            this.includeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.includeTextBox.Location = new System.Drawing.Point(12, 27);
            this.includeTextBox.Multiline = true;
            this.includeTextBox.Name = "includeTextBox";
            this.includeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.includeTextBox.Size = new System.Drawing.Size(280, 100);
            this.includeTextBox.TabIndex = 2;
            this.includeTextBox.TabStop = false;
            this.includeTextBox.WordWrap = false;
            // 
            // notIncludeTextBox
            // 
            this.notIncludeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.notIncludeTextBox.Location = new System.Drawing.Point(12, 158);
            this.notIncludeTextBox.Multiline = true;
            this.notIncludeTextBox.Name = "notIncludeTextBox";
            this.notIncludeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.notIncludeTextBox.Size = new System.Drawing.Size(280, 100);
            this.notIncludeTextBox.TabIndex = 4;
            this.notIncludeTextBox.TabStop = false;
            this.notIncludeTextBox.WordWrap = false;
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Ebrima", 7F);
            this.informationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.informationLabel.Location = new System.Drawing.Point(10, 302);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(190, 12);
            this.informationLabel.TabIndex = 8;
            this.informationLabel.Text = "*Séparer les filtres par des retours à la ligne";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cancelButton.Location = new System.Drawing.Point(177, 269);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 25);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.saveButton.Location = new System.Drawing.Point(27, 269);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 25);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Sauvegarder";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FilterPacketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(304, 320);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.notIncludeTextBox);
            this.Controls.Add(this.includeTextBox);
            this.Controls.Add(this.notIncludeLabel);
            this.Controls.Add(this.includeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterPacketForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtre";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FilterPacketForm_FormClosed);
            this.Load += new System.EventHandler(this.FilterPacketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label includeLabel;
        private System.Windows.Forms.Label notIncludeLabel;
        private System.Windows.Forms.TextBox includeTextBox;
        private System.Windows.Forms.TextBox notIncludeTextBox;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}