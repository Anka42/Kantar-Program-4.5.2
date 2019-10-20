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
            
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from Brut Where PlakaNo like'%" + cmbPlakaNo.Text + "%'", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            dataAdapter.Fill(data, "Brut");
            dgwBrut.DataSource = data.Tables[0];
            conn.Close();
            pnlDGW.Dock = DockStyle.Fill;
            pnlDVeri.Controls.Clear();
            pnlDVeri.Controls.Add(pnlDGW);
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            if (txtTartimNo.Text == "")
            { MessageBox.Show("Tarım No Giriniz.", "Lütfen");}
            else
            {               
                this.fisUCTableAdapter.Fill(this.yazilimKantarDataSet.FisUC, Convert.ToInt32(txtTartimNo.Text));
                tpDaraData.Controls.Add(RaporClss.GetReport(System.Environment.CurrentDirectory + "\\Raporm\\RprtFisUC.rdlc", "DataSetFisUC", fisUCBindingSource));
                pnlRaporu.Dock = DockStyle.Fill;
                pnlDVeri.Controls.Clear();
                pnlDVeri.Controls.Add(pnlRaporu);
            }
        }

        private void FisUC_Load(object sender, EventArgs e)
        {
            pnlDGW.Dock = DockStyle.Fill;
            pnlDVeri.Controls.Clear();
            pnlDVeri.Controls.Add(pnlDGW);
            this.brutTableAdapter.Fill(this.yazilimKantarDataSet.Brut);
        }
        int b;
        private void btnElmnBir_Click(object sender, EventArgs e)
        {
            dgwBrut.Rows[0].Selected = true;
            b = 0;
            dgwBrut.FirstDisplayedScrollingRowIndex = b;
            dgwBrut.CurrentCell = dgwBrut.Rows[b].Cells[0];
            dgwBrut.Refresh();
        }

        private void btnOncekiElmn_Click(object sender, EventArgs e)
        {
            if (b > 0)
            {
                b -= 1;
                dgwBrut.Rows[b].Selected = true;
                dgwBrut.FirstDisplayedScrollingRowIndex = b;
                dgwBrut.CurrentCell = dgwBrut.Rows[b].Cells[0];
                dgwBrut.Refresh();
            }
            else
            {
                b = dgwBrut.Rows.Count - 1;
                dgwBrut.Rows[b].Selected = true;
                dgwBrut.FirstDisplayedScrollingRowIndex = b;
                dgwBrut.CurrentCell = dgwBrut.Rows[b].Cells[0];
                dgwBrut.Refresh();
            }
        }

        private void btnGunceleme_Click(object sender, EventArgs e)
        {
            DataGridYenile();
            this.brutTableAdapter.Fill(this.yazilimKantarDataSet.Brut);
        }

        private void btnSonrakiElmn_Click(object sender, EventArgs e)
        {
            if (b < dgwBrut.Rows.Count - 1)
            {
                b += 1;
                dgwBrut.Rows[b].Selected = true;
                dgwBrut.FirstDisplayedScrollingRowIndex = b;
                dgwBrut.CurrentCell = dgwBrut.Rows[b].Cells[0];
                dgwBrut.Refresh();
            }
            else
            {
                dgwBrut.Rows[0].Selected = true;
                b = 0;
                dgwBrut.FirstDisplayedScrollingRowIndex = b;
                dgwBrut.CurrentCell = dgwBrut.Rows[b].Cells[0];
                dgwBrut.Refresh();
            }
        }

        private void btnElmnSon_Click(object sender, EventArgs e)
        {
            dgwBrut.Rows[dgwBrut.Rows.Count - 1].Selected = true;
            b = dgwBrut.Rows.Count - 1;
            dgwBrut.FirstDisplayedScrollingRowIndex = b;
            dgwBrut.CurrentCell = dgwBrut.Rows[b].Cells[0];
            dgwBrut.Refresh();
        }
    }
}
