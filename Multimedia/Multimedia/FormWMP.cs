using AxWMPLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Multimedia
{
    public partial class FormWMP : Form
    {
        string url = "";
        public FormWMP()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                Player.URL = open.FileName;
                playToolStripMenuItem.Enabled = true;
                stopToolStripMenuItem.Enabled = true;
                PreviusToolStripMenuItem.Enabled = true;
                advanceToolStripMenuItem.Enabled = true;
                removeToolStripMenuItem.Enabled = true;
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void delayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.previous();
        }

        private void advanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.next();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
