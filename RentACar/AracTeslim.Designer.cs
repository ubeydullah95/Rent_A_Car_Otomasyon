namespace RentACar
{
    partial class AracTeslim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracTeslim));
            this.label1 = new System.Windows.Forms.Label();
            this.textTc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeTeslimTar = new System.Windows.Forms.DateTimePicker();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.textKmFark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textKmEnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textTopTutar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textKmStart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textAlisTar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSonuc = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // textTc
            // 
            this.textTc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textTc.Location = new System.Drawing.Point(90, 50);
            this.textTc.Margin = new System.Windows.Forms.Padding(2);
            this.textTc.MaxLength = 11;
            this.textTc.Name = "textTc";
            this.textTc.Size = new System.Drawing.Size(120, 20);
            this.textTc.TabIndex = 1;
            this.textTc.TextChanged += new System.EventHandler(this.textTc_TextChanged);
            this.textTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTc_KeyPress);
            this.textTc.Leave += new System.EventHandler(this.textTc_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeTeslimTar);
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.textKmFark);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textKmEnd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textTopTutar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textKmStart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textAlisTar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textSonuc);
            this.groupBox1.Controls.Add(this.lblSonuc);
            this.groupBox1.Controls.Add(this.textSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(362, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kira Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimeTeslimTar
            // 
            this.dateTimeTeslimTar.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimeTeslimTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTeslimTar.Location = new System.Drawing.Point(88, 112);
            this.dateTimeTeslimTar.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeTeslimTar.Name = "dateTimeTeslimTar";
            this.dateTimeTeslimTar.Size = new System.Drawing.Size(76, 20);
            this.dateTimeTeslimTar.TabIndex = 18;
            this.dateTimeTeslimTar.ValueChanged += new System.EventHandler(this.dateTimeTeslimTar_ValueChanged);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnIptal.Location = new System.Drawing.Point(274, 150);
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
            this.btnKaydet.Location = new System.Drawing.Point(213, 150);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(56, 41);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // textKmFark
            // 
            this.textKmFark.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textKmFark.Enabled = false;
            this.textKmFark.Location = new System.Drawing.Point(255, 89);
            this.textKmFark.Margin = new System.Windows.Forms.Padding(2);
            this.textKmFark.Name = "textKmFark";
            this.textKmFark.Size = new System.Drawing.Size(76, 20);
            this.textKmFark.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Km Fark :";
            // 
            // textKmEnd
            // 
            this.textKmEnd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textKmEnd.Location = new System.Drawing.Point(255, 67);
            this.textKmEnd.Margin = new System.Windows.Forms.Padding(2);
            this.textKmEnd.Name = "textKmEnd";
            this.textKmEnd.Size = new System.Drawing.Size(76, 20);
            this.textKmEnd.TabIndex = 13;
            this.textKmEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textKmEnd_KeyPress);
            this.textKmEnd.Leave += new System.EventHandler(this.textKmEnd_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Km End :";
            // 
            // textTopTutar
            // 
            this.textTopTutar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textTopTutar.Enabled = false;
            this.textTopTutar.Location = new System.Drawing.Point(255, 44);
            this.textTopTutar.Margin = new System.Windows.Forms.Padding(2);
            this.textTopTutar.Name = "textTopTutar";
            this.textTopTutar.Size = new System.Drawing.Size(76, 20);
            this.textTopTutar.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Toplam Tutar :";
            // 
            // textKmStart
            // 
            this.textKmStart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textKmStart.Enabled = false;
            this.textKmStart.Location = new System.Drawing.Point(255, 23);
            this.textKmStart.Margin = new System.Windows.Forms.Padding(2);
            this.textKmStart.Name = "textKmStart";
            this.textKmStart.Size = new System.Drawing.Size(76, 20);
            this.textKmStart.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Km Start :";
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
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(274, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDurum);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textTc);
            this.groupBox2.Location = new System.Drawing.Point(9, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(362, 100);
            this.groupBox2.TabIndex = 1;
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
            // AracTeslim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 319);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AracTeslim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Teslim Alma";
            this.Load += new System.EventHandler(this.AracTeslim_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textTopTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textKmStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAlisTar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSonuc;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.DateTimePicker dateTimeTeslimTar;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox textKmFark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textKmEnd;
        private System.Windows.Forms.Label label8;
    }
}