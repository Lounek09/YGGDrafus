using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace YGGDrafus
{
    public partial class EncyclopediaForm : Form
    {
        private readonly string itemsPath;
        
        public EncyclopediaForm(string itemsPath)
        {
            InitializeComponent();
            this.itemsPath = itemsPath;
        }

        private void EncyclopediaForm_Load(object sender, EventArgs e)
        {
            Icon = new Icon(Constant.Instance.MAIN_ICO_FILE);

            axShockwaveFlash1.LoadMovie(0, itemsPath + "1/1.swf");

            axShockwaveFlash2.LoadMovie(0, Path.GetFullPath(Constant.Instance.SWF_PATH + "item.swf") + "?item=" + itemsPath + "1/1.swf");
        }


        private void EncyclopediaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)Owner).EncyclopediaToolStripMenuItem.Enabled = true;
        }
    }
}
