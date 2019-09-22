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
    public partial class SabitUC : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;initial Catalog=YazilimKantar;Integrated Security=True");
        SabitDataClss Sabit = new SabitDataClss();
        public void DataGridYenile()
        {
            dgwSabit.DataSource = Sabit.TabloyuGetir();
        }
        public SabitUC()
        {
            InitializeComponent();
            DataGridYenile();
        }
        int i;
        private void btnElmnBir_Click(object sender, EventArgs e)
        {
            dgwSabit.Rows[0].Selected = true;
            i = 0;
            dgwSabit.FirstDisplayedScrollingRowIndex = i;
            dgwSabit.CurrentCell = dgwSabit.Rows[i].Cells[0];
            dgwSabit.Refresh();
        }

        private void btnOncekiElmn_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i -= 1;
                dgwSabit.Rows[i].Selected = true;
                dgwSabit.FirstDisplayedScrollingRowIndex = i;
                dgwSabit.CurrentCell = dgwSabit.Rows[i].Cells[0];
                dgwSabit.Refresh();
            }
            else
            {
                i = dgwSabit.Rows.Count - 1;
                dgwSabit.Rows[i].Selected = true;
                dgwSabit.FirstDisplayedScrollingRowIndex = i;
                dgwSabit.CurrentCell = dgwSabit.Rows[i].Cells[0];
                dgwSabit.Refresh();
            }
        }

        private void btnGunceleme_Click(object sender, EventArgs e)
        {
            DataGridYenile();
        }

        private void btnSonrakiElmn_Click(object sender, EventArgs e)
        {
            if (i < dgwSabit.Rows.Count - 1)
            {
                i += 1;
                dgwSabit.Rows[i].Selected = true;
                dgwSabit.FirstDisplayedScrollingRowIndex =i;
                dgwSabit.CurrentCell = dgwSabit.Rows[i].Cells[0];
                dgwSabit.Refresh();
            }
            else
            {
                dgwSabit.Rows[0].Selected = true;
                i = 0;
                dgwSabit.FirstDisplayedScrollingRowIndex = i;
                dgwSabit.CurrentCell = dgwSabit.Rows[i].Cells[0];
                dgwSabit.Refresh();
            }
        }

        private void btnElmnSon_Click(object sender, EventArgs e)
        {
            dgwSabit.Rows[dgwSabit.Rows.Count - 1].Selected = true;  //Tartim
            i = dgwSabit.Rows.Count - 1;
            dgwSabit.FirstDisplayedScrollingRowIndex = i;
            dgwSabit.CurrentCell = dgwSabit.Rows[i].Cells[0];
            dgwSabit.Refresh();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            if (txtPlkaNo.Text=="")
            {
                MessageBox.Show("Plaka No'yu Giriniz...");
            }
            else
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Select * from Sabit Where PlakaNo like'%" + txtPlkaNo.Text + "%'", conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                dataAdapter.Fill(data, "Sabit");
                dgwSabit.DataSource = data.Tables[0];
                conn.Close();
            }
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();
            Secim = MessageBox.Show("Seçili satırı silmek istediğinizden emin misiniz ?", "Mosas-Group | Taralsa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Secim == DialogResult.Yes)
            {
                string ID = dgwSabit.Rows[dgwSabit.CurrentRow.Index].Cells[0].Value.ToString();
                Sabit.SatiriSil(ID);
                DataGridYenile();
            }
            else
            {
                MessageBox.Show("İşlem yapılmadı", "Mosas-Group | Taralsa");
            }
        }

        private void btnKaydetme_Click(object sender, EventArgs e)
        {
            Sabit.YeniSatirEkle(txtTrtmNo.Text, txtPlkaNo.Text,dtpGiris.Text,dTPCikis.Text,cBxGrs.Text,cBxCks.Text,txtFrmaAd.Text,txtGidnFrmAdi.Text, txtMalzeme.Text,txtOprtr.Text,cBxGldgil.Text,cBxGtdgil.Text,txtNot.Text,txtDara.Text,txtBrt.Text,txtKg.Text);
            DataGridYenile();
        }

        private void cmbPlaka_SelectedIndexChanged(object sender, EventArgs e)
        { txtPlkaNo.Text = cmbPlaka.Text; } //Plaka = ComboBox'tan veriyi textBox'a çekmek.
        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        { txtOprtr.Text = cmbOperator.Text; } //Operatör = ComboBox'tan veriyi textBox'a çekmek.
        private void cmbFirma_SelectedIndexChanged(object sender, EventArgs e)
        { txtFrmaAd.Text = cmbFirma.Text; }  //Firma = ComboBox'tan veriyi textBox'a çekmek.
        private void cmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        { txtMalzeme.Text = cmbMalzeme.Text; }  //Malzeme = ComboBox'tan veriyi textBox'a çekmek.
        private void cmbGFirma_SelectedIndexChanged(object sender, EventArgs e)
        { txtGidnFrmAdi.Text = cmbGFirma.Text; }   //GFirma = ComboBox'tan veriyi textBox'a çekmek.
        private void cmbAciklama_SelectedIndexChanged(object sender, EventArgs e)
        { txtNot.Text = cmbAciklama.Text; }   //Açıklama = ComboBox'tan veriyi textBox'a çekmek.

        private void SabitUC_Load(object sender, EventArgs e)
        {
            //plakaNo
            SqlCommand cmd = new SqlCommand(); cmd.CommandText = "SELECT *FROM KaPlaka";
            cmd.Connection = conn; cmd.CommandType = CommandType.Text;
            SqlDataReader dr; conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read()){cmbPlaka.Items.Add(dr["PlakaNo"]);}
            conn.Close(); //Operator
            cmd.CommandText = "SELECT *FROM KaOperator";
            cmd.Connection = conn; cmd.CommandType = CommandType.Text;
            conn.Open(); dr = cmd.ExecuteReader();
            while (dr.Read()) { cmbOperator.Items.Add(dr["Operator"]); }
            conn.Close(); //FirmAdi
            cmd.CommandText = "SELECT *FROM KaFirma";
            cmd.Connection = conn; cmd.CommandType = CommandType.Text;
            conn.Open(); dr = cmd.ExecuteReader();
            while (dr.Read()) { cmbFirma.Items.Add(dr["Firma"]); }
            conn.Close(); //Malzeme
            cmd.CommandText = "SELECT *FROM KaMalzeme";
            cmd.Connection = conn; cmd.CommandType = CommandType.Text;
            conn.Open(); dr = cmd.ExecuteReader();
            while (dr.Read()) { cmbMalzeme.Items.Add(dr["Malzeme"]); }
            conn.Close(); //GFirma
            cmd.CommandText = "SELECT *FROM KaGFirma";
            cmd.Connection = conn; cmd.CommandType = CommandType.Text;
            conn.Open(); dr = cmd.ExecuteReader();
            while (dr.Read()) { cmbGFirma.Items.Add(dr["GFirma"]); }
            conn.Close(); //Aciklama(Not)
            cmd.CommandText = "SELECT *FROM KaNot";
            cmd.Connection = conn; cmd.CommandType = CommandType.Text;
            conn.Open(); dr = cmd.ExecuteReader();
            while (dr.Read()) { cmbAciklama.Items.Add(dr["Not"]); }
            conn.Close();
        }
    }
}
