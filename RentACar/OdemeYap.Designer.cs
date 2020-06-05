namespace RentACar
{
    partial class OdemeYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeYap));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textTc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOnay = new System.Windows.Forms.Label();
            this.comboOdemeSekli = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeTeslimTar = new System.Windows.Forms.DateTimePicker();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.textTopTutar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textAlisTar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSonuc = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDurum);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textTc);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(347, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorgula";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.Red;
            this.lblDurum.Location = new System.Drawing.Point(8, 75);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(270, 17);
            this.lblDurum.TabIndex = 4;
            this.lblDurum.Text = "Böyle bir Kayıt Yok Bilgileri Kontrol Ediniz.";
            this.lblDurum.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(103, 24);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Plaka No ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 24);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tc Kimlik No:";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc Kimlik No :";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(287, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textTc
            // 
            this.textTc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textTc.Location = new System.Drawing.Point(90, 50);
            this.textTc.Margin = new System.Windows.Forms.Padding(2);
            this.textTc.MaxLength = 11;
            this.textTc.Name = "textTc";
            this.textTc.Size = new System.Drawing.Size(120, 20);
            this.textTc.TabIndex = 1;
            this.textTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTc_KeyPress);
            this.textTc.Leave += new System.EventHandler(this.textTc_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOnay);
            this.groupBox1.Controls.Add(this.comboOdemeSekli);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimeTeslimTar);
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.textTopTutar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textAlisTar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textSonuc);
            this.groupBox1.Controls.Add(this.lblSonuc);
            this.groupBox1.Controls.Add(this.textSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(347, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kira Bilgileri";
            // 
            // lblOnay
            // 
            this.lblOnay.AutoSize = true;
            this.lblOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOnay.ForeColor = System.Drawing.Color.Red;
            this.lblOnay.Location = new System.Drawing.Point(4, 142);
            this.lblOnay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOnay.Name = "lblOnay";
            this.lblOnay.Size = new System.Drawing.Size(218, 17);
            this.lblOnay.TabIndex = 5;
            this.lblOnay.Text = "Ödeme İşleminiz Tamamlanmıştır.";
            this.lblOnay.Visible = false;
            // 
            // comboOdemeSekli
            // 
            this.comboOdemeSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOdemeSekli.FormattingEnabled = true;
            this.comboOdemeSekli.Items.AddRange(new object[] {
            "NAKİT",
            "KREDİ"});
            this.comboOdemeSekli.Location = new System.Drawing.Point(255, 50);
            this.comboOdemeSekli.Name = "comboOdemeSekli";
            this.comboOdemeSekli.Size = new System.Drawing.Size(76, 21);
            this.comboOdemeSekli.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Odeme Şekli";
            // 
            // dateTimeTeslimTar
            // 
            this.dateTimeTeslimTar.Enabled = false;
            this.dateTimeTeslimTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTeslimTar.Location = new System.Drawing.Point(88, 112);
            this.dateTimeTeslimTar.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeTeslimTar.Name = "dateTimeTeslimTar";
            this.dateTimeTeslimTar.Size = new System.Drawing.Size(76, 20);
            this.dateTimeTeslimTar.TabIndex = 18;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnIptal.Location = new System.Drawing.Point(275, 173);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(56, 41);
            this.btnIptal.TabIndex = 17;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKaydet.Location = new System.Drawing.Point(214, 173);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(56, 41);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Ödeme Yap";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // textTopTutar
            // 
            this.textTopTutar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textTopTutar.Enabled = false;
            this.textTopTutar.Location = new System.Drawing.Point(255, 24);
            this.textTopTutar.Margin = new System.Windows.Forms.Padding(2);
            this.textTopTutar.Name = "textTopTutar";
            this.textTopTutar.Size = new System.Drawing.Size(76, 20);
            this.textTopTutar.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Toplam Tutar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teslim Tarihi :";
            // 
            // textAlisTar
            // 
            this.textAlisTar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textAlisTar.Enabled = false;
            this.textAlisTar.Location = new System.Drawing.Point(88, 91);
            this.textAlisTar.Margin = new System.Windows.Forms.Padding(2);
            this.textAlisTar.Name = "textAlisTar";
            this.textAlisTar.Size = new System.Drawing.Size(76, 20);
            this.textAlisTar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alıs Tarihi :";
            // 
            // textSonuc
            // 
            this.textSonuc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textSonuc.Enabled = false;
            this.textSonuc.Location = new System.Drawing.Point(88, 23);
            this.textSonuc.Margin = new System.Windows.Forms.Padding(2);
            this.textSonuc.Name = "textSonuc";
            this.textSonuc.Size = new System.Drawing.Size(76, 20);
            this.textSonuc.TabIndex = 5;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(4, 27);
            this.lblSonuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(57, 13);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "Plaka No :";
            // 
            // textSoyad
            // 
            this.textSoyad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textSoyad.Enabled = false;
            this.textSoyad.Location = new System.Drawing.Point(88, 68);
            this.textSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(76, 20);
            this.textSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müsteri Soyad :";
            // 
            // textAd
            // 
            this.textAd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textAd.Enabled = false;
            this.textAd.Location = new System.Drawing.Point(88, 46);
            this.textAd.Margin = new System.Windows.Forms.Padding(2);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(76, 20);
            this.textAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müsteri Adı :";
            // 
            // OdemeYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(377, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OdemeYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kira Odeme Yap";
            this.Load += new System.EventHandler(this.OdemeYap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textTc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeTeslimTar;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox textTopTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAlisTar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSonuc;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboOdemeSekli;
        private System.Windows.Forms.Label lblOnay;
    }
}