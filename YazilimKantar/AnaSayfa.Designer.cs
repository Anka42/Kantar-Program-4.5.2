namespace YazilimKantar
{
    partial class AnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlSMIAnaSayfa = new System.Windows.Forms.ToolStripMenuItem();
            this.tlSMITartm = new System.Windows.Forms.ToolStripMenuItem();
            this.tlSMIArac = new System.Windows.Forms.ToolStripMenuItem();
            this.tlSMIRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.tlMIFs = new System.Windows.Forms.ToolStripMenuItem();
            this.tlMISabt = new System.Windows.Forms.ToolStripMenuItem();
            this.tlMIKulanclar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlSMIEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tlMIAyar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.anaSayfaUC1 = new YazilimKantar.UserControls.AnaSayfaUC();
            this.aracUC1 = new YazilimKantar.UserControls.AracUC();
            this.tartımUc1 = new YazilimKantar.UserControls.TartımUc();
            this.ayarUC1 = new YazilimKantar.UserControls.AyarUC();
            this.fisUC1 = new YazilimKantar.UserControls.FisUC();
            this.kulancUC1 = new YazilimKantar.UserControls.KulancUC();
            this.raporUC1 = new YazilimKantar.UserControls.RaporUC();
            this.sabitUC1 = new YazilimKantar.UserControls.SabitUC();
            this.aracListesiTableAdapter1 = new YazilimKantar.YazilimKantarDataSetTableAdapters.AracListesiTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlSMIAnaSayfa,
            this.tlSMITartm,
            this.tlSMIArac,
            this.tlSMIRapor,
            this.tlMIFs,
            this.tlMISabt,
            this.tlMIKulanclar,
            this.tlSMIEkle,
            this.tlMIAyar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tlSMIAnaSayfa
            // 
            this.tlSMIAnaSayfa.BackColor = System.Drawing.Color.Transparent;
            this.tlSMIAnaSayfa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tlSMIAnaSayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlSMIAnaSayfa.Name = "tlSMIAnaSayfa";
            this.tlSMIAnaSayfa.Size = new System.Drawing.Size(89, 23);
            this.tlSMIAnaSayfa.Text = "Ana Sayfa";
            this.tlSMIAnaSayfa.Click += new System.EventHandler(this.tlSMIAnaSayfa_Click);
            // 
            // tlSMITartm
            // 
            this.tlSMITartm.BackColor = System.Drawing.Color.Transparent;
            this.tlSMITartm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tlSMITartm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlSMITartm.Name = "tlSMITartm";
            this.tlSMITartm.Size = new System.Drawing.Size(64, 23);
            this.tlSMITartm.Text = "Tartım";
            this.tlSMITartm.Click += new System.EventHandler(this.tlSMITartm_Click);
            // 
            // tlSMIArac
            // 
            this.tlSMIArac.BackColor = System.Drawing.Color.Transparent;
            this.tlSMIArac.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tlSMIArac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlSMIArac.Name = "tlSMIArac";
            this.tlSMIArac.Size = new System.Drawing.Size(97, 23);
            this.tlSMIArac.Text = "Araç Listesi";
            this.tlSMIArac.Click += new System.EventHandler(this.tlSMIArac_Click);
            // 
            // tlSMIRapor
            // 
            this.tlSMIRapor.BackColor = System.Drawing.Color.Transparent;
            this.tlSMIRapor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tlSMIRapor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlSMIRapor.Name = "tlSMIRapor";
            this.tlSMIRapor.Size = new System.Drawing.Size(80, 23);
            this.tlSMIRapor.Text = "Raporlar";
            this.tlSMIRapor.Click += new System.EventHandler(this.tlSMIRapor_Click);
            // 
            // tlMIFs
            // 
            this.tlMIFs.BackColor = System.Drawing.Color.Transparent;
            this.tlMIFs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tlMIFs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlMIFs.Name = "tlMIFs";
            this.tlMIFs.Size = new System.Drawing.Size(103, 23);
            this.tlMIFs.Text = "Fiş Yazdırma";
            this.tlMIFs.Click += new System.EventHandler(this.tlMIFs_Click);
            // 
            // tlMISabt
            // 
            this.tlMISabt.BackColor = System.Drawing.Color.Transparent;
            this.tlMISabt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tlMISabt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlMISabt.Name = "tlMISabt";
            this.tlMISabt.Size = new System.Drawing.Size(92, 23);
            this.tlMISabt.Text = "Sabit Dara";
            this.tlMISabt.Click += new System.EventHandler(this.tlMISabt_Click);
            // 
            // tlMIKulanclar
            // 
            this.tlMIKulanclar.BackColor = System.Drawing.Color.Transparent;
            this.tlMIKulanclar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tlMIKulanclar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlMIKulanclar.Name = "tlMIKulanclar";
            this.tlMIKulanclar.Size = new System.Drawing.Size(97, 23);
            this.tlMIKulanclar.Text = "Kullanıcılar";
            this.tlMIKulanclar.Click += new System.EventHandler(this.tlMIKulanclar_Click);
            // 
            // tlSMIEkle
            // 
            this.tlSMIEkle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tlSMIEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlSMIEkle.Name = "tlSMIEkle";
            this.tlSMIEkle.Size = new System.Drawing.Size(49, 23);
            this.tlSMIEkle.Text = "Ekle";
            this.tlSMIEkle.Click += new System.EventHandler(this.tlSMIEkle_Click);
            // 
            // tlMIAyar
            // 
            this.tlMIAyar.BackColor = System.Drawing.Color.Transparent;
            this.tlMIAyar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tlMIAyar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlMIAyar.Name = "tlMIAyar";
            this.tlMIAyar.Size = new System.Drawing.Size(71, 23);
            this.tlMIAyar.Text = "Ayarlar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 632);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(980, 632);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // anaSayfaUC1
            // 
            this.anaSayfaUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.anaSayfaUC1.Location = new System.Drawing.Point(0, 32);
            this.anaSayfaUC1.Name = "anaSayfaUC1";
            this.anaSayfaUC1.Size = new System.Drawing.Size(900, 550);
            this.anaSayfaUC1.TabIndex = 1;
            // 
            // aracUC1
            // 
            this.aracUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.aracUC1.Location = new System.Drawing.Point(0, 32);
            this.aracUC1.Name = "aracUC1";
            this.aracUC1.Size = new System.Drawing.Size(900, 550);
            this.aracUC1.TabIndex = 2;
            // 
            // tartımUc1
            // 
            this.tartımUc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.tartımUc1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tartımUc1.BackgroundImage")));
            this.tartımUc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tartımUc1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tartımUc1.Location = new System.Drawing.Point(0, 32);
            this.tartımUc1.Name = "tartımUc1";
            this.tartımUc1.Size = new System.Drawing.Size(554, 407);
            this.tartımUc1.TabIndex = 3;
            // 
            // ayarUC1
            // 
            this.ayarUC1.Location = new System.Drawing.Point(0, 32);
            this.ayarUC1.Name = "ayarUC1";
            this.ayarUC1.Size = new System.Drawing.Size(900, 550);
            this.ayarUC1.TabIndex = 4;
            // 
            // fisUC1
            // 
            this.fisUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.fisUC1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.fisUC1.Location = new System.Drawing.Point(0, 32);
            this.fisUC1.Name = "fisUC1";
            this.fisUC1.Size = new System.Drawing.Size(900, 550);
            this.fisUC1.TabIndex = 6;
            // 
            // kulancUC1
            // 
            this.kulancUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.kulancUC1.Location = new System.Drawing.Point(0, 32);
            this.kulancUC1.Name = "kulancUC1";
            this.kulancUC1.Size = new System.Drawing.Size(900, 550);
            this.kulancUC1.TabIndex = 7;
            // 
            // raporUC1
            // 
            this.raporUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.raporUC1.Location = new System.Drawing.Point(0, 32);
            this.raporUC1.Name = "raporUC1";
            this.raporUC1.Size = new System.Drawing.Size(900, 550);
            this.raporUC1.TabIndex = 8;
            // 
            // sabitUC1
            // 
            this.sabitUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.sabitUC1.Location = new System.Drawing.Point(0, 32);
            this.sabitUC1.Name = "sabitUC1";
            this.sabitUC1.Size = new System.Drawing.Size(900, 550);
            this.sabitUC1.TabIndex = 9;
            // 
            // aracListesiTableAdapter1
            // 
            this.aracListesiTableAdapter1.ClearBeforeFill = true;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaSayfa";
            this.Text = "Kantar Programı 4.5.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlSMIAnaSayfa;
        private System.Windows.Forms.ToolStripMenuItem tlSMITartm;
        private System.Windows.Forms.ToolStripMenuItem tlSMIArac;
        private System.Windows.Forms.ToolStripMenuItem tlSMIRapor;
        private System.Windows.Forms.ToolStripMenuItem tlMIFs;
        private System.Windows.Forms.ToolStripMenuItem tlMISabt;
        private System.Windows.Forms.ToolStripMenuItem tlMIKulanclar;
        private System.Windows.Forms.ToolStripMenuItem tlMIAyar;
        private UserControls.AnaSayfaUC anaSayfaUC1;
        private UserControls.AracUC aracUC1;
        private UserControls.TartımUc tartımUc1;
        private UserControls.AyarUC ayarUC1;
        private UserControls.FisUC fisUC1;
        private UserControls.KulancUC kulancUC1;
        private UserControls.RaporUC raporUC1;
        private UserControls.SabitUC sabitUC1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem tlSMIEkle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private YazilimKantarDataSetTableAdapters.AracListesiTableAdapter aracListesiTableAdapter1;
    }
}