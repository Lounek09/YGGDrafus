using Ookii.Dialogs.WinForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace YGGDrafus
{
    public partial class OptionForm : Form
    {
        private ConfigurableOptions configurableOptions;

        public OptionForm()
        {
            InitializeComponent();
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            Icon = new Icon(Constant.Instance.OPTION_ICO_FILE);

            configurableOptions = ((MainForm)Owner).ConfigurableOptions;

            //Set saved option value
            AddShorcutsValue(configurableOptions.Shortcuts);
            pathTextBox.Text = configurableOptions.GamePath;
            notificationCheckBox.Checked = configurableOptions.EnableNotification;
            enableFilterOpacityCheckBox.Checked = configurableOptions.EnableFilterOpacity;
            EnableFilterOpacityValue();
            filterOpacityValueNumericUpDown.Value = configurableOptions.FilterOpacityValue;
            enableLogCheckBox.Checked = configurableOptions.EnableLog;
        }

        private void AddShorcutsValue(Dictionary<string, string> shortcuts)
        {
            newTextBox.Text = shortcuts["new"];
            nextTextBox.Text = shortcuts["next"];
            previousTextBox.Text = shortcuts["previous"];
            screenshotTextBox.Text = shortcuts["screenshot"];
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveShorcutsValue();
            configurableOptions.GamePath = pathTextBox.Text;
            configurableOptions.EnableNotification = notificationCheckBox.Checked;
            configurableOptions.EnableFilterOpacity = enableFilterOpacityCheckBox.Checked;
            EnableFilterOpacityValue();
            configurableOptions.FilterOpacityValue = Convert.ToInt32(filterOpacityValueNumericUpDown.Value);
            configurableOptions.EnableLog = enableLogCheckBox.Checked;

            configurableOptions.Save();

            Close();
        }

        private void SaveShorcutsValue()
        {
            configurableOptions.Shortcuts["new"] = newTextBox.Text;
            configurableOptions.Shortcuts["next"] = nextTextBox.Text;
            configurableOptions.Shortcuts["previous"] = previousTextBox.Text;
            configurableOptions.Shortcuts["screenshot"] = screenshotTextBox.Text;
        }

        private void EnableFilterOpacityValue()
        {
            filterOpacityValueLabel.Enabled = enableFilterOpacityCheckBox.Checked;
            filterOpacityValueNumericUpDown.Enabled = enableFilterOpacityCheckBox.Checked;
            UpdateFilterOpacity(Convert.ToInt32(filterOpacityValueNumericUpDown.Value), enableFilterOpacityCheckBox.Checked);
        }

        private void UpdateFilterOpacity(int value, bool enable)
        {
            ((MainForm)Owner).SetGamesFilterOpacity(value, enable);
        }

        private void OptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)Owner).OptionToolStripMenuItem.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CloseOptionWithoutSave();
        }

        #region General Tab

        private void PathButton_Click(object sender, EventArgs e)
        {
            using (VistaFolderBrowserDialog dialog = new VistaFolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pathTextBox.Text = dialog.SelectedPath;
                    dialog.Dispose();
                }
            }
        }

        private void EnableFilterOpacityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EnableFilterOpacityValue();
        }

        private void FilterOpacityValueNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateFilterOpacity(Convert.ToInt32(filterOpacityValueNumericUpDown.Value), enableFilterOpacityCheckBox.Checked);
        }

        private void ScreenshotFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = Path.GetFullPath(Constant.Instance.SCREENSHOT_PATH),
                UseShellExecute = true,
                Verb = "open"
            });
        }

        #endregion

        #region Shortcut Tab

        private void OptionForm_KeyDown(object sender, KeyEventArgs e)
        {
            string input = new ExtendedKeyEventArgs(e.KeyData).ToString();

            if (newTextBox.Enabled)
                newTextBox.Text = input;
            else if (nextTextBox.Enabled)
                nextTextBox.Text = input;
            else if (previousTextBox.Enabled)
                previousTextBox.Text = input;
            else if (screenshotTextBox.Enabled)
                screenshotTextBox.Text = input;
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

        private void NextEditButton_Click(object sender, EventArgs e)
        {
            bool doEdit = nextTextBox.Enabled;

            DisabledShortcutEdit();
            if (!doEdit)
                nextTextBox.Enabled = true;
        }

        private void PreviousEditButton_Click(object sender, EventArgs e)
        {
            bool doEdit = previousTextBox.Enabled;

            DisabledShortcutEdit();
            if (!doEdit)
                previousTextBox.Enabled = true;
        }

        private void ScreenshotEditButton_Click(object sender, EventArgs e)
        {
            bool doEdit = screenshotTextBox.Enabled;

            DisabledShortcutEdit();
            if (!doEdit)
                screenshotTextBox.Enabled = true;
        }

        private void TabControl_TabIndexChanged(object sender, EventArgs e)
        {
            DisabledShortcutEdit();
        }

        private void DisabledShortcutEdit()
        {
            newTextBox.Enabled = false;
            nextTextBox.Enabled = false;
            previousTextBox.Enabled = false;
            screenshotTextBox.Enabled = false;
        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            AddShorcutsValue(ConfigurableOptions.DefaultShorcuts());
            DisabledShortcutEdit();
        }

        #endregion

        private void CloseOptionWithoutSave()
        {
            UpdateFilterOpacity(configurableOptions.FilterOpacityValue, configurableOptions.EnableFilterOpacity);
            Close();
        }
    }
}
