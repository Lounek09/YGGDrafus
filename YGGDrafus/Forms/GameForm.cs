﻿using AxShockwaveFlashObjects;
using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace YGGDrafus
{
    public partial class GameForm : Form
    {
        private readonly string gamePath;

        public GameForm(string gamePath)
        {
            InitializeComponent();
            this.gamePath = gamePath;
        }

        #region Initialization
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitGame();
            InitText();
            InitImage();
        }

        private void InitGame()
        {
            // Launch the game
            gameAxShockwaveFlash.LoadMovie(0, gamePath);

            //Add Filter
            SetGameFilterOpacity(((MainForm)MdiParent).ConfigurableOptions.FilterOpacityValue, ((MainForm)MdiParent).ConfigurableOptions.EnableFilterOpacity);

            // Communication Flash
            gameAxShockwaveFlash.FlashCall += new _IShockwaveFlashEvents_FlashCallEventHandler(GameAxShockwaveFlash_FlashCall);
        }

        private void InitText()
        {
            indexLabel.Text = (GetIndex() + 1).ToString();
        }

        private void InitImage()
        {
            buttonClose.Image = Image.FromFile(Constant.Instance.IMG_PATH + "close.png");
            pictureBoxLogo.ImageLocation = Constant.Instance.IMG_PATH + "login.png";
        }

        #endregion

        #region Flash Communication

        private void GameAxShockwaveFlash_FlashCall(object sender, _IShockwaveFlashEvents_FlashCallEvent e)
        {

            XmlDocument document = Xml.ReadXmlFromString(e.request);

            if (document != null)
            {
                string nameFunction = document.DocumentElement.GetAttribute("name");
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
                        if (((MainForm)MdiParent).ConfigurableOptions.EnableNotification && ActiveForm == null)
                            MakeNotification((string)args[0]);
                        break;
                    case "setLoginDiscordActivity":
                        SetLoginDiscordActivity();
                        break;
                    case "setIngameDiscordActivity":
                        SetIngameDiscordActivity(args);
                        break;
                    case "changeTitle":
                        break;
                }
            }
        }
        
        private void DebugRequest(ArrayList args)
        {
            string data, playerName, currentServer, arrow, message;
            PacketForm packetForm = null;

            if (String.IsNullOrEmpty(args[0].ToString()))
                arrow = "<-->";
            else
                arrow = (bool)args[0] ? "-->" : "<--";
            data = String.IsNullOrEmpty(args[2].ToString()) ? null : args[2].ToString();
            playerName = String.IsNullOrEmpty(args[3].ToString()) ? null : args[3].ToString();
            currentServer = String.IsNullOrEmpty(args[4].ToString()) ? null : args[4].ToString();

            if (playerName == null)
                message = arrow + " " + data;
            else
                message = "(" + playerName + ", " + currentServer + ") " + arrow + " " + data;

            foreach (Form form in ((MainForm)MdiParent).OwnedForms)
            {
                if (form is PacketForm)
                {
                    packetForm = (PacketForm)form;
                    break;
                }
            }
            if (!(packetForm is null))
                packetForm.AddNewPacket(message);

            if (((MainForm)MdiParent).ConfigurableOptions.EnableLog)
                Logger.Log(message);
        }

        private void MakeNotification(string message)
        {
            message = message.Replace("\r\n","");
            if (message.Length > 100)
                message = message.Substring(0, 100) + "...";

            ((MainForm)MdiParent).MakeNotification((String)((MainForm)MdiParent).GameListToolStripComboBox.Items[GetIndex()], message, Constant.Instance.IMG_PATH + "YGGDrafus-game.png");

        }

        private void SetLoginDiscordActivity()
        {

            pictureBoxLogo.ImageLocation = Constant.Instance.IMG_PATH + "login.png";
            ((MainForm)MdiParent).GameListToolStripComboBox.Items[GetIndex()] = (GetIndex() + 1) + " - Connexion";

            ((MainForm)MdiParent).SetDebugRequestsInConfig(false);

            if (((MainForm)MdiParent).Children.Count < Constant.Instance.MAX_GAME_INSTANCE)
                ((MainForm)MdiParent).NewToolStripMenuItem.Enabled = true;

        }

        private void SetIngameDiscordActivity(ArrayList args)
        {
            string playerPseudo = (string)args[2];
            int classId = Convert.ToInt16(args[5], NumberFormatInfo.InvariantInfo);
            int sexeId = Convert.ToByte(args[6], NumberFormatInfo.InvariantInfo);
            string logo = Constant.Instance.IMG_PATH + "login.png";
            switch(classId)
            {
                case 1: //Feca
                    if (sexeId == 1)
                        logo = Constant.Instance.IMG_PATH + "fecaF.png";
                    else
                        logo = Constant.Instance.IMG_PATH + "fecaM.png";
                    break;
                case 2: //Osamodas
                    if (sexeId == 1)
                        logo = Constant.Instance.IMG_PATH + "osaF.png";
                    else
                        logo = Constant.Instance.IMG_PATH + "osaM.png";
                    break;
                case 3: //Enutrof
                    if (sexeId == 1)
                        logo = Constant.Instance.IMG_PATH + "enuF.png";
                    else
                        logo = Constant.Instance.IMG_PATH + "enuM.png";
                    break;
                case 4: //Sram
                    if (sexeId == 1)
                        logo = Constant.Instance.IMG_PATH + "sramF.png";
                    else
                        logo = Constant.Instance.IMG_PATH + "sramM.png";
                    break;
                case 5: //Xelor
                    if (sexeId == 1)
                        logo = Constant.Instance.IMG_PATH + "xelF.png";
                    else
                        logo = Constant.Instance.IMG_PATH + "xelM.png";
                    break;
                case 6: //Ecaflip
                    if (sexeId == 1)
                        logo = Constant.Instance.IMG_PATH + "ecaF.png";
                    else
                        logo = Constant.Instance.IMG_PATH + "ecaM.png";
                    break;
                case 7: //Eniripsa
                    if (sexeId == 1)
                        logo = Constant.Instance.IMG_PATH + "eniF.png";
                    else
                        logo = Constant.Instance.IMG_PATH + "eniM.png";
                    break;
                case 8: //Iop
                    if (sexeId == 1)
                        logo = Constant.Instance.IMG_PATH + "iopF.png";
                    else
                        logo = Constant.Instance.IMG_PATH + "iopM.png";
                    break;
                case 9: //Cra
                    if (sexeId == 1)
                        logo = Constant.Instance.IMG_PATH + "craF.png";
                    else
                        logo = Constant.Instance.IMG_PATH + "craM.png";
                    break;
                case 10: //Sadida
                    if (sexeId == 1)
                        logo = Constant.Instance.IMG_PATH + "sadiF.png";
                    else
                        logo = Constant.Instance.IMG_PATH + "sadiM.png";
                    break;
                case 11: //Sacrieur
                    if (sexeId == 1)
                        logo = Constant.Instance.IMG_PATH + "sacriF.png";
                    else
                        logo = Constant.Instance.IMG_PATH + "sacriM.png";
                    break;
                case 12: //Pandawa
                    if (sexeId == 1)
                        logo = Constant.Instance.IMG_PATH + "pandaF.png";
                    else
                        logo = Constant.Instance.IMG_PATH + "pandaM.png";
                    break;
            }
            ((MainForm)MdiParent).GameListToolStripComboBox.Items[GetIndex()] = (GetIndex() + 1) + " - " + playerPseudo;
            pictureBoxLogo.ImageLocation = logo;
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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            CloseGame();
        }

        public void CloseGame()
        {
            ToolStripComboBox cb = ((MainForm)MdiParent).GameListToolStripComboBox;
            int index = GetIndex();

            cb.Items.RemoveAt(index);
            ((MainForm)MdiParent).Children.RemoveAt(index);

            if (cb.Items.Count < Constant.Instance.MAX_GAME_INSTANCE)
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

        public void SetGameFilterOpacity(int value, bool enable)
        {
            if (enable)
                gameAxShockwaveFlash.LoadMovie(1, Path.GetFullPath(Constant.Instance.SWF_PATH + "filter.swf") + "?opacity=" + value);
            else
                gameAxShockwaveFlash.LoadMovie(1, "");
        }
    }
}
