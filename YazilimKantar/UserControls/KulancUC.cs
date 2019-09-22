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
    public partial class KulancUC : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;initial Catalog=YazilimKantar;Integrated Security=True");
        KlncDataClss klnc = new KlncDataClss();
        public KulancUC()
        {
            InitializeComponent();
        }
        int pAsagi, pYukari, pTAsagi, pTYukari;
        int px = 0;
        private void KulancUC_Load(object sender, EventArgs e)
        {
            Tilk.Start();
            pAsagi = pbAsagi.Location.Y;
            pYukari = pbYukari.Location.Y;
            TTilk.Start();
            pTAsagi = pbTAsagi.Location.Y;
            pTYukari = pbTYukari.Location.Y;
            pnlAna.Controls.Clear();
            pnlAna.Controls.Add(pnlKullanici);
            pnlKullanici.Location = new Point(0,0);
            this.operatorTableAdapter.Fill(this.yazilimKantarDataSet.Operator);
            this.kullaniciTableAdapter.Fill(this.yazilimKantarDataSet.Kullanici);
            cmbKlnci.Text = string.Empty;
            //cmbOprtr.Text = string.Empty;
        }

        private void Tilk_Tick(object sender, EventArgs e)
        {
            pYukari = pYukari - 5;
            pAsagi = pAsagi + 5;
            pbYukari.Location = new Point(px, pYukari);
            pbAsagi.Location = new Point(px, pAsagi);
            if (pbYukari.Location.Y == 0)
            {
                Tilk.Stop();
                Tson.Start();
            }

        }

        private void Tson_Tick(object sender, EventArgs e)
        {
            pYukari = pYukari + 5;
            pAsagi = pAsagi - 5;
            pbYukari.Location = new Point(px, pYukari);
            pbAsagi.Location = new Point(px, pAsagi);
            if (pbYukari.Location.Y == 190)
            {
                Tson.Stop();
                //Tilk.Start();
            }
        }

        private void TTilk_Tick(object sender, EventArgs e)
        {
            pTYukari = pTYukari - 5;
            pTAsagi = pTAsagi + 3;
            pbTYukari.Location = new Point(px, pTYukari);
            pbTAsagi.Location = new Point(px, pTAsagi);
            if (pbTYukari.Location.Y == 0)
            {
                TTilk.Stop();
                TTson.Start();
            }

        }

        private void TTson_Tick(object sender, EventArgs e)
        {
            pTYukari = pTYukari + 5;
            pTAsagi = pTAsagi - 3;
            pbTYukari.Location = new Point(px, pTYukari);
            pbTAsagi.Location = new Point(px, pTAsagi);
            if (pbTYukari.Location.Y == 200)
            {
                TTson.Stop();
                //TTilk.Start();
            }
        }

        public void satirDegisti() 
        {
            cmbKlnci.Text = dgwKlnci.Rows[dgwKlnci.CurrentRow.Index].Cells[1].Value.ToString();
            txtYSifre.Text = dgwKlnci.Rows[dgwKlnci.CurrentRow.Index].Cells[2].Value.ToString();
        }
        int a;
        private void btnElmnBir_Click(object sender, EventArgs e)
        {
            dgwKlnci.Rows[0].Selected = true;
            a = 0;
            dgwKlnci.FirstDisplayedScrollingRowIndex = a;
            dgwKlnci.CurrentCell = dgwKlnci.Rows[a].Cells[0];
            dgwKlnci.Refresh();
            satirDegisti();
        }
        private void btnOncekiElmn_Click(object sender, EventArgs e)
        {
            if (a > 0)
            {
                a -= 1;
                dgwKlnci.Rows[a].Selected = true;
                dgwKlnci.FirstDisplayedScrollingRowIndex = a;
                dgwKlnci.CurrentCell = dgwKlnci.Rows[a].Cells[0];
                dgwKlnci.Refresh();
                satirDegisti();
            }
            else
            {
                a = dgwKlnci.Rows.Count - 1;
                dgwKlnci.Rows[a].Selected = true;
                dgwKlnci.FirstDisplayedScrollingRowIndex = a;
                dgwKlnci.CurrentCell = dgwKlnci.Rows[a].Cells[0];
                dgwKlnci.Refresh();
                satirDegisti();
            }
        }
        private void btnGunceleme_Click(object sender, EventArgs e)
        {
            if (dgwKlnci.SelectedRows.Count != 0)
            {
                string ID = dgwKlnci.Rows[dgwKlnci.CurrentRow.Index].Cells[0].Value.ToString();
                klnc.SatirGunceleme(ID, cmbKlnci.Text,txtYSifre.Text);
                this.kullaniciTableAdapter.Fill(this.yazilimKantarDataSet.Kullanici);
            }
            else
            {
                MessageBox.Show("Secim Yapınız.");
            }
        }

        private void btnSonrakiElmn_Click(object sender, EventArgs e)
        {
            if (a < dgwKlnci.Rows.Count - 1)
            {
                a += 1;
                dgwKlnci.Rows[a].Selected = true;
                dgwKlnci.FirstDisplayedScrollingRowIndex = a;
                dgwKlnci.CurrentCell = dgwKlnci.Rows[a].Cells[0];
                dgwKlnci.Refresh();
                satirDegisti();
            }
            else
            {
                dgwKlnci.Rows[0].Selected = true;
                a = 0;
                dgwKlnci.FirstDisplayedScrollingRowIndex =a;
                dgwKlnci.CurrentCell = dgwKlnci.Rows[a].Cells[0];
                dgwKlnci.Refresh();
                satirDegisti();
            }
        }
        private void btnElmnSon_Click(object sender, EventArgs e)
        {
            dgwKlnci.Rows[dgwKlnci.Rows.Count - 1].Selected = true;  
            a = dgwKlnci.Rows.Count - 1;
            dgwKlnci.FirstDisplayedScrollingRowIndex = a;
            dgwKlnci.CurrentCell = dgwKlnci.Rows[a].Cells[0];
            dgwKlnci.Refresh();
            satirDegisti();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            pnlAna.Controls.Clear();
            pnlAna.Controls.Add(pnlOperator);
            pnlOperator.Location = new Point(0, 0);
            cmbOprtr.Text = string.Empty;
        }
        int b;
        private void btnSilme_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();
            Secim = MessageBox.Show("Seçili satırı silmek istediğinizden emin misiniz ?", "Mosas-Group | Taralsa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Secim == DialogResult.Yes)
            {
                string ID = dgwOperator.Rows[dgwOperator.CurrentRow.Index].Cells[0].Value.ToString();
                klnc.SatiriSil(ID);
                this.operatorTableAdapter.Fill(this.yazilimKantarDataSet.Operator);
            }
            else
            {
                MessageBox.Show("İşlem yapılmadı", "Mosas-Group | Taralsa");
            }
        }
        private void cmbKlnci_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from Kullanici Where KullncAdi like'%" + cmbKlnci.Text + "%'", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            dataAdapter.Fill(data, "Kullanici");
            dgwOperator.DataSource = data.Tables[0];
            conn.Close();
            txtYSifre.Text = string.Empty;
        }
        private void btnArama_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from Kullanici Where KullncAdi like'%" + cmbOprtr.Text + "%'", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            dataAdapter.Fill(data, "Kullanici");
            dgwOperator.DataSource = data.Tables[0];
            conn.Close();
        }
        private void btnKaydetme_Click(object sender, EventArgs e)
        {
            klnc.YeniSatirEkle(cmbOprtr.Text,txtOSifre.Text);
            this.operatorTableAdapter.Fill(this.yazilimKantarDataSet.Operator);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlAna.Controls.Clear();
            pnlAna.Controls.Add(pnlKullanici);
            pnlOperator.Location = new Point(0, 0);
        }
        public void satirDegistiOprtr()
        {
            cmbOprtr.Text = dgwOperator.Rows[dgwOperator.CurrentRow.Index].Cells[1].Value.ToString();
            txtOSifre.Text = dgwOperator.Rows[dgwOperator.CurrentRow.Index].Cells[2].Value.ToString();
        }
        private void btnElmnBirO_Click(object sender, EventArgs e)
        {
            dgwOperator.Rows[0].Selected = true;
            b = 0;
            dgwOperator.FirstDisplayedScrollingRowIndex = b;
            dgwOperator.CurrentCell = dgwOperator.Rows[b].Cells[0];
            dgwOperator.Refresh();
            satirDegistiOprtr();
        }

        private void cmbOprtr_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOSifre.Text = string.Empty;
        }

        private void btnOncekiElmnO_Click(object sender, EventArgs e)
        {
            if (b > 0)
            {
                b -= 1;
                dgwOperator.Rows[b].Selected = true;
                dgwOperator.FirstDisplayedScrollingRowIndex = b;
                dgwOperator.CurrentCell = dgwOperator.Rows[b].Cells[0];
                dgwOperator.Refresh();
                satirDegistiOprtr();
            }
            else
            {
                b = dgwOperator.Rows.Count - 1;
                dgwOperator.Rows[b].Selected = true;
                dgwOperator.FirstDisplayedScrollingRowIndex = b;
                dgwOperator.CurrentCell = dgwOperator.Rows[b].Cells[0];
                dgwOperator.Refresh();
                satirDegistiOprtr();
            }
        }
        private void btnSonrakiElmnO_Click(object sender, EventArgs e)
        {
            if (b < dgwOperator.Rows.Count - 1)
            {
                b += 1;
                dgwOperator.Rows[b].Selected = true;
                dgwOperator.FirstDisplayedScrollingRowIndex = b;
                dgwOperator.CurrentCell = dgwOperator.Rows[b].Cells[0];
                dgwOperator.Refresh();
                satirDegistiOprtr();
            }
            else
            {
                dgwOperator.Rows[0].Selected = true;
                b = 0;
                dgwOperator.FirstDisplayedScrollingRowIndex = b;
                dgwOperator.CurrentCell = dgwOperator.Rows[b].Cells[0];
                dgwOperator.Refresh();
                satirDegistiOprtr();
            }
        }
        private void btnElmnSonO_Click(object sender, EventArgs e)
        {
            dgwOperator.Rows[dgwOperator.Rows.Count - 1].Selected = true;
            b = dgwOperator.Rows.Count - 1;
            dgwOperator.FirstDisplayedScrollingRowIndex = b;
            dgwOperator.CurrentCell = dgwOperator.Rows[b].Cells[0];
            dgwOperator.Refresh();
            satirDegistiOprtr();
        }
    }
}
