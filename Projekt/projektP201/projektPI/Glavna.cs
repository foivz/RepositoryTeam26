using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektPI
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void igračiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unosIgraca noviIgrac = new unosIgraca();
            noviIgrac.ShowDialog();
        }

        private void timoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unosTimova noviTim = new unosTimova();
            noviTim.ShowDialog();
        }

        private void planiranjeTreningaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            planiranje noviTrening = new planiranje();
            noviTrening.ShowDialog();
        }

       

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statistikaIgraca statistika = new statistikaIgraca();
            statistika.ShowDialog();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unosTimova noviTim = new unosTimova();
            noviTim.ShowDialog();
        }

       

        private void planerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void utakmiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utakmica utakmica = new Utakmica();
            utakmica.ShowDialog();
        }
    }
}
