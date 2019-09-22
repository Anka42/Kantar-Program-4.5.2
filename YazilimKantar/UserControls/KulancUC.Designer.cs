namespace YazilimKantar.UserControls
{
    partial class KulancUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KulancUC));
            this.YonTus = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwKlnci = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullncAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazilimKantarDataSet = new YazilimKantar.YazilimKantarDataSet();
            this.btnElmnBir = new System.Windows.Forms.Button();
            this.btnElmnSon = new System.Windows.Forms.Button();
            this.btnOncekiElmn = new System.Windows.Forms.Button();
            this.btnSonrakiElmn = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbYukari = new System.Windows.Forms.PictureBox();
            this.pbAsagi = new System.Windows.Forms.PictureBox();
            this.Tilk = new System.Windows.Forms.Timer(this.components);
            this.Tson = new System.Windows.Forms.Timer(this.components);
            this.TTilk = new System.Windows.Forms.Timer(this.components);
            this.TTson = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbTYukari = new System.Windows.Forms.PictureBox();
            this.pbTAsagi = new System.Windows.Forms.PictureBox();
            this.pnlKullanici = new System.Windows.Forms.Panel();
            this.btnGunceleme = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.kullaniciTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.KullaniciTableAdapter();
            this.pnlOperator = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgwOperator = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtOSifre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSonrakiElmnO = new System.Windows.Forms.Button();
            this.btnOncekiElmnO = new System.Windows.Forms.Button();
            this.btnElmnSonO = new System.Windows.Forms.Button();
            this.btnElmnBirO = new System.Windows.Forms.Button();
            this.btnKaydetme = new System.Windows.Forms.Button();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.pnlAna = new System.Windows.Forms.Panel();
            this.operatorTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.OperatorTableAdapter();
            this.cmbOprtr = new System.Windows.Forms.ComboBox();
            this.cmbKlnci = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKlnci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimKantarDataSet)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbYukari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsagi)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTYukari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTAsagi)).BeginInit();
            this.pnlKullanici.SuspendLayout();
            this.pnlOperator.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorBindingSource)).BeginInit();
            this.pnlAna.SuspendLayout();
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
            this.YonTus.Images.SetKeyName(5, "cancel.png");
            this.YonTus.Images.SetKeyName(6, "edit.png");
            this.YonTus.Images.SetKeyName(7, "magnifying-glass.png");
            this.YonTus.Images.SetKeyName(8, "back.png");
            this.YonTus.Images.SetKeyName(9, "next.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dgwKlnci);
            this.panel1.Location = new System.Drawing.Point(2, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 300);
            this.panel1.TabIndex = 171;
            // 
            // dgwKlnci
            // 
            this.dgwKlnci.AllowUserToAddRows = false;
            this.dgwKlnci.AutoGenerateColumns = false;
            this.dgwKlnci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKlnci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.kullncAdiDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn});
            this.dgwKlnci.DataSource = this.kullaniciBindingSource;
            this.dgwKlnci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwKlnci.Location = new System.Drawing.Point(0, 0);
            this.dgwKlnci.Name = "dgwKlnci";
            this.dgwKlnci.Size = new System.Drawing.Size(331, 300);
            this.dgwKlnci.TabIndex = 0;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.FillWeight = 91.37056F;
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 60;
            // 
            // kullncAdiDataGridViewTextBoxColumn
            // 
            this.kullncAdiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kullncAdiDataGridViewTextBoxColumn.DataPropertyName = "KullncAdi";
            this.kullncAdiDataGridViewTextBoxColumn.FillWeight = 104.3147F;
            this.kullncAdiDataGridViewTextBoxColumn.HeaderText = "KullncAdi";
            this.kullncAdiDataGridViewTextBoxColumn.Name = "kullncAdiDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.FillWeight = 104.3147F;
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this.yazilimKantarDataSet;
            // 
            // yazilimKantarDataSet
            // 
            this.yazilimKantarDataSet.DataSetName = "YazilimKantarDataSet";
            this.yazilimKantarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnElmnBir.Location = new System.Drawing.Point(13, 188);
            this.btnElmnBir.Margin = new System.Windows.Forms.Padding(2);
            this.btnElmnBir.Name = "btnElmnBir";
            this.btnElmnBir.Size = new System.Drawing.Size(40, 40);
            this.btnElmnBir.TabIndex = 163;
            this.btnElmnBir.UseVisualStyleBackColor = false;
            this.btnElmnBir.Click += new System.EventHandler(this.btnElmnBir_Click);
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
            this.btnElmnSon.Location = new System.Drawing.Point(229, 188);
            this.btnElmnSon.Margin = new System.Windows.Forms.Padding(2);
            this.btnElmnSon.Name = "btnElmnSon";
            this.btnElmnSon.Size = new System.Drawing.Size(40, 40);
            this.btnElmnSon.TabIndex = 166;
            this.btnElmnSon.UseVisualStyleBackColor = false;
            this.btnElmnSon.Click += new System.EventHandler(this.btnElmnSon_Click);
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
            this.btnOncekiElmn.Location = new System.Drawing.Point(67, 188);
            this.btnOncekiElmn.Margin = new System.Windows.Forms.Padding(2);
            this.btnOncekiElmn.Name = "btnOncekiElmn";
            this.btnOncekiElmn.Size = new System.Drawing.Size(40, 40);
            this.btnOncekiElmn.TabIndex = 164;
            this.btnOncekiElmn.UseVisualStyleBackColor = false;
            this.btnOncekiElmn.Click += new System.EventHandler(this.btnOncekiElmn_Click);
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
            this.btnSonrakiElmn.Location = new System.Drawing.Point(173, 188);
            this.btnSonrakiElmn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSonrakiElmn.Name = "btnSonrakiElmn";
            this.btnSonrakiElmn.Size = new System.Drawing.Size(40, 40);
            this.btnSonrakiElmn.TabIndex = 165;
            this.btnSonrakiElmn.UseVisualStyleBackColor = false;
            this.btnSonrakiElmn.Click += new System.EventHandler(this.btnSonrakiElmn_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.ImageIndex = 9;
            this.btnNext.ImageList = this.YonTus;
            this.btnNext.Location = new System.Drawing.Point(282, 188);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 167;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 162;
            this.label2.Text = "Şifre  :";
            // 
            // txtYSifre
            // 
            this.txtYSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYSifre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYSifre.Location = new System.Drawing.Point(163, 120);
            this.txtYSifre.Name = "txtYSifre";
            this.txtYSifre.Size = new System.Drawing.Size(140, 27);
            this.txtYSifre.TabIndex = 161;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 160;
            this.label1.Text = "Kullanıcı Adı  :";
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
            this.pnlUst.TabIndex = 158;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pbYukari);
            this.panel2.Controls.Add(this.pbAsagi);
            this.panel2.Location = new System.Drawing.Point(664, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 565);
            this.panel2.TabIndex = 183;
            // 
            // pbYukari
            // 
            this.pbYukari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbYukari.Image = ((System.Drawing.Image)(resources.GetObject("pbYukari.Image")));
            this.pbYukari.Location = new System.Drawing.Point(0, 190);
            this.pbYukari.Name = "pbYukari";
            this.pbYukari.Size = new System.Drawing.Size(313, 196);
            this.pbYukari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbYukari.TabIndex = 178;
            this.pbYukari.TabStop = false;
            // 
            // pbAsagi
            // 
            this.pbAsagi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAsagi.Image = ((System.Drawing.Image)(resources.GetObject("pbAsagi.Image")));
            this.pbAsagi.Location = new System.Drawing.Point(0, 190);
            this.pbAsagi.Name = "pbAsagi";
            this.pbAsagi.Size = new System.Drawing.Size(313, 196);
            this.pbAsagi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAsagi.TabIndex = 179;
            this.pbAsagi.TabStop = false;
            // 
            // Tilk
            // 
            this.Tilk.Tick += new System.EventHandler(this.Tilk_Tick);
            // 
            // Tson
            // 
            this.Tson.Tick += new System.EventHandler(this.Tson_Tick);
            // 
            // TTilk
            // 
            this.TTilk.Tick += new System.EventHandler(this.TTilk_Tick);
            // 
            // TTson
            // 
            this.TTson.Tick += new System.EventHandler(this.TTson_Tick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.pbTYukari);
            this.panel3.Controls.Add(this.pbTAsagi);
            this.panel3.Location = new System.Drawing.Point(3, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 565);
            this.panel3.TabIndex = 184;
            // 
            // pbTYukari
            // 
            this.pbTYukari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbTYukari.Image = ((System.Drawing.Image)(resources.GetObject("pbTYukari.Image")));
            this.pbTYukari.Location = new System.Drawing.Point(0, 200);
            this.pbTYukari.Name = "pbTYukari";
            this.pbTYukari.Size = new System.Drawing.Size(313, 243);
            this.pbTYukari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTYukari.TabIndex = 180;
            this.pbTYukari.TabStop = false;
            // 
            // pbTAsagi
            // 
            this.pbTAsagi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbTAsagi.Image = ((System.Drawing.Image)(resources.GetObject("pbTAsagi.Image")));
            this.pbTAsagi.Location = new System.Drawing.Point(0, 200);
            this.pbTAsagi.Name = "pbTAsagi";
            this.pbTAsagi.Size = new System.Drawing.Size(313, 243);
            this.pbTAsagi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTAsagi.TabIndex = 179;
            this.pbTAsagi.TabStop = false;
            // 
            // pnlKullanici
            // 
            this.pnlKullanici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlKullanici.Controls.Add(this.cmbKlnci);
            this.pnlKullanici.Controls.Add(this.btnGunceleme);
            this.pnlKullanici.Controls.Add(this.label5);
            this.pnlKullanici.Controls.Add(this.panel1);
            this.pnlKullanici.Controls.Add(this.label1);
            this.pnlKullanici.Controls.Add(this.txtYSifre);
            this.pnlKullanici.Controls.Add(this.label2);
            this.pnlKullanici.Controls.Add(this.btnNext);
            this.pnlKullanici.Controls.Add(this.btnSonrakiElmn);
            this.pnlKullanici.Controls.Add(this.btnOncekiElmn);
            this.pnlKullanici.Controls.Add(this.btnElmnSon);
            this.pnlKullanici.Controls.Add(this.btnElmnBir);
            this.pnlKullanici.Location = new System.Drawing.Point(0, 15);
            this.pnlKullanici.Name = "pnlKullanici";
            this.pnlKullanici.Size = new System.Drawing.Size(335, 565);
            this.pnlKullanici.TabIndex = 172;
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
            this.btnGunceleme.Location = new System.Drawing.Point(120, 188);
            this.btnGunceleme.Margin = new System.Windows.Forms.Padding(2);
            this.btnGunceleme.Name = "btnGunceleme";
            this.btnGunceleme.Size = new System.Drawing.Size(40, 40);
            this.btnGunceleme.TabIndex = 178;
            this.btnGunceleme.UseVisualStyleBackColor = false;
            this.btnGunceleme.Click += new System.EventHandler(this.btnGunceleme_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(102, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 36);
            this.label5.TabIndex = 177;
            this.label5.Text = "KULLANICI";
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // pnlOperator
            // 
            this.pnlOperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOperator.Controls.Add(this.cmbOprtr);
            this.pnlOperator.Controls.Add(this.btnBack);
            this.pnlOperator.Controls.Add(this.label6);
            this.pnlOperator.Controls.Add(this.panel5);
            this.pnlOperator.Controls.Add(this.label7);
            this.pnlOperator.Controls.Add(this.txtOSifre);
            this.pnlOperator.Controls.Add(this.label9);
            this.pnlOperator.Controls.Add(this.btnSonrakiElmnO);
            this.pnlOperator.Controls.Add(this.btnOncekiElmnO);
            this.pnlOperator.Controls.Add(this.btnElmnSonO);
            this.pnlOperator.Controls.Add(this.btnElmnBirO);
            this.pnlOperator.Controls.Add(this.btnKaydetme);
            this.pnlOperator.Controls.Add(this.btnArama);
            this.pnlOperator.Controls.Add(this.btnSilme);
            this.pnlOperator.Location = new System.Drawing.Point(0, 42);
            this.pnlOperator.Name = "pnlOperator";
            this.pnlOperator.Size = new System.Drawing.Size(335, 565);
            this.pnlOperator.TabIndex = 178;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.ImageIndex = 8;
            this.btnBack.ImageList = this.YonTus;
            this.btnBack.Location = new System.Drawing.Point(263, 148);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 178;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(102, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 36);
            this.label6.TabIndex = 177;
            this.label6.Text = "OPERATÖR";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.dgwOperator);
            this.panel5.Location = new System.Drawing.Point(2, 264);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(331, 300);
            this.panel5.TabIndex = 171;
            // 
            // dgwOperator
            // 
            this.dgwOperator.AllowUserToAddRows = false;
            this.dgwOperator.AutoGenerateColumns = false;
            this.dgwOperator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOperator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgwOperator.DataSource = this.operatorBindingSource;
            this.dgwOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwOperator.Location = new System.Drawing.Point(0, 0);
            this.dgwOperator.Name = "dgwOperator";
            this.dgwOperator.Size = new System.Drawing.Size(331, 300);
            this.dgwOperator.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 91.37056F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KullncAdi";
            this.dataGridViewTextBoxColumn2.FillWeight = 104.3147F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Operatör";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sifre";
            this.dataGridViewTextBoxColumn3.FillWeight = 104.3147F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Sifre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // operatorBindingSource
            // 
            this.operatorBindingSource.DataMember = "Operator";
            this.operatorBindingSource.DataSource = this.yazilimKantarDataSet;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(36, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 23);
            this.label7.TabIndex = 160;
            this.label7.Text = "Operatör Adı  :";
            // 
            // txtOSifre
            // 
            this.txtOSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOSifre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOSifre.Location = new System.Drawing.Point(163, 105);
            this.txtOSifre.Name = "txtOSifre";
            this.txtOSifre.Size = new System.Drawing.Size(140, 27);
            this.txtOSifre.TabIndex = 161;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(35, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 162;
            this.label9.Text = "Şifre  :";
            // 
            // btnSonrakiElmnO
            // 
            this.btnSonrakiElmnO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSonrakiElmnO.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSonrakiElmnO.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSonrakiElmnO.FlatAppearance.BorderSize = 2;
            this.btnSonrakiElmnO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSonrakiElmnO.ImageIndex = 3;
            this.btnSonrakiElmnO.ImageList = this.YonTus;
            this.btnSonrakiElmnO.Location = new System.Drawing.Point(195, 205);
            this.btnSonrakiElmnO.Margin = new System.Windows.Forms.Padding(2);
            this.btnSonrakiElmnO.Name = "btnSonrakiElmnO";
            this.btnSonrakiElmnO.Size = new System.Drawing.Size(40, 40);
            this.btnSonrakiElmnO.TabIndex = 165;
            this.btnSonrakiElmnO.UseVisualStyleBackColor = false;
            this.btnSonrakiElmnO.Click += new System.EventHandler(this.btnSonrakiElmnO_Click);
            // 
            // btnOncekiElmnO
            // 
            this.btnOncekiElmnO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOncekiElmnO.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOncekiElmnO.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOncekiElmnO.FlatAppearance.BorderSize = 2;
            this.btnOncekiElmnO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOncekiElmnO.ImageIndex = 2;
            this.btnOncekiElmnO.ImageList = this.YonTus;
            this.btnOncekiElmnO.Location = new System.Drawing.Point(129, 205);
            this.btnOncekiElmnO.Margin = new System.Windows.Forms.Padding(2);
            this.btnOncekiElmnO.Name = "btnOncekiElmnO";
            this.btnOncekiElmnO.Size = new System.Drawing.Size(40, 40);
            this.btnOncekiElmnO.TabIndex = 164;
            this.btnOncekiElmnO.UseVisualStyleBackColor = false;
            this.btnOncekiElmnO.Click += new System.EventHandler(this.btnOncekiElmnO_Click);
            // 
            // btnElmnSonO
            // 
            this.btnElmnSonO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnElmnSonO.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnElmnSonO.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElmnSonO.FlatAppearance.BorderSize = 2;
            this.btnElmnSonO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElmnSonO.ImageIndex = 1;
            this.btnElmnSonO.ImageList = this.YonTus;
            this.btnElmnSonO.Location = new System.Drawing.Point(263, 205);
            this.btnElmnSonO.Margin = new System.Windows.Forms.Padding(2);
            this.btnElmnSonO.Name = "btnElmnSonO";
            this.btnElmnSonO.Size = new System.Drawing.Size(40, 40);
            this.btnElmnSonO.TabIndex = 166;
            this.btnElmnSonO.UseVisualStyleBackColor = false;
            this.btnElmnSonO.Click += new System.EventHandler(this.btnElmnSonO_Click);
            // 
            // btnElmnBirO
            // 
            this.btnElmnBirO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnElmnBirO.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnElmnBirO.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElmnBirO.FlatAppearance.BorderSize = 2;
            this.btnElmnBirO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElmnBirO.ImageIndex = 0;
            this.btnElmnBirO.ImageList = this.YonTus;
            this.btnElmnBirO.Location = new System.Drawing.Point(60, 205);
            this.btnElmnBirO.Margin = new System.Windows.Forms.Padding(2);
            this.btnElmnBirO.Name = "btnElmnBirO";
            this.btnElmnBirO.Size = new System.Drawing.Size(40, 40);
            this.btnElmnBirO.TabIndex = 163;
            this.btnElmnBirO.UseVisualStyleBackColor = false;
            this.btnElmnBirO.Click += new System.EventHandler(this.btnElmnBirO_Click);
            // 
            // btnKaydetme
            // 
            this.btnKaydetme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKaydetme.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKaydetme.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydetme.FlatAppearance.BorderSize = 2;
            this.btnKaydetme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydetme.ImageIndex = 6;
            this.btnKaydetme.ImageList = this.YonTus;
            this.btnKaydetme.Location = new System.Drawing.Point(195, 148);
            this.btnKaydetme.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydetme.Name = "btnKaydetme";
            this.btnKaydetme.Size = new System.Drawing.Size(40, 40);
            this.btnKaydetme.TabIndex = 169;
            this.btnKaydetme.UseVisualStyleBackColor = false;
            this.btnKaydetme.Click += new System.EventHandler(this.btnKaydetme_Click);
            // 
            // btnArama
            // 
            this.btnArama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnArama.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnArama.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnArama.FlatAppearance.BorderSize = 2;
            this.btnArama.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArama.ImageIndex = 7;
            this.btnArama.ImageList = this.YonTus;
            this.btnArama.Location = new System.Drawing.Point(60, 148);
            this.btnArama.Margin = new System.Windows.Forms.Padding(2);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(40, 40);
            this.btnArama.TabIndex = 170;
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSilme.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSilme.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSilme.FlatAppearance.BorderSize = 2;
            this.btnSilme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSilme.ImageIndex = 5;
            this.btnSilme.ImageList = this.YonTus;
            this.btnSilme.Location = new System.Drawing.Point(129, 148);
            this.btnSilme.Margin = new System.Windows.Forms.Padding(2);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(40, 40);
            this.btnSilme.TabIndex = 168;
            this.btnSilme.UseVisualStyleBackColor = false;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // pnlAna
            // 
            this.pnlAna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAna.Controls.Add(this.pnlOperator);
            this.pnlAna.Controls.Add(this.pnlKullanici);
            this.pnlAna.Location = new System.Drawing.Point(323, 62);
            this.pnlAna.Name = "pnlAna";
            this.pnlAna.Size = new System.Drawing.Size(335, 565);
            this.pnlAna.TabIndex = 178;
            // 
            // operatorTableAdapter
            // 
            this.operatorTableAdapter.ClearBeforeFill = true;
            // 
            // cmbOprtr
            // 
            this.cmbOprtr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOprtr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOprtr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOprtr.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.operatorBindingSource, "KullncAdi", true));
            this.cmbOprtr.DataSource = this.operatorBindingSource;
            this.cmbOprtr.DisplayMember = "KullncAdi";
            this.cmbOprtr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cmbOprtr.FormattingEnabled = true;
            this.cmbOprtr.Location = new System.Drawing.Point(163, 71);
            this.cmbOprtr.Name = "cmbOprtr";
            this.cmbOprtr.Size = new System.Drawing.Size(140, 27);
            this.cmbOprtr.TabIndex = 185;
            this.cmbOprtr.ValueMember = "KullncAdi";
            this.cmbOprtr.SelectedIndexChanged += new System.EventHandler(this.cmbOprtr_SelectedIndexChanged);
            // 
            // cmbKlnci
            // 
            this.cmbKlnci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbKlnci.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKlnci.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKlnci.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kullaniciBindingSource, "KullncAdi", true));
            this.cmbKlnci.DataSource = this.kullaniciBindingSource;
            this.cmbKlnci.DisplayMember = "KullncAdi";
            this.cmbKlnci.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cmbKlnci.FormattingEnabled = true;
            this.cmbKlnci.Location = new System.Drawing.Point(163, 87);
            this.cmbKlnci.Name = "cmbKlnci";
            this.cmbKlnci.Size = new System.Drawing.Size(140, 27);
            this.cmbKlnci.TabIndex = 186;
            this.cmbKlnci.ValueMember = "KullncAdi";
            this.cmbKlnci.SelectedIndexChanged += new System.EventHandler(this.cmbKlnci_SelectedIndexChanged);
            // 
            // KulancUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlAna);
            this.Controls.Add(this.pnlUst);
            this.Name = "KulancUC";
            this.Size = new System.Drawing.Size(980, 630);
            this.Load += new System.EventHandler(this.KulancUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKlnci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimKantarDataSet)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbYukari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsagi)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTYukari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTAsagi)).EndInit();
            this.pnlKullanici.ResumeLayout(false);
            this.pnlKullanici.PerformLayout();
            this.pnlOperator.ResumeLayout(false);
            this.pnlOperator.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorBindingSource)).EndInit();
            this.pnlAna.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private YazilimKantarDataSet yazilimKantarDataSet;
        private System.Windows.Forms.ImageList YonTus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnElmnBir;
        private System.Windows.Forms.Button btnElmnSon;
        private System.Windows.Forms.Button btnOncekiElmn;
        private System.Windows.Forms.Button btnSonrakiElmn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.DataGridView dgwKlnci;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullncAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private YazilimKantarDataSetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbYukari;
        private System.Windows.Forms.PictureBox pbAsagi;
        private System.Windows.Forms.Timer Tilk;
        private System.Windows.Forms.Timer Tson;
        private System.Windows.Forms.Timer TTilk;
        private System.Windows.Forms.Timer TTson;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbTYukari;
        private System.Windows.Forms.PictureBox pbTAsagi;
        private System.Windows.Forms.Panel pnlKullanici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlOperator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgwOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource operatorBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOSifre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSonrakiElmnO;
        private System.Windows.Forms.Button btnOncekiElmnO;
        private System.Windows.Forms.Button btnElmnSonO;
        private System.Windows.Forms.Button btnElmnBirO;
        private System.Windows.Forms.Button btnKaydetme;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnSilme;
        private System.Windows.Forms.Panel pnlAna;
        private YazilimKantarDataSetTableAdapters.OperatorTableAdapter operatorTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGunceleme;
        private System.Windows.Forms.ComboBox cmbOprtr;
        private System.Windows.Forms.ComboBox cmbKlnci;
    }
}
