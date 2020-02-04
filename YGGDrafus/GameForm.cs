using AxShockwaveFlashObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml;
using Tulpep.NotificationWindow;


namespace YGGDrafus
{
    public partial class GameForm : Form
    {
        private readonly List<string> packets;
        private bool txtPacketFocused;
        private bool mainFormFocused;
        private readonly PopupNotifier popup;
        private GameFormSerializable gameFormSerializable;

        public GameForm()
        {
            InitializeComponent();
            packets = new List<string>();
            popup = new PopupNotifier();
            gameFormSerializable = new GameFormSerializable();
        }

        #region Form Event
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitSerializableData();
            // Launch the game
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = System.IO.Path.GetDirectoryName(path);
            //axShockwaveFlashGame.LoadMovie(0, directory + "\\preloader.swf?electron=yes");
            axShockwaveFlashGame.LoadMovie(0, "C:\\Users\\samuh\\Desktop\\Dofus\\Dofus 1\\Client\\Dofus Perso Modde\\Custom 1.30.17\\resources\\app\\retroclient\\preloader.swf?electron=yes");

            // Communicate with Flash
            axShockwaveFlashGame.FlashCall += new _IShockwaveFlashEvents_FlashCallEventHandler(AxShockwaveFlashGame_FlashCall);

            //Set design for the notifications
            popup.BorderColor = Color.Black;
            popup.BodyColor = Color.Black;
            popup.ContentColor = Color.White;
            popup.ContentHoverColor = Color.White;
            popup.ContentPadding = new Padding(0, 15, 0, 20);
            popup.HeaderHeight = 1;
            popup.Image = Properties.Resources.Dofus;
            popup.ImageSize = new Size(45, 70);
            popup.ImagePadding = new Padding(20, 15, 40, 0);
            popup.Click += Popup_Click;
        }

        private void InitSerializableData()
        {
            Stream stream = null;
            try
            {
                stream = File.Open("gameForm.ygg", FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();
                gameFormSerializable = (GameFormSerializable)bformatter.Deserialize(stream);
            }
            catch
            {
                gameFormSerializable = new GameFormSerializable();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            splitContainer.SplitterDistance = gameFormSerializable.SplitterDistance;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            mainFormFocused = true;
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            mainFormFocused = false;
            txtPacketFocused = false;
        }

        private void Popup_Click(object sender, EventArgs e)
        {
            popup.Hide();
        }
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlashGame.CallFunction("<invoke name=\"send\" returntype=\"xml\"><arguments><string> " + "BM*|a|" + "</string></arguments></invoke>");
        }
        */

        private void TxtPacket_Enter(object sender, EventArgs e)
        {
            txtPacketFocused = true;
        }

        private void TxtPacket_Leave(object sender, EventArgs e)
        {
            txtPacketFocused = false;
        }


        private void SplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            gameFormSerializable.SplitterDistance = splitContainer.SplitterDistance;
            gameFormSerializable.Save();
        }

        #endregion


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
                        if (!txtPacketFocused)
                            DebugRequest(args);
                        break;
                    case "setLoginDiscordActivity":
                        break;
                    case "makeNotification":
                        if (!mainFormFocused)
                            MakeNotification((String)args[0]);
                        break;
                    case "changeTitle":
                        Text = "YGGDrafus : " + (String)args[0];
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
            txtPacket.Lines = packets.ToArray();
        }

        private void MakeNotification(String message)
        {
            if (message.Length > 100)
            {
                message = message.Substring(0, 100) + "...";
            }
            popup.ContentText = message;
            popup.Popup();
        }

        #endregion
    }
}
