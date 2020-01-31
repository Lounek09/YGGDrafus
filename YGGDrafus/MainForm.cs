using AxShockwaveFlashObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Tulpep.NotificationWindow;


namespace YGGDrafus
{
    public partial class MainForm : Form
    {
        private List<String> packets;
        private bool txtPacketFocused;
        private bool mainFormFocused;
        private PopupNotifier popup;

        public MainForm()
        {
            InitializeComponent();
            packets = new List<string>();
            popup = new PopupNotifier();
        }

        #region Form Event
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Launch the game
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = System.IO.Path.GetDirectoryName(path);
            axShockwaveFlashGame.LoadMovie(0, directory + "\\preloader.swf?electron=yes");
            //axShockwaveFlashGame.LoadMovie(0, "C:\\Users\\samuh\\Desktop\\Dofus\\Dofus 1\\Client\\Dofus Perso Modde\\Custom 1.30.17\\resources\\app\\retroclient\\preloader.swf?electron=yes");

            // Communicate with Flash
            axShockwaveFlashGame.FlashCall += new _IShockwaveFlashEvents_FlashCallEventHandler(axShockwaveFlashGame_FlashCall);

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
            popup.Click += popup_Click;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            mainFormFocused = true;
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            mainFormFocused = false;
        }

        private void popup_Click(object sender, EventArgs e)
        {
            popup.Hide();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlashGame.CallFunction("<invoke name=\"send\" returntype=\"xml\"><arguments><string> " + "BM*|a|" + "</string></arguments></invoke>");
        }
        */

        private void txtPacket_Enter(object sender, EventArgs e)
        {
            txtPacketFocused = true;
        }

        private void txtPacket_Leave(object sender, EventArgs e)
        {
            txtPacketFocused = false;
        }

        #endregion


        #region Flash Communication

        void axShockwaveFlashGame_FlashCall(object sender, _IShockwaveFlashEvents_FlashCallEvent e)
        {
            XmlDocument document = new XmlDocument();
            document.LoadXml(e.request);

            String nameFunction = document.DocumentElement.GetAttribute("name");
            document.ToString();
            //Set all arg into an ArrayList
            ArrayList args = new ArrayList();
            foreach(XmlNode arg in document.GetElementsByTagName("arguments")[0].ChildNodes)
            {
                if (arg.Name.Equals("false") || arg.Name.Equals("true"))
                    args.Add(Boolean.Parse(arg.Name));
                else
                    args.Add(arg.InnerText);
            }

            switch (nameFunction)
            {
                case "userLog":
                    break;
                case "debugRequest":
                    if(!txtPacketFocused)
                        debugRequest(args);
                    break;
                case "setLoginDiscordActivity":
                    break;
                case "makeNotification":
                    if(!mainFormFocused)
                        makeNotification((String)args[0]);
                    break;
                case "changeTitle":
                    Text = "YGGDrafus : " + (String)args[0];
                    break;
            }
        }
        
        private void debugRequest(ArrayList args)
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

        private void makeNotification(String message)
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
