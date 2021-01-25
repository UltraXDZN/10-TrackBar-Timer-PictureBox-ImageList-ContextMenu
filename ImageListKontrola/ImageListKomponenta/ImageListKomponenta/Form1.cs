using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageListKomponenta
{
    public partial class Form1 : Form
    {
        int brojac = 0;
        public Form1()
        {
            InitializeComponent();
            slika.Image = images.Images[brojac];
        }

        private void promijeni_Click(object sender, EventArgs e)
        {
            try
            {
                slika.Image = images.Images[brojac];
                brojac++;
            }
            catch
            {
                brojac = 0;
                slika.Image = images.Images[brojac];
            }
        }
    }
}
