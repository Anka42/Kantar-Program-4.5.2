namespace YazilimKantar.UserControls
{
    partial class EkleUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EkleUC));
            this.pnlUst = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbxSecim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVeri = new System.Windows.Forms.TextBox();
            this.lblSGösterge = new System.Windows.Forms.Label();
            this.YonTus = new System.Windows.Forms.ImageList(this.components);
            this.btnKaydetme = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnElmnBir = new System.Windows.Forms.Button();
            this.btnElmnSon = new System.Windows.Forms.Button();
            this.btnOncekiElmn = new System.Windows.Forms.Button();
            this.btnSonrakiElmn = new System.Windows.Forms.Button();
            this.btnGunceleme = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwNot = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaNotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazilimKantarDataSet = new YazilimKantar.YazilimKantarDataSet();
            this.dgwMalzeme = new System.Windows.Forms.DataGridView();
            this.kaMalzemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgwFirma = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaFirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgwGFirma = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gFirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaGFirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaFirmaTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.KaFirmaTableAdapter();
            this.pbTAsagi = new System.Windows.Forms.PictureBox();
            this.Tilk = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbYukari = new System.Windows.Forms.PictureBox();
            this.pbAsagi = new System.Windows.Forms.PictureBox();
            this.Tson = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbTYukari = new System.Windows.Forms.PictureBox();
            this.TTilk = new System.Windows.Forms.Timer(this.components);
            this.TTson = new System.Windows.Forms.Timer(this.components);
            this.kaGFirmaTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.KaGFirmaTableAdapter();
            this.kaMalzemeTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.KaMalzemeTableAdapter();
            this.kaNotTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.KaNotTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ıdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malzeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaNotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimKantarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMalzeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaMalzemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaFirmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaGFirmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTAsagi)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbYukari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsagi)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTYukari)).BeginInit();
            this.SuspendLayout();
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
            this.pnlUst.TabIndex = 105;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbxSecim
            // 
            this.cmbxSecim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbxSecim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbxSecim.FormattingEnabled = true;
            this.cmbxSecim.Items.AddRange(new object[] {
            "FİRMA ADI",
            "GİTTİĞİ FİRMA ADI",
            "MALZEME ADI",
            "AÇIKLAMA (NOT)"});
            this.cmbxSecim.Location = new System.Drawing.Point(500, 77);
            this.cmbxSecim.Name = "cmbxSecim";
            this.cmbxSecim.Size = new System.Drawing.Size(160, 27);
            this.cmbxSecim.TabIndex = 106;
            this.cmbxSecim.SelectedIndexChanged += new System.EventHandler(this.cmbxSecim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(318, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 107;
            this.label1.Text = "SEÇİNİZ  ";
            // 
            // txtVeri
            // 
            this.txtVeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeri.Location = new System.Drawing.Point(500, 121);
            this.txtVeri.Name = "txtVeri";
            this.txtVeri.Size = new System.Drawing.Size(160, 27);
            this.txtVeri.TabIndex = 108;
            // 
            // lblSGösterge
            // 
            this.lblSGösterge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSGösterge.AutoSize = true;
            this.lblSGösterge.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSGösterge.Location = new System.Drawing.Point(317, 125);
            this.lblSGösterge.Name = "lblSGösterge";
            this.lblSGösterge.Size = new System.Drawing.Size(177, 23);
            this.lblSGösterge.TabIndex = 109;
            this.lblSGösterge.Text = "SEÇİM BEKLENİYOR...";
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
            this.btnKaydetme.Location = new System.Drawing.Point(581, 164);
            this.btnKaydetme.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydetme.Name = "btnKaydetme";
            this.btnKaydetme.Size = new System.Drawing.Size(40, 40);
            this.btnKaydetme.TabIndex = 155;
            this.btnKaydetme.UseVisualStyleBackColor = false;
            this.btnKaydetme.Click += new System.EventHandler(this.btnKaydetme_Click);
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
            this.btnSilme.Location = new System.Drawing.Point(518, 164);
            this.btnSilme.Margin = new System.Windows.Forms.Padding(2);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(40, 40);
            this.btnSilme.TabIndex = 154;
            this.btnSilme.UseVisualStyleBackColor = false;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
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
            this.btnArama.Location = new System.Drawing.Point(458, 164);
            this.btnArama.Margin = new System.Windows.Forms.Padding(2);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(40, 40);
            this.btnArama.TabIndex = 156;
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
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
            this.btnElmnBir.Location = new System.Drawing.Point(394, 217);
            this.btnElmnBir.Margin = new System.Windows.Forms.Padding(2);
            this.btnElmnBir.Name = "btnElmnBir";
            this.btnElmnBir.Size = new System.Drawing.Size(40, 40);
            this.btnElmnBir.TabIndex = 149;
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
            this.btnElmnSon.Location = new System.Drawing.Point(581, 217);
            this.btnElmnSon.Margin = new System.Windows.Forms.Padding(2);
            this.btnElmnSon.Name = "btnElmnSon";
            this.btnElmnSon.Size = new System.Drawing.Size(40, 40);
            this.btnElmnSon.TabIndex = 152;
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
            this.btnOncekiElmn.Location = new System.Drawing.Point(457, 217);
            this.btnOncekiElmn.Margin = new System.Windows.Forms.Padding(2);
            this.btnOncekiElmn.Name = "btnOncekiElmn";
            this.btnOncekiElmn.Size = new System.Drawing.Size(40, 40);
            this.btnOncekiElmn.TabIndex = 150;
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
            this.btnSonrakiElmn.Location = new System.Drawing.Point(518, 217);
            this.btnSonrakiElmn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSonrakiElmn.Name = "btnSonrakiElmn";
            this.btnSonrakiElmn.Size = new System.Drawing.Size(40, 40);
            this.btnSonrakiElmn.TabIndex = 151;
            this.btnSonrakiElmn.UseVisualStyleBackColor = false;
            this.btnSonrakiElmn.Click += new System.EventHandler(this.btnSonrakiElmn_Click);
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
            this.btnGunceleme.Location = new System.Drawing.Point(396, 164);
            this.btnGunceleme.Margin = new System.Windows.Forms.Padding(2);
            this.btnGunceleme.Name = "btnGunceleme";
            this.btnGunceleme.Size = new System.Drawing.Size(40, 40);
            this.btnGunceleme.TabIndex = 153;
            this.btnGunceleme.UseVisualStyleBackColor = false;
            this.btnGunceleme.Click += new System.EventHandler(this.btnGunceleme_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dgwNot);
            this.panel1.Controls.Add(this.dgwMalzeme);
            this.panel1.Controls.Add(this.dgwFirma);
            this.panel1.Controls.Add(this.dgwGFirma);
            this.panel1.Location = new System.Drawing.Point(321, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 360);
            this.panel1.TabIndex = 157;
            // 
            // dgwNot
            // 
            this.dgwNot.AllowUserToAddRows = false;
            this.dgwNot.AutoGenerateColumns = false;
            this.dgwNot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn2,
            this.notDataGridViewTextBoxColumn});
            this.dgwNot.DataSource = this.kaNotBindingSource;
            this.dgwNot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwNot.Location = new System.Drawing.Point(0, 0);
            this.dgwNot.Name = "dgwNot";
            this.dgwNot.Size = new System.Drawing.Size(339, 360);
            this.dgwNot.TabIndex = 4;
            // 
            // ıdDataGridViewTextBoxColumn2
            // 
            this.ıdDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ıdDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.ıdDataGridViewTextBoxColumn2.Name = "ıdDataGridViewTextBoxColumn2";
            this.ıdDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // notDataGridViewTextBoxColumn
            // 
            this.notDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notDataGridViewTextBoxColumn.DataPropertyName = "Not";
            this.notDataGridViewTextBoxColumn.HeaderText = "Açıklama (Not)";
            this.notDataGridViewTextBoxColumn.Name = "notDataGridViewTextBoxColumn";
            // 
            // kaNotBindingSource
            // 
            this.kaNotBindingSource.DataMember = "KaNot";
            this.kaNotBindingSource.DataSource = this.yazilimKantarDataSet;
            // 
            // yazilimKantarDataSet
            // 
            this.yazilimKantarDataSet.DataSetName = "YazilimKantarDataSet";
            this.yazilimKantarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgwMalzeme
            // 
            this.dgwMalzeme.AllowUserToAddRows = false;
            this.dgwMalzeme.AutoGenerateColumns = false;
            this.dgwMalzeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMalzeme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn1,
            this.Malzeme});
            this.dgwMalzeme.DataSource = this.kaMalzemeBindingSource;
            this.dgwMalzeme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwMalzeme.Location = new System.Drawing.Point(0, 0);
            this.dgwMalzeme.Name = "dgwMalzeme";
            this.dgwMalzeme.Size = new System.Drawing.Size(339, 360);
            this.dgwMalzeme.TabIndex = 3;
            // 
            // kaMalzemeBindingSource
            // 
            this.kaMalzemeBindingSource.DataMember = "KaMalzeme";
            this.kaMalzemeBindingSource.DataSource = this.yazilimKantarDataSet;
            // 
            // dgwFirma
            // 
            this.dgwFirma.AllowUserToAddRows = false;
            this.dgwFirma.AutoGenerateColumns = false;
            this.dgwFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFirma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Firma});
            this.dgwFirma.DataSource = this.kaFirmaBindingSource;
            this.dgwFirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwFirma.Location = new System.Drawing.Point(0, 0);
            this.dgwFirma.Name = "dgwFirma";
            this.dgwFirma.Size = new System.Drawing.Size(339, 360);
            this.dgwFirma.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Firma
            // 
            this.Firma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Firma.DataPropertyName = "Firma";
            this.Firma.HeaderText = "Firma Adı";
            this.Firma.Name = "Firma";
            // 
            // kaFirmaBindingSource
            // 
            this.kaFirmaBindingSource.DataMember = "KaFirma";
            this.kaFirmaBindingSource.DataSource = this.yazilimKantarDataSet;
            // 
            // dgwGFirma
            // 
            this.dgwGFirma.AllowUserToAddRows = false;
            this.dgwGFirma.AutoGenerateColumns = false;
            this.dgwGFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGFirma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.gFirmaDataGridViewTextBoxColumn});
            this.dgwGFirma.DataSource = this.kaGFirmaBindingSource;
            this.dgwGFirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwGFirma.Location = new System.Drawing.Point(0, 0);
            this.dgwGFirma.Name = "dgwGFirma";
            this.dgwGFirma.Size = new System.Drawing.Size(339, 360);
            this.dgwGFirma.TabIndex = 1;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gFirmaDataGridViewTextBoxColumn
            // 
            this.gFirmaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gFirmaDataGridViewTextBoxColumn.DataPropertyName = "GFirma";
            this.gFirmaDataGridViewTextBoxColumn.HeaderText = "Gittiği Firma Adı";
            this.gFirmaDataGridViewTextBoxColumn.Name = "gFirmaDataGridViewTextBoxColumn";
            // 
            // kaGFirmaBindingSource
            // 
            this.kaGFirmaBindingSource.DataMember = "KaGFirma";
            this.kaGFirmaBindingSource.DataSource = this.yazilimKantarDataSet;
            // 
            // kaFirmaTableAdapter
            // 
            this.kaFirmaTableAdapter.ClearBeforeFill = true;
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
            // Tilk
            // 
            this.Tilk.Tick += new System.EventHandler(this.Tilk_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pbYukari);
            this.panel2.Controls.Add(this.pbAsagi);
            this.panel2.Location = new System.Drawing.Point(664, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 565);
            this.panel2.TabIndex = 181;
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
            // Tson
            // 
            this.Tson.Tick += new System.EventHandler(this.Tson_Tick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.pbTYukari);
            this.panel3.Controls.Add(this.pbTAsagi);
            this.panel3.Location = new System.Drawing.Point(3, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 565);
            this.panel3.TabIndex = 182;
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
            // TTilk
            // 
            this.TTilk.Tick += new System.EventHandler(this.TTilk_Tick);
            // 
            // TTson
            // 
            this.TTson.Tick += new System.EventHandler(this.TTson_Tick);
            // 
            // kaGFirmaTableAdapter
            // 
            this.kaGFirmaTableAdapter.ClearBeforeFill = true;
            // 
            // kaMalzemeTableAdapter
            // 
            this.kaMalzemeTableAdapter.ClearBeforeFill = true;
            // 
            // kaNotTableAdapter
            // 
            this.kaNotTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ıdDataGridViewTextBoxColumn1
            // 
            this.ıdDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ıdDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.ıdDataGridViewTextBoxColumn1.Name = "ıdDataGridViewTextBoxColumn1";
            this.ıdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Malzeme
            // 
            this.Malzeme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Malzeme.DataPropertyName = "Malzeme";
            this.Malzeme.HeaderText = "Malzeme Adı";
            this.Malzeme.Name = "Malzeme";
            // 
            // EkleUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKaydetme);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnElmnBir);
            this.Controls.Add(this.btnElmnSon);
            this.Controls.Add(this.btnOncekiElmn);
            this.Controls.Add(this.btnSonrakiElmn);
            this.Controls.Add(this.btnGunceleme);
            this.Controls.Add(this.lblSGösterge);
            this.Controls.Add(this.txtVeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxSecim);
            this.Controls.Add(this.pnlUst);
            this.Name = "EkleUC";
            this.Size = new System.Drawing.Size(980, 630);
            this.Load += new System.EventHandler(this.EkleUC_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaNotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimKantarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMalzeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaMalzemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaFirmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaGFirmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTAsagi)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbYukari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsagi)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTYukari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbxSecim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVeri;
        private System.Windows.Forms.Label lblSGösterge;
        private System.Windows.Forms.ImageList YonTus;
        private System.Windows.Forms.Button btnKaydetme;
        private System.Windows.Forms.Button btnSilme;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnElmnBir;
        private System.Windows.Forms.Button btnElmnSon;
        private System.Windows.Forms.Button btnOncekiElmn;
        private System.Windows.Forms.Button btnSonrakiElmn;
        private System.Windows.Forms.Button btnGunceleme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource kaFirmaBindingSource;
        private YazilimKantarDataSet yazilimKantarDataSet;
        private YazilimKantarDataSetTableAdapters.KaFirmaTableAdapter kaFirmaTableAdapter;
        private System.Windows.Forms.PictureBox pbTAsagi;
        private System.Windows.Forms.Timer Tilk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbYukari;
        private System.Windows.Forms.PictureBox pbAsagi;
        private System.Windows.Forms.Timer Tson;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbTYukari;
        private System.Windows.Forms.Timer TTilk;
        private System.Windows.Forms.Timer TTson;
        private System.Windows.Forms.DataGridView dgwGFirma;
        private System.Windows.Forms.DataGridView dgwMalzeme;
        private System.Windows.Forms.DataGridView dgwFirma;
        private System.Windows.Forms.BindingSource kaGFirmaBindingSource;
        private YazilimKantarDataSetTableAdapters.KaGFirmaTableAdapter kaGFirmaTableAdapter;
        private System.Windows.Forms.DataGridView dgwNot;
        private System.Windows.Forms.BindingSource kaNotBindingSource;
        private System.Windows.Forms.BindingSource kaMalzemeBindingSource;
        private YazilimKantarDataSetTableAdapters.KaMalzemeTableAdapter kaMalzemeTableAdapter;
        private YazilimKantarDataSetTableAdapters.KaNotTableAdapter kaNotTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn notDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gFirmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malzeme;
    }
}
