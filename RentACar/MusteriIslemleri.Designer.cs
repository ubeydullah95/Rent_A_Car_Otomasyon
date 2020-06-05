namespace RentACar
{
    partial class MusteriIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriIslemleri));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnYeniKayit = new System.Windows.Forms.ToolStripButton();
            this.btnKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.btnGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textDogumTar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.radioSoyad = new System.Windows.Forms.RadioButton();
            this.radioAd = new System.Windows.Forms.RadioButton();
            this.radioTc = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeniKayit,
            this.btnKaydet,
            this.btnSil,
            this.btnGuncelle,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1027, 58);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            this.btnGuncelle.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 10.1F);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(130, 55);
            this.toolStripButton1.Text = "Müşteri Hareketleri";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "Seçilen Müşteriyi Güncelleyin";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textMail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textTel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textAdres);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textDogumTar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(226, 244);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri ";
            // 
            // textMail
            // 
            this.textMail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textMail.Location = new System.Drawing.Point(109, 137);
            this.textMail.Margin = new System.Windows.Forms.Padding(2);
            this.textMail.MaxLength = 2000;
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(101, 20);
            this.textMail.TabIndex = 13;
            this.textMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMail_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "E-Mail ";
            // 
            // textTel
            // 
            this.textTel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textTel.Location = new System.Drawing.Point(109, 115);
            this.textTel.Margin = new System.Windows.Forms.Padding(2);
            this.textTel.MaxLength = 11;
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(101, 20);
            this.textTel.TabIndex = 11;
            this.textTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTel_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tel No :";
            // 
            // textAdres
            // 
            this.textAdres.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textAdres.Location = new System.Drawing.Point(109, 162);
            this.textAdres.Margin = new System.Windows.Forms.Padding(2);
            this.textAdres.Multiline = true;
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(102, 78);
            this.textAdres.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 163);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Adres : ";
            // 
            // textDogumTar
            // 
            this.textDogumTar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textDogumTar.Location = new System.Drawing.Point(110, 92);
            this.textDogumTar.Margin = new System.Windows.Forms.Padding(2);
            this.textDogumTar.Name = "textDogumTar";
            this.textDogumTar.Size = new System.Drawing.Size(101, 20);
            this.textDogumTar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // textSoyad
            // 
            this.textSoyad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textSoyad.Location = new System.Drawing.Point(110, 69);
            this.textSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(101, 20);
            this.textSoyad.TabIndex = 5;
            this.textSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSoyad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyadı :";
            // 
            // textAdi
            // 
            this.textAdi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textAdi.Location = new System.Drawing.Point(110, 46);
            this.textAdi.Margin = new System.Windows.Forms.Padding(2);
            this.textAdi.Name = "textAdi";
            this.textAdi.Size = new System.Drawing.Size(101, 20);
            this.textAdi.TabIndex = 3;
            this.textAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAdi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı :";
            // 
            // textTc
            // 
            this.textTc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textTc.Location = new System.Drawing.Point(110, 24);
            this.textTc.Margin = new System.Windows.Forms.Padding(2);
            this.textTc.MaxLength = 11;
            this.textTc.Name = "textTc";
            this.textTc.Size = new System.Drawing.Size(101, 20);
            this.textTc.TabIndex = 1;
            this.textTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTc_KeyPress);
            this.textTc.Leave += new System.EventHandler(this.textTc_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(248, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(770, 358);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(761, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textArama);
            this.groupBox3.Controls.Add(this.lblArama);
            this.groupBox3.Controls.Add(this.radioSoyad);
            this.groupBox3.Controls.Add(this.radioAd);
            this.groupBox3.Controls.Add(this.radioTc);
            this.groupBox3.Location = new System.Drawing.Point(9, 309);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(226, 109);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arama Yap";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(180, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 32);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textArama
            // 
            this.textArama.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textArama.Location = new System.Drawing.Point(82, 49);
            this.textArama.Margin = new System.Windows.Forms.Padding(2);
            this.textArama.MaxLength = 11;
            this.textArama.Name = "textArama";
            this.textArama.Size = new System.Drawing.Size(135, 20);
            this.textArama.TabIndex = 4;
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Location = new System.Drawing.Point(4, 51);
            this.lblArama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(75, 13);
            this.lblArama.TabIndex = 3;
            this.lblArama.Text = "TC No Giriniz :";
            // 
            // radioSoyad
            // 
            this.radioSoyad.AutoSize = true;
            this.radioSoyad.Location = new System.Drawing.Point(121, 24);
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
            this.radioAd.Location = new System.Drawing.Point(70, 24);
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
            this.radioTc.Checked = true;
            this.radioTc.Location = new System.Drawing.Point(7, 24);
            this.radioTc.Margin = new System.Windows.Forms.Padding(2);
            this.radioTc.Name = "radioTc";
            this.radioTc.Size = new System.Drawing.Size(56, 17);
            this.radioTc.TabIndex = 0;
            this.radioTc.TabStop = true;
            this.radioTc.Text = "TC No";
            this.radioTc.UseVisualStyleBackColor = true;
            this.radioTc.CheckedChanged += new System.EventHandler(this.radioTc_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(981, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 32);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1027, 427);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MusteriIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.MusteriIslemleri_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textDogumTar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.RadioButton radioSoyad;
        private System.Windows.Forms.RadioButton radioAd;
        private System.Windows.Forms.RadioButton radioTc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}