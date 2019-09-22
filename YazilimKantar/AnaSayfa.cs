using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimKantar.UserControls;

namespace YazilimKantar
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void tlSMIAnaSayfa_Click(object sender, EventArgs e)
        {
            //Giris a = new Giris();
            //a.Show();
            //this.Hide();
            panel2.Controls.Clear();
            AnaSayfaUC uuc = new AnaSayfaUC() { Dock = DockStyle.Fill };
            panel2.Controls.Add(uuc);
        }

        private void tlSMITartm_Click(object sender, EventArgs e)
        {
            //Giris a = new Giris();
            //a.Show();
            //this.Hide();
            panel2.Controls.Clear();
            TartımUc uuc1 = new TartımUc() { Dock = DockStyle.Fill };
            panel2.Controls.Add(uuc1);
        }

        private void tlSMIArac_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AracUC uuc2 = new AracUC() { Dock = DockStyle.Fill };
            panel2.Controls.Add(uuc2);
        }

        private void tlSMIRapor_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            RaporUC uuc3 = new RaporUC() { Dock = DockStyle.Fill };
            panel2.Controls.Add(uuc3);
        }

        private void tlMIFs_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FisUC uuc4 = new FisUC() { Dock = DockStyle.Fill };
            panel2.Controls.Add(uuc4);
        }

        private void tlMISabt_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            SabitUC uuc5 = new SabitUC() { Dock = DockStyle.Fill };
            panel2.Controls.Add(uuc5);
        }

        private void tlMIKulanclar_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            KulancUC uuc6 = new KulancUC() { Dock = DockStyle.Fill };
            panel2.Controls.Add(uuc6);
        }

        private void tlSMIEkle_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            EkleUC uuc7 = new EkleUC() { Dock = DockStyle.Fill };
            panel2.Controls.Add(uuc7);
        }

    }
}
