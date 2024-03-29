﻿namespace YGGDrafus
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
            this.enableLogCheckBox = new System.Windows.Forms.CheckBox();
            this.enableLogLabel = new System.Windows.Forms.Label();
            this.enableFilterOpacityCheckBox = new System.Windows.Forms.CheckBox();
            this.enableFilterOpacityLabel = new System.Windows.Forms.Label();
            this.filterOpacityValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.filterOpacityValueLabel = new System.Windows.Forms.Label();
            this.screenshotFolderButton = new System.Windows.Forms.Button();
            this.screenshotFolderLabel = new System.Windows.Forms.Label();
            this.notificationCheckBox = new System.Windows.Forms.CheckBox();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.pathButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.shortcutTabPage = new System.Windows.Forms.TabPage();
            this.screenshotEditButton = new System.Windows.Forms.Button();
            this.screenshotTextBox = new System.Windows.Forms.TextBox();
            this.screenshotLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.filterOpacityValueNumericUpDown)).BeginInit();
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
            this.generalTabPage.Controls.Add(this.enableLogCheckBox);
            this.generalTabPage.Controls.Add(this.enableLogLabel);
            this.generalTabPage.Controls.Add(this.enableFilterOpacityCheckBox);
            this.generalTabPage.Controls.Add(this.enableFilterOpacityLabel);
            this.generalTabPage.Controls.Add(this.filterOpacityValueNumericUpDown);
            this.generalTabPage.Controls.Add(this.filterOpacityValueLabel);
            this.generalTabPage.Controls.Add(this.screenshotFolderButton);
            this.generalTabPage.Controls.Add(this.screenshotFolderLabel);
            this.generalTabPage.Controls.Add(this.notificationCheckBox);
            this.generalTabPage.Controls.Add(this.notificationLabel);
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
            // enableLogCheckBox
            // 
            this.enableLogCheckBox.AutoSize = true;
            this.enableLogCheckBox.Location = new System.Drawing.Point(108, 191);
            this.enableLogCheckBox.Name = "enableLogCheckBox";
            this.enableLogCheckBox.Size = new System.Drawing.Size(15, 14);
            this.enableLogCheckBox.TabIndex = 12;
            this.enableLogCheckBox.UseVisualStyleBackColor = true;
            // 
            // enableLogLabel
            // 
            this.enableLogLabel.AutoSize = true;
            this.enableLogLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableLogLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enableLogLabel.Location = new System.Drawing.Point(10, 190);
            this.enableLogLabel.Name = "enableLogLabel";
            this.enableLogLabel.Size = new System.Drawing.Size(92, 15);
            this.enableLogLabel.TabIndex = 11;
            this.enableLogLabel.Text = "Activer les logs :";
            // 
            // enableFilterOpacityCheckBox
            // 
            this.enableFilterOpacityCheckBox.AutoSize = true;
            this.enableFilterOpacityCheckBox.Location = new System.Drawing.Point(105, 111);
            this.enableFilterOpacityCheckBox.Name = "enableFilterOpacityCheckBox";
            this.enableFilterOpacityCheckBox.Size = new System.Drawing.Size(15, 14);
            this.enableFilterOpacityCheckBox.TabIndex = 10;
            this.enableFilterOpacityCheckBox.UseVisualStyleBackColor = true;
            this.enableFilterOpacityCheckBox.CheckedChanged += new System.EventHandler(this.EnableFilterOpacityCheckBox_CheckedChanged);
            // 
            // enableFilterOpacityLabel
            // 
            this.enableFilterOpacityLabel.AutoSize = true;
            this.enableFilterOpacityLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableFilterOpacityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enableFilterOpacityLabel.Location = new System.Drawing.Point(10, 110);
            this.enableFilterOpacityLabel.Name = "enableFilterOpacityLabel";
            this.enableFilterOpacityLabel.Size = new System.Drawing.Size(89, 15);
            this.enableFilterOpacityLabel.TabIndex = 9;
            this.enableFilterOpacityLabel.Text = "Activer le filtre :";
            // 
            // filterOpacityValueNumericUpDown
            // 
            this.filterOpacityValueNumericUpDown.Location = new System.Drawing.Point(142, 129);
            this.filterOpacityValueNumericUpDown.Name = "filterOpacityValueNumericUpDown";
            this.filterOpacityValueNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.filterOpacityValueNumericUpDown.TabIndex = 8;
            this.filterOpacityValueNumericUpDown.ValueChanged += new System.EventHandler(this.FilterOpacityValueNumericUpDown_ValueChanged);
            // 
            // filterOpacityValueLabel
            // 
            this.filterOpacityValueLabel.AutoSize = true;
            this.filterOpacityValueLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterOpacityValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.filterOpacityValueLabel.Location = new System.Drawing.Point(30, 130);
            this.filterOpacityValueLabel.Name = "filterOpacityValueLabel";
            this.filterOpacityValueLabel.Size = new System.Drawing.Size(106, 15);
            this.filterOpacityValueLabel.TabIndex = 7;
            this.filterOpacityValueLabel.Text = "- Opacité du filtre :";
            // 
            // screenshotFolderButton
            // 
            this.screenshotFolderButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenshotFolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.screenshotFolderButton.Location = new System.Drawing.Point(200, 156);
            this.screenshotFolderButton.Name = "screenshotFolderButton";
            this.screenshotFolderButton.Size = new System.Drawing.Size(46, 23);
            this.screenshotFolderButton.TabIndex = 6;
            this.screenshotFolderButton.Text = "ouvrir";
            this.screenshotFolderButton.UseVisualStyleBackColor = true;
            this.screenshotFolderButton.Click += new System.EventHandler(this.ScreenshotFolderButton_Click);
            // 
            // screenshotFolderLabel
            // 
            this.screenshotFolderLabel.AutoSize = true;
            this.screenshotFolderLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenshotFolderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.screenshotFolderLabel.Location = new System.Drawing.Point(10, 160);
            this.screenshotFolderLabel.Name = "screenshotFolderLabel";
            this.screenshotFolderLabel.Size = new System.Drawing.Size(184, 15);
            this.screenshotFolderLabel.TabIndex = 5;
            this.screenshotFolderLabel.Text = "Ouvrir le dossier des screenshots :";
            // 
            // notificationCheckBox
            // 
            this.notificationCheckBox.AutoSize = true;
            this.notificationCheckBox.Location = new System.Drawing.Point(152, 81);
            this.notificationCheckBox.Name = "notificationCheckBox";
            this.notificationCheckBox.Size = new System.Drawing.Size(15, 14);
            this.notificationCheckBox.TabIndex = 4;
            this.notificationCheckBox.UseVisualStyleBackColor = true;
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.notificationLabel.Location = new System.Drawing.Point(10, 80);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(136, 15);
            this.notificationLabel.TabIndex = 3;
            this.notificationLabel.Text = "Activer les notifications :";
            // 
            // pathButton
            // 
            this.pathButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pathButton.Location = new System.Drawing.Point(330, 38);
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
            this.pathTextBox.Location = new System.Drawing.Point(13, 39);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(317, 20);
            this.pathTextBox.TabIndex = 1;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pathLabel.Location = new System.Drawing.Point(10, 20);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(174, 15);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "Chemin de votre dossier de jeu :";
            // 
            // shortcutTabPage
            // 
            this.shortcutTabPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.shortcutTabPage.Controls.Add(this.screenshotEditButton);
            this.shortcutTabPage.Controls.Add(this.screenshotTextBox);
            this.shortcutTabPage.Controls.Add(this.screenshotLabel);
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
            // screenshotEditButton
            // 
            this.screenshotEditButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenshotEditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.screenshotEditButton.Location = new System.Drawing.Point(256, 107);
            this.screenshotEditButton.Name = "screenshotEditButton";
            this.screenshotEditButton.Size = new System.Drawing.Size(35, 22);
            this.screenshotEditButton.TabIndex = 15;
            this.screenshotEditButton.TabStop = false;
            this.screenshotEditButton.Text = "Edit";
            this.screenshotEditButton.UseVisualStyleBackColor = true;
            this.screenshotEditButton.Click += new System.EventHandler(this.ScreenshotEditButton_Click);
            // 
            // screenshotTextBox
            // 
            this.screenshotTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.screenshotTextBox.Enabled = false;
            this.screenshotTextBox.Location = new System.Drawing.Point(146, 108);
            this.screenshotTextBox.Name = "screenshotTextBox";
            this.screenshotTextBox.ReadOnly = true;
            this.screenshotTextBox.Size = new System.Drawing.Size(100, 20);
            this.screenshotTextBox.TabIndex = 14;
            // 
            // screenshotLabel
            // 
            this.screenshotLabel.AutoSize = true;
            this.screenshotLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenshotLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.screenshotLabel.Location = new System.Drawing.Point(10, 110);
            this.screenshotLabel.Name = "screenshotLabel";
            this.screenshotLabel.Size = new System.Drawing.Size(131, 15);
            this.screenshotLabel.TabIndex = 13;
            this.screenshotLabel.Text = "Prendre un screenshot :";
            // 
            // defaultButton
            // 
            this.defaultButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.defaultButton.Location = new System.Drawing.Point(20, 150);
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
            this.nextEditButton.Location = new System.Drawing.Point(256, 47);
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
            this.previousEditButton.Location = new System.Drawing.Point(256, 77);
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
            this.newEditButton.Location = new System.Drawing.Point(256, 17);
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
            this.previousTextBox.Location = new System.Drawing.Point(146, 78);
            this.previousTextBox.Name = "previousTextBox";
            this.previousTextBox.ReadOnly = true;
            this.previousTextBox.Size = new System.Drawing.Size(100, 20);
            this.previousTextBox.TabIndex = 6;
            // 
            // nextTextBox
            // 
            this.nextTextBox.Enabled = false;
            this.nextTextBox.Location = new System.Drawing.Point(146, 48);
            this.nextTextBox.Name = "nextTextBox";
            this.nextTextBox.ReadOnly = true;
            this.nextTextBox.Size = new System.Drawing.Size(100, 20);
            this.nextTextBox.TabIndex = 5;
            // 
            // newTextBox
            // 
            this.newTextBox.Enabled = false;
            this.newTextBox.Location = new System.Drawing.Point(146, 18);
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
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tabControl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionForm_FormClosing);
            this.Load += new System.EventHandler(this.OptionForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OptionForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OptionForm_KeyUp);
            this.tabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterOpacityValueNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.CheckBox notificationCheckBox;
        private System.Windows.Forms.Button screenshotEditButton;
        private System.Windows.Forms.TextBox screenshotTextBox;
        private System.Windows.Forms.Label screenshotLabel;
        private System.Windows.Forms.Button screenshotFolderButton;
        private System.Windows.Forms.Label screenshotFolderLabel;
        private System.Windows.Forms.NumericUpDown filterOpacityValueNumericUpDown;
        private System.Windows.Forms.Label filterOpacityValueLabel;
        private System.Windows.Forms.Label enableFilterOpacityLabel;
        private System.Windows.Forms.CheckBox enableFilterOpacityCheckBox;
        private System.Windows.Forms.CheckBox enableLogCheckBox;
        private System.Windows.Forms.Label enableLogLabel;
    }
}