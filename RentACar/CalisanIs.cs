using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace RentACar
{
    public partial class CalisanIs : Form
    {
        public CalisanIs()
        {
            InitializeComponent();
        }
       

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            int CALISAN_ID;
            try
            {
                CALISAN_ID = Convert.ToInt32((dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value).ToString());
                CalisanGuncelle a = new CalisanGuncelle();
                a.GelenID = CALISAN_ID;
                a.TC = (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value).ToString();
                a.ADI = (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value).ToString();
                a.SOYADI = (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value).ToString();
                a.ROL = Convert.ToInt32((dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value).ToString());
                a.KULLANICI_ADI = (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value).ToString();
                a.SIFRE = (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value).ToString();

                a.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Listeden Kayıt Seçmelisiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }
        public void temizle()
        {
            textTC.Text = "";
            textSoyadi.Text = "";
            textAdi.Text = "";
            textKullaniciAdi.Text = "";
            textSifre.Text = "";
        }
        private void CalisanIs_Load(object sender, EventArgs e)
        {
            radioTc.Checked = true;

            VeriTabani vt = new VeriTabani();

            string sorgu = "select * from CALISAN,CALISAN_BILGI where CALISAN.CALISAN_ID=CALISAN_BILGI.CALISAN_ID";
            vt.baglan(sorgu, dataGridView1, "CALISAN");
            dataGridView1.Columns[5].Visible = false;

            //toolStrip1.TabStop = false;

            
            textAdi.Focus();


        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            temizle();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (textTC.Text.Length==11)
            {
                try
                {
                    VeriTabani vt = new VeriTabani();
                    vt.CalısanEkle(textTC.Text, textAdi.Text, textSoyadi.Text, comboRol.SelectedIndex, textKullaniciAdi.Text, textSifre.Text);
                    string sorgu = "select * from CALISAN,CALISAN_BILGI where CALISAN.CALISAN_ID=CALISAN_BILGI.CALISAN_ID";
                    vt.baglan(sorgu, dataGridView1, "CALISAN");
                    dataGridView1.Columns[5].Visible = false;
                    temizle();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Bu TC Sisteme Kayıtlı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textTC.Text = "";
                    textTC.Focus();
                }
            }
            else
            {

                MessageBox.Show("Hatalı Veya Eksik TC no girişi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textTC.Focus();
            }



        }

        private void textTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           int CALISAN_ID;
           try
           {
               CALISAN_ID = Convert.ToInt32((dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value).ToString());

               DialogResult a = MessageBox.Show("Kayıt Silinecek! İşlemi onaylıyormusunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
               if (a == DialogResult.Yes)
               {
                   //messagebox da evet butonuna basılırsa sorguyu calıstıyoruz
                   VeriTabani vt = new VeriTabani();
                   vt.CalısanSil(CALISAN_ID);

                   string sorgu = "select * from CALISAN,CALISAN_BILGI where CALISAN.CALISAN_ID=CALISAN_BILGI.CALISAN_ID";
                   vt.baglan(sorgu, dataGridView1, "CALISAN");
                   dataGridView1.Columns[5].Visible = false;

               }
           }
           catch (FormatException)
           {
               MessageBox.Show("Listeden Kayıt Seçmelisiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
           
        }
        public bool tc;
        private void textTC_Leave(object sender, EventArgs e)
        {
            if (textTC.TextLength != 11 && textTC.TextLength != 0)
            {
                MessageBox.Show("TC alanı Eksik Girildi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textTC.Focus();
                tc = true;
            }
            else
                tc = false;
           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void textTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = true;//eğer rakamsa  yazdır.
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = false;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void textSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = true;//eğer rakamsa  yazdır.
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = false;//bunların dışındaysa hiçbirisini yazdırma
            }
        }
        public static int deneme = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (deneme == 1)
            {
                VeriTabani vt = new VeriTabani();
                string sorgu = "select * from CALISAN,CALISAN_BILGI where CALISAN.CALISAN_ID=CALISAN_BILGI.CALISAN_ID";
                vt.baglan(sorgu, dataGridView1, "CALISAN");
                dataGridView1.Columns[5].Visible = false;
                deneme = 0;
            }
        }

        private void radioTc_CheckedChanged(object sender, EventArgs e)
        {
            LblArama.Text = "TC No Giriniz : ";
            textArama.MaxLength = 11;
        }

        private void radioAd_CheckedChanged(object sender, EventArgs e)
        {
            LblArama.Text = "Adı Giriniz : ";
            textArama.MaxLength = 111111;
        }

        private void radioSoyad_CheckedChanged(object sender, EventArgs e)
        {
            LblArama.Text = "Soyadı Giriniz : ";
            textArama.MaxLength = 111111;
        }

        private void textArama_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioTc.Checked == true)
            {
                VeriTabani vt = new VeriTabani();
                string sorgu = "select * from CALISAN,CALISAN_BILGI where CALISAN.CALISAN_ID=CALISAN_BILGI.CALISAN_ID and CALISAN_TC like '" + textArama.Text + "'";
                vt.baglan(sorgu, dataGridView1, "CALISAN");
                dataGridView1.Columns[5].Visible = false;
            }
            else if (radioAd.Checked == true)
            {
                VeriTabani vt = new VeriTabani();
                string sorgu = "select * from CALISAN,CALISAN_BILGI where CALISAN.CALISAN_ID=CALISAN_BILGI.CALISAN_ID and ADI like '%" + textArama.Text + "%'";
                vt.baglan(sorgu, dataGridView1, "CALISAN");
                dataGridView1.Columns[5].Visible = false;
            }
            else if (radioSoyad.Checked == true)
            {
                VeriTabani vt = new VeriTabani();
                string sorgu = "select * from CALISAN,CALISAN_BILGI where CALISAN.CALISAN_ID=CALISAN_BILGI.CALISAN_ID and SOYADI like '%" + textArama.Text + "%'";
                vt.baglan(sorgu, dataGridView1, "CALISAN");
                dataGridView1.Columns[5].Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();

            string sorgu = "select * from CALISAN,CALISAN_BILGI where CALISAN.CALISAN_ID=CALISAN_BILGI.CALISAN_ID";
            vt.baglan(sorgu, dataGridView1, "CALISAN");
            dataGridView1.Columns[5].Visible = false;
            textArama.Text = "";
        }



    }
}
