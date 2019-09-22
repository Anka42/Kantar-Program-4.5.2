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
    public partial class AracUC : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;initial Catalog=YazilimKantar;Integrated Security=True");
        TartimDataClss Tartim = new TartimDataClss();
        SabitDataClss Sabit = new SabitDataClss();
        BrutDataClss Brut = new BrutDataClss();
        public void DataGridYenile()
        {
            dgwSabit.DataSource = Sabit.TabloyuGetir();
            dgwTartim.DataSource = Tartim.TabloyuGetir();
            dgwBrut.DataSource = Brut.TabloyuGetir();
        }
        public AracUC()
        {
            InitializeComponent();
            DataGridYenile();
        }

        private void AracUC_Load(object sender, EventArgs e)
        {
            this.aracListesiTableAdapter.Fill(this.yazilimKantarDataSet.AracListesi);
            tpDaraData.Controls.Add(RaporClss.GetReport(System.Environment.CurrentDirectory + "\\Raporm\\RprtArac.rdlc", "DataSetArac", bsAlistesi));
            pnlDVeri.Controls.Clear();
            pnlDVeri.Controls.Add(dgwBrut);
        }

        private void rBtnBrut_CheckedChanged(object sender, EventArgs e)
        {
            pnlDVeri.Controls.Clear();
            pnlDVeri.Controls.Add(dgwBrut);
        }

        private void rBtnTartim_CheckedChanged(object sender, EventArgs e)
        {
            pnlDVeri.Controls.Clear();
            pnlDVeri.Controls.Add(dgwTartim);
        }

        private void rBtnSabit_CheckedChanged(object sender, EventArgs e)
        {
            pnlDVeri.Controls.Clear();
            dgwSabit.Dock = DockStyle.Fill;
            pnlDVeri.Controls.Add(dgwSabit);
        }
        int i, j,y;
        private void btnElmnBir_Click(object sender, EventArgs e)
        {
            if (rBtnTartim.Checked == true) //Tartim
            {
                dgwTartim.Rows[0].Selected = true;
                i = 0;
                dgwTartim.FirstDisplayedScrollingRowIndex = i;
                dgwTartim.CurrentCell = dgwTartim.Rows[i].Cells[0];
                dgwTartim.Refresh();
            }
            else if (rBtnSabit.Checked == true) //Sabit
            {
                dgwSabit.Rows[0].Selected = true;
                j = 0;
                dgwSabit.FirstDisplayedScrollingRowIndex = j;
                dgwSabit.CurrentCell = dgwSabit.Rows[j].Cells[0];
                dgwSabit.Refresh();
            }
            else if (rBtnBrut.Checked == true) //Brut
            {
                dgwBrut.Rows[0].Selected = true;
                y = 0;
                dgwBrut.FirstDisplayedScrollingRowIndex = y;
                dgwBrut.CurrentCell = dgwBrut.Rows[y].Cells[0];
                dgwBrut.Refresh();
            }
        }

        private void btnOncekiElmn_Click(object sender, EventArgs e)
        {
            if (rBtnTartim.Checked == true) //Tartim
            {
                if (i > 0)
                {
                    i -= 1;
                    dgwTartim.Rows[i].Selected = true;
                    dgwTartim.FirstDisplayedScrollingRowIndex = i;
                    dgwTartim.CurrentCell = dgwTartim.Rows[i].Cells[0];
                    dgwTartim.Refresh();
                }
                else
                {
                    i = dgwTartim.Rows.Count - 1;
                    dgwTartim.Rows[i].Selected = true;
                    dgwTartim.FirstDisplayedScrollingRowIndex = i;
                    dgwTartim.CurrentCell = dgwTartim.Rows[i].Cells[0];
                    dgwTartim.Refresh();
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
                }
                else
                {
                    j = dgwSabit.Rows.Count - 1;
                    dgwSabit.Rows[j].Selected = true;
                    dgwSabit.FirstDisplayedScrollingRowIndex = j;
                    dgwSabit.CurrentCell = dgwSabit.Rows[j].Cells[0];
                    dgwSabit.Refresh();
                }
            }
            else if (rBtnBrut.Checked == true) //Brut
            {
                if (y > 0)
                {
                    y -= 1;
                    dgwBrut.Rows[y].Selected = true;
                    dgwBrut.FirstDisplayedScrollingRowIndex = y;
                    dgwBrut.CurrentCell = dgwBrut.Rows[y].Cells[0];
                    dgwBrut.Refresh();
                }
                else
                {
                    y = dgwBrut.Rows.Count - 1;
                    dgwBrut.Rows[y].Selected = true;
                    dgwBrut.FirstDisplayedScrollingRowIndex = y;
                    dgwBrut.CurrentCell = dgwBrut.Rows[y].Cells[0];
                    dgwBrut.Refresh();
                }
            }
        }

        private void btnGunceleme_Click(object sender, EventArgs e)
        {
            DataGridYenile();
        }
        
        private void btnSonrakiElmn_Click(object sender, EventArgs e)
        {
            if (rBtnTartim.Checked == true) //Tartim
            {
                if (i < dgwTartim.Rows.Count - 1)
                {
                    i += 1;
                    dgwTartim.Rows[i].Selected = true;
                    dgwTartim.FirstDisplayedScrollingRowIndex = i;
                    dgwTartim.CurrentCell = dgwTartim.Rows[i].Cells[0];
                    dgwTartim.Refresh();
                }
                else
                {
                    dgwTartim.Rows[0].Selected = true;
                    i = 0;
                    dgwTartim.FirstDisplayedScrollingRowIndex = i;
                    dgwTartim.CurrentCell = dgwTartim.Rows[i].Cells[0];
                    dgwTartim.Refresh();
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
                }
                else
                {
                    dgwSabit.Rows[0].Selected = true;
                    j = 0;
                    dgwSabit.FirstDisplayedScrollingRowIndex = j;
                    dgwSabit.CurrentCell = dgwSabit.Rows[j].Cells[0];
                    dgwSabit.Refresh();
                }
            }
            else if (rBtnBrut.Checked == true) //Brut
            {
                if (y < dgwBrut.Rows.Count - 1)
                {
                    y += 1;
                    dgwBrut.Rows[y].Selected = true;
                    dgwBrut.FirstDisplayedScrollingRowIndex = y;
                    dgwBrut.CurrentCell = dgwBrut.Rows[y].Cells[0];
                    dgwBrut.Refresh();
                }
                else
                {
                    dgwBrut.Rows[0].Selected = true;
                    y= 0;
                    dgwBrut.FirstDisplayedScrollingRowIndex =y;
                    dgwBrut.CurrentCell = dgwBrut.Rows[y].Cells[0];
                    dgwBrut.Refresh();
                }
            }
        }

        private void btnElmnSon_Click(object sender, EventArgs e)
        {
            if (rBtnTartim.Checked == true)
            {
                dgwTartim.Rows[dgwTartim.Rows.Count - 1].Selected = true;  //Tartim
                i = dgwTartim.Rows.Count - 1;
                dgwTartim.FirstDisplayedScrollingRowIndex = i;
                dgwTartim.CurrentCell = dgwTartim.Rows[i].Cells[0];
                dgwTartim.Refresh();
                
            }
            else if (rBtnSabit.Checked == true)
            {
                dgwSabit.Rows[dgwSabit.Rows.Count - 1].Selected = true;  //Sabit
                j = dgwSabit.Rows.Count - 1;
                dgwSabit.FirstDisplayedScrollingRowIndex = j;
                dgwSabit.CurrentCell = dgwSabit.Rows[j].Cells[0];
                dgwSabit.Refresh();
                
            }
            else if (rBtnBrut.Checked == true)
            {
                dgwBrut.Rows[dgwBrut.Rows.Count - 1].Selected = true;  //Sabit
                y = dgwBrut.Rows.Count - 1;
                dgwBrut.FirstDisplayedScrollingRowIndex = y;
                dgwBrut.CurrentCell = dgwBrut.Rows[y].Cells[0];
                dgwBrut.Refresh();

            }
        }

        private void btnRaporBrut_Click(object sender, EventArgs e)
        {
            pnlDVeri.Controls.Clear();
            pnlDVeri.Controls.Add(pnlRapor);
        }
    }
}
