using AxShockwaveFlashObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml;


namespace YGGDrafus
{
    public partial class GameForm : Form
    {
        private readonly List<string> packets;
        private readonly string gamePath;
        private bool focused;

        public GameForm(String gamePath)
        {
            InitializeComponent();
            packets = new List<string>();
            this.gamePath = gamePath;
        }

        #region Initialization
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitGame();
        }


        private void InitGame()
        {
            // Launch the game
            axShockwaveFlashGame.LoadMovie(0, gamePath);

            // Communicate with Flash
            axShockwaveFlashGame.FlashCall += new _IShockwaveFlashEvents_FlashCallEventHandler(AxShockwaveFlashGame_FlashCall);
        }

        #endregion

        private int GetIndex()
        {
            int index = 0;

            foreach (Form child in ((MainForm)MdiParent).Children)
            {
                if (child.Equals(this))
                    break;
                index++;
            }
            return index;
        }

        private void GameForm_Activated(object sender, EventArgs e)
        {
            focused = true;
        }

        private void GameForm_Deactivate(object sender, EventArgs e)
        {
            focused = false;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            CloseGame();
        }

        #region Flash Communication

        private static XmlDocument ReadFlashCall(string request)
        {
            XmlDocument document = new XmlDocument() { XmlResolver = null };
            StringReader stringReader = new StringReader(request);
            XmlReader xmlReader = null;
            try
            {
                xmlReader = XmlReader.Create(input: stringReader, settings: new XmlReaderSettings() { XmlResolver = null });
                document.Load(xmlReader);
            }
            finally
            {
                if (xmlReader != null)
                    xmlReader.Close();
                else
                    document = null;
            }
            return document;
        }

        private void AxShockwaveFlashGame_FlashCall(object sender, _IShockwaveFlashEvents_FlashCallEvent e)
        {

            XmlDocument document = ReadFlashCall(e.request);

            if (document != null)
            {
                String nameFunction = document.DocumentElement.GetAttribute("name");
                document.ToString();
                //Set all arg into an ArrayList
                ArrayList args = new ArrayList();
                foreach (XmlNode arg in document.GetElementsByTagName("arguments")[0].ChildNodes)
                {
                    if (String.Equals(arg.Name, "false", StringComparison.Ordinal) || String.Equals(arg.Name, "true", StringComparison.Ordinal))
                        args.Add(Boolean.Parse(arg.Name));
                    else
                        args.Add(arg.InnerText);
                }
                
                switch (nameFunction)
                {
                    case "userLog":
                        break;
                    case "debugRequest":
                            DebugRequest(args);
                        break;
                    case "makeNotification":
                        //if (!focused)
                            //MakeNotification((String)args[0]);
                        break;
                    case "setLoginDiscordActivity":
                        SetLoginDiscordActivity(args);
                        break;
                    case "setIngameDiscordActivity":
                        SetIngameDiscordActivity(args);
                        break;
                    case "changeTitle":
                        Text = GetIndex() + " : " + (String)args[0];
                        break;
                }
            }
        }
        
        private void DebugRequest(ArrayList args)
        {
            String data, playerName, currentServer, arrow, message;

            if(String.IsNullOrEmpty(args[0].ToString()))
                arrow = "<-->";
            else
            {
                arrow = (bool)args[0] ? "-->" : "<--";
            } 
            data = String.IsNullOrEmpty(args[2].ToString()) ? null : args[2].ToString();
            playerName = String.IsNullOrEmpty(args[3].ToString()) ? null : args[3].ToString();
            currentServer = String.IsNullOrEmpty(args[4].ToString()) ? null : args[4].ToString();
            
            if (playerName == null)
                message = arrow + " " + data;
            else
                message = "(" + playerName + ", " + currentServer + ") " + arrow + " " + data;

            packets.Insert(0, message);
            if (packets.Count > 100)
                packets.RemoveAt(100);
        }

