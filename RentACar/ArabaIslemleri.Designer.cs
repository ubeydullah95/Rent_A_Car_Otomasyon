namespace RentACar
{
    partial class ArabaIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArabaIslemleri));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnYeniKayit = new System.Windows.Forms.ToolStripButton();
            this.BtnKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.btnGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.BtnArama = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TextArama = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextPlakaNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSeri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboYakıt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboVites = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboKasaTip = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboCekis = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboRenk = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textKiloMetre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textUcret = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnYeniKayit,
            this.BtnKaydet,
            this.btnSil,
            this.btnGuncelle,
            this.toolStripButton1,
            this.BtnArama,
            this.toolStripLabel1,
            this.TextArama});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(907, 58);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // BtnYeniKayit
            // 
            this.BtnYeniKayit.Font = new System.Drawing.Font("Segoe UI", 10.1F);
            this.BtnYeniKayit.Image = ((System.Drawing.Image)(resources.GetObject("BtnYeniKayit.Image")));
            this.BtnYeniKayit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnYeniKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnYeniKayit.Name = "BtnYeniKayit";
            this.BtnYeniKayit.Size = new System.Drawing.Size(72, 55);
            this.BtnYeniKayit.Text = "Yeni Kayıt";
            this.BtnYeniKayit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnYeniKayit.ToolTipText = "Yeni Kayıt İçin textleri Temizleyin.";
            this.BtnYeniKayit.Click += new System.EventHandler(this.BtnYeniKayit_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Segoe UI", 10.1F);
            this.BtnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.Image")));
            this.BtnKaydet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(55, 55);
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnKaydet.ToolTipText = "Araba Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
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
            this.btnSil.ToolTipText = "Seçilen Arabanın Kaydını Silin";
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
            this.btnGuncelle.ToolTipText = "Seçilen Arabayı Güncelleyin";
            this.btnGuncelle.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 10.1F);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(79, 55);
            this.toolStripButton1.Text = "Arama Yap";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "Aramak İstediğiniz Aracın Plakasını Giriniz";
            // 
            // BtnArama
            // 
            this.BtnArama.Font = new System.Drawing.Font("Segoe UI", 10.1F);
            this.BtnArama.Image = ((System.Drawing.Image)(resources.GetObject("BtnArama.Image")));
            this.BtnArama.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnArama.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnArama.Name = "BtnArama";
            this.BtnArama.Size = new System.Drawing.Size(110, 55);
            this.BtnArama.Text = "Araç Hareketleri";
            this.BtnArama.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnArama.ToolTipText = "Aramak İstediğiniz Aracın Plakasını Giriniz";
            this.BtnArama.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 55);
            this.toolStripLabel1.Text = "Plaka No :";
            // 
            // TextArama
            // 
            this.TextArama.Name = "TextArama";
            this.TextArama.Size = new System.Drawing.Size(76, 58);
            this.TextArama.Leave += new System.EventHandler(this.toolStripTextBox1_Leave);
            this.TextArama.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            this.TextArama.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaka NO : ";
            // 
            // TextPlakaNo
            // 
            this.TextPlakaNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextPlakaNo.Location = new System.Drawing.Point(101, 20);
            this.TextPlakaNo.Margin = new System.Windows.Forms.Padding(2);
            this.TextPlakaNo.Name = "TextPlakaNo";
            this.TextPlakaNo.Size = new System.Drawing.Size(134, 20);
            this.TextPlakaNo.TabIndex = 2;
            this.TextPlakaNo.Leave += new System.EventHandler(this.TextPlakaNo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marka : ";
            // 
            // comboMarka
            // 
            this.comboMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(101, 45);
            this.comboMarka.Margin = new System.Windows.Forms.Padding(2);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(134, 21);
            this.comboMarka.TabIndex = 4;
            this.comboMarka.SelectedIndexChanged += new System.EventHandler(this.comboMarka_SelectedIndexChanged);
            // 
            // comboModel
            // 
            this.comboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(101, 70);
            this.comboModel.Margin = new System.Windows.Forms.Padding(2);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(134, 21);
            this.comboModel.TabIndex = 6;
            this.comboModel.SelectedIndexChanged += new System.EventHandler(this.comboModel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model : ";
            // 
            // comboSeri
            // 
            this.comboSeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeri.FormattingEnabled = true;
            this.comboSeri.Location = new System.Drawing.Point(101, 97);
            this.comboSeri.Margin = new System.Windows.Forms.Padding(2);
            this.comboSeri.Name = "comboSeri";
            this.comboSeri.Size = new System.Drawing.Size(134, 21);
            this.comboSeri.TabIndex = 8;
            this.comboSeri.SelectedIndexChanged += new System.EventHandler(this.comboSeri_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seri : ";
            // 
            // comboYakıt
            // 
            this.comboYakıt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYakıt.FormattingEnabled = true;
            this.comboYakıt.Items.AddRange(new object[] {
            "DİZEL",
            "BENZİN",
            "BENZİN&LPG",
            "ELEKTRİK",
            "HYBRID"});
            this.comboYakıt.Location = new System.Drawing.Point(101, 121);
            this.comboYakıt.Margin = new System.Windows.Forms.Padding(2);
            this.comboYakıt.Name = "comboYakıt";
            this.comboYakıt.Size = new System.Drawing.Size(134, 21);
            this.comboYakıt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yakıt :";
            // 
            // comboVites
            // 
            this.comboVites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVites.FormattingEnabled = true;
            this.comboVites.Items.AddRange(new object[] {
            "MANUEL",
            "OTOMATİK"});
            this.comboVites.Location = new System.Drawing.Point(101, 145);
            this.comboVites.Margin = new System.Windows.Forms.Padding(2);
            this.comboVites.Name = "comboVites";
            this.comboVites.Size = new System.Drawing.Size(134, 21);
            this.comboVites.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vites :";
            // 
            // comboKasaTip
            // 
            this.comboKasaTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKasaTip.FormattingEnabled = true;
            this.comboKasaTip.Items.AddRange(new object[] {
            "Sedan",
            "Station Wagon",
            "Coupe",
            "Cabrio",
            "Hatchback 3 Kapı",
            "Hatchback 5 Kapı"});
            this.comboKasaTip.Location = new System.Drawing.Point(101, 170);
            this.comboKasaTip.Margin = new System.Windows.Forms.Padding(2);
            this.comboKasaTip.Name = "comboKasaTip";
            this.comboKasaTip.Size = new System.Drawing.Size(134, 21);
            this.comboKasaTip.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kasa Tipi ";
            // 
            // comboCekis
            // 
            this.comboCekis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCekis.FormattingEnabled = true;
            this.comboCekis.Items.AddRange(new object[] {
            "Önden Çekiş",
            "Arkadan İtiş",
            "4 WD (Sürekli)",
            "4 WD Elektronik"});
            this.comboCekis.Location = new System.Drawing.Point(101, 194);
            this.comboCekis.Margin = new System.Windows.Forms.Padding(2);
            this.comboCekis.Name = "comboCekis";
            this.comboCekis.Size = new System.Drawing.Size(134, 21);
            this.comboCekis.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 200);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Çekiş : ";
            // 
            // comboRenk
            // 
            this.comboRenk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRenk.FormattingEnabled = true;
            this.comboRenk.Items.AddRange(new object[] {
            "Bej",
            "Beyaz",
            "Bordo",
            "Füme",
            "Gri",
            "Kahverengi",
            "Kırmızı",
            "Mavi",
            "Mor",
            "Sarı",
            "Siyah",
            "Turuncu",
            "Yeşil"});
            this.comboRenk.Location = new System.Drawing.Point(101, 219);
            this.comboRenk.Margin = new System.Windows.Forms.Padding(2);
            this.comboRenk.Name = "comboRenk";
            this.comboRenk.Size = new System.Drawing.Size(134, 21);
            this.comboRenk.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Renk :";
            // 
            // textKiloMetre
            // 
            this.textKiloMetre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textKiloMetre.Location = new System.Drawing.Point(139, 245);
            this.textKiloMetre.Margin = new System.Windows.Forms.Padding(2);
            this.textKiloMetre.Name = "textKiloMetre";
            this.textKiloMetre.Size = new System.Drawing.Size(96, 20);
            this.textKiloMetre.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 247);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Kilometre :";
            // 
            // textUcret
            // 
            this.textUcret.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textUcret.Location = new System.Drawing.Point(139, 269);
            this.textUcret.Margin = new System.Windows.Forms.Padding(2);
            this.textUcret.Name = "textUcret";
            this.textUcret.Size = new System.Drawing.Size(96, 20);
            this.textUcret.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 271);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Günlük Ücret :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textUcret);
            this.groupBox1.Controls.Add(this.TextPlakaNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textKiloMetre);
            this.groupBox1.Controls.Add(this.comboMarka);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboRenk);
            this.groupBox1.Controls.Add(this.comboModel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboCekis);
            this.groupBox1.Controls.Add(this.comboSeri);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboKasaTip);
            this.groupBox1.Controls.Add(this.comboYakıt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboVites);
            this.groupBox1.Location = new System.Drawing.Point(9, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(244, 321);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(257, 67);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(640, 321);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(632, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(846, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 32);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ArabaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(907, 398);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ArabaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araba İşlemleri";
            this.Load += new System.EventHandler(this.ArabaIslemleri_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripButton BtnYeniKayit;
        private System.Windows.Forms.ToolStripButton BtnKaydet;
        private System.Windows.Forms.ToolStripButton BtnArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextPlakaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboYakıt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboVites;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboKasaTip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboCekis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboRenk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textKiloMetre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textUcret;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton btnGuncelle;
        private System.Windows.Forms.ToolStripTextBox TextArama;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}