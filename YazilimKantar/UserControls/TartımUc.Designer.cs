namespace YazilimKantar.UserControls
{
    partial class TartımUc
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TartımUc));
            this.txtKg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDara = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBrt = new System.Windows.Forms.TextBox();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.txtMalzeme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlkaNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrtmNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFrmaAd = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOprtr = new System.Windows.Forms.TextBox();
            this.txtGidnFrmAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.btnTartim = new System.Windows.Forms.Button();
            this.btnBrut = new System.Windows.Forms.Button();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.dTPCikis = new System.Windows.Forms.DateTimePicker();
            this.cBxGrs = new System.Windows.Forms.ComboBox();
            this.cBxCks = new System.Windows.Forms.ComboBox();
            this.cBxGldgil = new System.Windows.Forms.ComboBox();
            this.cBxGtdgil = new System.Windows.Forms.ComboBox();
            this.cmbFirma = new System.Windows.Forms.ComboBox();
            this.cmbMalzeme = new System.Windows.Forms.ComboBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.cmbGFirma = new System.Windows.Forms.ComboBox();
            this.cmbPlaka = new System.Windows.Forms.ComboBox();
            this.cYAracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazilimKantarDataSet = new YazilimKantar.YazilimKantarDataSet();
            this.cmbAciklama = new System.Windows.Forms.ComboBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlDVeri = new System.Windows.Forms.Panel();
            this.dgwTartim = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaNoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giTarihDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giSaatDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmAdiDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelilDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tartimDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tartimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgwSabit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giTarihDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giSaatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmAdiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tartimDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnElmnBir = new System.Windows.Forms.Button();
            this.YonTus = new System.Windows.Forms.ImageList(this.components);
            this.btnElmnSon = new System.Windows.Forms.Button();
            this.rBtnTartim = new System.Windows.Forms.RadioButton();
            this.rBtnSabit = new System.Windows.Forms.RadioButton();
            this.btnOncekiElmn = new System.Windows.Forms.Button();
            this.btnSonrakiElmn = new System.Windows.Forms.Button();
            this.btnGunceleme = new System.Windows.Forms.Button();
            this.plakaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tartimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TartimNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlakaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiFirmAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malzeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gelil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gitil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabitTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.SabitTableAdapter();
            this.tartimTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.TartimTableAdapter();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cYAracTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.CYAracTableAdapter();
            this.pnlAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cYAracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimKantarDataSet)).BeginInit();
            this.pnlData.SuspendLayout();
            this.pnlDVeri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTartim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tartimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSabit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabitBindingSource)).BeginInit();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKg
            // 
            this.txtKg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.txtKg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtKg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKg.ForeColor = System.Drawing.SystemColors.Window;
            this.txtKg.Location = new System.Drawing.Point(809, 8);
            this.txtKg.Margin = new System.Windows.Forms.Padding(2);
            this.txtKg.Name = "txtKg";
            this.txtKg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKg.Size = new System.Drawing.Size(120, 26);
            this.txtKg.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(369, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(151, 23);
            this.label12.TabIndex = 28;
            this.label12.Text = "SON TARTIM     :";
            // 
            // txtDara
            // 
            this.txtDara.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.txtDara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDara.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDara.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDara.Location = new System.Drawing.Point(220, 8);
            this.txtDara.Margin = new System.Windows.Forms.Padding(2);
            this.txtDara.Name = "txtDara";
            this.txtDara.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDara.Size = new System.Drawing.Size(120, 26);
            this.txtDara.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(698, 10);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(109, 23);
            this.label13.TabIndex = 29;
            this.label13.Text = "NET ( KG ) :";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(49, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(143, 23);
            this.label11.TabIndex = 27;
            this.label11.Text = "İLK TARTIM     :";
            // 
            // txtBrt
            // 
            this.txtBrt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.txtBrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBrt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBrt.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBrt.Location = new System.Drawing.Point(541, 8);
            this.txtBrt.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrt.Name = "txtBrt";
            this.txtBrt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBrt.Size = new System.Drawing.Size(120, 26);
            this.txtBrt.TabIndex = 32;
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.Color.Honeydew;
            this.pnlAlt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAlt.Controls.Add(this.txtBrt);
            this.pnlAlt.Controls.Add(this.txtKg);
            this.pnlAlt.Controls.Add(this.label12);
            this.pnlAlt.Controls.Add(this.txtDara);
            this.pnlAlt.Controls.Add(this.label13);
            this.pnlAlt.Controls.Add(this.label11);
            this.pnlAlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 590);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlAlt.Size = new System.Drawing.Size(980, 40);
            this.pnlAlt.TabIndex = 84;
            // 
            // txtMalzeme
            // 
            this.txtMalzeme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMalzeme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMalzeme.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMalzeme.Location = new System.Drawing.Point(240, 533);
            this.txtMalzeme.Margin = new System.Windows.Forms.Padding(2);
            this.txtMalzeme.Name = "txtMalzeme";
            this.txtMalzeme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMalzeme.Size = new System.Drawing.Size(120, 23);
            this.txtMalzeme.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(81, 408);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 65;
            this.label4.Text = "GİRİŞ TARİHİ      :";
            // 
            // txtPlkaNo
            // 
            this.txtPlkaNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlkaNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPlkaNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlkaNo.Location = new System.Drawing.Point(622, 64);
            this.txtPlkaNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlkaNo.Name = "txtPlkaNo";
            this.txtPlkaNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPlkaNo.Size = new System.Drawing.Size(120, 23);
            this.txtPlkaNo.TabIndex = 64;
            this.txtPlkaNo.TextChanged += new System.EventHandler(this.txtPlkaNo_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(454, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 63;
            this.label3.Text = "PLAKA NO      :";
            // 
            // txtTrtmNo
            // 
            this.txtTrtmNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrtmNo.BackColor = System.Drawing.Color.Firebrick;
            this.txtTrtmNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTrtmNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTrtmNo.ForeColor = System.Drawing.SystemColors.Info;
            this.txtTrtmNo.Location = new System.Drawing.Point(241, 65);
            this.txtTrtmNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrtmNo.Name = "txtTrtmNo";
            this.txtTrtmNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTrtmNo.Size = new System.Drawing.Size(200, 23);
            this.txtTrtmNo.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(468, 442);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "ÇIKIŞ SAATİ                 :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(77, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 59;
            this.label1.Text = "TARTIM NO    :";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(469, 411);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(179, 23);
            this.label14.TabIndex = 65;
            this.label14.Text = "ÇIKIŞ TARİHİ               :  ";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(81, 438);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(139, 23);
            this.label15.TabIndex = 60;
            this.label15.Text = "GİRİŞ SAATİ        :";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(81, 469);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(138, 23);
            this.label16.TabIndex = 60;
            this.label16.Text = "FİRMA ADI         :";
            // 
            // txtFrmaAd
            // 
            this.txtFrmaAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFrmaAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFrmaAd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFrmaAd.Location = new System.Drawing.Point(240, 470);
            this.txtFrmaAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtFrmaAd.Name = "txtFrmaAd";
            this.txtFrmaAd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFrmaAd.Size = new System.Drawing.Size(120, 23);
            this.txtFrmaAd.TabIndex = 62;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(470, 504);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(169, 23);
            this.label17.TabIndex = 60;
            this.label17.Text = "GİTTİĞİ İL                    :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(80, 500);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 60;
            this.label5.Text = "GELDİĞİ İL           :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(79, 532);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(141, 23);
            this.label6.TabIndex = 60;
            this.label6.Text = "MALZEME ADI   :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(265, 368);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(162, 23);
            this.label7.TabIndex = 60;
            this.label7.Text = "OPERATÖR ADI       :";
            // 
            // txtOprtr
            // 
            this.txtOprtr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOprtr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOprtr.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOprtr.Location = new System.Drawing.Point(459, 368);
            this.txtOprtr.Margin = new System.Windows.Forms.Padding(2);
            this.txtOprtr.Name = "txtOprtr";
            this.txtOprtr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOprtr.Size = new System.Drawing.Size(120, 23);
            this.txtOprtr.TabIndex = 75;
            // 
            // txtGidnFrmAdi
            // 
            this.txtGidnFrmAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGidnFrmAdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtGidnFrmAdi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGidnFrmAdi.Location = new System.Drawing.Point(660, 474);
            this.txtGidnFrmAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtGidnFrmAdi.Name = "txtGidnFrmAdi";
            this.txtGidnFrmAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGidnFrmAdi.Size = new System.Drawing.Size(120, 23);
            this.txtGidnFrmAdi.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(469, 473);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(171, 23);
            this.label8.TabIndex = 88;
            this.label8.Text = "GİTTİĞİ FİRMA ADI  :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(470, 533);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(168, 23);
            this.label9.TabIndex = 60;
            this.label9.Text = "AÇIKLAMA ( NOT )  :";
            // 
            // txtNot
            // 
            this.txtNot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNot.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNot.Location = new System.Drawing.Point(660, 534);
            this.txtNot.Margin = new System.Windows.Forms.Padding(2);
            this.txtNot.Name = "txtNot";
            this.txtNot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNot.Size = new System.Drawing.Size(120, 23);
            this.txtNot.TabIndex = 62;
            // 
            // btnTartim
            // 
            this.btnTartim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTartim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTartim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTartim.ForeColor = System.Drawing.Color.Black;
            this.btnTartim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTartim.Location = new System.Drawing.Point(684, 564);
            this.btnTartim.Name = "btnTartim";
            this.btnTartim.Size = new System.Drawing.Size(90, 23);
            this.btnTartim.TabIndex = 90;
            this.btnTartim.Text = "1. TARTIM";
            this.btnTartim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTartim.UseVisualStyleBackColor = true;
            this.btnTartim.Click += new System.EventHandler(this.btnTrKydt_Click);
            // 
            // btnBrut
            // 
            this.btnBrut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrut.ForeColor = System.Drawing.Color.Black;
            this.btnBrut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrut.Location = new System.Drawing.Point(780, 564);
            this.btnBrut.Name = "btnBrut";
            this.btnBrut.Size = new System.Drawing.Size(79, 23);
            this.btnBrut.TabIndex = 91;
            this.btnBrut.Text = "2. TARTIM";
            this.btnBrut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBrut.UseVisualStyleBackColor = true;
            this.btnBrut.Click += new System.EventHandler(this.btnBrut_Click);
            // 
            // dtpGiris
            // 
            this.dtpGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpGiris.CustomFormat = "yyyy/MM/dd";
            this.dtpGiris.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGiris.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGiris.Location = new System.Drawing.Point(240, 410);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(200, 23);
            this.dtpGiris.TabIndex = 93;
            // 
            // dTPCikis
            // 
            this.dTPCikis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dTPCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dTPCikis.CustomFormat = "yyyy/MM/dd";
            this.dTPCikis.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dTPCikis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPCikis.Location = new System.Drawing.Point(660, 411);
            this.dTPCikis.Name = "dTPCikis";
            this.dTPCikis.Size = new System.Drawing.Size(200, 23);
            this.dTPCikis.TabIndex = 94;
            // 
            // cBxGrs
            // 
            this.cBxGrs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBxGrs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBxGrs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBxGrs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBxGrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxGrs.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBxGrs.FormattingEnabled = true;
            this.cBxGrs.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cBxGrs.Location = new System.Drawing.Point(240, 439);
            this.cBxGrs.Name = "cBxGrs";
            this.cBxGrs.Size = new System.Drawing.Size(200, 23);
            this.cBxGrs.TabIndex = 95;
            // 
            // cBxCks
            // 
            this.cBxCks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBxCks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBxCks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBxCks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBxCks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxCks.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBxCks.FormattingEnabled = true;
            this.cBxCks.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cBxCks.Location = new System.Drawing.Point(660, 442);
            this.cBxCks.Name = "cBxCks";
            this.cBxCks.Size = new System.Drawing.Size(200, 23);
            this.cBxCks.TabIndex = 96;
            // 
            // cBxGldgil
            // 
            this.cBxGldgil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBxGldgil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBxGldgil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBxGldgil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBxGldgil.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBxGldgil.FormattingEnabled = true;
            this.cBxGldgil.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cBxGldgil.Location = new System.Drawing.Point(240, 499);
            this.cBxGldgil.Name = "cBxGldgil";
            this.cBxGldgil.Size = new System.Drawing.Size(200, 23);
            this.cBxGldgil.TabIndex = 97;
            // 
            // cBxGtdgil
            // 
            this.cBxGtdgil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBxGtdgil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBxGtdgil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBxGtdgil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBxGtdgil.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBxGtdgil.FormattingEnabled = true;
            this.cBxGtdgil.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cBxGtdgil.Location = new System.Drawing.Point(660, 504);
            this.cBxGtdgil.Name = "cBxGtdgil";
            this.cBxGtdgil.Size = new System.Drawing.Size(200, 23);
            this.cBxGtdgil.TabIndex = 98;
            // 
            // cmbFirma
            // 
            this.cmbFirma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFirma.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFirma.FormattingEnabled = true;
            this.cmbFirma.Location = new System.Drawing.Point(370, 470);
            this.cmbFirma.Name = "cmbFirma";
            this.cmbFirma.Size = new System.Drawing.Size(70, 23);
            this.cmbFirma.TabIndex = 99;
            this.cmbFirma.SelectedIndexChanged += new System.EventHandler(this.cmbFirma_SelectedIndexChanged);
            // 
            // cmbMalzeme
            // 
            this.cmbMalzeme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMalzeme.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMalzeme.FormattingEnabled = true;
            this.cmbMalzeme.Location = new System.Drawing.Point(370, 533);
            this.cmbMalzeme.Name = "cmbMalzeme";
            this.cmbMalzeme.Size = new System.Drawing.Size(70, 23);
            this.cmbMalzeme.TabIndex = 99;
            this.cmbMalzeme.SelectedIndexChanged += new System.EventHandler(this.cmbMalzeme_SelectedIndexChanged);
            // 
            // cmbOperator
            // 
            this.cmbOperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOperator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOperator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOperator.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(589, 368);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(70, 23);
            this.cmbOperator.TabIndex = 99;
            this.cmbOperator.SelectedIndexChanged += new System.EventHandler(this.cmbOperator_SelectedIndexChanged);
            // 
            // cmbGFirma
            // 
            this.cmbGFirma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbGFirma.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGFirma.FormattingEnabled = true;
            this.cmbGFirma.Location = new System.Drawing.Point(790, 473);
            this.cmbGFirma.Name = "cmbGFirma";
            this.cmbGFirma.Size = new System.Drawing.Size(70, 23);
            this.cmbGFirma.TabIndex = 99;
            this.cmbGFirma.SelectedIndexChanged += new System.EventHandler(this.cmbGFirma_SelectedIndexChanged);
            // 
            // cmbPlaka
            // 
            this.cmbPlaka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPlaka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPlaka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPlaka.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cYAracBindingSource, "PlakaNo", true));
            this.cmbPlaka.DataSource = this.cYAracBindingSource;
            this.cmbPlaka.DisplayMember = "PlakaNo";
            this.cmbPlaka.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPlaka.FormattingEnabled = true;
            this.cmbPlaka.Location = new System.Drawing.Point(752, 64);
            this.cmbPlaka.Name = "cmbPlaka";
            this.cmbPlaka.Size = new System.Drawing.Size(100, 23);
            this.cmbPlaka.TabIndex = 99;
            this.cmbPlaka.ValueMember = "PlakaNo";
            this.cmbPlaka.SelectedIndexChanged += new System.EventHandler(this.cmbPlaka_SelectedIndexChanged);
            // 
            // cYAracBindingSource
            // 
            this.cYAracBindingSource.DataMember = "CYArac";
            this.cYAracBindingSource.DataSource = this.yazilimKantarDataSet;
            // 
            // yazilimKantarDataSet
            // 
            this.yazilimKantarDataSet.DataSetName = "YazilimKantarDataSet";
            this.yazilimKantarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbAciklama
            // 
            this.cmbAciklama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAciklama.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAciklama.FormattingEnabled = true;
            this.cmbAciklama.Location = new System.Drawing.Point(789, 533);
            this.cmbAciklama.Name = "cmbAciklama";
            this.cmbAciklama.Size = new System.Drawing.Size(70, 23);
            this.cmbAciklama.TabIndex = 100;
            this.cmbAciklama.SelectedIndexChanged += new System.EventHandler(this.cmbAciklama_SelectedIndexChanged);
            // 
            // pnlData
            // 
            this.pnlData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlData.BackColor = System.Drawing.Color.Transparent;
            this.pnlData.Controls.Add(this.pnlDVeri);
            this.pnlData.Controls.Add(this.btnElmnBir);
            this.pnlData.Controls.Add(this.btnElmnSon);
            this.pnlData.Controls.Add(this.rBtnTartim);
            this.pnlData.Controls.Add(this.rBtnSabit);
            this.pnlData.Controls.Add(this.btnOncekiElmn);
            this.pnlData.Controls.Add(this.btnSonrakiElmn);
            this.pnlData.Controls.Add(this.btnGunceleme);
            this.pnlData.Location = new System.Drawing.Point(-1, 94);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(980, 260);
            this.pnlData.TabIndex = 101;
            // 
            // pnlDVeri
            // 
            this.pnlDVeri.Controls.Add(this.dgwTartim);
            this.pnlDVeri.Controls.Add(this.dgwSabit);
            this.pnlDVeri.Location = new System.Drawing.Point(-1, 1);
            this.pnlDVeri.Name = "pnlDVeri";
            this.pnlDVeri.Size = new System.Drawing.Size(980, 210);
            this.pnlDVeri.TabIndex = 27;
            // 
            // dgwTartim
            // 
            this.dgwTartim.AllowUserToAddRows = false;
            this.dgwTartim.AllowUserToOrderColumns = true;
            this.dgwTartim.AutoGenerateColumns = false;
            this.dgwTartim.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwTartim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTartim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.plakaNoDataGridViewTextBoxColumn2,
            this.giTarihDataGridViewTextBoxColumn2,
            this.giSaatDataGridViewTextBoxColumn2,
            this.firmAdiDataGridViewTextBoxColumn2,
            this.malzemeDataGridViewTextBoxColumn2,
            this.operatorDataGridViewTextBoxColumn2,
            this.gelilDataGridViewTextBoxColumn1,
            this.aciklamaDataGridViewTextBoxColumn2,
            this.tartimDataGridViewTextBoxColumn2});
            this.dgwTartim.DataSource = this.tartimBindingSource;
            this.dgwTartim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwTartim.Location = new System.Drawing.Point(0, 0);
            this.dgwTartim.Name = "dgwTartim";
            this.dgwTartim.Size = new System.Drawing.Size(980, 210);
            this.dgwTartim.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Tartım No";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // plakaNoDataGridViewTextBoxColumn2
            // 
            this.plakaNoDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plakaNoDataGridViewTextBoxColumn2.DataPropertyName = "PlakaNo";
            this.plakaNoDataGridViewTextBoxColumn2.HeaderText = "Plaka No";
            this.plakaNoDataGridViewTextBoxColumn2.Name = "plakaNoDataGridViewTextBoxColumn2";
            // 
            // giTarihDataGridViewTextBoxColumn2
            // 
            this.giTarihDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giTarihDataGridViewTextBoxColumn2.DataPropertyName = "GiTarih";
            this.giTarihDataGridViewTextBoxColumn2.HeaderText = "Giriş Tarih";
            this.giTarihDataGridViewTextBoxColumn2.Name = "giTarihDataGridViewTextBoxColumn2";
            // 
            // giSaatDataGridViewTextBoxColumn2
            // 
            this.giSaatDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giSaatDataGridViewTextBoxColumn2.DataPropertyName = "GiSaat";
            this.giSaatDataGridViewTextBoxColumn2.HeaderText = "Giriş Saat";
            this.giSaatDataGridViewTextBoxColumn2.Name = "giSaatDataGridViewTextBoxColumn2";
            // 
            // firmAdiDataGridViewTextBoxColumn2
            // 
            this.firmAdiDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firmAdiDataGridViewTextBoxColumn2.DataPropertyName = "FirmAdi";
            this.firmAdiDataGridViewTextBoxColumn2.HeaderText = "Firma Adı";
            this.firmAdiDataGridViewTextBoxColumn2.Name = "firmAdiDataGridViewTextBoxColumn2";
            // 
            // malzemeDataGridViewTextBoxColumn2
            // 
            this.malzemeDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.malzemeDataGridViewTextBoxColumn2.DataPropertyName = "Malzeme";
            this.malzemeDataGridViewTextBoxColumn2.HeaderText = "Malzeme Adı";
            this.malzemeDataGridViewTextBoxColumn2.Name = "malzemeDataGridViewTextBoxColumn2";
            // 
            // operatorDataGridViewTextBoxColumn2
            // 
            this.operatorDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.operatorDataGridViewTextBoxColumn2.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn2.HeaderText = "Operatör Adı";
            this.operatorDataGridViewTextBoxColumn2.Name = "operatorDataGridViewTextBoxColumn2";
            // 
            // gelilDataGridViewTextBoxColumn1
            // 
            this.gelilDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gelilDataGridViewTextBoxColumn1.DataPropertyName = "Gelil";
            this.gelilDataGridViewTextBoxColumn1.HeaderText = "Geldiği il";
            this.gelilDataGridViewTextBoxColumn1.Name = "gelilDataGridViewTextBoxColumn1";
            // 
            // aciklamaDataGridViewTextBoxColumn2
            // 
            this.aciklamaDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aciklamaDataGridViewTextBoxColumn2.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn2.HeaderText = "Açıklama (Not)";
            this.aciklamaDataGridViewTextBoxColumn2.Name = "aciklamaDataGridViewTextBoxColumn2";
            // 
            // tartimDataGridViewTextBoxColumn2
            // 
            this.tartimDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tartimDataGridViewTextBoxColumn2.DataPropertyName = "Tartim";
            this.tartimDataGridViewTextBoxColumn2.HeaderText = "Tartım";
            this.tartimDataGridViewTextBoxColumn2.Name = "tartimDataGridViewTextBoxColumn2";
            // 
            // tartimBindingSource
            // 
            this.tartimBindingSource.DataMember = "Tartim";
            this.tartimBindingSource.DataSource = this.yazilimKantarDataSet;
            // 
            // dgwSabit
            // 
            this.dgwSabit.AllowUserToAddRows = false;
            this.dgwSabit.AutoGenerateColumns = false;
            this.dgwSabit.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwSabit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSabit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn57,
            this.plakaNoDataGridViewTextBoxColumn1,
            this.giTarihDataGridViewTextBoxColumn1,
            this.giSaatDataGridViewTextBoxColumn1,
            this.firmAdiDataGridViewTextBoxColumn1,
            this.malzemeDataGridViewTextBoxColumn1,
            this.operatorDataGridViewTextBoxColumn1,
            this.gelilDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn1,
            this.tartimDataGridViewTextBoxColumn1});
            this.dgwSabit.DataSource = this.sabitBindingSource;
            this.dgwSabit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwSabit.Location = new System.Drawing.Point(0, 0);
            this.dgwSabit.Name = "dgwSabit";
            this.dgwSabit.Size = new System.Drawing.Size(980, 210);
            this.dgwSabit.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn57.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn57.HeaderText = "Tartım No";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.ReadOnly = true;
            // 
            // plakaNoDataGridViewTextBoxColumn1
            // 
            this.plakaNoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plakaNoDataGridViewTextBoxColumn1.DataPropertyName = "PlakaNo";
            this.plakaNoDataGridViewTextBoxColumn1.HeaderText = "Plaka No";
            this.plakaNoDataGridViewTextBoxColumn1.Name = "plakaNoDataGridViewTextBoxColumn1";
            // 
            // giTarihDataGridViewTextBoxColumn1
            // 
            this.giTarihDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giTarihDataGridViewTextBoxColumn1.DataPropertyName = "GiTarih";
            this.giTarihDataGridViewTextBoxColumn1.HeaderText = "Giriş Tarih";
            this.giTarihDataGridViewTextBoxColumn1.Name = "giTarihDataGridViewTextBoxColumn1";
            // 
            // giSaatDataGridViewTextBoxColumn1
            // 
            this.giSaatDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giSaatDataGridViewTextBoxColumn1.DataPropertyName = "GiSaat";
            this.giSaatDataGridViewTextBoxColumn1.HeaderText = "Giriş Saat";
            this.giSaatDataGridViewTextBoxColumn1.Name = "giSaatDataGridViewTextBoxColumn1";
            // 
            // firmAdiDataGridViewTextBoxColumn1
            // 
            this.firmAdiDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firmAdiDataGridViewTextBoxColumn1.DataPropertyName = "FirmAdi";
            this.firmAdiDataGridViewTextBoxColumn1.HeaderText = "Firma Adı";
            this.firmAdiDataGridViewTextBoxColumn1.Name = "firmAdiDataGridViewTextBoxColumn1";
            // 
            // malzemeDataGridViewTextBoxColumn1
            // 
            this.malzemeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.malzemeDataGridViewTextBoxColumn1.DataPropertyName = "Malzeme";
            this.malzemeDataGridViewTextBoxColumn1.HeaderText = "Malzeme Adı";
            this.malzemeDataGridViewTextBoxColumn1.Name = "malzemeDataGridViewTextBoxColumn1";
            // 
            // operatorDataGridViewTextBoxColumn1
            // 
            this.operatorDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.operatorDataGridViewTextBoxColumn1.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn1.HeaderText = "Operatör Adı";
            this.operatorDataGridViewTextBoxColumn1.Name = "operatorDataGridViewTextBoxColumn1";
            // 
            // gelilDataGridViewTextBoxColumn
            // 
            this.gelilDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gelilDataGridViewTextBoxColumn.DataPropertyName = "Gelil";
            this.gelilDataGridViewTextBoxColumn.HeaderText = "Geldiği il";
            this.gelilDataGridViewTextBoxColumn.Name = "gelilDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn1
            // 
            this.aciklamaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aciklamaDataGridViewTextBoxColumn1.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn1.HeaderText = "Açıklama (Not)";
            this.aciklamaDataGridViewTextBoxColumn1.Name = "aciklamaDataGridViewTextBoxColumn1";
            // 
            // tartimDataGridViewTextBoxColumn1
            // 
            this.tartimDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tartimDataGridViewTextBoxColumn1.DataPropertyName = "Tartim";
            this.tartimDataGridViewTextBoxColumn1.HeaderText = "Tartım";
            this.tartimDataGridViewTextBoxColumn1.Name = "tartimDataGridViewTextBoxColumn1";
            // 
            // sabitBindingSource
            // 
            this.sabitBindingSource.DataMember = "Sabit";
            this.sabitBindingSource.DataSource = this.yazilimKantarDataSet;
            // 
            // btnElmnBir
            // 
            this.btnElmnBir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnElmnBir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnElmnBir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElmnBir.FlatAppearance.BorderSize = 2;
            this.btnElmnBir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElmnBir.ImageIndex = 0;
            this.btnElmnBir.ImageList = this.YonTus;
            this.btnElmnBir.Location = new System.Drawing.Point(440, 215);
            this.btnElmnBir.Margin = new System.Windows.Forms.Padding(2);
            this.btnElmnBir.Name = "btnElmnBir";
            this.btnElmnBir.Size = new System.Drawing.Size(40, 40);
            this.btnElmnBir.TabIndex = 22;
            this.btnElmnBir.UseVisualStyleBackColor = false;
            this.btnElmnBir.Click += new System.EventHandler(this.btnElmnBir_Click);
            // 
            // YonTus
            // 
            this.YonTus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("YonTus.ImageStream")));
            this.YonTus.TransparentColor = System.Drawing.Color.Transparent;
            this.YonTus.Images.SetKeyName(0, "fast-forward.png");
            this.YonTus.Images.SetKeyName(1, "fast-forward-sonraki.png");
            this.YonTus.Images.SetKeyName(2, "play-button.png");
            this.YonTus.Images.SetKeyName(3, "play-button-sonraki.png");
            this.YonTus.Images.SetKeyName(4, "repeat.png");
            // 
            // btnElmnSon
            // 
            this.btnElmnSon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnElmnSon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnElmnSon.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElmnSon.FlatAppearance.BorderSize = 2;
            this.btnElmnSon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElmnSon.ImageIndex = 1;
            this.btnElmnSon.ImageList = this.YonTus;
            this.btnElmnSon.Location = new System.Drawing.Point(695, 214);
            this.btnElmnSon.Margin = new System.Windows.Forms.Padding(2);
            this.btnElmnSon.Name = "btnElmnSon";
            this.btnElmnSon.Size = new System.Drawing.Size(40, 40);
            this.btnElmnSon.TabIndex = 25;
            this.btnElmnSon.UseVisualStyleBackColor = false;
            this.btnElmnSon.Click += new System.EventHandler(this.btnElmnSon_Click);
            // 
            // rBtnTartim
            // 
            this.rBtnTartim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rBtnTartim.AutoSize = true;
            this.rBtnTartim.Checked = true;
            this.rBtnTartim.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtnTartim.Location = new System.Drawing.Point(228, 219);
            this.rBtnTartim.Name = "rBtnTartim";
            this.rBtnTartim.Size = new System.Drawing.Size(70, 30);
            this.rBtnTartim.TabIndex = 1;
            this.rBtnTartim.TabStop = true;
            this.rBtnTartim.Text = "Dara";
            this.rBtnTartim.UseVisualStyleBackColor = true;
            this.rBtnTartim.CheckedChanged += new System.EventHandler(this.rBtnTartim_CheckedChanged);
            // 
            // rBtnSabit
            // 
            this.rBtnSabit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rBtnSabit.AutoSize = true;
            this.rBtnSabit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtnSabit.Location = new System.Drawing.Point(318, 220);
            this.rBtnSabit.Name = "rBtnSabit";
            this.rBtnSabit.Size = new System.Drawing.Size(118, 30);
            this.rBtnSabit.TabIndex = 2;
            this.rBtnSabit.TabStop = true;
            this.rBtnSabit.Text = "Sabit Dara";
            this.rBtnSabit.UseVisualStyleBackColor = true;
            this.rBtnSabit.CheckedChanged += new System.EventHandler(this.rBtnSabit_CheckedChanged);
            // 
            // btnOncekiElmn
            // 
            this.btnOncekiElmn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOncekiElmn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOncekiElmn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOncekiElmn.FlatAppearance.BorderSize = 2;
            this.btnOncekiElmn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOncekiElmn.ImageIndex = 2;
            this.btnOncekiElmn.ImageList = this.YonTus;
            this.btnOncekiElmn.Location = new System.Drawing.Point(503, 215);
            this.btnOncekiElmn.Margin = new System.Windows.Forms.Padding(2);
            this.btnOncekiElmn.Name = "btnOncekiElmn";
            this.btnOncekiElmn.Size = new System.Drawing.Size(40, 40);
            this.btnOncekiElmn.TabIndex = 23;
            this.btnOncekiElmn.UseVisualStyleBackColor = false;
            this.btnOncekiElmn.Click += new System.EventHandler(this.btnOncekiElmn_Click);
            // 
            // btnSonrakiElmn
            // 
            this.btnSonrakiElmn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSonrakiElmn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSonrakiElmn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSonrakiElmn.FlatAppearance.BorderSize = 2;
            this.btnSonrakiElmn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSonrakiElmn.ImageIndex = 3;
            this.btnSonrakiElmn.ImageList = this.YonTus;
            this.btnSonrakiElmn.Location = new System.Drawing.Point(632, 214);
            this.btnSonrakiElmn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSonrakiElmn.Name = "btnSonrakiElmn";
            this.btnSonrakiElmn.Size = new System.Drawing.Size(40, 40);
            this.btnSonrakiElmn.TabIndex = 24;
            this.btnSonrakiElmn.UseVisualStyleBackColor = false;
            this.btnSonrakiElmn.Click += new System.EventHandler(this.btnSonrakiElmn_Click);
            // 
            // btnGunceleme
            // 
            this.btnGunceleme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGunceleme.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGunceleme.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGunceleme.FlatAppearance.BorderSize = 2;
            this.btnGunceleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGunceleme.ImageIndex = 4;
            this.btnGunceleme.ImageList = this.YonTus;
            this.btnGunceleme.Location = new System.Drawing.Point(566, 214);
            this.btnGunceleme.Margin = new System.Windows.Forms.Padding(2);
            this.btnGunceleme.Name = "btnGunceleme";
            this.btnGunceleme.Size = new System.Drawing.Size(40, 40);
            this.btnGunceleme.TabIndex = 26;
            this.btnGunceleme.UseVisualStyleBackColor = false;
            this.btnGunceleme.Click += new System.EventHandler(this.btnGunceleme_Click);
            // 
            // plakaNoDataGridViewTextBoxColumn
            // 
            this.plakaNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plakaNoDataGridViewTextBoxColumn.DataPropertyName = "PlakaNo";
            this.plakaNoDataGridViewTextBoxColumn.HeaderText = "Plaka No";
            this.plakaNoDataGridViewTextBoxColumn.Name = "plakaNoDataGridViewTextBoxColumn";
            // 
            // giTarihDataGridViewTextBoxColumn
            // 
            this.giTarihDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giTarihDataGridViewTextBoxColumn.DataPropertyName = "GiTarih";
            this.giTarihDataGridViewTextBoxColumn.HeaderText = "Giriş Tarih";
            this.giTarihDataGridViewTextBoxColumn.Name = "giTarihDataGridViewTextBoxColumn";
            // 
            // giSaatDataGridViewTextBoxColumn
            // 
            this.giSaatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giSaatDataGridViewTextBoxColumn.DataPropertyName = "GiSaat";
            this.giSaatDataGridViewTextBoxColumn.HeaderText = "Giriş Saat";
            this.giSaatDataGridViewTextBoxColumn.Name = "giSaatDataGridViewTextBoxColumn";
            // 
            // firmAdiDataGridViewTextBoxColumn
            // 
            this.firmAdiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firmAdiDataGridViewTextBoxColumn.DataPropertyName = "FirmAdi";
            this.firmAdiDataGridViewTextBoxColumn.HeaderText = "Firma Adı";
            this.firmAdiDataGridViewTextBoxColumn.Name = "firmAdiDataGridViewTextBoxColumn";
            // 
            // malzemeDataGridViewTextBoxColumn
            // 
            this.malzemeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.malzemeDataGridViewTextBoxColumn.DataPropertyName = "Malzeme";
            this.malzemeDataGridViewTextBoxColumn.HeaderText = "Malzeme Adı";
            this.malzemeDataGridViewTextBoxColumn.Name = "malzemeDataGridViewTextBoxColumn";
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "Operatör Adı";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // tartimDataGridViewTextBoxColumn
            // 
            this.tartimDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tartimDataGridViewTextBoxColumn.DataPropertyName = "Tartim";
            this.tartimDataGridViewTextBoxColumn.HeaderText = "Tartım";
            this.tartimDataGridViewTextBoxColumn.Name = "tartimDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PlakaNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Plaka No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GiTarih";
            this.dataGridViewTextBoxColumn2.HeaderText = "Giriş Tarih";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GiSaat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Giriş Saat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FirmAdi";
            this.dataGridViewTextBoxColumn4.HeaderText = "Firma Adı";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Malzeme";
            this.dataGridViewTextBoxColumn5.HeaderText = "Malzeme Adı";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn6.HeaderText = "Operatör Adı";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Aciklama";
            this.dataGridViewTextBoxColumn7.HeaderText = "Açıklama";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Tartim";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tartım";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PlakaNo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Plaka No";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "GiTarih";
            this.dataGridViewTextBoxColumn10.HeaderText = "Giriş Tarih";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "GiSaat";
            this.dataGridViewTextBoxColumn11.HeaderText = "Giriş Saat";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FirmAdi";
            this.dataGridViewTextBoxColumn12.HeaderText = "Firma Adı";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Malzeme";
            this.dataGridViewTextBoxColumn13.HeaderText = "Malzeme Adı";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn14.HeaderText = "Operatör Adı";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Aciklama";
            this.dataGridViewTextBoxColumn15.HeaderText = "Açıklama";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Tartim";
            this.dataGridViewTextBoxColumn16.HeaderText = "Tartım";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "PlakaNo";
            this.dataGridViewTextBoxColumn17.HeaderText = "Plaka No";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "GiTarih";
            this.dataGridViewTextBoxColumn18.HeaderText = "Giriş Tarih";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn19.DataPropertyName = "GiSaat";
            this.dataGridViewTextBoxColumn19.HeaderText = "Giriş Saat";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn20.DataPropertyName = "FirmAdi";
            this.dataGridViewTextBoxColumn20.HeaderText = "Firma Adı";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Malzeme";
            this.dataGridViewTextBoxColumn21.HeaderText = "Malzeme Adı";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn22.HeaderText = "Operatör Adı";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Aciklama";
            this.dataGridViewTextBoxColumn23.HeaderText = "Açıklama";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Tartim";
            this.dataGridViewTextBoxColumn24.HeaderText = "Tartım";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn25.DataPropertyName = "PlakaNo";
            this.dataGridViewTextBoxColumn25.HeaderText = "Plaka No";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn26.DataPropertyName = "GiTarih";
            this.dataGridViewTextBoxColumn26.HeaderText = "Giriş Tarih";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn27.DataPropertyName = "GiSaat";
            this.dataGridViewTextBoxColumn27.HeaderText = "Giriş Saat";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn28.DataPropertyName = "FirmAdi";
            this.dataGridViewTextBoxColumn28.HeaderText = "Firma Adı";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Malzeme";
            this.dataGridViewTextBoxColumn29.HeaderText = "Malzeme Adı";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn30.HeaderText = "Operatör Adı";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Aciklama";
            this.dataGridViewTextBoxColumn31.HeaderText = "Açıklama";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Tartim";
            this.dataGridViewTextBoxColumn32.HeaderText = "Tartım";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn33.DataPropertyName = "PlakaNo";
            this.dataGridViewTextBoxColumn33.HeaderText = "Plaka No";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn34.DataPropertyName = "GiTarih";
            this.dataGridViewTextBoxColumn34.HeaderText = "Giriş Tarih";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn35.DataPropertyName = "GiSaat";
            this.dataGridViewTextBoxColumn35.HeaderText = "Giriş Saat";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn36.DataPropertyName = "FirmAdi";
            this.dataGridViewTextBoxColumn36.HeaderText = "Firma Adı";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Malzeme";
            this.dataGridViewTextBoxColumn37.HeaderText = "Malzeme Adı";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn38.HeaderText = "Operatör Adı";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Aciklama";
            this.dataGridViewTextBoxColumn39.HeaderText = "Açıklama";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Tartim";
            this.dataGridViewTextBoxColumn40.HeaderText = "Tartım";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn41.DataPropertyName = "PlakaNo";
            this.dataGridViewTextBoxColumn41.HeaderText = "Plaka No";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn42.DataPropertyName = "GiTarih";
            this.dataGridViewTextBoxColumn42.HeaderText = "Giriş Tarih";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn43.DataPropertyName = "GiSaat";
            this.dataGridViewTextBoxColumn43.HeaderText = "Giriş Saat";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn44.DataPropertyName = "FirmAdi";
            this.dataGridViewTextBoxColumn44.HeaderText = "Firma Adı";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn45.DataPropertyName = "Malzeme";
            this.dataGridViewTextBoxColumn45.HeaderText = "Malzeme Adı";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn46.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn46.HeaderText = "Operatör Adı";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn47.DataPropertyName = "Aciklama";
            this.dataGridViewTextBoxColumn47.HeaderText = "Açıklama";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn48.DataPropertyName = "Tartim";
            this.dataGridViewTextBoxColumn48.HeaderText = "Tartım";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn49.DataPropertyName = "PlakaNo";
            this.dataGridViewTextBoxColumn49.HeaderText = "Plaka No";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn50.DataPropertyName = "GiTarih";
            this.dataGridViewTextBoxColumn50.HeaderText = "Giriş Tarih";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn51.DataPropertyName = "GiSaat";
            this.dataGridViewTextBoxColumn51.HeaderText = "Giriş Saat";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn52.DataPropertyName = "FirmAdi";
            this.dataGridViewTextBoxColumn52.HeaderText = "Firma Adı";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn53.DataPropertyName = "Malzeme";
            this.dataGridViewTextBoxColumn53.HeaderText = "Malzeme Adı";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn54.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn54.HeaderText = "Operatör Adı";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn55.DataPropertyName = "Aciklama";
            this.dataGridViewTextBoxColumn55.HeaderText = "Açıklama";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn56.DataPropertyName = "Tartim";
            this.dataGridViewTextBoxColumn56.HeaderText = "Tartım";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            // 
            // TartimNo
            // 
            this.TartimNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TartimNo.DataPropertyName = "TartimNo";
            this.TartimNo.HeaderText = "Tartım No";
            this.TartimNo.Name = "TartimNo";
            // 
            // PlakaNo
            // 
            this.PlakaNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlakaNo.DataPropertyName = "PlakaNo";
            this.PlakaNo.HeaderText = "Plaka No";
            this.PlakaNo.Name = "PlakaNo";
            // 
            // GiTarih
            // 
            this.GiTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiTarih.DataPropertyName = "GiTarih";
            this.GiTarih.HeaderText = "Giriş Tarih";
            this.GiTarih.Name = "GiTarih";
            // 
            // CiTarih
            // 
            this.CiTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CiTarih.DataPropertyName = "CiTarih";
            this.CiTarih.HeaderText = "Cıkış Tarih";
            this.CiTarih.Name = "CiTarih";
            // 
            // GiSaat
            // 
            this.GiSaat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiSaat.DataPropertyName = "GiSaat";
            this.GiSaat.HeaderText = "Giriş Saat";
            this.GiSaat.Name = "GiSaat";
            // 
            // CiSaat
            // 
            this.CiSaat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CiSaat.DataPropertyName = "CiSaat";
            this.CiSaat.HeaderText = "Cıkış Saat";
            this.CiSaat.Name = "CiSaat";
            // 
            // FirmAdi
            // 
            this.FirmAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirmAdi.DataPropertyName = "FirmAdi";
            this.FirmAdi.HeaderText = "Firma Adı";
            this.FirmAdi.Name = "FirmAdi";
            // 
            // GiFirmAdi
            // 
            this.GiFirmAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiFirmAdi.DataPropertyName = "GiFirmAdi";
            this.GiFirmAdi.HeaderText = "Gitiği Firma Adı";
            this.GiFirmAdi.Name = "GiFirmAdi";
            // 
            // Malzeme
            // 
            this.Malzeme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Malzeme.DataPropertyName = "Malzeme";
            this.Malzeme.HeaderText = "Malzeme Adı";
            this.Malzeme.Name = "Malzeme";
            // 
            // Operator
            // 
            this.Operator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Operator.DataPropertyName = "Operator";
            this.Operator.HeaderText = "Operatör Adı";
            this.Operator.Name = "Operator";
            // 
            // Gelil
            // 
            this.Gelil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gelil.DataPropertyName = "Gelil";
            this.Gelil.HeaderText = "Geldiği il";
            this.Gelil.Name = "Gelil";
            // 
            // Gitil
            // 
            this.Gitil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gitil.DataPropertyName = "Gitil";
            this.Gitil.HeaderText = "Gitiği il";
            this.Gitil.Name = "Gitil";
            // 
            // Aciklama
            // 
            this.Aciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açıklama(Not)";
            this.Aciklama.Name = "Aciklama";
            // 
            // sabitTableAdapter
            // 
            this.sabitTableAdapter.ClearBeforeFill = true;
            // 
            // tartimTableAdapter
            // 
            this.tartimTableAdapter.ClearBeforeFill = true;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.Honeydew;
            this.pnlUst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUst.Controls.Add(this.pictureBox2);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(980, 55);
            this.pnlUst.TabIndex = 103;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(346, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // cYAracTableAdapter
            // 
            this.cYAracTableAdapter.ClearBeforeFill = true;
            // 
            // TartımUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.cmbAciklama);
            this.Controls.Add(this.cmbPlaka);
            this.Controls.Add(this.cmbGFirma);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.cmbMalzeme);
            this.Controls.Add(this.cmbFirma);
            this.Controls.Add(this.cBxGtdgil);
            this.Controls.Add(this.cBxGldgil);
            this.Controls.Add(this.cBxCks);
            this.Controls.Add(this.cBxGrs);
            this.Controls.Add(this.dTPCikis);
            this.Controls.Add(this.dtpGiris);
            this.Controls.Add(this.btnBrut);
            this.Controls.Add(this.btnTartim);
            this.Controls.Add(this.txtGidnFrmAdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOprtr);
            this.Controls.Add(this.txtMalzeme);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlkaNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.txtFrmaAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTrtmNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TartımUc";
            this.Size = new System.Drawing.Size(980, 630);
            this.Load += new System.EventHandler(this.TartımUc_Load);
            this.pnlAlt.ResumeLayout(false);
            this.pnlAlt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cYAracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimKantarDataSet)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlDVeri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTartim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tartimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSabit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabitBindingSource)).EndInit();
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDara;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBrt;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.TextBox txtMalzeme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlkaNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrtmNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFrmaAd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOprtr;
        private System.Windows.Forms.TextBox txtGidnFrmAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Button btnTartim;
        private System.Windows.Forms.Button btnBrut;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.DateTimePicker dTPCikis;
        private System.Windows.Forms.ComboBox cBxGrs;
        private System.Windows.Forms.ComboBox cBxCks;
        private System.Windows.Forms.ComboBox cBxGldgil;
        private System.Windows.Forms.ComboBox cBxGtdgil;
        private System.Windows.Forms.ComboBox cmbFirma;
        private System.Windows.Forms.ComboBox cmbMalzeme;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.ComboBox cmbGFirma;
        private System.Windows.Forms.ComboBox cmbPlaka;
        private System.Windows.Forms.ComboBox cmbAciklama;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.RadioButton rBtnSabit;
        private System.Windows.Forms.RadioButton rBtnTartim;
        private System.Windows.Forms.Button btnElmnBir;
        private System.Windows.Forms.Button btnElmnSon;
        private System.Windows.Forms.Button btnSonrakiElmn;
        private System.Windows.Forms.Button btnGunceleme;
        private System.Windows.Forms.Button btnOncekiElmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tartimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.Panel pnlDVeri;
        private System.Windows.Forms.DataGridView dgwSabit;
        private YazilimKantarDataSet yazilimKantarDataSet;
        private System.Windows.Forms.DataGridView dgwTartim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TartimNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlakaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiFirmAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malzeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gelil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gitil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.BindingSource tartimBindingSource;
        private System.Windows.Forms.BindingSource sabitBindingSource;
        private YazilimKantarDataSetTableAdapters.SabitTableAdapter sabitTableAdapter;
        private YazilimKantarDataSetTableAdapters.TartimTableAdapter tartimTableAdapter;
        private System.Windows.Forms.ImageList YonTus;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource cYAracBindingSource;
        private YazilimKantarDataSetTableAdapters.CYAracTableAdapter cYAracTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaNoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn giTarihDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn giSaatDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmAdiDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelilDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tartimDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giTarihDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giSaatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmAdiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tartimDataGridViewTextBoxColumn1;
    }
}
