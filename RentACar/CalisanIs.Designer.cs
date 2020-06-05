namespace RentACar
{
    partial class CalisanIs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanIs));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnYeniKayit = new System.Windows.Forms.ToolStripButton();
            this.btnKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.btnGuncelle = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.textArama = new System.Windows.Forms.TextBox();
            this.LblArama = new System.Windows.Forms.Label();
            this.radioSoyad = new System.Windows.Forms.RadioButton();
            this.radioAd = new System.Windows.Forms.RadioButton();
            this.radioTc = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeniKayit,
            this.btnKaydet,
            this.btnSil,
            this.btnGuncelle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 58);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Font = new System.Drawing.Font("Segoe UI", 10.1F);
            this.btnYeniKayit.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniKayit.Image")));
            this.btnYeniKayit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnYeniKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(72, 55);
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnYeniKayit.ToolTipText = "Yeni Kayıt İçin textleri Temizleyin.";
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10.1F);
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(55, 55);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKaydet.ToolTipText = "Müşteriyi Kaydetmek İçin Tıklayın";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 10.1F);
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(58, 55);
            this.btnSil.Text = "    Sil    ";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSil.ToolTipText = "Seçilen Müşterinin Kaydını Silin";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 10.1F);
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(65, 55);
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuncelle.ToolTipText = "Seçilen Müşteriyi Güncelleyin";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textSifre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textKullaniciAdi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboRol);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textSoyadi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(215, 188);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışan Bilgileri";
            // 
            // textSifre
            // 
            this.textSifre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textSifre.Location = new System.Drawing.Point(116, 137);
            this.textSifre.Margin = new System.Windows.Forms.Padding(2);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(92, 20);
            this.textSifre.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Şifre :";
            // 
            // textKullaniciAdi
            // 
            this.textKullaniciAdi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textKullaniciAdi.Location = new System.Drawing.Point(116, 115);
            this.textKullaniciAdi.Margin = new System.Windows.Forms.Padding(2);
            this.textKullaniciAdi.Name = "textKullaniciAdi";
            this.textKullaniciAdi.Size = new System.Drawing.Size(92, 20);
            this.textKullaniciAdi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kullanıcı Adı :";
            // 
            // comboRol
            // 
            this.comboRol.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Items.AddRange(new object[] {
            "ADMIN",
            "CALISAN"});
            this.comboRol.Location = new System.Drawing.Point(116, 90);
            this.comboRol.Margin = new System.Windows.Forms.Padding(2);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(92, 21);
            this.comboRol.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rol :";
            // 
            // textSoyadi
            // 
            this.textSoyadi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textSoyadi.Location = new System.Drawing.Point(116, 67);
            this.textSoyadi.Margin = new System.Windows.Forms.Padding(2);
            this.textSoyadi.Name = "textSoyadi";
            this.textSoyadi.Size = new System.Drawing.Size(92, 20);
            this.textSoyadi.TabIndex = 5;
            this.textSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSoyadi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyadı :";
            // 
            // textAdi
            // 
            this.textAdi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textAdi.Location = new System.Drawing.Point(116, 45);
            this.textAdi.Margin = new System.Windows.Forms.Padding(2);
            this.textAdi.Name = "textAdi";
            this.textAdi.Size = new System.Drawing.Size(92, 20);
            this.textAdi.TabIndex = 3;
            this.textAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAdi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı :";
            // 
            // textTC
            // 
            this.textTC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textTC.Location = new System.Drawing.Point(116, 22);
            this.textTC.Margin = new System.Windows.Forms.Padding(2);
            this.textTC.MaxLength = 11;
            this.textTC.Name = "textTC";
            this.textTC.Size = new System.Drawing.Size(92, 20);
            this.textTC.TabIndex = 1;
            this.textTC.TextChanged += new System.EventHandler(this.textTC_TextChanged);
            this.textTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTC_KeyPress);
            this.textTC.Leave += new System.EventHandler(this.textTC_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnArama);
            this.groupBox3.Controls.Add(this.textArama);
            this.groupBox3.Controls.Add(this.LblArama);
            this.groupBox3.Controls.Add(this.radioSoyad);
            this.groupBox3.Controls.Add(this.radioAd);
            this.groupBox3.Controls.Add(this.radioTc);
            this.groupBox3.Location = new System.Drawing.Point(9, 260);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(215, 116);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arama Yap";
            // 
            // btnArama
            // 
            this.btnArama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArama.BackgroundImage")));
            this.btnArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnArama.Location = new System.Drawing.Point(164, 72);
            this.btnArama.Margin = new System.Windows.Forms.Padding(2);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(43, 40);
            this.btnArama.TabIndex = 5;
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.button1_Click);
            // 
            // textArama
            // 
            this.textArama.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textArama.Location = new System.Drawing.Point(116, 49);
            this.textArama.Margin = new System.Windows.Forms.Padding(2);
            this.textArama.Name = "textArama";
            this.textArama.Size = new System.Drawing.Size(92, 20);
            this.textArama.TabIndex = 4;
            this.textArama.TextChanged += new System.EventHandler(this.textArama_TextChanged);
            // 
            // LblArama
            // 
            this.LblArama.AutoSize = true;
            this.LblArama.Location = new System.Drawing.Point(4, 51);
            this.LblArama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblArama.Name = "LblArama";
            this.LblArama.Size = new System.Drawing.Size(72, 13);
            this.LblArama.TabIndex = 3;
            this.LblArama.Text = "Arama Kriteri: ";
            // 
            // radioSoyad
            // 
            this.radioSoyad.AutoSize = true;
            this.radioSoyad.Location = new System.Drawing.Point(116, 27);
            this.radioSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.radioSoyad.Name = "radioSoyad";
            this.radioSoyad.Size = new System.Drawing.Size(55, 17);
            this.radioSoyad.TabIndex = 2;
            this.radioSoyad.TabStop = true;
            this.radioSoyad.Text = "Soyad";
            this.radioSoyad.UseVisualStyleBackColor = true;
            this.radioSoyad.CheckedChanged += new System.EventHandler(this.radioSoyad_CheckedChanged);
            // 
            // radioAd
            // 
            this.radioAd.AutoSize = true;
            this.radioAd.Location = new System.Drawing.Point(66, 27);
            this.radioAd.Margin = new System.Windows.Forms.Padding(2);
            this.radioAd.Name = "radioAd";
            this.radioAd.Size = new System.Drawing.Size(38, 17);
            this.radioAd.TabIndex = 1;
            this.radioAd.TabStop = true;
            this.radioAd.Text = "Ad";
            this.radioAd.UseVisualStyleBackColor = true;
            this.radioAd.CheckedChanged += new System.EventHandler(this.radioAd_CheckedChanged);
            // 
            // radioTc
            // 
            this.radioTc.AutoSize = true;
            this.radioTc.Location = new System.Drawing.Point(2, 27);
            this.radioTc.Margin = new System.Windows.Forms.Padding(2);
            this.radioTc.Name = "radioTc";
            this.radioTc.Size = new System.Drawing.Size(56, 17);
            this.radioTc.TabIndex = 0;
            this.radioTc.TabStop = true;
            this.radioTc.Text = "TC No";
            this.radioTc.UseVisualStyleBackColor = true;
            this.radioTc.CheckedChanged += new System.EventHandler(this.radioTc_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(229, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(605, 305);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çalışan Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(596, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(784, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 28);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CalisanIs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CalisanIs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan İşlemleri";
            this.Load += new System.EventHandler(this.CalisanIs_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnYeniKayit;
        private System.Windows.Forms.ToolStripButton btnKaydet;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripButton btnGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textKullaniciAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textArama;
        private System.Windows.Forms.Label LblArama;
        private System.Windows.Forms.RadioButton radioSoyad;
        private System.Windows.Forms.RadioButton radioAd;
        private System.Windows.Forms.RadioButton radioTc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button button1;
    }
}