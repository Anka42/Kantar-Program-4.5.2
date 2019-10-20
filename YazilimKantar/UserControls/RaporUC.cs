using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimKantar.Classs;

namespace YazilimKantar.UserControls
{
    public partial class RaporUC : UserControl
    {
        public RaporUC()
        {
            InitializeComponent();
        }

        private void RaporUC_Load(object sender, EventArgs e)
        {
            pnlSag.Dock = DockStyle.Fill;
            pnlAna.Dock = DockStyle.Fill;
            pnlGnlk.Dock = DockStyle.Fill;
        }

        private void btnGunluk_Click(object sender, EventArgs e)
        {
            pnlGetir.Controls.Clear();
            pnlGnlk.Dock = DockStyle.Fill;
            pnlGetir.Controls.Add(pnlGnlk);
        }

        private void btnAylık_Click(object sender, EventArgs e)
        {
            pnlGetir.Controls.Clear();
            pnlAylik.Dock = DockStyle.Fill;
            pnlGetir.Controls.Add(pnlAylik);
        }

        private void btnOzel_Click(object sender, EventArgs e)
        {
            pnlGetir.Controls.Clear();
            pnlOzel.Dock = DockStyle.Fill;
            pnlGetir.Controls.Add(pnlOzel);
        }

        private void rBtnOAylik_CheckedChanged(object sender, EventArgs e)
        {
            dtpOBasTarih.CustomFormat = "MMMM / yyyy ";
            dtpOBitTarih.CustomFormat = "MMMM / yyyy ";
        }

        private void rBtnOGunluk_CheckedChanged(object sender, EventArgs e)
        {
            dtpOBasTarih.CustomFormat = " yyyy/MM/dd ";
            dtpOBitTarih.CustomFormat = " yyyy/MM/dd ";
        }

        private void btnGRapor_Click(object sender, EventArgs e)
        {
            if (rbtnGVardiye1.Checked==true)//Vardiye1
            {
                this.gunlukRaporTableAdapter.Fill(this.yazilimKantarDataSet.GunlukRapor, Convert.ToDateTime(dtpGZaman.Text), 06, 14);
                tpDaraData.Controls.Add(RaporClss.GetReport(System.Environment.CurrentDirectory + "\\Raporm\\RprtGunluk.rdlc", "dsGunlukRpr", bSourceGunluk));
            }
            else if (rbtnGVardiye2.Checked == true)//Vardiye2
            {
                this.gunlukRaporTableAdapter.Fill(this.yazilimKantarDataSet.GunlukRapor, Convert.ToDateTime(dtpGZaman.Text), 15, 22);
                tpDaraData.Controls.Add(RaporClss.GetReport(System.Environment.CurrentDirectory + "\\Raporm\\RprtGunluk.rdlc", "dsGunlukRpr", bSourceGunluk));
            }
            else if (rbtnGVardiye3.Checked == true)//Vardiye3
            {
                this.gunlukRaporTableAdapter.Fill(this.yazilimKantarDataSet.GunlukRapor, Convert.ToDateTime(dtpGZaman.Text), 23, 05);
                tpDaraData.Controls.Add(RaporClss.GetReport(System.Environment.CurrentDirectory + "\\Raporm\\RprtGunluk.rdlc", "dsGunlukRpr", bSourceGunluk));
            }
            else if (rbtnGVardiyeTüm.Checked==true)//Vardiye Tüm Gün
            {
                this.gunlukRaporTableAdapter.Fill(this.yazilimKantarDataSet.GunlukRapor, Convert.ToDateTime(dtpGZaman.Text), 00, 24);
                tpDaraData.Controls.Add(RaporClss.GetReport(System.Environment.CurrentDirectory + "\\Raporm\\RprtGunluk.rdlc", "dsGunlukRpr", bSourceGunluk));
            }
        }

        private void btnARapor_Click(object sender, EventArgs e)
        {
            this.aylikRaporTableAdapter.Fill(this.yazilimKantarDataSet.AylikRapor, Convert.ToDateTime(dtpABasTarih.Text), Convert.ToDateTime(dtpABitTarih.Text));
            tpDaraData.Controls.Add(RaporClss.GetReport(System.Environment.CurrentDirectory + "\\Raporm\\RprtAylik.rdlc", "dsAylikRpr", bSourceAylik));
        }

        private void btnOzelRpr_Click(object sender, EventArgs e)
        {
            if (rBtnOGunluk.Checked==true)
            {
                this.ozelGRaporTableAdapter.Fill(this.yazilimKantarDataSet.OzelGRapor, cmbOPlaka.Text, Convert.ToInt32(cmbOBas.Text), Convert.ToInt32(cmbOBit.Text));
                tpDaraData.Controls.Add(RaporClss.GetReport(System.Environment.CurrentDirectory + "\\Raporm\\RprtOzelG.rdlc", "dsOzelGRpr", bSourceOzelG));
            }
            else if (rBtnOAylik.Checked==true)
            {
                this.ozelARaporTableAdapter.Fill(this.yazilimKantarDataSet.OzelARapor, cmbOPlaka.Text, Convert.ToDateTime(dtpOBasTarih.Text), Convert.ToDateTime(dtpOBitTarih.Text));
                tpDaraData.Controls.Add(RaporClss.GetReport(System.Environment.CurrentDirectory + "\\Raporm\\RprtOzelA.rdlc", "dsOzelA", bSourceOzelA));
            }
        }
    }
}
