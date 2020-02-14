namespace YGGDrafus
{
    partial class OptionForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.pathButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.shortcutTabPage = new System.Windows.Forms.TabPage();
            this.defaultButton = new System.Windows.Forms.Button();
            this.nextEditButton = new System.Windows.Forms.Button();
            this.previousEditButton = new System.Windows.Forms.Button();
            this.newEditButton = new System.Windows.Forms.Button();
            this.previousTextBox = new System.Windows.Forms.TextBox();
            this.nextTextBox = new System.Windows.Forms.TextBox();
            this.newTextBox = new System.Windows.Forms.TextBox();
            this.nextLabel = new System.Windows.Forms.Label();
            this.previousLabel = new System.Windows.Forms.Label();
            this.newLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.shortcutTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.generalTabPage);
            this.tabControl.Controls.Add(this.shortcutTabPage);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(386, 420);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabIndexChanged += new System.EventHandler(this.TabControl_TabIndexChanged);
            // 
            // generalTabPage
            // 
            this.generalTabPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.generalTabPage.Controls.Add(this.pathButton);
            this.generalTabPage.Controls.Add(this.pathTextBox);
            this.generalTabPage.Controls.Add(this.pathLabel);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Size = new System.Drawing.Size(378, 394);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "Général";
            // 
            // pathButton
            // 
            this.pathButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pathButton.Location = new System.Drawing.Point(330, 35);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(25, 22);
            this.pathButton.TabIndex = 2;
            this.pathButton.Text = "...";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pathTextBox.Location = new System.Drawing.Point(13, 36);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(317, 20);
            this.pathTextBox.TabIndex = 1;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pathLabel.Location = new System.Drawing.Point(7, 17);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(174, 15);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "Chemin de votre dossier de jeu :";
            // 
            // shortcutTabPage
            // 
            this.shortcutTabPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.shortcutTabPage.Controls.Add(this.defaultButton);
            this.shortcutTabPage.Controls.Add(this.nextEditButton);
            this.shortcutTabPage.Controls.Add(this.previousEditButton);
            this.shortcutTabPage.Controls.Add(this.newEditButton);
            this.shortcutTabPage.Controls.Add(this.previousTextBox);
            this.shortcutTabPage.Controls.Add(this.nextTextBox);
            this.shortcutTabPage.Controls.Add(this.newTextBox);
            this.shortcutTabPage.Controls.Add(this.nextLabel);
            this.shortcutTabPage.Controls.Add(this.previousLabel);
            this.shortcutTabPage.Controls.Add(this.newLabel);
            this.shortcutTabPage.Location = new System.Drawing.Point(4, 22);
            this.shortcutTabPage.Name = "shortcutTabPage";
            this.shortcutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.shortcutTabPage.Size = new System.Drawing.Size(378, 394);
            this.shortcutTabPage.TabIndex = 1;
            this.shortcutTabPage.Text = "Raccourci";
            // 
            // defaultButton
            // 
            this.defaultButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.defaultButton.Location = new System.Drawing.Point(20, 120);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(75, 23);
            this.defaultButton.TabIndex = 12;
            this.defaultButton.Text = "Défaut";
            this.defaultButton.UseVisualStyleBackColor = true;
            this.defaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // nextEditButton
            // 
            this.nextEditButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextEditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nextEditButton.Location = new System.Drawing.Point(246, 77);
            this.nextEditButton.Name = "nextEditButton";
            this.nextEditButton.Size = new System.Drawing.Size(35, 22);
            this.nextEditButton.TabIndex = 11;
            this.nextEditButton.TabStop = false;
            this.nextEditButton.Text = "Edit";
            this.nextEditButton.UseVisualStyleBackColor = true;
            this.nextEditButton.Click += new System.EventHandler(this.NextEditButton_Click);
            // 
            // previousEditButton
            // 
            this.previousEditButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousEditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.previousEditButton.Location = new System.Drawing.Point(246, 47);
            this.previousEditButton.Name = "previousEditButton";
            this.previousEditButton.Size = new System.Drawing.Size(35, 22);
            this.previousEditButton.TabIndex = 10;
            this.previousEditButton.TabStop = false;
            this.previousEditButton.Text = "Edit";
            this.previousEditButton.UseVisualStyleBackColor = true;
            this.previousEditButton.Click += new System.EventHandler(this.PreviousEditButton_Click);
            // 
            // newEditButton
            // 
            this.newEditButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.newEditButton.Location = new System.Drawing.Point(246, 17);
            this.newEditButton.Name = "newEditButton";
            this.newEditButton.Size = new System.Drawing.Size(35, 22);
            this.newEditButton.TabIndex = 8;
            this.newEditButton.TabStop = false;
            this.newEditButton.Text = "Edit";
            this.newEditButton.UseVisualStyleBackColor = true;
            this.newEditButton.Click += new System.EventHandler(this.NewEditButton_Click);
            // 
            // previousTextBox
            // 
            this.previousTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.previousTextBox.Enabled = false;
            this.previousTextBox.Location = new System.Drawing.Point(136, 78);
            this.previousTextBox.Name = "previousTextBox";
            this.previousTextBox.ReadOnly = true;
            this.previousTextBox.Size = new System.Drawing.Size(100, 20);
            this.previousTextBox.TabIndex = 6;
            // 
            // nextTextBox
            // 
            this.nextTextBox.Enabled = false;
            this.nextTextBox.Location = new System.Drawing.Point(136, 48);
            this.nextTextBox.Name = "nextTextBox";
            this.nextTextBox.ReadOnly = true;
            this.nextTextBox.Size = new System.Drawing.Size(100, 20);
            this.nextTextBox.TabIndex = 5;
            // 
            // newTextBox
            // 
            this.newTextBox.Enabled = false;
            this.newTextBox.Location = new System.Drawing.Point(136, 18);
            this.newTextBox.Name = "newTextBox";
            this.newTextBox.ReadOnly = true;
            this.newTextBox.Size = new System.Drawing.Size(100, 20);
            this.newTextBox.TabIndex = 4;
            // 
            // nextLabel
            // 
            this.nextLabel.AutoSize = true;
            this.nextLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nextLabel.Location = new System.Drawing.Point(10, 50);
            this.nextLabel.Name = "nextLabel";
            this.nextLabel.Size = new System.Drawing.Size(52, 15);
            this.nextLabel.TabIndex = 3;
            this.nextLabel.Text = "Suivant :";
            // 
            // previousLabel
            // 
            this.previousLabel.AutoSize = true;
            this.previousLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.previousLabel.Location = new System.Drawing.Point(10, 80);
            this.previousLabel.Name = "previousLabel";
            this.previousLabel.Size = new System.Drawing.Size(66, 15);
            this.previousLabel.TabIndex = 2;
            this.previousLabel.Text = "Précédent :";
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.newLabel.Location = new System.Drawing.Point(10, 20);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(61, 15);
            this.newLabel.TabIndex = 0;
            this.newLabel.Text = "Nouveau :";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.saveButton.Location = new System.Drawing.Point(62, 425);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 25);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Sauvegarder";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cancelButton.Location = new System.Drawing.Point(222, 425);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 25);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OptionForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Option";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionForm_FormClosing);
            this.Load += new System.EventHandler(this.OptionForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OptionForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OptionForm_KeyUp);
            this.tabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            this.shortcutTabPage.ResumeLayout(false);
            this.shortcutTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage shortcutTabPage;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox previousTextBox;
        private System.Windows.Forms.TextBox nextTextBox;
        private System.Windows.Forms.TextBox newTextBox;
        private System.Windows.Forms.Label nextLabel;
        private System.Windows.Forms.Label previousLabel;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.Button newEditButton;
        private System.Windows.Forms.Button nextEditButton;
        private System.Windows.Forms.Button previousEditButton;
        private System.Windows.Forms.Button defaultButton;
    }
}