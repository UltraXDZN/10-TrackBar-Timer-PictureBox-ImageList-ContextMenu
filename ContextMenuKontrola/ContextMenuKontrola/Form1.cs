using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lijevoDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desniBox.Text = lijeviBox.Text;
        }

        private void desnoLijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lijeviBox.Text = desniBox.Text;
        }
    }
}
