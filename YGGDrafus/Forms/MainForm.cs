using AxShockwaveFlashObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Xml;

namespace YGGDrafus
{
    public partial class MainForm : Form
    {
        private ConfigurableOptions configurableOptions;
        private readonly List<GameForm> children;

        public ConfigurableOptions ConfigurableOptions { get => configurableOptions; }
        public List<GameForm> Children { get => children; }

        public MainForm()
        {
            InitializeComponent();
            children = new List<GameForm>();
        }

        #region Initialization

        private void MainForm_Load(object sender, EventArgs e)
        {
            Icon = new Icon(Constant.Instance.MAIN_ICO_FILE);
            InitConfigurableOptions();
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

        #endregion

        #region MenuStrip
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
            OptionForm optionForm = new OptionForm { Owner = this };
            optionForm.Show();

            optionToolStripMenuItem.Enabled = false;
        }

        private void PaquetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacketForm packetForm = new PacketForm { Owner = this };
            packetForm.Show();

            packetToolStripMenuItem.Enabled = false; 
        }

        private void EncyclopediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string itemsPath = configurableOptions.GamePath + Constant.Instance.ITEMS_IN_GAME_PATH;

            EncyclopediaForm encyclopediaForm = new EncyclopediaForm(itemsPath) { Owner = this };
            encyclopediaForm.Show();

            encyclopediaToolStripMenuItem.Enabled = false;
        }

        #endregion

        #region Shortcuts

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            string input = new ExtendedKeyEventArgs(e.KeyData).ToString();
            Dictionary<string, string> shortcuts = configurableOptions.Shortcuts;

            if (String.Equals(input, shortcuts["new"], StringComparison.Ordinal))
                AddNewGame();
            if (String.Equals(input, shortcuts["next"], StringComparison.Ordinal))
                Next();
            if (String.Equals(input, shortcuts["previous"], StringComparison.Ordinal))
                Previous();
            if (String.Equals(input, shortcuts["screenshot"], StringComparison.Ordinal))
                TakeScreenShot();
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

        private void Previous()
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

        private void TakeScreenShot()
        {
            if (gameListToolStripComboBox.Items.Count != 0)
            {
                AxShockwaveFlash game = children[gameListToolStripComboBox.SelectedIndex].GameAxShockwaveFlash;

                Rectangle bounds = game.RectangleToScreen(game.Bounds);
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                        graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size, CopyPixelOperation.SourceCopy);
                    bitmap.Save(Constant.Instance.SCREENSHOT_PATH + "dofus-" + DateTime.Now.ToString("MMddyyyyHHmmss") + ".png", ImageFormat.Png);
                }

                MakeNotification("YGGDrafus", "Vous avez pris un screenshot !", Constant.Instance.IMG_PATH + "YGGDrafus-screenshot.png");
            }
        }

        #endregion

        private void AddNewGame()
        {
            if (children.Count < Constant.Instance.MAX_GAME_INSTANCE)
            {
                string loaderPath = configurableOptions.GamePath + Constant.Instance.PRELOADER_IN_GAME_PATH;
                if (File.Exists(loaderPath))
                {
                    newToolStripMenuItem.Enabled = false;

                    SetDebugRequestsInConfig(true);

                    children.Add(new GameForm(loaderPath + "?electron=true")
                    {
                        MdiParent = this,
                        Dock = DockStyle.Fill
                    });
                    children[children.Count - 1].Show();

                    gameListToolStripComboBox.Items.Add((gameListToolStripComboBox.Items.Count + 1) + " - Chargement");
                    gameListToolStripComboBox.SelectedIndex = gameListToolStripComboBox.Items.Count - 1;
                }
                else
                    MessageBox.Show("Impossible de lancer le jeu, le fichier preloader.swf est introuvable", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SetDebugRequestsInConfig(bool add)
        {
            string configPath = configurableOptions.GamePath + Constant.Instance.CONFIG_IN_GAME_PATH;

            XmlDocument config = Xml.ReadXmlFromFile(configPath);

            if (config != null)
            {
                XmlNode nodeConf = config.DocumentElement.SelectSingleNode("/config/conf");

                if(nodeConf != null)
                { 
                    if (add)
                    {
                        XmlAttribute debugRequests = config.CreateAttribute("debugrequests");
                        debugRequests.Value = "2";

                        nodeConf.Attributes.Append(debugRequests);
                    }
                    else
                        nodeConf.Attributes.RemoveNamedItem("debugrequests");

                    config.Save(configPath);
                }
            }
        }

        public void MakeNotification(string title, string message, string logo)
        {
            ExecuteCmd.ExecuteCommandAsync(@"notification\snoretoast.exe " + "-t \"" + title + "\" -m \"" + message + "\" -appID YGGDrafus -p " + logo);
        }

        public void ReorganizeGameListText()
        {
            for (int i = 0; i < gameListToolStripComboBox.Items.Count; i++)
            {
                string value = (string)gameListToolStripComboBox.Items[i];
                value = value.Split('-')[1];
                gameListToolStripComboBox.Items[i] = (i + 1) + " -" + value;
                children[i].IndexLabel.Text = (i + 1).ToString();
            }
        }

        public void SetGamesFilterOpacity(int value, bool enable)
        {
            foreach(GameForm gameForm in children)
            {
                gameForm.SetGameFilterOpacity(value, enable);
            }
        }
    }
}
