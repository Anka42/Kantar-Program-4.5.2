using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimKantar.Classs;

namespace YazilimKantar.UserControls
{
    public partial class FisUC : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;initial Catalog=YazilimKantar;Integrated Security=True");
        BrutDataClss Brut = new BrutDataClss();
        public void DataGridYenile()
        {
            dgwBrut.DataSource = Brut.TabloyuGetir();
        }
        public FisUC()
        {
            InitializeComponent();
            DataGridYenile();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            pnlDGW.Dock = DockStyle.Fill;
            pnlDVeri.Controls.Clear();
            pnlDVeri.Controls.Add(pnlDGW);
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            this.fisUCTableAdapter.Fill(this.yazilimKantarDataSet.FisUC, comboBox1.Text);
            pnlRaporu.Dock = DockStyle.Fill;
            pnlDVeri.Controls.Clear();
            pnlDVeri.Controls.Add(pnlRaporu);
        }

        private void FisUC_Load(object sender, EventArgs e)
        {
            pnlDGW.Dock = DockStyle.Fill;
            pnlDVeri.Controls.Clear();
            pnlDVeri.Controls.Add(pnlDGW);
            this.brutTableAdapter.Fill(this.yazilimKantarDataSet.Brut);
            this.fisUCTableAdapter.Fill(this.yazilimKantarDataSet.FisUC , comboBox1.Text);
            tpDaraData.Controls.Add(RaporClss.GetReport(System.Environment.CurrentDirectory + "\\Raporm\\RprtFisUC.rdlc", "DataSetFisUC", fisUCBindingSource));
        }

    }
}
