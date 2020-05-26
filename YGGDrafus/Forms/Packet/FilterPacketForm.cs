using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGGDrafus.Packet
{
    public partial class FilterPacketForm : Form
    {
        public FilterPacketForm()
        {
            InitializeComponent();
        }

        private void FilterPacketForm_Load(object sender, EventArgs e)
        {
            Icon = new Icon(Constant.Instance.OPTION_ICO_FILE);

            includeTextBox.Lines = ((PacketForm)Owner).FilterInclude.ToArray();
            notIncludeTextBox.Lines = ((PacketForm)Owner).FilterNotInclude.ToArray();
        }

        private void FilterPacketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((PacketForm)Owner).FilterToolStripMenuItem.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ((PacketForm)Owner).FilterInclude = includeTextBox.Lines.ToList<string>();
            ((PacketForm)Owner).FilterNotInclude = notIncludeTextBox.Lines.ToList<string>();
            Close();
        }
    }
}
