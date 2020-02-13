using System.Windows.Forms;

namespace YGGDrafus
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
            if (disposing)
            {
                if (components != null)
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameListToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.upToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.gameListToolStripComboBox,
            this.upToolStripMenuItem,
            this.downToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1008, 27);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.newToolStripMenuItem.Text = "Nouveau";
            this.newToolStripMenuItem.ToolTipText = "Lancer une nouvelle instance du jeu";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // gameListToolStripComboBox
            // 
            this.gameListToolStripComboBox.Name = "gameListToolStripComboBox";
            this.gameListToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.gameListToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.GameListToolStripComboBox_SelectedIndexChanged);
            // 
            // upToolStripMenuItem
            // 
            this.upToolStripMenuItem.Enabled = false;
            this.upToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.upToolStripMenuItem.Name = "upToolStripMenuItem";
            this.upToolStripMenuItem.Size = new System.Drawing.Size(27, 23);
            this.upToolStripMenuItem.Text = "￪";
            this.upToolStripMenuItem.ToolTipText = "Up";
            this.upToolStripMenuItem.Click += new System.EventHandler(this.UpToolStripMenuItem_Click);
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.Enabled = false;
            this.downToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.Size = new System.Drawing.Size(27, 23);
            this.downToolStripMenuItem.Text = "￬";
            this.downToolStripMenuItem.ToolTipText = "Down";
            this.downToolStripMenuItem.Click += new System.EventHandler(this.DownToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.optionToolStripMenuItem.Text = "Option";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.OptionToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 704);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1008, 25);
            this.mainPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "YGGDrafus";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox gameListToolStripComboBox;
        private System.Windows.Forms.Panel mainPanel;
        private ToolStripMenuItem upToolStripMenuItem;
        private ToolStripMenuItem downToolStripMenuItem;
        private ToolStripMenuItem optionToolStripMenuItem;

        public ToolStripMenuItem NewToolStripMenuItem { get => this.newToolStripMenuItem; }
        public ToolStripComboBox GameListToolStripComboBox { get => gameListToolStripComboBox; }
        public ToolStripMenuItem OptionToolStripMenuItem { get => optionToolStripMenuItem; }
    }
}