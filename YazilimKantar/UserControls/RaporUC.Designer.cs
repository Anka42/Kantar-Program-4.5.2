namespace YazilimKantar.UserControls
{
    partial class RaporUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporUC));
            this.pnlUst = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlAna = new System.Windows.Forms.Panel();
            this.pnlSag = new System.Windows.Forms.Panel();
            this.pnlUstSag = new System.Windows.Forms.Panel();
            this.tcBrut = new System.Windows.Forms.TabControl();
            this.tpDaraData = new System.Windows.Forms.TabPage();
            this.pnlSol = new System.Windows.Forms.Panel();
            this.pnlSAlt = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAylık = new System.Windows.Forms.Button();
            this.btnGunluk = new System.Windows.Forms.Button();
            this.btnOzel = new System.Windows.Forms.Button();
            this.pnlGetir = new System.Windows.Forms.Panel();
            this.pnlGnlk = new System.Windows.Forms.Panel();
            this.rbtnGVardiye3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGRapor = new System.Windows.Forms.Button();
            this.ilistRapor = new System.Windows.Forms.ImageList(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rbtnGVardiye1 = new System.Windows.Forms.RadioButton();
            this.rbtnGVardiye2 = new System.Windows.Forms.RadioButton();
            this.rbtnGVardiyeTüm = new System.Windows.Forms.RadioButton();
            this.dtpGZaman = new System.Windows.Forms.DateTimePicker();
            this.pnlAylik = new System.Windows.Forms.Panel();
            this.btnARapor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpABitTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpABasTarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlOzel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOzelRpr = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOPlaka = new System.Windows.Forms.ComboBox();
            this.dtpOBasTarih = new System.Windows.Forms.DateTimePicker();
            this.rBtnOGunluk = new System.Windows.Forms.RadioButton();
            this.cmbOBit = new System.Windows.Forms.ComboBox();
            this.lblplka = new System.Windows.Forms.Label();
            this.cmbOBas = new System.Windows.Forms.ComboBox();
            this.rBtnOAylik = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOBitTarih = new System.Windows.Forms.DateTimePicker();
            this.pnlSBslik = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlUstSol = new System.Windows.Forms.Panel();
            this.yazilimKantarDataSet = new YazilimKantar.YazilimKantarDataSet();
            this.bSourceGunluk = new System.Windows.Forms.BindingSource(this.components);
            this.gunlukRaporTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.GunlukRaporTableAdapter();
            this.bSourceAylik = new System.Windows.Forms.BindingSource(this.components);
            this.aylikRaporTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.AylikRaporTableAdapter();
            this.bSourceOzelG = new System.Windows.Forms.BindingSource(this.components);
            this.ozelGRaporTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.OzelGRaporTableAdapter();
            this.bSourceOzelA = new System.Windows.Forms.BindingSource(this.components);
            this.ozelARaporTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.OzelARaporTableAdapter();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlAna.SuspendLayout();
            this.pnlSag.SuspendLayout();
            this.tcBrut.SuspendLayout();
            this.pnlSol.SuspendLayout();
            this.pnlSAlt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlGetir.SuspendLayout();
            this.pnlGnlk.SuspendLayout();
            this.pnlAylik.SuspendLayout();
            this.pnlOzel.SuspendLayout();
            this.pnlSBslik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimKantarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceGunluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceAylik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceOzelG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceOzelA)).BeginInit();
            this.SuspendLayout();
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
            this.pnlUst.TabIndex = 104;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(343, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pnlAna
            // 
            this.pnlAna.Controls.Add(this.pnlSag);
            this.pnlAna.Controls.Add(this.pnlSol);
            this.pnlAna.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAna.Location = new System.Drawing.Point(0, 55);
            this.pnlAna.Name = "pnlAna";
            this.pnlAna.Size = new System.Drawing.Size(980, 575);
            this.pnlAna.TabIndex = 105;
            // 
            // pnlSag
            // 
            this.pnlSag.Controls.Add(this.pnlUstSag);
            this.pnlSag.Controls.Add(this.tcBrut);
            this.pnlSag.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSag.Location = new System.Drawing.Point(230, 0);
            this.pnlSag.Name = "pnlSag";
            this.pnlSag.Size = new System.Drawing.Size(750, 575);
            this.pnlSag.TabIndex = 1;
            // 
            // pnlUstSag
            // 
            this.pnlUstSag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.pnlUstSag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUstSag.Location = new System.Drawing.Point(0, 0);
            this.pnlUstSag.Name = "pnlUstSag";
            this.pnlUstSag.Size = new System.Drawing.Size(750, 20);
            this.pnlUstSag.TabIndex = 112;
            // 
            // tcBrut
            // 
            this.tcBrut.Controls.Add(this.tpDaraData);
            this.tcBrut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBrut.Location = new System.Drawing.Point(0, 0);
            this.tcBrut.Name = "tcBrut";
            this.tcBrut.SelectedIndex = 0;
            this.tcBrut.Size = new System.Drawing.Size(750, 575);
            this.tcBrut.TabIndex = 113;
            // 
            // tpDaraData
            // 
            this.tpDaraData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.tpDaraData.Location = new System.Drawing.Point(4, 22);
            this.tpDaraData.Name = "tpDaraData";
            this.tpDaraData.Padding = new System.Windows.Forms.Padding(3);
            this.tpDaraData.Size = new System.Drawing.Size(742, 549);
            this.tpDaraData.TabIndex = 0;
            // 
            // pnlSol
            // 
            this.pnlSol.Controls.Add(this.pnlSAlt);
            this.pnlSol.Controls.Add(this.pnlSBslik);
            this.pnlSol.Controls.Add(this.pnlUstSol);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 0);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(230, 575);
            this.pnlSol.TabIndex = 0;
            // 
            // pnlSAlt
            // 
            this.pnlSAlt.Controls.Add(this.panel1);
            this.pnlSAlt.Controls.Add(this.pnlGetir);
            this.pnlSAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSAlt.Location = new System.Drawing.Point(0, 60);
            this.pnlSAlt.Name = "pnlSAlt";
            this.pnlSAlt.Size = new System.Drawing.Size(230, 515);
            this.pnlSAlt.TabIndex = 115;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.btnAylık);
            this.panel1.Controls.Add(this.btnGunluk);
            this.panel1.Controls.Add(this.btnOzel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 515);
            this.panel1.TabIndex = 0;
            // 
            // btnAylık
            // 
            this.btnAylık.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAylık.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAylık.Location = new System.Drawing.Point(0, 171);
            this.btnAylık.Name = "btnAylık";
            this.btnAylık.Size = new System.Drawing.Size(40, 173);
            this.btnAylık.TabIndex = 58;
            this.btnAylık.Text = "AYL IK";
            this.btnAylık.UseVisualStyleBackColor = true;
            this.btnAylık.Click += new System.EventHandler(this.btnAylık_Click);
            // 
            // btnGunluk
            // 
            this.btnGunluk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGunluk.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunluk.Location = new System.Drawing.Point(0, 0);
            this.btnGunluk.Name = "btnGunluk";
            this.btnGunluk.Size = new System.Drawing.Size(40, 171);
            this.btnGunluk.TabIndex = 57;
            this.btnGunluk.Text = "GÜNLÜK";
            this.btnGunluk.UseVisualStyleBackColor = true;
            this.btnGunluk.Click += new System.EventHandler(this.btnGunluk_Click);
            // 
            // btnOzel
            // 
            this.btnOzel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOzel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOzel.Location = new System.Drawing.Point(0, 344);
            this.btnOzel.Name = "btnOzel";
            this.btnOzel.Size = new System.Drawing.Size(40, 171);
            this.btnOzel.TabIndex = 59;
            this.btnOzel.Text = "ÖZEL";
            this.btnOzel.UseVisualStyleBackColor = true;
            this.btnOzel.Click += new System.EventHandler(this.btnOzel_Click);
            // 
            // pnlGetir
            // 
            this.pnlGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.pnlGetir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGetir.Controls.Add(this.pnlGnlk);
            this.pnlGetir.Controls.Add(this.pnlAylik);
            this.pnlGetir.Controls.Add(this.pnlOzel);
            this.pnlGetir.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGetir.Location = new System.Drawing.Point(40, 0);
            this.pnlGetir.Name = "pnlGetir";
            this.pnlGetir.Size = new System.Drawing.Size(190, 515);
            this.pnlGetir.TabIndex = 100;
            // 
            // pnlGnlk
            // 
            this.pnlGnlk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.pnlGnlk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGnlk.Controls.Add(this.rbtnGVardiye3);
            this.pnlGnlk.Controls.Add(this.label3);
            this.pnlGnlk.Controls.Add(this.btnGRapor);
            this.pnlGnlk.Controls.Add(this.label12);
            this.pnlGnlk.Controls.Add(this.label13);
            this.pnlGnlk.Controls.Add(this.rbtnGVardiye1);
            this.pnlGnlk.Controls.Add(this.rbtnGVardiye2);
            this.pnlGnlk.Controls.Add(this.rbtnGVardiyeTüm);
            this.pnlGnlk.Controls.Add(this.dtpGZaman);
            this.pnlGnlk.Location = new System.Drawing.Point(1, 59);
            this.pnlGnlk.Name = "pnlGnlk";
            this.pnlGnlk.Size = new System.Drawing.Size(190, 512);
            this.pnlGnlk.TabIndex = 53;
            // 
            // rbtnGVardiye3
            // 
            this.rbtnGVardiye3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnGVardiye3.AutoSize = true;
            this.rbtnGVardiye3.BackColor = System.Drawing.Color.Transparent;
            this.rbtnGVardiye3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnGVardiye3.Location = new System.Drawing.Point(9, 282);
            this.rbtnGVardiye3.Name = "rbtnGVardiye3";
            this.rbtnGVardiye3.Size = new System.Drawing.Size(169, 22);
            this.rbtnGVardiye3.TabIndex = 99;
            this.rbtnGVardiye3.Text = "3. Vardiye (23:00-05:59)";
            this.rbtnGVardiye3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 98;
            this.label3.Text = "Vardiye Seçiniz :";
            // 
            // btnGRapor
            // 
            this.btnGRapor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGRapor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGRapor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGRapor.FlatAppearance.BorderSize = 2;
            this.btnGRapor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGRapor.ImageIndex = 0;
            this.btnGRapor.ImageList = this.ilistRapor;
            this.btnGRapor.Location = new System.Drawing.Point(120, 410);
            this.btnGRapor.Margin = new System.Windows.Forms.Padding(2);
            this.btnGRapor.Name = "btnGRapor";
            this.btnGRapor.Size = new System.Drawing.Size(40, 40);
            this.btnGRapor.TabIndex = 97;
            this.btnGRapor.UseVisualStyleBackColor = false;
            this.btnGRapor.Click += new System.EventHandler(this.btnGRapor_Click);
            // 
            // ilistRapor
            // 
            this.ilistRapor.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilistRapor.ImageStream")));
            this.ilistRapor.TransparentColor = System.Drawing.Color.Transparent;
            this.ilistRapor.Images.SetKeyName(0, "test.png");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Right;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(71, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 23);
            this.label12.TabIndex = 39;
            this.label12.Text = "Günlük Rapor";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(47, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 18);
            this.label13.TabIndex = 33;
            this.label13.Text = "Tarih Seçiniz :";
            // 
            // rbtnGVardiye1
            // 
            this.rbtnGVardiye1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnGVardiye1.AutoSize = true;
            this.rbtnGVardiye1.BackColor = System.Drawing.Color.Transparent;
            this.rbtnGVardiye1.Checked = true;
            this.rbtnGVardiye1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnGVardiye1.Location = new System.Drawing.Point(9, 229);
            this.rbtnGVardiye1.Name = "rbtnGVardiye1";
            this.rbtnGVardiye1.Size = new System.Drawing.Size(169, 22);
            this.rbtnGVardiye1.TabIndex = 34;
            this.rbtnGVardiye1.TabStop = true;
            this.rbtnGVardiye1.Text = "1. Vardiye (06:00-14:59)";
            this.rbtnGVardiye1.UseVisualStyleBackColor = false;
            // 
            // rbtnGVardiye2
            // 
            this.rbtnGVardiye2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnGVardiye2.AutoSize = true;
            this.rbtnGVardiye2.BackColor = System.Drawing.Color.Transparent;
            this.rbtnGVardiye2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnGVardiye2.Location = new System.Drawing.Point(9, 254);
            this.rbtnGVardiye2.Name = "rbtnGVardiye2";
            this.rbtnGVardiye2.Size = new System.Drawing.Size(169, 22);
            this.rbtnGVardiye2.TabIndex = 35;
            this.rbtnGVardiye2.Text = "2. Vardiye (15:00-22:59)";
            this.rbtnGVardiye2.UseVisualStyleBackColor = false;
            // 
            // rbtnGVardiyeTüm
            // 
            this.rbtnGVardiyeTüm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnGVardiyeTüm.AutoSize = true;
            this.rbtnGVardiyeTüm.BackColor = System.Drawing.Color.Transparent;
            this.rbtnGVardiyeTüm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnGVardiyeTüm.Location = new System.Drawing.Point(9, 310);
            this.rbtnGVardiyeTüm.Name = "rbtnGVardiyeTüm";
            this.rbtnGVardiyeTüm.Size = new System.Drawing.Size(78, 22);
            this.rbtnGVardiyeTüm.TabIndex = 38;
            this.rbtnGVardiyeTüm.Text = "Tüm gün";
            this.rbtnGVardiyeTüm.UseVisualStyleBackColor = false;
            // 
            // dtpGZaman
            // 
            this.dtpGZaman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpGZaman.CustomFormat = "yyyy/MM/dd";
            this.dtpGZaman.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGZaman.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGZaman.Location = new System.Drawing.Point(36, 137);
            this.dtpGZaman.Name = "dtpGZaman";
            this.dtpGZaman.Size = new System.Drawing.Size(105, 26);
            this.dtpGZaman.TabIndex = 32;
            // 
            // pnlAylik
            // 
            this.pnlAylik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.pnlAylik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAylik.Controls.Add(this.btnARapor);
            this.pnlAylik.Controls.Add(this.label10);
            this.pnlAylik.Controls.Add(this.dtpABitTarih);
            this.pnlAylik.Controls.Add(this.dtpABasTarih);
            this.pnlAylik.Controls.Add(this.label6);
            this.pnlAylik.Controls.Add(this.label5);
            this.pnlAylik.Location = new System.Drawing.Point(0, 34);
            this.pnlAylik.Name = "pnlAylik";
            this.pnlAylik.Size = new System.Drawing.Size(190, 512);
            this.pnlAylik.TabIndex = 55;
            // 
            // btnARapor
            // 
            this.btnARapor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnARapor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnARapor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnARapor.FlatAppearance.BorderSize = 2;
            this.btnARapor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnARapor.ImageIndex = 0;
            this.btnARapor.ImageList = this.ilistRapor;
            this.btnARapor.Location = new System.Drawing.Point(120, 410);
            this.btnARapor.Margin = new System.Windows.Forms.Padding(2);
            this.btnARapor.Name = "btnARapor";
            this.btnARapor.Size = new System.Drawing.Size(40, 40);
            this.btnARapor.TabIndex = 97;
            this.btnARapor.UseVisualStyleBackColor = false;
            this.btnARapor.Click += new System.EventHandler(this.btnARapor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(88, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 41;
            this.label10.Text = "Aylık Rapor";
            // 
            // dtpABitTarih
            // 
            this.dtpABitTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpABitTarih.CustomFormat = "MMMM / yyyy";
            this.dtpABitTarih.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpABitTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpABitTarih.Location = new System.Drawing.Point(14, 264);
            this.dtpABitTarih.Name = "dtpABitTarih";
            this.dtpABitTarih.Size = new System.Drawing.Size(135, 26);
            this.dtpABitTarih.TabIndex = 39;
            // 
            // dtpABasTarih
            // 
            this.dtpABasTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpABasTarih.CustomFormat = "MMMM / yyyy";
            this.dtpABasTarih.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpABasTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpABasTarih.Location = new System.Drawing.Point(15, 151);
            this.dtpABasTarih.Name = "dtpABasTarih";
            this.dtpABasTarih.Size = new System.Drawing.Size(133, 26);
            this.dtpABasTarih.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Bitiş Tarihi :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Başlangıç Tarihi :";
            // 
            // pnlOzel
            // 
            this.pnlOzel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.pnlOzel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOzel.Controls.Add(this.label2);
            this.pnlOzel.Controls.Add(this.label9);
            this.pnlOzel.Controls.Add(this.label1);
            this.pnlOzel.Controls.Add(this.btnOzelRpr);
            this.pnlOzel.Controls.Add(this.label8);
            this.pnlOzel.Controls.Add(this.label7);
            this.pnlOzel.Controls.Add(this.cmbOPlaka);
            this.pnlOzel.Controls.Add(this.dtpOBasTarih);
            this.pnlOzel.Controls.Add(this.rBtnOGunluk);
            this.pnlOzel.Controls.Add(this.cmbOBit);
            this.pnlOzel.Controls.Add(this.lblplka);
            this.pnlOzel.Controls.Add(this.cmbOBas);
            this.pnlOzel.Controls.Add(this.rBtnOAylik);
            this.pnlOzel.Controls.Add(this.label4);
            this.pnlOzel.Controls.Add(this.dtpOBitTarih);
            this.pnlOzel.Location = new System.Drawing.Point(0, 8);
            this.pnlOzel.Name = "pnlOzel";
            this.pnlOzel.Size = new System.Drawing.Size(190, 512);
            this.pnlOzel.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 99;
            this.label2.Text = "ile";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(11, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 18);
            this.label9.TabIndex = 98;
            this.label9.Text = "Seçiniz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(87, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 97;
            this.label1.Text = " Özel Rapor";
            // 
            // btnOzelRpr
            // 
            this.btnOzelRpr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOzelRpr.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOzelRpr.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOzelRpr.FlatAppearance.BorderSize = 2;
            this.btnOzelRpr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOzelRpr.ImageIndex = 0;
            this.btnOzelRpr.ImageList = this.ilistRapor;
            this.btnOzelRpr.Location = new System.Drawing.Point(120, 410);
            this.btnOzelRpr.Margin = new System.Windows.Forms.Padding(2);
            this.btnOzelRpr.Name = "btnOzelRpr";
            this.btnOzelRpr.Size = new System.Drawing.Size(40, 40);
            this.btnOzelRpr.TabIndex = 96;
            this.btnOzelRpr.UseVisualStyleBackColor = false;
            this.btnOzelRpr.Click += new System.EventHandler(this.btnOzelRpr_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 59;
            this.label8.Text = "Bitiş Tarihi :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 58;
            this.label7.Text = "Başlangıç Tarihi :";
            // 
            // cmbOPlaka
            // 
            this.cmbOPlaka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOPlaka.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOPlaka.FormattingEnabled = true;
            this.cmbOPlaka.Location = new System.Drawing.Point(25, 118);
            this.cmbOPlaka.Name = "cmbOPlaka";
            this.cmbOPlaka.Size = new System.Drawing.Size(151, 26);
            this.cmbOPlaka.TabIndex = 57;
            // 
            // dtpOBasTarih
            // 
            this.dtpOBasTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpOBasTarih.CustomFormat = "yyyy/MM/dd";
            this.dtpOBasTarih.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpOBasTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOBasTarih.Location = new System.Drawing.Point(25, 238);
            this.dtpOBasTarih.Name = "dtpOBasTarih";
            this.dtpOBasTarih.Size = new System.Drawing.Size(151, 26);
            this.dtpOBasTarih.TabIndex = 56;
            // 
            // rBtnOGunluk
            // 
            this.rBtnOGunluk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtnOGunluk.AutoSize = true;
            this.rBtnOGunluk.BackColor = System.Drawing.Color.Transparent;
            this.rBtnOGunluk.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtnOGunluk.Location = new System.Drawing.Point(107, 180);
            this.rBtnOGunluk.Name = "rBtnOGunluk";
            this.rBtnOGunluk.Size = new System.Drawing.Size(71, 22);
            this.rBtnOGunluk.TabIndex = 55;
            this.rBtnOGunluk.TabStop = true;
            this.rBtnOGunluk.Text = "Günlük";
            this.rBtnOGunluk.UseVisualStyleBackColor = false;
            this.rBtnOGunluk.CheckedChanged += new System.EventHandler(this.rBtnOGunluk_CheckedChanged);
            // 
            // cmbOBit
            // 
            this.cmbOBit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOBit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOBit.FormattingEnabled = true;
            this.cmbOBit.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00"});
            this.cmbOBit.Location = new System.Drawing.Point(116, 361);
            this.cmbOBit.Name = "cmbOBit";
            this.cmbOBit.Size = new System.Drawing.Size(60, 26);
            this.cmbOBit.TabIndex = 53;
            // 
            // lblplka
            // 
            this.lblplka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblplka.AutoSize = true;
            this.lblplka.BackColor = System.Drawing.Color.Transparent;
            this.lblplka.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblplka.Location = new System.Drawing.Point(12, 95);
            this.lblplka.Name = "lblplka";
            this.lblplka.Size = new System.Drawing.Size(69, 18);
            this.lblplka.TabIndex = 50;
            this.lblplka.Text = "Plaka No :";
            // 
            // cmbOBas
            // 
            this.cmbOBas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOBas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOBas.FormattingEnabled = true;
            this.cmbOBas.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00"});
            this.cmbOBas.Location = new System.Drawing.Point(25, 361);
            this.cmbOBas.Name = "cmbOBas";
            this.cmbOBas.Size = new System.Drawing.Size(60, 26);
            this.cmbOBas.TabIndex = 52;
            // 
            // rBtnOAylik
            // 
            this.rBtnOAylik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtnOAylik.AutoSize = true;
            this.rBtnOAylik.BackColor = System.Drawing.Color.Transparent;
            this.rBtnOAylik.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtnOAylik.Location = new System.Drawing.Point(20, 179);
            this.rBtnOAylik.Name = "rBtnOAylik";
            this.rBtnOAylik.Size = new System.Drawing.Size(57, 22);
            this.rBtnOAylik.TabIndex = 49;
            this.rBtnOAylik.TabStop = true;
            this.rBtnOAylik.Text = "Aylık";
            this.rBtnOAylik.UseVisualStyleBackColor = false;
            this.rBtnOAylik.CheckedChanged += new System.EventHandler(this.rBtnOAylik_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Saat Aralığı :";
            // 
            // dtpOBitTarih
            // 
            this.dtpOBitTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpOBitTarih.CustomFormat = "yyyy/MM/dd";
            this.dtpOBitTarih.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpOBitTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOBitTarih.Location = new System.Drawing.Point(25, 299);
            this.dtpOBitTarih.Name = "dtpOBitTarih";
            this.dtpOBitTarih.Size = new System.Drawing.Size(151, 26);
            this.dtpOBitTarih.TabIndex = 47;
            // 
            // pnlSBslik
            // 
            this.pnlSBslik.BackColor = System.Drawing.Color.Honeydew;
            this.pnlSBslik.Controls.Add(this.pictureBox5);
            this.pnlSBslik.Controls.Add(this.label11);
            this.pnlSBslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSBslik.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnlSBslik.Location = new System.Drawing.Point(0, 20);
            this.pnlSBslik.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSBslik.Name = "pnlSBslik";
            this.pnlSBslik.Size = new System.Drawing.Size(230, 40);
            this.pnlSBslik.TabIndex = 114;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(166, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(13, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "RAPOR";
            // 
            // pnlUstSol
            // 
            this.pnlUstSol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.pnlUstSol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUstSol.Location = new System.Drawing.Point(0, 0);
            this.pnlUstSol.Name = "pnlUstSol";
            this.pnlUstSol.Size = new System.Drawing.Size(230, 20);
            this.pnlUstSol.TabIndex = 111;
            // 
            // yazilimKantarDataSet
            // 
            this.yazilimKantarDataSet.DataSetName = "YazilimKantarDataSet";
            this.yazilimKantarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bSourceGunluk
            // 
            this.bSourceGunluk.DataMember = "GunlukRapor";
            this.bSourceGunluk.DataSource = this.yazilimKantarDataSet;
            // 
            // gunlukRaporTableAdapter
            // 
            this.gunlukRaporTableAdapter.ClearBeforeFill = true;
            // 
            // bSourceAylik
            // 
            this.bSourceAylik.DataMember = "AylikRapor";
            this.bSourceAylik.DataSource = this.yazilimKantarDataSet;
            // 
            // aylikRaporTableAdapter
            // 
            this.aylikRaporTableAdapter.ClearBeforeFill = true;
            // 
            // bSourceOzelG
            // 
            this.bSourceOzelG.DataMember = "OzelGRapor";
            this.bSourceOzelG.DataSource = this.yazilimKantarDataSet;
            // 
            // ozelGRaporTableAdapter
            // 
            this.ozelGRaporTableAdapter.ClearBeforeFill = true;
            // 
            // bSourceOzelA
            // 
            this.bSourceOzelA.DataMember = "OzelARapor";
            this.bSourceOzelA.DataSource = this.yazilimKantarDataSet;
            // 
            // ozelARaporTableAdapter
            // 
            this.ozelARaporTableAdapter.ClearBeforeFill = true;
            // 
            // RaporUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.Controls.Add(this.pnlAna);
            this.Controls.Add(this.pnlUst);
            this.Name = "RaporUC";
            this.Size = new System.Drawing.Size(980, 630);
            this.Load += new System.EventHandler(this.RaporUC_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlAna.ResumeLayout(false);
            this.pnlSag.ResumeLayout(false);
            this.tcBrut.ResumeLayout(false);
            this.pnlSol.ResumeLayout(false);
            this.pnlSAlt.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlGetir.ResumeLayout(false);
            this.pnlGnlk.ResumeLayout(false);
            this.pnlGnlk.PerformLayout();
            this.pnlAylik.ResumeLayout(false);
            this.pnlAylik.PerformLayout();
            this.pnlOzel.ResumeLayout(false);
            this.pnlOzel.PerformLayout();
            this.pnlSBslik.ResumeLayout(false);
            this.pnlSBslik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimKantarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceGunluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceAylik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceOzelG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceOzelA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlAna;
        private System.Windows.Forms.Panel pnlSag;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.Panel pnlUstSag;
        private System.Windows.Forms.TabControl tcBrut;
        private System.Windows.Forms.TabPage tpDaraData;
        private System.Windows.Forms.Panel pnlOzel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOzelRpr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbOPlaka;
        private System.Windows.Forms.DateTimePicker dtpOBasTarih;
        private System.Windows.Forms.RadioButton rBtnOGunluk;
        private System.Windows.Forms.ComboBox cmbOBit;
        private System.Windows.Forms.Label lblplka;
        private System.Windows.Forms.ComboBox cmbOBas;
        private System.Windows.Forms.RadioButton rBtnOAylik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOBitTarih;
        private System.Windows.Forms.Panel pnlAylik;
        private System.Windows.Forms.Button btnARapor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpABitTarih;
        private System.Windows.Forms.DateTimePicker dtpABasTarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlSAlt;
        private System.Windows.Forms.Button btnOzel;
        private System.Windows.Forms.Button btnGunluk;
        private System.Windows.Forms.Button btnAylık;
        private System.Windows.Forms.Panel pnlGnlk;
        private System.Windows.Forms.Button btnGRapor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbtnGVardiye1;
        private System.Windows.Forms.RadioButton rbtnGVardiye2;
        private System.Windows.Forms.RadioButton rbtnGVardiyeTüm;
        private System.Windows.Forms.DateTimePicker dtpGZaman;
        private System.Windows.Forms.Panel pnlSBslik;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlUstSol;
        private System.Windows.Forms.ImageList ilistRapor;
        private System.Windows.Forms.RadioButton rbtnGVardiye3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlGetir;
        private System.Windows.Forms.Panel panel1;
        private YazilimKantarDataSet yazilimKantarDataSet;
        private System.Windows.Forms.BindingSource bSourceGunluk;
        private YazilimKantarDataSetTableAdapters.GunlukRaporTableAdapter gunlukRaporTableAdapter;
        private System.Windows.Forms.BindingSource bSourceAylik;
        private YazilimKantarDataSetTableAdapters.AylikRaporTableAdapter aylikRaporTableAdapter;
        private System.Windows.Forms.BindingSource bSourceOzelG;
        private YazilimKantarDataSetTableAdapters.OzelGRaporTableAdapter ozelGRaporTableAdapter;
        private System.Windows.Forms.BindingSource bSourceOzelA;
        private YazilimKantarDataSetTableAdapters.OzelARaporTableAdapter ozelARaporTableAdapter;
    }
}
