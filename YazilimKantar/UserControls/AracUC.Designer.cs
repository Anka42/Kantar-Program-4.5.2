namespace YazilimKantar.UserControls
{
    partial class AracUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracUC));
            this.YonTus = new System.Windows.Forms.ImageList(this.components);
            this.pnlDVeri = new System.Windows.Forms.Panel();
            this.pnlRapor = new System.Windows.Forms.Panel();
            this.pnlRaporUst = new System.Windows.Forms.Panel();
            this.tcBrut = new System.Windows.Forms.TabControl();
            this.tpDaraData = new System.Windows.Forms.TabPage();
            this.dgwBrut = new System.Windows.Forms.DataGridView();
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
            this.tartimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazilimKantarDataSet = new YazilimKantar.YazilimKantarDataSet();
            this.dgwTartim = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tartimNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giTarihDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciTarihDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giSaatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciSaatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmAdiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giFirmAdiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelilDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gitilDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tartimDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwSabit = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tartimNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giFirmAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gitilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tartimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRaporBrut = new System.Windows.Forms.Button();
            this.rBtnBrut = new System.Windows.Forms.RadioButton();
            this.btnElmnBir = new System.Windows.Forms.Button();
            this.btnGunceleme = new System.Windows.Forms.Button();
            this.btnElmnSon = new System.Windows.Forms.Button();
            this.btnSonrakiElmn = new System.Windows.Forms.Button();
            this.rBtnTartim = new System.Windows.Forms.RadioButton();
            this.btnOncekiElmn = new System.Windows.Forms.Button();
            this.rBtnSabit = new System.Windows.Forms.RadioButton();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sabitTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.SabitTableAdapter();
            this.tartimTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.TartimTableAdapter();
            this.bsAlistesi = new System.Windows.Forms.BindingSource(this.components);
            this.aracListesiTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.AracListesiTableAdapter();
            this.pnlDVeri.SuspendLayout();
            this.pnlRapor.SuspendLayout();
            this.tcBrut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tartimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimKantarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTartim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSabit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabitBindingSource)).BeginInit();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlistesi)).BeginInit();
            this.SuspendLayout();
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
            this.YonTus.Images.SetKeyName(5, "chat.png");
            // 
            // pnlDVeri
            // 
            this.pnlDVeri.Controls.Add(this.pnlRapor);
            this.pnlDVeri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDVeri.Location = new System.Drawing.Point(0, 110);
            this.pnlDVeri.Name = "pnlDVeri";
            this.pnlDVeri.Size = new System.Drawing.Size(980, 520);
            this.pnlDVeri.TabIndex = 27;
            // 
            // pnlRapor
            // 
            this.pnlRapor.Controls.Add(this.pnlRaporUst);
            this.pnlRapor.Controls.Add(this.tcBrut);
            this.pnlRapor.Controls.Add(this.dgwBrut);
            this.pnlRapor.Controls.Add(this.dgwTartim);
            this.pnlRapor.Controls.Add(this.dgwSabit);
            this.pnlRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRapor.Location = new System.Drawing.Point(0, 0);
            this.pnlRapor.Name = "pnlRapor";
            this.pnlRapor.Size = new System.Drawing.Size(980, 520);
            this.pnlRapor.TabIndex = 103;
            // 
            // pnlRaporUst
            // 
            this.pnlRaporUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.pnlRaporUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRaporUst.Location = new System.Drawing.Point(0, 0);
            this.pnlRaporUst.Name = "pnlRaporUst";
            this.pnlRaporUst.Size = new System.Drawing.Size(980, 20);
            this.pnlRaporUst.TabIndex = 103;
            // 
            // tcBrut
            // 
            this.tcBrut.Controls.Add(this.tpDaraData);
            this.tcBrut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBrut.Location = new System.Drawing.Point(0, 0);
            this.tcBrut.Name = "tcBrut";
            this.tcBrut.SelectedIndex = 0;
            this.tcBrut.Size = new System.Drawing.Size(980, 520);
            this.tcBrut.TabIndex = 103;
            // 
            // tpDaraData
            // 
            this.tpDaraData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.tpDaraData.Location = new System.Drawing.Point(4, 22);
            this.tpDaraData.Name = "tpDaraData";
            this.tpDaraData.Padding = new System.Windows.Forms.Padding(3);
            this.tpDaraData.Size = new System.Drawing.Size(972, 494);
            this.tpDaraData.TabIndex = 0;
            // 
            // dgwBrut
            // 
            this.dgwBrut.AllowUserToAddRows = false;
            this.dgwBrut.AllowUserToOrderColumns = true;
            this.dgwBrut.AutoGenerateColumns = false;
            this.dgwBrut.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwBrut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBrut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.dgwBrut.DataSource = this.tartimBindingSource;
            this.dgwBrut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwBrut.GridColor = System.Drawing.Color.SeaShell;
            this.dgwBrut.Location = new System.Drawing.Point(0, 0);
            this.dgwBrut.Name = "dgwBrut";
            this.dgwBrut.Size = new System.Drawing.Size(980, 520);
            this.dgwBrut.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TartimNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tartım No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PlakaNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Plaka No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GiTarih";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giriş Tarih";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CiTarih";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cıkış Tarih";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GiSaat";
            this.dataGridViewTextBoxColumn6.HeaderText = "Giriş Saat";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CiSaat";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cıkış Saat";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FirmAdi";
            this.dataGridViewTextBoxColumn8.HeaderText = "Firma Adı";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "GiFirmAdi";
            this.dataGridViewTextBoxColumn9.HeaderText = "Gitiği Firma Adı";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Malzeme";
            this.dataGridViewTextBoxColumn10.HeaderText = "Malzeme Adı";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn11.HeaderText = "Operatör Adı";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Gelil";
            this.dataGridViewTextBoxColumn12.HeaderText = "Geldiği İl";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Gitil";
            this.dataGridViewTextBoxColumn13.HeaderText = "Gitiği İl";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Aciklama";
            this.dataGridViewTextBoxColumn14.HeaderText = "Açıklama (Not)";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Tartim";
            this.dataGridViewTextBoxColumn15.HeaderText = "Dara";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Brut";
            this.dataGridViewTextBoxColumn16.HeaderText = "Brüt";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Kg";
            this.dataGridViewTextBoxColumn17.HeaderText = "Net";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // tartimBindingSource
            // 
            this.tartimBindingSource.DataMember = "Tartim";
            this.tartimBindingSource.DataSource = this.yazilimKantarDataSet;
            // 
            // yazilimKantarDataSet
            // 
            this.yazilimKantarDataSet.DataSetName = "YazilimKantarDataSet";
            this.yazilimKantarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgwTartim
            // 
            this.dgwTartim.AllowUserToAddRows = false;
            this.dgwTartim.AllowUserToOrderColumns = true;
            this.dgwTartim.AutoGenerateColumns = false;
            this.dgwTartim.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwTartim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTartim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn1,
            this.tartimNoDataGridViewTextBoxColumn1,
            this.plakaNoDataGridViewTextBoxColumn1,
            this.giTarihDataGridViewTextBoxColumn1,
            this.ciTarihDataGridViewTextBoxColumn1,
            this.giSaatDataGridViewTextBoxColumn1,
            this.ciSaatDataGridViewTextBoxColumn1,
            this.firmAdiDataGridViewTextBoxColumn1,
            this.giFirmAdiDataGridViewTextBoxColumn1,
            this.malzemeDataGridViewTextBoxColumn1,
            this.operatorDataGridViewTextBoxColumn1,
            this.gelilDataGridViewTextBoxColumn1,
            this.gitilDataGridViewTextBoxColumn1,
            this.aciklamaDataGridViewTextBoxColumn1,
            this.tartimDataGridViewTextBoxColumn1,
            this.brutDataGridViewTextBoxColumn1,
            this.kgDataGridViewTextBoxColumn1});
            this.dgwTartim.DataSource = this.tartimBindingSource;
            this.dgwTartim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwTartim.GridColor = System.Drawing.Color.SeaShell;
            this.dgwTartim.Location = new System.Drawing.Point(0, 0);
            this.dgwTartim.Name = "dgwTartim";
            this.dgwTartim.Size = new System.Drawing.Size(980, 520);
            this.dgwTartim.TabIndex = 1;
            // 
            // ıdDataGridViewTextBoxColumn1
            // 
            this.ıdDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ıdDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.ıdDataGridViewTextBoxColumn1.Name = "ıdDataGridViewTextBoxColumn1";
            this.ıdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tartimNoDataGridViewTextBoxColumn1
            // 
            this.tartimNoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tartimNoDataGridViewTextBoxColumn1.DataPropertyName = "TartimNo";
            this.tartimNoDataGridViewTextBoxColumn1.HeaderText = "Tartım No";
            this.tartimNoDataGridViewTextBoxColumn1.Name = "tartimNoDataGridViewTextBoxColumn1";
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
            // ciTarihDataGridViewTextBoxColumn1
            // 
            this.ciTarihDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ciTarihDataGridViewTextBoxColumn1.DataPropertyName = "CiTarih";
            this.ciTarihDataGridViewTextBoxColumn1.HeaderText = "Cıkış Tarih";
            this.ciTarihDataGridViewTextBoxColumn1.Name = "ciTarihDataGridViewTextBoxColumn1";
            // 
            // giSaatDataGridViewTextBoxColumn1
            // 
            this.giSaatDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giSaatDataGridViewTextBoxColumn1.DataPropertyName = "GiSaat";
            this.giSaatDataGridViewTextBoxColumn1.HeaderText = "Giriş Saat";
            this.giSaatDataGridViewTextBoxColumn1.Name = "giSaatDataGridViewTextBoxColumn1";
            // 
            // ciSaatDataGridViewTextBoxColumn1
            // 
            this.ciSaatDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ciSaatDataGridViewTextBoxColumn1.DataPropertyName = "CiSaat";
            this.ciSaatDataGridViewTextBoxColumn1.HeaderText = "Cıkış Saat";
            this.ciSaatDataGridViewTextBoxColumn1.Name = "ciSaatDataGridViewTextBoxColumn1";
            // 
            // firmAdiDataGridViewTextBoxColumn1
            // 
            this.firmAdiDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firmAdiDataGridViewTextBoxColumn1.DataPropertyName = "FirmAdi";
            this.firmAdiDataGridViewTextBoxColumn1.HeaderText = "Firma Adı";
            this.firmAdiDataGridViewTextBoxColumn1.Name = "firmAdiDataGridViewTextBoxColumn1";
            // 
            // giFirmAdiDataGridViewTextBoxColumn1
            // 
            this.giFirmAdiDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giFirmAdiDataGridViewTextBoxColumn1.DataPropertyName = "GiFirmAdi";
            this.giFirmAdiDataGridViewTextBoxColumn1.HeaderText = "Gitiği Firma Adı";
            this.giFirmAdiDataGridViewTextBoxColumn1.Name = "giFirmAdiDataGridViewTextBoxColumn1";
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
            // gelilDataGridViewTextBoxColumn1
            // 
            this.gelilDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gelilDataGridViewTextBoxColumn1.DataPropertyName = "Gelil";
            this.gelilDataGridViewTextBoxColumn1.HeaderText = "Geldiği İl";
            this.gelilDataGridViewTextBoxColumn1.Name = "gelilDataGridViewTextBoxColumn1";
            // 
            // gitilDataGridViewTextBoxColumn1
            // 
            this.gitilDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gitilDataGridViewTextBoxColumn1.DataPropertyName = "Gitil";
            this.gitilDataGridViewTextBoxColumn1.HeaderText = "Gitiği İl";
            this.gitilDataGridViewTextBoxColumn1.Name = "gitilDataGridViewTextBoxColumn1";
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
            this.tartimDataGridViewTextBoxColumn1.HeaderText = "Dara";
            this.tartimDataGridViewTextBoxColumn1.Name = "tartimDataGridViewTextBoxColumn1";
            // 
            // brutDataGridViewTextBoxColumn1
            // 
            this.brutDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brutDataGridViewTextBoxColumn1.DataPropertyName = "Brut";
            this.brutDataGridViewTextBoxColumn1.HeaderText = "Brüt";
            this.brutDataGridViewTextBoxColumn1.Name = "brutDataGridViewTextBoxColumn1";
            // 
            // kgDataGridViewTextBoxColumn1
            // 
            this.kgDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kgDataGridViewTextBoxColumn1.DataPropertyName = "Kg";
            this.kgDataGridViewTextBoxColumn1.HeaderText = "Net";
            this.kgDataGridViewTextBoxColumn1.Name = "kgDataGridViewTextBoxColumn1";
            // 
            // dgwSabit
            // 
            this.dgwSabit.AllowUserToAddRows = false;
            this.dgwSabit.AutoGenerateColumns = false;
            this.dgwSabit.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwSabit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSabit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.tartimNoDataGridViewTextBoxColumn,
            this.plakaNoDataGridViewTextBoxColumn,
            this.giTarihDataGridViewTextBoxColumn,
            this.ciTarihDataGridViewTextBoxColumn,
            this.giSaatDataGridViewTextBoxColumn,
            this.ciSaatDataGridViewTextBoxColumn,
            this.firmAdiDataGridViewTextBoxColumn,
            this.giFirmAdiDataGridViewTextBoxColumn,
            this.malzemeDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.gelilDataGridViewTextBoxColumn,
            this.gitilDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.tartimDataGridViewTextBoxColumn,
            this.brutDataGridViewTextBoxColumn,
            this.kgDataGridViewTextBoxColumn});
            this.dgwSabit.DataSource = this.sabitBindingSource;
            this.dgwSabit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwSabit.GridColor = System.Drawing.Color.SeaShell;
            this.dgwSabit.Location = new System.Drawing.Point(0, 0);
            this.dgwSabit.Name = "dgwSabit";
            this.dgwSabit.Size = new System.Drawing.Size(980, 520);
            this.dgwSabit.TabIndex = 0;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tartimNoDataGridViewTextBoxColumn
            // 
            this.tartimNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tartimNoDataGridViewTextBoxColumn.DataPropertyName = "TartimNo";
            this.tartimNoDataGridViewTextBoxColumn.HeaderText = "Tartım No";
            this.tartimNoDataGridViewTextBoxColumn.Name = "tartimNoDataGridViewTextBoxColumn";
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
            // ciTarihDataGridViewTextBoxColumn
            // 
            this.ciTarihDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ciTarihDataGridViewTextBoxColumn.DataPropertyName = "CiTarih";
            this.ciTarihDataGridViewTextBoxColumn.HeaderText = "Cıkış Tarih";
            this.ciTarihDataGridViewTextBoxColumn.Name = "ciTarihDataGridViewTextBoxColumn";
            // 
            // giSaatDataGridViewTextBoxColumn
            // 
            this.giSaatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giSaatDataGridViewTextBoxColumn.DataPropertyName = "GiSaat";
            this.giSaatDataGridViewTextBoxColumn.HeaderText = "Giriş Saat";
            this.giSaatDataGridViewTextBoxColumn.Name = "giSaatDataGridViewTextBoxColumn";
            // 
            // ciSaatDataGridViewTextBoxColumn
            // 
            this.ciSaatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ciSaatDataGridViewTextBoxColumn.DataPropertyName = "CiSaat";
            this.ciSaatDataGridViewTextBoxColumn.HeaderText = "Cıkış Saat";
            this.ciSaatDataGridViewTextBoxColumn.Name = "ciSaatDataGridViewTextBoxColumn";
            // 
            // firmAdiDataGridViewTextBoxColumn
            // 
            this.firmAdiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firmAdiDataGridViewTextBoxColumn.DataPropertyName = "FirmAdi";
            this.firmAdiDataGridViewTextBoxColumn.HeaderText = "Firms Adı";
            this.firmAdiDataGridViewTextBoxColumn.Name = "firmAdiDataGridViewTextBoxColumn";
            // 
            // giFirmAdiDataGridViewTextBoxColumn
            // 
            this.giFirmAdiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giFirmAdiDataGridViewTextBoxColumn.DataPropertyName = "GiFirmAdi";
            this.giFirmAdiDataGridViewTextBoxColumn.HeaderText = "Gitiği Firma Adı";
            this.giFirmAdiDataGridViewTextBoxColumn.Name = "giFirmAdiDataGridViewTextBoxColumn";
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
            // gelilDataGridViewTextBoxColumn
            // 
            this.gelilDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gelilDataGridViewTextBoxColumn.DataPropertyName = "Gelil";
            this.gelilDataGridViewTextBoxColumn.HeaderText = "Geldiği İl";
            this.gelilDataGridViewTextBoxColumn.Name = "gelilDataGridViewTextBoxColumn";
            // 
            // gitilDataGridViewTextBoxColumn
            // 
            this.gitilDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gitilDataGridViewTextBoxColumn.DataPropertyName = "Gitil";
            this.gitilDataGridViewTextBoxColumn.HeaderText = "Gitiği İl";
            this.gitilDataGridViewTextBoxColumn.Name = "gitilDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama (Not)";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // tartimDataGridViewTextBoxColumn
            // 
            this.tartimDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tartimDataGridViewTextBoxColumn.DataPropertyName = "Tartim";
            this.tartimDataGridViewTextBoxColumn.HeaderText = "Dara";
            this.tartimDataGridViewTextBoxColumn.Name = "tartimDataGridViewTextBoxColumn";
            // 
            // brutDataGridViewTextBoxColumn
            // 
            this.brutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brutDataGridViewTextBoxColumn.DataPropertyName = "Brut";
            this.brutDataGridViewTextBoxColumn.HeaderText = "Brüt";
            this.brutDataGridViewTextBoxColumn.Name = "brutDataGridViewTextBoxColumn";
            // 
            // kgDataGridViewTextBoxColumn
            // 
            this.kgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kgDataGridViewTextBoxColumn.DataPropertyName = "Kg";
            this.kgDataGridViewTextBoxColumn.HeaderText = "Net";
            this.kgDataGridViewTextBoxColumn.Name = "kgDataGridViewTextBoxColumn";
            // 
            // sabitBindingSource
            // 
            this.sabitBindingSource.DataMember = "Sabit";
            this.sabitBindingSource.DataSource = this.yazilimKantarDataSet;
            // 
            // btnRaporBrut
            // 
            this.btnRaporBrut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRaporBrut.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRaporBrut.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRaporBrut.FlatAppearance.BorderSize = 2;
            this.btnRaporBrut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaporBrut.ImageIndex = 5;
            this.btnRaporBrut.ImageList = this.YonTus;
            this.btnRaporBrut.Location = new System.Drawing.Point(796, 63);
            this.btnRaporBrut.Margin = new System.Windows.Forms.Padding(2);
            this.btnRaporBrut.Name = "btnRaporBrut";
            this.btnRaporBrut.Size = new System.Drawing.Size(40, 40);
            this.btnRaporBrut.TabIndex = 38;
            this.btnRaporBrut.UseVisualStyleBackColor = false;
            this.btnRaporBrut.Click += new System.EventHandler(this.btnRaporBrut_Click);
            // 
            // rBtnBrut
            // 
            this.rBtnBrut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtnBrut.AutoSize = true;
            this.rBtnBrut.Checked = true;
            this.rBtnBrut.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtnBrut.Location = new System.Drawing.Point(134, 68);
            this.rBtnBrut.Name = "rBtnBrut";
            this.rBtnBrut.Size = new System.Drawing.Size(67, 30);
            this.rBtnBrut.TabIndex = 37;
            this.rBtnBrut.TabStop = true;
            this.rBtnBrut.Text = "Brüt";
            this.rBtnBrut.UseVisualStyleBackColor = true;
            this.rBtnBrut.CheckedChanged += new System.EventHandler(this.rBtnBrut_CheckedChanged);
            // 
            // btnElmnBir
            // 
            this.btnElmnBir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnElmnBir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnElmnBir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElmnBir.FlatAppearance.BorderSize = 2;
            this.btnElmnBir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElmnBir.ImageIndex = 0;
            this.btnElmnBir.ImageList = this.YonTus;
            this.btnElmnBir.Location = new System.Drawing.Point(479, 64);
            this.btnElmnBir.Margin = new System.Windows.Forms.Padding(2);
            this.btnElmnBir.Name = "btnElmnBir";
            this.btnElmnBir.Size = new System.Drawing.Size(40, 40);
            this.btnElmnBir.TabIndex = 32;
            this.btnElmnBir.UseVisualStyleBackColor = false;
            this.btnElmnBir.Click += new System.EventHandler(this.btnElmnBir_Click);
            // 
            // btnGunceleme
            // 
            this.btnGunceleme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGunceleme.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGunceleme.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGunceleme.FlatAppearance.BorderSize = 2;
            this.btnGunceleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGunceleme.ImageIndex = 4;
            this.btnGunceleme.ImageList = this.YonTus;
            this.btnGunceleme.Location = new System.Drawing.Point(605, 63);
            this.btnGunceleme.Margin = new System.Windows.Forms.Padding(2);
            this.btnGunceleme.Name = "btnGunceleme";
            this.btnGunceleme.Size = new System.Drawing.Size(40, 40);
            this.btnGunceleme.TabIndex = 36;
            this.btnGunceleme.UseVisualStyleBackColor = false;
            this.btnGunceleme.Click += new System.EventHandler(this.btnGunceleme_Click);
            // 
            // btnElmnSon
            // 
            this.btnElmnSon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnElmnSon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnElmnSon.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElmnSon.FlatAppearance.BorderSize = 2;
            this.btnElmnSon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElmnSon.ImageIndex = 1;
            this.btnElmnSon.ImageList = this.YonTus;
            this.btnElmnSon.Location = new System.Drawing.Point(734, 63);
            this.btnElmnSon.Margin = new System.Windows.Forms.Padding(2);
            this.btnElmnSon.Name = "btnElmnSon";
            this.btnElmnSon.Size = new System.Drawing.Size(40, 40);
            this.btnElmnSon.TabIndex = 35;
            this.btnElmnSon.UseVisualStyleBackColor = false;
            this.btnElmnSon.Click += new System.EventHandler(this.btnElmnSon_Click);
            // 
            // btnSonrakiElmn
            // 
            this.btnSonrakiElmn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSonrakiElmn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSonrakiElmn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSonrakiElmn.FlatAppearance.BorderSize = 2;
            this.btnSonrakiElmn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSonrakiElmn.ImageIndex = 3;
            this.btnSonrakiElmn.ImageList = this.YonTus;
            this.btnSonrakiElmn.Location = new System.Drawing.Point(671, 63);
            this.btnSonrakiElmn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSonrakiElmn.Name = "btnSonrakiElmn";
            this.btnSonrakiElmn.Size = new System.Drawing.Size(40, 40);
            this.btnSonrakiElmn.TabIndex = 34;
            this.btnSonrakiElmn.UseVisualStyleBackColor = false;
            this.btnSonrakiElmn.Click += new System.EventHandler(this.btnSonrakiElmn_Click);
            // 
            // rBtnTartim
            // 
            this.rBtnTartim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtnTartim.AutoSize = true;
            this.rBtnTartim.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtnTartim.Location = new System.Drawing.Point(224, 68);
            this.rBtnTartim.Name = "rBtnTartim";
            this.rBtnTartim.Size = new System.Drawing.Size(70, 30);
            this.rBtnTartim.TabIndex = 30;
            this.rBtnTartim.Text = "Dara";
            this.rBtnTartim.UseVisualStyleBackColor = true;
            this.rBtnTartim.CheckedChanged += new System.EventHandler(this.rBtnTartim_CheckedChanged);
            // 
            // btnOncekiElmn
            // 
            this.btnOncekiElmn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOncekiElmn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOncekiElmn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOncekiElmn.FlatAppearance.BorderSize = 2;
            this.btnOncekiElmn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOncekiElmn.ImageIndex = 2;
            this.btnOncekiElmn.ImageList = this.YonTus;
            this.btnOncekiElmn.Location = new System.Drawing.Point(542, 64);
            this.btnOncekiElmn.Margin = new System.Windows.Forms.Padding(2);
            this.btnOncekiElmn.Name = "btnOncekiElmn";
            this.btnOncekiElmn.Size = new System.Drawing.Size(40, 40);
            this.btnOncekiElmn.TabIndex = 33;
            this.btnOncekiElmn.UseVisualStyleBackColor = false;
            this.btnOncekiElmn.Click += new System.EventHandler(this.btnOncekiElmn_Click);
            // 
            // rBtnSabit
            // 
            this.rBtnSabit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtnSabit.AutoSize = true;
            this.rBtnSabit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtnSabit.Location = new System.Drawing.Point(314, 69);
            this.rBtnSabit.Name = "rBtnSabit";
            this.rBtnSabit.Size = new System.Drawing.Size(118, 30);
            this.rBtnSabit.TabIndex = 31;
            this.rBtnSabit.Text = "Sabit Dara";
            this.rBtnSabit.UseVisualStyleBackColor = true;
            this.rBtnSabit.CheckedChanged += new System.EventHandler(this.rBtnSabit_CheckedChanged);
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.Honeydew;
            this.pnlUst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUst.Controls.Add(this.pictureBox1);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(980, 55);
            this.pnlUst.TabIndex = 104;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(783, 9);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // sabitTableAdapter
            // 
            this.sabitTableAdapter.ClearBeforeFill = true;
            // 
            // tartimTableAdapter
            // 
            this.tartimTableAdapter.ClearBeforeFill = true;
            // 
            // bsAlistesi
            // 
            this.bsAlistesi.DataMember = "AracListesi";
            this.bsAlistesi.DataSource = this.yazilimKantarDataSet;
            // 
            // aracListesiTableAdapter
            // 
            this.aracListesiTableAdapter.ClearBeforeFill = true;
            // 
            // AracUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.btnRaporBrut);
            this.Controls.Add(this.rBtnBrut);
            this.Controls.Add(this.btnElmnBir);
            this.Controls.Add(this.btnGunceleme);
            this.Controls.Add(this.btnElmnSon);
            this.Controls.Add(this.btnSonrakiElmn);
            this.Controls.Add(this.rBtnTartim);
            this.Controls.Add(this.btnOncekiElmn);
            this.Controls.Add(this.rBtnSabit);
            this.Controls.Add(this.pnlDVeri);
            this.Name = "AracUC";
            this.Size = new System.Drawing.Size(980, 630);
            this.Load += new System.EventHandler(this.AracUC_Load);
            this.pnlDVeri.ResumeLayout(false);
            this.pnlRapor.ResumeLayout(false);
            this.tcBrut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tartimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimKantarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTartim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSabit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabitBindingSource)).EndInit();
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlistesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlDVeri;
        private System.Windows.Forms.DataGridView dgwTartim;
        private System.Windows.Forms.DataGridView dgwSabit;
        private System.Windows.Forms.DataGridView dgwBrut;
        private System.Windows.Forms.BindingSource tartimBindingSource;
        private YazilimKantarDataSet yazilimKantarDataSet;
        private System.Windows.Forms.BindingSource sabitBindingSource;
        private YazilimKantarDataSetTableAdapters.SabitTableAdapter sabitTableAdapter;
        private YazilimKantarDataSetTableAdapters.TartimTableAdapter tartimTableAdapter;
        private System.Windows.Forms.ImageList YonTus;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tartimNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giTarihDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciTarihDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giSaatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciSaatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmAdiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giFirmAdiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelilDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gitilDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tartimDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tartimNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giFirmAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gitilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tartimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlRapor;
        private System.Windows.Forms.Panel pnlRaporUst;
        private System.Windows.Forms.TabControl tcBrut;
        private System.Windows.Forms.TabPage tpDaraData;
        private System.Windows.Forms.Button btnRaporBrut;
        private System.Windows.Forms.RadioButton rBtnBrut;
        private System.Windows.Forms.Button btnElmnBir;
        private System.Windows.Forms.Button btnGunceleme;
        private System.Windows.Forms.Button btnElmnSon;
        private System.Windows.Forms.Button btnSonrakiElmn;
        private System.Windows.Forms.RadioButton rBtnTartim;
        private System.Windows.Forms.Button btnOncekiElmn;
        private System.Windows.Forms.RadioButton rBtnSabit;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bsAlistesi;
        private YazilimKantarDataSetTableAdapters.AracListesiTableAdapter aracListesiTableAdapter;
    }
}
