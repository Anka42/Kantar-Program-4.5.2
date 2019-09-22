using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimKantar
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            AnaSayfa gcsAnaSayfa = new AnaSayfa();
            gcsAnaSayfa.Show();
            panel1.Width = 0;
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (panel1.Width == 0)
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width = panel1.Width-2;
        }
    }
}
