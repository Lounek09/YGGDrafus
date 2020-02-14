using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace YGGDrafus
{
    public partial class MainForm : Form
    {
        private ConfigurableOptions configurableOptions;
        private PopupNotifier popup;
        private readonly List<GameForm> children;

        public ConfigurableOptions ConfigurableOption { get => configurableOptions; }
        public PopupNotifier Popup { get => popup; }
        public List<GameForm> Children { get => children; }
        public MainForm()
        {
            InitializeComponent();
            popup = new PopupNotifier();
            children = new List<GameForm>();
        }

        #region Initialization

        private void MainForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.YGGDrafus;
            InitConfigurableOptions();
            InitDesignNotification(Properties.Resources.Dofus);
        }

        private void InitConfigurableOptions()
        {
            Stream stream = null;
            try
            {
                stream = File.Open("options.ygg", FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();
                configurableOptions = (ConfigurableOptions)bformatter.Deserialize(stream);
            }
            catch
            {
                configurableOptions = new ConfigurableOptions();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        private void InitDesignNotification(Bitmap icon)
        {
            popup = new PopupNotifier
            {
                BorderColor = Color.Black,
                BodyColor = Color.Black,
                ContentColor = Color.White,
                ContentHoverColor = Color.White,
                ContentPadding = new Padding(0, 15, 0, 20),
                HeaderHeight = 1,
                Image = icon,
                ImageSize = new Size(45, 70),
                ImagePadding = new Padding(20, 15, 40, 0)
            };
            popup.Click += Popup_Click;
        }

        private void Popup_Click(object sender, EventArgs e)
        {
            popup.Hide();
        }

        #endregion

        #region ToolStrip
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewGame();
        }

        private void GameListToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = gameListToolStripComboBox.SelectedIndex;
            int nbInstance = gameListToolStripComboBox.Items.Count;

            children[selectedIndex].Select();

            if (nbInstance > 1 && selectedIndex != nbInstance - 1)
                upToolStripMenuItem.Enabled = true;
            else
                upToolStripMenuItem.Enabled = false;

            if(nbInstance > 1 && selectedIndex != 0)
                downToolStripMenuItem.Enabled = true;
            else
                downToolStripMenuItem.Enabled = false;
        }

        private void UpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nbInstance = gameListToolStripComboBox.Items.Count;
            int selectedIndex = gameListToolStripComboBox.SelectedIndex;
            if (nbInstance > 1 && selectedIndex != nbInstance - 1)
            {
                object comboBoxTemp = gameListToolStripComboBox.Items[selectedIndex];
                GameForm childrenTemp = children[selectedIndex];

                gameListToolStripComboBox.Items[selectedIndex] = gameListToolStripComboBox.Items[selectedIndex + 1];
                children[selectedIndex] = children[selectedIndex + 1];
                gameListToolStripComboBox.Items[selectedIndex + 1] = comboBoxTemp;
                children[selectedIndex + 1] = childrenTemp;

                gameListToolStripComboBox.SelectedIndex = selectedIndex + 1;

                ReorganizeGameListText();
            }
        }

        private void DownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nbInstance = gameListToolStripComboBox.Items.Count;
            int selectedIndex = gameListToolStripComboBox.SelectedIndex;
            if (nbInstance > 1 && selectedIndex != 0)
            { 
                object comboBoxTemp = gameListToolStripComboBox.Items[selectedIndex];
                GameForm childrenTemp = children[selectedIndex];

                gameListToolStripComboBox.Items[selectedIndex] = gameListToolStripComboBox.Items[selectedIndex - 1];
                children[selectedIndex] = children[selectedIndex - 1];
                gameListToolStripComboBox.Items[selectedIndex - 1] = comboBoxTemp;
                children[selectedIndex - 1] = childrenTemp;

                gameListToolStripComboBox.SelectedIndex = selectedIndex - 1;

                ReorganizeGameListText();
            }
        }

        private void OptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OptionForm optionForm = new OptionForm {Owner = this })
                optionForm.Show();
            optionToolStripMenuItem.Enabled = false;
        }

        public void ReorganizeGameListText()
        {
            for (int i = 0; i < gameListToolStripComboBox.Items.Count; i++)
            {
                string value = (String)gameListToolStripComboBox.Items[i];
                value = value.Split(':')[1];
                gameListToolStripComboBox.Items[i] = (i + 1) + " :" + value;
            }
        }

        #endregion

        #region Shortcuts

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            String input = new ExtendedKeyEventArgs(e.KeyData).ToString();
            Dictionary<String, String> shortcuts = configurableOptions.Shortcuts;

            if (String.Equals(input, shortcuts["new"], StringComparison.Ordinal))
                AddNewGame();
            if (String.Equals(input, shortcuts["previous"], StringComparison.Ordinal))
                Previous();
            if (String.Equals(input, shortcuts["next"], StringComparison.Ordinal))
                Next();
        }

        public void Previous()
        {
            int selectedIndex = gameListToolStripComboBox.SelectedIndex;
            int nbInstance = children.Count;
            
            if(nbInstance > 1)
            {
                if (selectedIndex != 0)
                    gameListToolStripComboBox.SelectedIndex = selectedIndex - 1;
                else
                    gameListToolStripComboBox.SelectedIndex = nbInstance - 1;
            }
        }

        private void Next()
        {
            int selectedIndex = gameListToolStripComboBox.SelectedIndex;
            int nbInstance = children.Count;

            if (nbInstance > 1)
            {
                if (selectedIndex != nbInstance - 1)
                    gameListToolStripComboBox.SelectedIndex = selectedIndex + 1;
                else
                    gameListToolStripComboBox.SelectedIndex = 0;
            }
        }

        #endregion

        private void AddNewGame()
        {
            if (children.Count < 8)
            {
                String loaderPath = configurableOptions.GamePath + @"\resources\app\retroclient\preloader.swf";
                if (File.Exists(loaderPath))
                {
                    children.Add(new GameForm(loaderPath + "?electron=true")
                    {
                        MdiParent = this,
                        Dock = DockStyle.Fill
                    });
                    children[children.Count - 1].Show();

                    gameListToolStripComboBox.Items.Add((gameListToolStripComboBox.Items.Count + 1) + " : Chargement");
                    gameListToolStripComboBox.SelectedIndex = gameListToolStripComboBox.Items.Count - 1;

                    if (MdiChildren.Length > 7)
                        newToolStripMenuItem.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Impossible de lancer le jeu, le fichier preloader.swf est introuvable", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
