namespace RentACar
{
    partial class AracSorguları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracSorguları));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkplaka = new System.Windows.Forms.CheckBox();
            this.checkMarka = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboSeri = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.checkTarih = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeBas = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnAracArama = new System.Windows.Forms.Button();
            this.TextPlakaArama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox5.Controls.Add(this.checkplaka);
            this.groupBox5.Controls.Add(this.checkMarka);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.checkTarih);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Location = new System.Drawing.Point(9, 10);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(470, 363);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Araçlar";
            // 
            // checkplaka
            // 
            this.checkplaka.AutoSize = true;
            this.checkplaka.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkplaka.Location = new System.Drawing.Point(9, 21);
            this.checkplaka.Margin = new System.Windows.Forms.Padding(2);
            this.checkplaka.Name = "checkplaka";
            this.checkplaka.Size = new System.Drawing.Size(77, 17);
            this.checkplaka.TabIndex = 15;
            this.checkplaka.Text = "Plaka Aktif";
            this.checkplaka.UseVisualStyleBackColor = false;
            this.checkplaka.CheckedChanged += new System.EventHandler(this.checkplaka_CheckedChanged);
            // 
            // checkMarka
            // 
            this.checkMarka.AutoSize = true;
            this.checkMarka.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkMarka.Location = new System.Drawing.Point(9, 157);
            this.checkMarka.Margin = new System.Windows.Forms.Padding(2);
            this.checkMarka.Name = "checkMarka";
            this.checkMarka.Size = new System.Drawing.Size(88, 17);
            this.checkMarka.TabIndex = 14;
            this.checkMarka.Text = "Marka Model";
            this.checkMarka.UseVisualStyleBackColor = false;
            this.checkMarka.CheckedChanged += new System.EventHandler(this.checkMarka_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboSeri);
            this.groupBox2.Controls.Add(this.comboMarka);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboModel);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(9, 179);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(445, 106);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marka Model Seri Ekle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Markalar:";
            // 
            // comboSeri
            // 
            this.comboSeri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboSeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeri.FormattingEnabled = true;
            this.comboSeri.Location = new System.Drawing.Point(78, 81);
            this.comboSeri.Margin = new System.Windows.Forms.Padding(2);
            this.comboSeri.Name = "comboSeri";
            this.comboSeri.Size = new System.Drawing.Size(92, 21);
            this.comboSeri.TabIndex = 13;
            this.comboSeri.SelectedIndexChanged += new System.EventHandler(this.comboSeri_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(78, 30);
            this.comboMarka.Margin = new System.Windows.Forms.Padding(2);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(92, 21);
            this.comboMarka.TabIndex = 9;
            this.comboMarka.SelectedIndexChanged += new System.EventHandler(this.comboMarka_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seri :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Model :";
            // 
            // comboModel
            // 
            this.comboModel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(78, 57);
            this.comboModel.Margin = new System.Windows.Forms.Padding(2);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(92, 21);
            this.comboModel.TabIndex = 11;
            this.comboModel.SelectedIndexChanged += new System.EventHandler(this.comboModel_SelectedIndexChanged);
            // 
            // checkTarih
            // 
            this.checkTarih.AutoSize = true;
            this.checkTarih.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkTarih.Location = new System.Drawing.Point(9, 289);
            this.checkTarih.Margin = new System.Windows.Forms.Padding(2);
            this.checkTarih.Name = "checkTarih";
            this.checkTarih.Size = new System.Drawing.Size(80, 17);
            this.checkTarih.TabIndex = 4;
            this.checkTarih.Text = "Tarih Aktif :";
            this.checkTarih.UseVisualStyleBackColor = false;
            this.checkTarih.CheckedChanged += new System.EventHandler(this.checkTarih_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeBitis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimeBas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(9, 311);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(445, 47);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitis.Location = new System.Drawing.Point(237, 14);
            this.dateTimeBitis.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(83, 20);
            this.dateTimeBitis.TabIndex = 3;
            this.dateTimeBitis.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş :";
            // 
            // dateTimeBas
            // 
            this.dateTimeBas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBas.Location = new System.Drawing.Point(67, 14);
            this.dateTimeBas.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeBas.Name = "dateTimeBas";
            this.dateTimeBas.Size = new System.Drawing.Size(83, 20);
            this.dateTimeBas.TabIndex = 1;
            this.dateTimeBas.ValueChanged += new System.EventHandler(this.dateTimeBas_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç :";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblDurum);
            this.groupBox7.Controls.Add(this.btnAracArama);
            this.groupBox7.Controls.Add(this.TextPlakaArama);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(9, 43);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(452, 109);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Plaka No";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.Red;
            this.lblDurum.Location = new System.Drawing.Point(9, 82);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(270, 17);
            this.lblDurum.TabIndex = 14;
            this.lblDurum.Text = "Böyle bir Kayıt Yok Bilgileri Kontrol Ediniz.";
            this.lblDurum.Visible = false;
            // 
            // btnAracArama
            // 
            this.btnAracArama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAracArama.BackgroundImage")));
            this.btnAracArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAracArama.Location = new System.Drawing.Point(180, 41);
            this.btnAracArama.Margin = new System.Windows.Forms.Padding(2);
            this.btnAracArama.Name = "btnAracArama";
            this.btnAracArama.Size = new System.Drawing.Size(37, 32);
            this.btnAracArama.TabIndex = 5;
            this.btnAracArama.UseVisualStyleBackColor = true;
            this.btnAracArama.Click += new System.EventHandler(this.btnAracArama_Click);
            // 
            // TextPlakaArama
            // 
            this.TextPlakaArama.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextPlakaArama.Location = new System.Drawing.Point(97, 18);
            this.TextPlakaArama.Margin = new System.Windows.Forms.Padding(2);
            this.TextPlakaArama.MaxLength = 11;
            this.TextPlakaArama.Name = "TextPlakaArama";
            this.TextPlakaArama.Size = new System.Drawing.Size(121, 20);
            this.TextPlakaArama.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plaka No Giriniz :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(364, 378);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(424, 378);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AracSorguları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 428);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AracSorguları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arac Sorguları";
            this.Load += new System.EventHandler(this.AracSorguları_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboSeri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAracArama;
        private System.Windows.Forms.TextBox TextPlakaArama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeBas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.CheckBox checkTarih;
        private System.Windows.Forms.CheckBox checkMarka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkplaka;
    }
}