        private void MakeNotification(String message)
        {
            if (message.Length > 100)
            {
                message = message.Substring(0, 100) + "...";
            }
            ((MainForm)MdiParent).Popup.ContentText = message;
            ((MainForm)MdiParent).Popup.Popup();
        }

        private void SetLoginDiscordActivity(ArrayList args)
        {

            pictureBoxLogo.Image = Properties.Resources.Login;
            ((MainForm)MdiParent).GameListToolStripComboBox.Items[GetIndex()] = (GetIndex() + 1) + " : Connexion";
        }

        private void SetIngameDiscordActivity(ArrayList args)
        {
            String playerPseudo = (String)args[2];
            int classId = Convert.ToInt16(args[5], NumberFormatInfo.InvariantInfo);
            int sexeId = Convert.ToByte(args[6], NumberFormatInfo.InvariantInfo);
            Bitmap logo = Properties.Resources.Login;
            switch(classId)
            {
                case 1: //Feca
                    if (sexeId == 1)
                        logo = Properties.Resources.fecaF;
                    else
                        logo = Properties.Resources.fecaM;
                    break;
                case 2: //Osamodas
                    if (sexeId == 1)
                        logo = Properties.Resources.osaF;
                    else
                        logo = Properties.Resources.osaM;
                    break;
                case 3: //Enutrof
                    if (sexeId == 1)
                        logo = Properties.Resources.enuF;
                    else
                        logo = Properties.Resources.enuM;
                    break;
                case 4: //Sram
                    if (sexeId == 1)
                        logo = Properties.Resources.sramF;
                    else
                        logo = Properties.Resources.sramM;
                    break;
                case 5: //Xelor
                    if (sexeId == 1)
                        logo = Properties.Resources.xelF;
                    else
                        logo = Properties.Resources.xelM;
                    break;
                case 6: //Ecaflip
                    if (sexeId == 1)
                        logo = Properties.Resources.ecaF;
                    else
                        logo = Properties.Resources.ecaM;
                    break;
                case 7: //Eniripsa
                    if (sexeId == 1)
                        logo = Properties.Resources.eniF;
                    else
                        logo = Properties.Resources.eniM;
                    break;
                case 8: //Iop
                    if (sexeId == 1)
                        logo = Properties.Resources.iopF;
                    else
                        logo = Properties.Resources.iopM;
                    break;
                case 9: //Cra
                    if (sexeId == 1)
                        logo = Properties.Resources.craF;
                    else
                        logo = Properties.Resources.craM;
                    break;
                case 10: //Sadida
                    if (sexeId == 1)
                        logo = Properties.Resources.sadiF;
                    else
                        logo = Properties.Resources.sadiM;
                    break;
                case 11: //Sacrieur
                    if (sexeId == 1)
                        logo = Properties.Resources.sacriF;
                    else
                        logo = Properties.Resources.sacriM;
                    break;
                case 12: //Pandawa
                    if (sexeId == 1)
                        logo = Properties.Resources.pandaF;
                    else
                        logo = Properties.Resources.pandaM;
                    break;
            }
            ((MainForm)MdiParent).GameListToolStripComboBox.Items[GetIndex()] = (GetIndex() + 1) + " : " + playerPseudo;
            pictureBoxLogo.Image = logo;
        }

        #endregion

        public void CloseGame()
        {
            ToolStripComboBox cb = ((MainForm)MdiParent).GameListToolStripComboBox;
            int index = GetIndex();

            cb.Items.RemoveAt(index);
            ((MainForm)MdiParent).Children.RemoveAt(index);

            if (cb.Items.Count < 8)
                ((MainForm)MdiParent).NewToolStripMenuItem.Enabled = true;

            if (index < cb.Items.Count)
                cb.SelectedIndex = index;
            else if (cb.Items.Count != 0)
                cb.SelectedIndex = 0;
            else
                cb.Text = "";

            ((MainForm)MdiParent).ReorganizeGameListText();

            Close();
        }
    }
}
