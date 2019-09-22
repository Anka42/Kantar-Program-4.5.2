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
    public partial class TartımUc : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;initial Catalog=YazilimKantar;Integrated Security=True");
        TartimDataClss Tartim = new TartimDataClss();
        SabitDataClss Sabit = new SabitDataClss();
        BrutDataClss Brut = new BrutDataClss();
        public void DataGridYenile()
        {
            dgwSabit.DataSource = Sabit.TabloyuGetir();
            dgwTartim.DataSource = Tartim.TabloyuGetir();
        }
        public TartımUc()
        {
            InitializeComponent();
            DataGridYenile();
        }

        private void TartımUc_Load(object sender, EventArgs e)
        {
            this.cYAracTableAdapter.Fill(this.yazilimKantarDataSet.CYArac);
            //plakaNo
            SqlCommand cmd = new SqlCommand(); cmd.CommandText = "SELECT *FROM KaPlaka";
            cmd.Connection = conn;    cmd.CommandType = CommandType.Text;
            SqlDataReader dr; conn.Open();
            dr = cmd.ExecuteReader();
            //while (dr.Read()){cmbPlaka.Items.Add(dr["PlakaNo"]);}
            conn.Close(); //Operator
            cmd.CommandText = "SELECT *FROM KaOperator";
            cmd.Connection = conn;    cmd.CommandType = CommandType.Text;
            conn.Open();    dr = cmd.ExecuteReader();
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
        private void btnTrKydt_Click(object sender, EventArgs e)
        {   
            if (String.IsNullOrEmpty(txtDara.Text))
            {
                MessageBox.Show("!!!..Dara Boş Bırakılamaz..!!!");
            }
            else
            {
                Tartim.YeniSatirEkle(txtTrtmNo.Text, txtPlkaNo.Text, dtpGiris.Text, dTPCikis.Text, cBxGrs.Text, cBxCks.Text, txtFrmaAd.Text, txtGidnFrmAdi.Text, txtMalzeme.Text, txtOprtr.Text, cBxGldgil.Text, cBxGtdgil.Text, txtNot.Text, txtDara.Text, txtBrt.Text, txtKg.Text);
                DataGridYenile();
            }
        }

        private void rBtnTartim_CheckedChanged(object sender, EventArgs e)
        {
            pnlDVeri.Controls.Clear();
            pnlDVeri.Controls.Add(dgwTartim);
        }

        private void rBtnSabit_CheckedChanged(object sender, EventArgs e)
        {
            pnlDVeri.Controls.Clear();
            pnlDVeri.Controls.Add(dgwSabit);
        }

        public void satirDegisti()  //Tartim
        {
            txtTrtmNo.Text = dgwTartim.Rows[dgwTartim.CurrentRow.Index].Cells[1].Value.ToString();
            txtPlkaNo.Text = dgwTartim.Rows[dgwTartim.CurrentRow.Index].Cells[2].Value.ToString();
            dtpGiris.Text=dgwTartim.Rows[dgwTartim.CurrentRow.Index].Cells[3].Value.ToString(); 
            cBxGrs.Text = dgwTartim.Rows[dgwTartim.CurrentRow.Index].Cells[4].Value.ToString();
            txtFrmaAd.Text = dgwTartim.Rows[dgwTartim.CurrentRow.Index].Cells[5].Value.ToString();
            txtMalzeme.Text = dgwTartim.Rows[dgwTartim.CurrentRow.Index].Cells[6].Value.ToString();
            txtOprtr.Text = dgwTartim.Rows[dgwTartim.CurrentRow.Index].Cells[7].Value.ToString();
            cBxGldgil.Text = dgwTartim.Rows[dgwTartim.CurrentRow.Index].Cells[8].Value.ToString();
            txtNot.Text = dgwTartim.Rows[dgwTartim.CurrentRow.Index].Cells[9].Value.ToString();
            txtDara.Text = dgwTartim.Rows[dgwTartim.CurrentRow.Index].Cells[10].Value.ToString();
        }
        public void satirDegistir()  //Sabit
        {
            txtTrtmNo.Text = dgwSabit.Rows[dgwSabit.CurrentRow.Index].Cells[1].Value.ToString();
            txtPlkaNo.Text = dgwSabit.Rows[dgwSabit.CurrentRow.Index].Cells[2].Value.ToString();
            dtpGiris.Text = dgwSabit.Rows[dgwSabit.CurrentRow.Index].Cells[3].Value.ToString();
            cBxGrs.Text = dgwSabit.Rows[dgwSabit.CurrentRow.Index].Cells[4].Value.ToString();
            txtFrmaAd.Text = dgwSabit.Rows[dgwSabit.CurrentRow.Index].Cells[5].Value.ToString();
            txtMalzeme.Text = dgwSabit.Rows[dgwSabit.CurrentRow.Index].Cells[6].Value.ToString();
            txtOprtr.Text = dgwSabit.Rows[dgwSabit.CurrentRow.Index].Cells[7].Value.ToString();
            cBxGldgil.Text = dgwSabit.Rows[dgwSabit.CurrentRow.Index].Cells[8].Value.ToString();
            txtNot.Text = dgwSabit.Rows[dgwSabit.CurrentRow.Index].Cells[9].Value.ToString();
            txtDara.Text = dgwSabit.Rows[dgwSabit.CurrentRow.Index].Cells[10].Value.ToString();
        }
        int i,j;
        private void btnElmnBir_Click(object sender, EventArgs e)
        {
            cmbPlaka.Text = string.Empty; cmbOperator.Text = string.Empty; cmbFirma.Text = string.Empty;    //ComboBox'taki Text'ti Temizleme.
            cmbMalzeme.Text = string.Empty; cmbGFirma.Text = string.Empty; cmbAciklama.Text = string.Empty; //ComboBox'taki Text'ti Temizleme.
            if (rBtnTartim.Checked==true) //Tartim
            {
                dgwTartim.Rows[0].Selected = true; 
                i = 0;
                dgwTartim.FirstDisplayedScrollingRowIndex = i;
                dgwTartim.CurrentCell = dgwTartim.Rows[i].Cells[0];
                dgwTartim.Refresh();
                satirDegisti();
            }
            else if (rBtnSabit.Checked == true) //Sabit
            {
                dgwSabit.Rows[0].Selected = true; 
                j = 0;
                dgwSabit.FirstDisplayedScrollingRowIndex = j;
                dgwSabit.CurrentCell = dgwSabit.Rows[j].Cells[0];
                dgwSabit.Refresh();
                satirDegistir();
            }
        }

        private void btnOncekiElmn_Click(object sender, EventArgs e)
        {
            cmbPlaka.Text = string.Empty; cmbOperator.Text = string.Empty; cmbFirma.Text = string.Empty;    //ComboBox'taki Text'ti Temizleme.
            cmbMalzeme.Text = string.Empty; cmbGFirma.Text = string.Empty; cmbAciklama.Text = string.Empty; //ComboBox'taki Text'ti Temizleme.
            if (rBtnTartim.Checked == true) //Tartim
            {
                if (i > 0)  
                {
                    i -= 1;
                    dgwTartim.Rows[i].Selected = true;
                    dgwTartim.FirstDisplayedScrollingRowIndex = i;
                    dgwTartim.CurrentCell = dgwTartim.Rows[i].Cells[0];
                    dgwTartim.Refresh();
                    satirDegisti();
                }
                else
                {
                    i = dgwTartim.Rows.Count - 1;
                    dgwTartim.Rows[i].Selected = true;
                    dgwTartim.FirstDisplayedScrollingRowIndex = i;
                    dgwTartim.CurrentCell = dgwTartim.Rows[i].Cells[0];
                    dgwTartim.Refresh();
                    satirDegisti();
                }
            }
            else if (rBtnSabit.Checked == true) //Sabit
            {
                if (j > 0)  
                {
                    j -= 1;
                    dgwSabit.Rows[j].Selected = true;
                    dgwSabit.FirstDisplayedScrollingRowIndex = j;
                    dgwSabit.CurrentCell = dgwSabit.Rows[j].Cells[0];
                    dgwSabit.Refresh();
                    satirDegistir();
                }
                else
                {
                    j = dgwSabit.Rows.Count - 1;
                    dgwSabit.Rows[j].Selected = true;
                    dgwSabit.FirstDisplayedScrollingRowIndex = j;
                    dgwSabit.CurrentCell = dgwSabit.Rows[j].Cells[0];
                    dgwSabit.Refresh();
                    satirDegistir();
                }
            }
        }

        private void btnGunceleme_Click(object sender, EventArgs e)
        {
            DataGridYenile();
            cmbPlaka.Text = string.Empty; cmbOperator.Text = string.Empty; cmbFirma.Text = string.Empty;    //ComboBox'taki Text'ti Temizleme.
            cmbMalzeme.Text = string.Empty; cmbGFirma.Text = string.Empty; cmbAciklama.Text = string.Empty; //ComboBox'taki Text'ti Temizleme.
        }

        private void btnSonrakiElmn_Click(object sender, EventArgs e)
        {
            cmbPlaka.Text = string.Empty; cmbOperator.Text = string.Empty; cmbFirma.Text = string.Empty;    //ComboBox'taki Text'ti Temizleme.
            cmbMalzeme.Text = string.Empty; cmbGFirma.Text = string.Empty; cmbAciklama.Text = string.Empty; //ComboBox'taki Text'ti Temizleme.
            if (rBtnTartim.Checked == true) //Tartim
            {
                if (i < dgwTartim.Rows.Count - 1) 
                {
                    i += 1;
                    dgwTartim.Rows[i].Selected = true;
                    dgwTartim.FirstDisplayedScrollingRowIndex = i;
                    dgwTartim.CurrentCell = dgwTartim.Rows[i].Cells[0];
                    dgwTartim.Refresh();
                    satirDegisti();
                }
                else
                {
                    dgwTartim.Rows[0].Selected = true;
                    i = 0;
                    dgwTartim.FirstDisplayedScrollingRowIndex = i;
                    dgwTartim.CurrentCell = dgwTartim.Rows[i].Cells[0];
                    dgwTartim.Refresh();
                    satirDegisti();
                }
            }
            else if (rBtnSabit.Checked == true) //Sabit
            {
                if (j < dgwSabit.Rows.Count - 1)  
                {
                    j += 1;
                    dgwSabit.Rows[j].Selected = true;
                    dgwSabit.FirstDisplayedScrollingRowIndex = j;
                    dgwSabit.CurrentCell = dgwSabit.Rows[j].Cells[0];
                    dgwSabit.Refresh();
                    satirDegistir();
                }
                else
                {
                    dgwSabit.Rows[0].Selected = true;
                    j = 0;
                    dgwSabit.FirstDisplayedScrollingRowIndex = j;
                    dgwSabit.CurrentCell = dgwSabit.Rows[j].Cells[0];
                    dgwSabit.Refresh();
                    satirDegistir();
                }
            }
        }

        private void btnElmnSon_Click(object sender, EventArgs e)
        {
            cmbPlaka.Text = string.Empty; cmbOperator.Text = string.Empty; cmbFirma.Text = string.Empty;    //ComboBox'taki Text'ti Temizleme.
            cmbMalzeme.Text = string.Empty; cmbGFirma.Text = string.Empty; cmbAciklama.Text = string.Empty; //ComboBox'taki Text'ti Temizleme.
            if (rBtnTartim.Checked == true)
            {
                dgwTartim.Rows[dgwTartim.Rows.Count - 1].Selected = true;  //Tartim
                i = dgwTartim.Rows.Count - 1;
                dgwTartim.FirstDisplayedScrollingRowIndex = i;
                dgwTartim.CurrentCell = dgwTartim.Rows[i].Cells[0];
                dgwTartim.Refresh();
                satirDegisti();
            }
            else if(rBtnSabit.Checked==true)
            {
                dgwSabit.Rows[dgwSabit.Rows.Count - 1].Selected = true;  //Sabit
                j = dgwSabit.Rows.Count - 1;
                dgwSabit.FirstDisplayedScrollingRowIndex =j;
                dgwSabit.CurrentCell = dgwSabit.Rows[j].Cells[0];
                dgwSabit.Refresh();
                satirDegistir();
            }
        }

        private void cmbPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {   txtPlkaNo.Text = cmbPlaka.Text;    } //Plaka = ComboBox'tan veriyi textBox'a çekmek.
        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {  txtOprtr.Text = cmbOperator.Text; } //Operatör = ComboBox'tan veriyi textBox'a çekmek.
        private void cmbFirma_SelectedIndexChanged(object sender, EventArgs e)
        { txtFrmaAd.Text = cmbFirma.Text; }  //Firma = ComboBox'tan veriyi textBox'a çekmek.
        private void cmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        { txtMalzeme.Text = cmbMalzeme.Text; }  //Malzeme = ComboBox'tan veriyi textBox'a çekmek.
        private void cmbGFirma_SelectedIndexChanged(object sender, EventArgs e)
        { txtGidnFrmAdi.Text = cmbGFirma.Text; }   //GFirma = ComboBox'tan veriyi textBox'a çekmek.
        private void cmbAciklama_SelectedIndexChanged(object sender, EventArgs e)
        {  txtNot.Text = cmbAciklama.Text; }   //Açıklama = ComboBox'tan veriyi textBox'a çekmek.
        int dara, brüt, kg;

        private void txtPlkaNo_TextChanged(object sender, EventArgs e)
        {
            if (rBtnTartim.Checked == true)
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Select * from Tartim  Where PlakaNo like'%" + txtPlkaNo.Text + "%'", conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                dataAdapter.Fill(data, "Tartim");
                dgwTartim.DataSource = data.Tables[0];
                conn.Close();
                //satirDegisti();
            }
            else if (rBtnSabit.Checked == true)
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Select * from Sabit Where PlakaNo like'%" + txtPlkaNo.Text + "%'", conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                dataAdapter.Fill(data, "Sabit");
                dgwSabit.DataSource = data.Tables[0];
                conn.Close();
                //satirDegistir();
            }
        }

        private void btnBrut_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBrt.Text))
            {
                MessageBox.Show("!!!..Brüt Boş Bırakılamaz..!!!");
            }
            else
            {
                string ID = dgwTartim.Rows[dgwTartim.CurrentRow.Index].Cells[0].Value.ToString();
                Tartim.SatiriSil(ID);
                dara = Convert.ToInt32(txtDara.Text);
                brüt = Convert.ToInt32(txtBrt.Text);
                if (dara > brüt)
                {
                    kg = dara - brüt;
                    txtKg.Text = " " + kg;
                }
                else { kg = brüt - dara; txtKg.Text = " " + kg; }
                Brut.YeniSatirEkle(txtTrtmNo.Text, txtPlkaNo.Text, dtpGiris.Text, dTPCikis.Text, cBxGrs.Text, cBxCks.Text, txtFrmaAd.Text, txtGidnFrmAdi.Text, txtMalzeme.Text, txtOprtr.Text, cBxGldgil.Text, cBxGtdgil.Text, txtNot.Text, txtDara.Text, txtBrt.Text, txtKg.Text);
                DataGridYenile();
            }
        }
    }
}
