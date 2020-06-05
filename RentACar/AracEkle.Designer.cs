namespace RentACar
{
    partial class AracEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.textMarka = new System.Windows.Forms.TextBox();
            this.textModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSeri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka : ";
            // 
            // textMarka
            // 
            this.textMarka.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.textMarka.Location = new System.Drawing.Point(94, 25);
            this.textMarka.Margin = new System.Windows.Forms.Padding(2);
            this.textMarka.Name = "textMarka";
            this.textMarka.Size = new System.Drawing.Size(119, 23);
            this.textMarka.TabIndex = 1;
            this.textMarka.Leave += new System.EventHandler(this.textMarka_Leave);
            // 
            // textModel
            // 
            this.textModel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.textModel.Location = new System.Drawing.Point(94, 52);
            this.textModel.Margin = new System.Windows.Forms.Padding(2);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(119, 23);
            this.textModel.TabIndex = 3;
            this.textModel.Leave += new System.EventHandler(this.textModel_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model :";
            // 
            // textSeri
            // 
            this.textSeri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textSeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.textSeri.Location = new System.Drawing.Point(94, 79);
            this.textSeri.Margin = new System.Windows.Forms.Padding(2);
            this.textSeri.Name = "textSeri";
            this.textSeri.Size = new System.Drawing.Size(119, 23);
            this.textSeri.TabIndex = 5;
            this.textSeri.Leave += new System.EventHandler(this.textSeri_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.label3.Location = new System.Drawing.Point(37, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seri : ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKaydet.Location = new System.Drawing.Point(94, 106);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(56, 40);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnIptal.Location = new System.Drawing.Point(155, 106);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(56, 40);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // AracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(323, 175);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.textSeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMarka);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AracEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Marka Model Ekle";
            this.Load += new System.EventHandler(this.AracEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMarka;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}