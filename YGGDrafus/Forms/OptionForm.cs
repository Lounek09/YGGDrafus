using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGGDrafus
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            pathTextBox.Text = ((MainForm)Owner).ConfigurableOption.GamePath;
            AddShorcutsValue(((MainForm)Owner).ConfigurableOption.Shortcuts);
        }

        private void AddShorcutsValue(Dictionary<String, String> shortcuts)
        {
            newTextBox.Text = shortcuts["new"];
            previousTextBox.Text = shortcuts["previous"];
            nextTextBox.Text = shortcuts["next"];
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ConfigurableOptions configurableOption = ((MainForm)Owner).ConfigurableOption;

            configurableOption.GamePath = pathTextBox.Text;
            configurableOption.Shortcuts["new"] = newTextBox.Text;
            configurableOption.Shortcuts["previous"] = previousTextBox.Text;
            configurableOption.Shortcuts["next"] = nextTextBox.Text;

            configurableOption.Save();

            Close();
        }

        private void OptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)Owner).OptionToolStripMenuItem.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region General Tab

        private void PathButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\Users";
            dialog.IsFolderPicker = true;
            
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                pathTextBox.Text = dialog.FileName;
            }
        }

        #endregion

        #region Shortcut Tab

        private void OptionForm_KeyDown(object sender, KeyEventArgs e)
        {
            String input = new ExtendedKeyEventArgs(e.KeyData).ToString();

            if (newTextBox.Enabled)
                newTextBox.Text = input;
            else if (previousTextBox.Enabled)
                previousTextBox.Text = input;
            else if (nextTextBox.Enabled)
                nextTextBox.Text = input;
        }

        private void OptionForm_KeyUp(object sender, KeyEventArgs e)
        {
            DisabledShortcutEdit();
        }

        private void NewEditButton_Click(object sender, EventArgs e)
        {
            bool doEdit = newTextBox.Enabled;

            DisabledShortcutEdit();
            if (!doEdit)
                newTextBox.Enabled = true;
        }

        private void PreviousEditButton_Click(object sender, EventArgs e)
        {
            bool doEdit = previousTextBox.Enabled;

            DisabledShortcutEdit();
            if (!doEdit)
                previousTextBox.Enabled = true;
        }

        private void NextEditButton_Click(object sender, EventArgs e)
        {
            bool doEdit = nextTextBox.Enabled;

            DisabledShortcutEdit();
            if (!doEdit)
                nextTextBox.Enabled = true;
        }

        private void TabControl_TabIndexChanged(object sender, EventArgs e)
        {
            DisabledShortcutEdit();
        }

        private void DisabledShortcutEdit()
        {
            newTextBox.Enabled = false;
            previousTextBox.Enabled = false;
            nextTextBox.Enabled = false;
        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            AddShorcutsValue(ConfigurableOptions.DefaultShorcuts());
            DisabledShortcutEdit();
        }

        #endregion
    }
}
