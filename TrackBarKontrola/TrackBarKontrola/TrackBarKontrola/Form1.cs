using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackBarKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vrijednost_Scroll(object sender, EventArgs e)
        {
            postavljenaVrijednostBox.Text = vrijednost.Value.ToString();
        }
    }
}
