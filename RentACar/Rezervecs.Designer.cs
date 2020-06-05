namespace RentACar
{
    partial class Rezervecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezervecs));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataRezList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnArama = new System.Windows.Forms.Button();
            this.textArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.radioSoyad = new System.Windows.Forms.RadioButton();
            this.radioAd = new System.Windows.Forms.RadioButton();
            this.radioTc = new System.Windows.Forms.RadioButton();
            this.btnOnay = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnRzvIptal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRezList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(481, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataRezList);
            this.groupBox2.Location = new System.Drawing.Point(11, 131);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(460, 180);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezerve Listesi";
            // 
            // dataRezList
            // 
            this.dataRezList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRezList.Location = new System.Drawing.Point(4, 17);
            this.dataRezList.Margin = new System.Windows.Forms.Padding(2);
            this.dataRezList.Name = "dataRezList";
            this.dataRezList.RowTemplate.Height = 24;
            this.dataRezList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRezList.Size = new System.Drawing.Size(451, 158);
            this.dataRezList.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTemizle);
            this.groupBox3.Controls.Add(this.btnArama);
            this.groupBox3.Controls.Add(this.textArama);
            this.groupBox3.Controls.Add(this.lblArama);
            this.groupBox3.Controls.Add(this.radioSoyad);
            this.groupBox3.Controls.Add(this.radioAd);
            this.groupBox3.Controls.Add(this.radioTc);
            this.groupBox3.Location = new System.Drawing.Point(4, 17);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(226, 109);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arama Yap";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.BackgroundImage")));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTemizle.Location = new System.Drawing.Point(180, 72);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(37, 32);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnArama
            // 
            this.btnArama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArama.BackgroundImage")));
            this.btnArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnArama.Location = new System.Drawing.Point(136, 72);
            this.btnArama.Margin = new System.Windows.Forms.Padding(2);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(37, 32);
            this.btnArama.TabIndex = 5;
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
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
            // btnOnay
            // 
            this.btnOnay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOnay.Location = new System.Drawing.Point(376, 331);
            this.btnOnay.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(56, 34);
            this.btnOnay.TabIndex = 2;
            this.btnOnay.Text = "Onayla";
            this.btnOnay.UseVisualStyleBackColor = false;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnIptal.Location = new System.Drawing.Point(436, 331);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(56, 34);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnRzvIptal
            // 
            this.btnRzvIptal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRzvIptal.Location = new System.Drawing.Point(9, 331);
            this.btnRzvIptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnRzvIptal.Name = "btnRzvIptal";
            this.btnRzvIptal.Size = new System.Drawing.Size(56, 34);
            this.btnRzvIptal.TabIndex = 8;
            this.btnRzvIptal.Text = "Rezerve İptali";
            this.btnRzvIptal.UseVisualStyleBackColor = false;
            this.btnRzvIptal.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rezervecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 405);
            this.Controls.Add(this.btnRzvIptal);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Rezervecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezerve Onay";
            this.Load += new System.EventHandler(this.Rezervecs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRezList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataRezList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.TextBox textArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.RadioButton radioSoyad;
        private System.Windows.Forms.RadioButton radioAd;
        private System.Windows.Forms.RadioButton radioTc;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnRzvIptal;
    }
}