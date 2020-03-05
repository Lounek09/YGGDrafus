using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace YGGDrafus
{
    public partial class PacketForm : Form
    {
        private readonly List<string> packets;

        public PacketForm()
        {
            InitializeComponent();
            packets = new List<string>();
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
            if (!packetTextBox.Focused)
            {
                packets.Insert(0, packet);

                if (packets.Count > 200)
                    packets.RemoveAt(200);

                packetTextBox.Lines = packets.ToArray();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            packetTextBox.Clear();
            packets.Clear();
        }
    }
}
