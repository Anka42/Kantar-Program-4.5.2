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
    public partial class EkleUC : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;initial Catalog=YazilimKantar;Integrated Security=True");
        EkleDataClss Ekle = new EkleDataClss();
        public void DataGridYenile()
        {
            dgwFirma.DataSource = Ekle.TabloyuGetir();/*KaFirma Tablosunu getirir.*/ dgwGFirma.DataSource = Ekle.TabloyuGetirGFirma();/*KaGFirma Tablosunu getirir.*/
            dgwMalzeme.DataSource = Ekle.TabloyuGetirMalzeme();/*KaMalzeme Tablosunu getirir.*/ dgwNot.DataSource = Ekle.TabloyuGetirNot();/*KaNot Tablosunu getirir.*/
        }
        public EkleUC()
        {
            InitializeComponent();
            DataGridYenile();
        }

        int pAsagi , pYukari, pTAsagi, pTYukari;
        int px = 0;
        private void EkleUC_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Height = 0;
            Tilk.Start();
            pAsagi = pbAsagi.Location.Y;
            pYukari = pbYukari.Location.Y;
            TTilk.Start();
            pTAsagi = pbTAsagi.Location.Y;
            pTYukari = pbTYukari.Location.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Height = panel1.Height + 5;
            if (panel1.Height == 360)
            {
                timer1.Stop();
            }
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

        private void cmbxSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Height = 0;
            lblSGösterge.Text = cmbxSecim.Text;
            if (cmbxSecim.SelectedIndex == 0)
            {
                txtVeri.Text = String.Empty;
                panel1.Controls.Clear();
                panel1.Controls.Add(dgwFirma);
                timer1.Start();
            }
            else if (cmbxSecim.SelectedIndex == 1)
            {
                txtVeri.Text = String.Empty;
                panel1.Controls.Clear();
                panel1.Controls.Add(dgwGFirma);
                timer1.Start();
            }
            else if (cmbxSecim.SelectedIndex == 2)
            {
                txtVeri.Text = String.Empty;
                panel1.Controls.Clear();
                panel1.Controls.Add(dgwMalzeme);
                timer1.Start();
            }
            else if (cmbxSecim.SelectedIndex == 3)
            {
                txtVeri.Text = String.Empty;
                panel1.Controls.Clear();
                panel1.Controls.Add(dgwNot);
                timer1.Start();
            }
        }

        private void btnGunceleme_Click(object sender, EventArgs e)
        {
            if (cmbxSecim.SelectedIndex==0)//KaFirma Tablodaki Veri Günceleme
            {
                if (dgwFirma.SelectedRows.Count != 0)
                {
                    string ID = dgwFirma.Rows[dgwFirma.CurrentRow.Index].Cells[0].Value.ToString();
                    Ekle.SatirGunceleme(ID, txtVeri.Text);
                    DataGridYenile();
                }
                else
                {
                    MessageBox.Show("Secim Yapınız.");
                }
            }
            else if (cmbxSecim.SelectedIndex == 1)//KaGFirma Tablodaki Veri Günceleme
            {
                if (dgwGFirma.SelectedRows.Count != 0)
                {
                    string ID = dgwGFirma.Rows[dgwGFirma.CurrentRow.Index].Cells[0].Value.ToString();
                    Ekle.SatirGuncelemeGFirma(ID, txtVeri.Text);
                    DataGridYenile();
                }
                else
                {
                    MessageBox.Show("Secim Yapınız.");
                }
            }
            else if (cmbxSecim.SelectedIndex == 2)//KaMalzeme Tablodaki Veri Günceleme
            {
                if (dgwMalzeme.SelectedRows.Count != 0)
                {
                    string ID = dgwMalzeme.Rows[dgwMalzeme.CurrentRow.Index].Cells[0].Value.ToString();
                    Ekle.SatirGuncelemeMalzeme(ID, txtVeri.Text);
                    DataGridYenile();
                }
                else
                {
                    MessageBox.Show("Secim Yapınız.");
                }
            }
            else if (cmbxSecim.SelectedIndex == 3)//KaNot Tablodaki Veri Günceleme
            {
                if (dgwNot.SelectedRows.Count != 0)
                {
                    string ID = dgwNot.Rows[dgwNot.CurrentRow.Index].Cells[0].Value.ToString();
                    Ekle.SatirGuncelemeNot(ID, txtVeri.Text);
                    DataGridYenile();
                }
                else
                {
                    MessageBox.Show("Secim Yapınız.");
                }
            }
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            if (cmbxSecim.SelectedIndex==0)
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Select * from KaFirma Where Firma like'%" + txtVeri.Text + "%'", conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                dataAdapter.Fill(data, "KaFirma");
                dgwFirma.DataSource = data.Tables[0];
                conn.Close();
            }
            else if (cmbxSecim.SelectedIndex == 1)
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Select * from KaGFirma  Where GFirma like'%" + txtVeri.Text + "%'", conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                dataAdapter.Fill(data, "KaGFirma");
                dgwGFirma.DataSource = data.Tables[0];
                conn.Close();
            }
            else if (cmbxSecim.SelectedIndex == 2)
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Select * from KaMalzeme  Where Malzeme like'%" + txtVeri.Text + "%'", conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                dataAdapter.Fill(data, "KaMalzeme");
                dgwMalzeme.DataSource = data.Tables[0];
                conn.Close();
            }
            else if (cmbxSecim.SelectedIndex == 3)
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Select * from KaNot  Where [Not] like'%" + txtVeri.Text + "%'", conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                dataAdapter.Fill(data, "KaNot");
                dgwNot.DataSource = data.Tables[0];
                conn.Close();
            }
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();
            Secim = MessageBox.Show("Seçili satırı silmek istediğinizden emin misiniz ?", "Mosas-Group | Taralsa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Secim == DialogResult.Yes)
            {
                if (cmbxSecim.SelectedIndex == 0)
                {
                    string ID = dgwFirma.Rows[dgwFirma.CurrentRow.Index].Cells[0].Value.ToString();
                    Ekle.SatiriSil(ID);
                    DataGridYenile();
                }
                else if (cmbxSecim.SelectedIndex == 1)
                {
                    string ID = dgwGFirma.Rows[dgwGFirma.CurrentRow.Index].Cells[0].Value.ToString();
                    Ekle.SatiriSilGFirma(ID);
                    DataGridYenile();
                }
                else if (cmbxSecim.SelectedIndex == 2)
                {
                    string ID = dgwMalzeme.Rows[dgwMalzeme.CurrentRow.Index].Cells[0].Value.ToString();
                    Ekle.SatiriSilMalzeme(ID);
                    DataGridYenile();
                }
                else if (cmbxSecim.SelectedIndex == 3)
                {
                    string ID = dgwNot.Rows[dgwNot.CurrentRow.Index].Cells[0].Value.ToString();
                    Ekle.SatiriSilNot(ID);
                    DataGridYenile();
                }
            }
            else
            {
                MessageBox.Show("İşlem yapılmadı", "Mosas-Group | Taralsa");
            }
        }

        private void btnKaydetme_Click(object sender, EventArgs e)
        {
            if (cmbxSecim.SelectedIndex==0)
            {
                Ekle.YeniSatirEkle(txtVeri.Text);
                DataGridYenile();
            }
            else if (cmbxSecim.SelectedIndex == 1)
            {
                Ekle.YeniSatirEkleGFirma(txtVeri.Text);
                DataGridYenile();
            }
            else if (cmbxSecim.SelectedIndex == 2)
            {
                Ekle.YeniSatirEkleMalzeme(txtVeri.Text);
                DataGridYenile();
            }
            else if (cmbxSecim.SelectedIndex == 3)
            {
                Ekle.YeniSatirEkleNot(txtVeri.Text);
                DataGridYenile();
            }
        }

        public void satirDegisti()  //KaFirma daki veriyi textbox aktarma
        { txtVeri.Text = dgwFirma.Rows[dgwFirma.CurrentRow.Index].Cells[1].Value.ToString(); }
        public void satirDegistiGFirma()  //KaGFirma daki veriyi textbox aktarma
        { txtVeri.Text = dgwGFirma.Rows[dgwGFirma.CurrentRow.Index].Cells[1].Value.ToString(); }
        public void satirDegistiMalzeme()  //KaMalzeme deki veriyi textbox aktarma
        { txtVeri.Text = dgwMalzeme.Rows[dgwMalzeme.CurrentRow.Index].Cells[1].Value.ToString(); }
        public void satirDegistiNot()  //KaNot daki veriyi textbox aktarma
        { txtVeri.Text = dgwNot.Rows[dgwNot.CurrentRow.Index].Cells[1].Value.ToString(); }

        int a, b, c, d;
        private void btnElmnBir_Click(object sender, EventArgs e)
        {
            if (cmbxSecim.SelectedIndex==0)//KaFirma DataGrid de ilk elaman
            {
                dgwFirma.Rows[0].Selected = true;      a = 0;
                dgwFirma.FirstDisplayedScrollingRowIndex = a;
                dgwFirma.CurrentCell = dgwFirma.Rows[a].Cells[0];
                dgwFirma.Refresh();               satirDegisti();
            }
            else if (cmbxSecim.SelectedIndex == 1)//KaGFirma DataGrid de ilk elaman
            {
                dgwGFirma.Rows[0].Selected = true;      b = 0;
                dgwGFirma.FirstDisplayedScrollingRowIndex = b;
                dgwGFirma.CurrentCell = dgwGFirma.Rows[b].Cells[0];
                dgwGFirma.Refresh();          satirDegistiGFirma();
            }
            else if (cmbxSecim.SelectedIndex == 2)//KaMalzeme DataGrid de ilk elaman
            {
                dgwMalzeme.Rows[0].Selected = true;      c = 0;
                dgwMalzeme.FirstDisplayedScrollingRowIndex = c;
                dgwMalzeme.CurrentCell = dgwMalzeme.Rows[c].Cells[0];
                dgwMalzeme.Refresh();          satirDegistiMalzeme();
            }
            else if (cmbxSecim.SelectedIndex == 3)//KaNot DataGrid de ilk elaman
            {
                dgwNot.Rows[0].Selected = true;       d= 0;
                dgwNot.FirstDisplayedScrollingRowIndex = d;
                dgwNot.CurrentCell = dgwNot.Rows[d].Cells[0];
                dgwNot.Refresh();          satirDegistiNot();
            }
        }

        private void btnOncekiElmn_Click(object sender, EventArgs e)
        {
            if (cmbxSecim.SelectedIndex==0)//KaFirma DataGrid önceki elaman
            {
                if (a > 0)
                {
                    a -= 1;     dgwFirma.Rows[a].Selected = true;
                    dgwFirma.FirstDisplayedScrollingRowIndex = a;
                    dgwFirma.CurrentCell = dgwFirma.Rows[a].Cells[0];
                    dgwFirma.Refresh();                 satirDegisti();
                }
                else
                {
                    a = dgwFirma.Rows.Count - 1;
                    dgwFirma.Rows[a].Selected = true;
                    dgwFirma.FirstDisplayedScrollingRowIndex = a;
                    dgwFirma.CurrentCell = dgwFirma.Rows[a].Cells[0];
                    dgwFirma.Refresh();                satirDegisti();
                }
            }
            else if (cmbxSecim.SelectedIndex == 1)//KaGFirma DataGrid önceki elaman
            {
                if (b > 0)
                {
                    b -= 1; dgwGFirma.Rows[b].Selected = true;
                    dgwGFirma.FirstDisplayedScrollingRowIndex =b;
                    dgwGFirma.CurrentCell = dgwGFirma.Rows[b].Cells[0];
                    dgwGFirma.Refresh(); satirDegistiGFirma();
                }
                else
                {
                    b = dgwGFirma.Rows.Count - 1;
                    dgwGFirma.Rows[b].Selected = true;
                    dgwGFirma.FirstDisplayedScrollingRowIndex = b;
                    dgwGFirma.CurrentCell = dgwGFirma.Rows[b].Cells[0];
                    dgwGFirma.Refresh(); satirDegistiGFirma();
                }
            }
            else if (cmbxSecim.SelectedIndex == 2)//KaMalzeme DataGrid önceki elaman
            {
                if (c > 0)
                {
                    c -= 1; dgwMalzeme.Rows[c].Selected = true;
                    dgwMalzeme.FirstDisplayedScrollingRowIndex = c;
                    dgwMalzeme.CurrentCell = dgwMalzeme.Rows[c].Cells[0];
                    dgwMalzeme.Refresh(); satirDegistiMalzeme();
                }
                else
                {
                    c = dgwMalzeme.Rows.Count - 1;
                    dgwMalzeme.Rows[c].Selected = true;
                    dgwMalzeme.FirstDisplayedScrollingRowIndex = c;
                    dgwMalzeme.CurrentCell = dgwMalzeme.Rows[c].Cells[0];
                    dgwMalzeme.Refresh(); satirDegistiMalzeme();
                }
            }
            else if (cmbxSecim.SelectedIndex == 3)//KaNot DataGrid önceki elaman
            {
                if (d > 0)
                {
                    d -= 1; dgwNot.Rows[d].Selected = true;
                    dgwNot.FirstDisplayedScrollingRowIndex = d;
                    dgwNot.CurrentCell = dgwNot.Rows[d].Cells[0];
                    dgwNot.Refresh(); satirDegistiNot();
                }
                else
                {
                    d = dgwNot.Rows.Count - 1;
                    dgwNot.Rows[d].Selected = true;
                    dgwNot.FirstDisplayedScrollingRowIndex = d;
                    dgwNot.CurrentCell = dgwNot.Rows[d].Cells[0];
                    dgwNot.Refresh(); satirDegistiNot();
                }
            }
        }

        private void btnSonrakiElmn_Click(object sender, EventArgs e)
        {
            if (cmbxSecim.SelectedIndex==0)//KaFirma DataGrid sonraki elaman
            {
                if (a < dgwFirma.Rows.Count - 1)
                {
                    a+= 1;      dgwFirma.Rows[a].Selected = true;
                    dgwFirma.FirstDisplayedScrollingRowIndex = a;
                    dgwFirma.CurrentCell = dgwFirma.Rows[a].Cells[0];
                    dgwFirma.Refresh();               satirDegisti();
                }
                else
                {
                    dgwFirma.Rows[0].Selected = true;      a = 0;
                    dgwFirma.FirstDisplayedScrollingRowIndex = a;
                    dgwFirma.CurrentCell = dgwFirma.Rows[a].Cells[0];
                    dgwFirma.Refresh();               satirDegisti();
                }
            }
            else if (cmbxSecim.SelectedIndex == 1)//KaGFirma DataGrid sonraki elaman
            {
                if (b < dgwGFirma.Rows.Count - 1)
                {
                    b += 1;     dgwGFirma.Rows[b].Selected = true;
                    dgwGFirma.FirstDisplayedScrollingRowIndex = b;
                    dgwGFirma.CurrentCell = dgwGFirma.Rows[b].Cells[0];
                    dgwGFirma.Refresh();          satirDegistiGFirma();
                }
                else
                {
                    dgwGFirma.Rows[0].Selected = true;      b = 0;
                    dgwGFirma.FirstDisplayedScrollingRowIndex = b;
                    dgwGFirma.CurrentCell = dgwGFirma.Rows[b].Cells[0];
                    dgwGFirma.Refresh();          satirDegistiGFirma();
                }
            }
            else if (cmbxSecim.SelectedIndex == 2)//KaMalzeme DataGrid sonraki elaman
            {
                if (c < dgwMalzeme.Rows.Count - 1)
                {
                    c += 1;     dgwMalzeme.Rows[c].Selected = true;
                    dgwMalzeme.FirstDisplayedScrollingRowIndex = c;
                    dgwMalzeme.CurrentCell = dgwMalzeme.Rows[c].Cells[0];
                    dgwMalzeme.Refresh();          satirDegistiMalzeme();
                }
                else
                {
                    dgwMalzeme.Rows[0].Selected = true;      c = 0;
                    dgwMalzeme.FirstDisplayedScrollingRowIndex = c;
                    dgwMalzeme.CurrentCell = dgwMalzeme.Rows[c].Cells[0];
                    dgwMalzeme.Refresh();          satirDegistiMalzeme();
                }
            }
            else if (cmbxSecim.SelectedIndex == 3)//KaNot DataGrid sonraki elaman
            {
                if (d < dgwNot.Rows.Count - 1)
                {
                    d += 1;     dgwNot.Rows[d].Selected = true;
                    dgwNot.FirstDisplayedScrollingRowIndex = d;
                    dgwNot.CurrentCell = dgwNot.Rows[d].Cells[0];
                    dgwNot.Refresh();          satirDegistiNot();
                }
                else
                {
                    dgwNot.Rows[0].Selected = true;      d = 0;
                    dgwNot.FirstDisplayedScrollingRowIndex = d;
                    dgwNot.CurrentCell = dgwNot.Rows[d].Cells[0];
                    dgwNot.Refresh();          satirDegistiNot();
                }
            }
        }

        private void btnElmnSon_Click(object sender, EventArgs e)
        {
            if (cmbxSecim.SelectedIndex==0)//KaFirma DataGrid de son elaman
            {
                dgwFirma.Rows[dgwFirma.Rows.Count - 1].Selected = true;                  a = dgwFirma.Rows.Count - 1;
                dgwFirma.FirstDisplayedScrollingRowIndex = a;       dgwFirma.CurrentCell = dgwFirma.Rows[a].Cells[0];
                dgwFirma.Refresh();                                                                   satirDegisti();
            }
            else if (cmbxSecim.SelectedIndex == 1)//KaGFirma DataGrid de son elaman
            {
                dgwGFirma.Rows[dgwGFirma.Rows.Count - 1].Selected = true;                b = dgwGFirma.Rows.Count - 1;
                dgwGFirma.FirstDisplayedScrollingRowIndex = b;     dgwGFirma.CurrentCell = dgwGFirma.Rows[b].Cells[0];
                dgwGFirma.Refresh();                                                             satirDegistiGFirma();
            }
            else if (cmbxSecim.SelectedIndex == 2)//KaMalzeme DataGrid de son elaman
            {
                dgwMalzeme.Rows[dgwMalzeme.Rows.Count - 1].Selected = true;                c = dgwMalzeme.Rows.Count - 1;
                dgwMalzeme.FirstDisplayedScrollingRowIndex = c;     dgwMalzeme.CurrentCell = dgwMalzeme.Rows[c].Cells[0];
                dgwMalzeme.Refresh();                                                              satirDegistiMalzeme();
            }
            else if (cmbxSecim.SelectedIndex == 3)//KaNot DataGrid de son elaman
            {
                dgwNot.Rows[dgwNot.Rows.Count - 1].Selected = true;                d = dgwNot.Rows.Count - 1;
                dgwNot.FirstDisplayedScrollingRowIndex = d;     dgwNot.CurrentCell = dgwNot.Rows[d].Cells[0];
                dgwNot.Refresh();                                                          satirDegistiNot();
            }
        }
    }
}
