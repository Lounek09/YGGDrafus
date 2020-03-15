using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace YGGDrafus
{
    public partial class PacketForm : Form
    {
        private readonly List<string> packets;
        private List<string> filterInclude;
        private List<string> filterNotInclude;

        public List<string> FilterInclude { get => filterInclude; set => filterInclude = value; }
        public List<string> FilterNotInclude { get => filterNotInclude; set => filterNotInclude = value; }


        public PacketForm()
        {
            InitializeComponent();
            packets = new List<string>();
            filterInclude = new List<string>();
            filterNotInclude = new List<string>();
        }

        private void PacketForm_Load(object sender, EventArgs e)
        {
            Icon = new Icon(Constant.MAIN_ICO_FILE);
        }

        private void PacketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainForm)Owner).PacketToolStripMenuItem.Enabled = true;
        }

        public void AddNewPacket(String packet)
        {
            if (!packetTextBox.Focused && ShowPacket(packet))
            {
                String timestamp = "[" + DateTime.Now.ToString("HH:mm:ss:ffff") + "]";

                packets.Insert(0,timestamp + " " + packet);

                if (packets.Count > 200)
                    packets.RemoveAt(200);

                packetTextBox.Lines = packets.ToArray();
            }
        }

        #region MenuStrip
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            packetTextBox.Clear();
            packets.Clear();
        }

        private void FilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Packet.FilterPacketForm filterPacketform = new Packet.FilterPacketForm { Owner = this };
            filterPacketform.Show();

            filterToolStripMenuItem.Enabled = false;
        }

        #endregion

        private bool ShowPacket(String packet)
        {
            bool show = true;

            foreach (String filter in filterInclude)
            {
                if (!packet.Contains(filter))
                {
                    show = false;
                    break;
                }
            }

            if(show)
            {
                foreach (String filter in filterNotInclude)
                {
                    if (packet.Contains(filter))
                    {
                        show = false;
                        break;
                    }
                }
            }

            return show;
        }
    }
}
