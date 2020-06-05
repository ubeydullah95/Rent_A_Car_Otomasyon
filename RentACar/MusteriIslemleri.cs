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
    public partial class MusteriIslemleri : Form
    {
        public MusteriIslemleri()
        {
            InitializeComponent();
        }
        private bool tc;
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            int MUSTERI_ID;
            try
            {
                timer1.Enabled = true;
                 MUSTERI_ID = Convert.ToInt32((dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value).ToString());
                 MusteriGuncelle a = new MusteriGuncelle();
                 a.Gelen_ID = MUSTERI_ID;
                 a.Show();
            }
            catch(FormatException)
            {
                MessageBox.Show("Listeden Kayıt Seçmelisiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
        public void TumListe()
        {

            string sorgu = "select * from MUSTERI";
            VeriTabani vt = new VeriTabani();
            vt.baglan(sorgu, dataGridView1, "MUSTERI");
        }
        public void Temizle()
        {
            textTc.Text = "";
            textAdi.Text = "";
            textSoyad.Text = "";
            textTel.Text = "";
            textMail.Text = "";
            textDogumTar.Text = "";
            textAdres.Text = "";
        }

        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from MUSTERI";
            VeriTabani vt = new VeriTabani();
            vt.baglan(sorgu, dataGridView1, "MUSTERI");
            toolTip1.SetToolTip(textDogumTar, "Doğum Tarihini dd.mm.yyy Şeklinde Giriniz");
            
            //Sonradan Uğraşılır
           // dataGridView1.Columns[1].HeaderText = "TC";

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            Temizle();

        }

        private void textTc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textTc_Leave(object sender, EventArgs e)
        {
            if (textTc.TextLength != 11 && textTc.TextLength != 0)
            {
                MessageBox.Show("TC alanı Eksik Girildi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textTc.Focus();
                tc = false;
            }
            else
                tc = true;
        }

        private void textAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = true;//eğer rakamsa  yazdırma.
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

        private void textSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = true;//eğer rakamsa  yazdırma.
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = false;//bunların dışındaysa hiçbirisini yazdır
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();
            if (tc && textTc.Text.Length==11)
            {
                try
                {
                    vt.MusteriEkle(textTc.Text, textAdi.Text, textSoyad.Text, Convert.ToDateTime(textDogumTar.Text), textAdres.Text, textTel.Text, textMail.Text, false);
                    Temizle();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hatalı Doğum Tarihi Girişi Yaptınız.\n 'dd/mm/yyyy' şeklinde Yapınız. ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textDogumTar.Focus();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Bu TC Sisteme Kayıtlı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textTc.Text = "";
                    textTc.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hatalı Doğum Tarihi Girişi Yaptınız.\n 'dd/mm/yyyy' şeklinde Yapınız. ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textDogumTar.Focus();
                }
                TumListe();
                
            }
            else
            {
                MessageBox.Show("Hatalı Veya Eksik TC no girişi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textTc.Focus();
            
            }

            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int MUSTERI_ID;
                MUSTERI_ID = Convert.ToInt32((dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value).ToString());
                DialogResult a = MessageBox.Show("Kayıt Silinecek! İşlemi onaylıyormusunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (a == DialogResult.Yes)
                {
                    //messagebox da evet butonuna basılırsa sorguyu calıstıyoruz
                    VeriTabani vt = new VeriTabani();
                    vt.MusteriSil(MUSTERI_ID);
                    TumListe();

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Listeden Kayıt Seçmelisiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        public static int deneme = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (deneme == 1)
            {
                TumListe();
                deneme = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TumListe();
            textArama.Text = "";
        }

        private void radioTc_CheckedChanged(object sender, EventArgs e)
        {
            lblArama.Text = "TC No Giriniz : ";
            textArama.MaxLength = 11;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioAd_CheckedChanged(object sender, EventArgs e)
        {
            lblArama.Text = "Adı Giriniz : ";
            textArama.MaxLength = 11111;
        }

        private void radioSoyad_CheckedChanged(object sender, EventArgs e)
        {
            lblArama.Text = "Soyadı Giriniz : ";
            textArama.MaxLength = 11111;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioTc.Checked == true)
            {
                VeriTabani vt = new VeriTabani();
                string sorgu = "select * from MUSTERI where TC_NO like '" + textArama.Text + "'";
                vt.baglan(sorgu, dataGridView1, "MUSTERI");
               
            }
            else if (radioAd.Checked == true)
            {
                VeriTabani vt = new VeriTabani();
                string sorgu = "select * from MUSTERI where ADI like '%" + textArama.Text + "%'";
                
                vt.baglan(sorgu, dataGridView1, "MUSTERI");
             
            }
            else if (radioSoyad.Checked == true)
            {
                VeriTabani vt = new VeriTabani();
                string sorgu = "select * from MUSTERI where SOYADI like '%" + textArama.Text + "%'";
                vt.baglan(sorgu, dataGridView1, "MUSTERI");
            }
        }

        private void textMail_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textTel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int MUSTERI_ID;
            try
            {
                DataSet ds = new DataSet();
                MUSTERI_ID = Convert.ToInt32((dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value).ToString());
                string sorgu = "select M.TC_NO,A.PLAKA_NO,MA.MARKA_ADI,MO.MODEL,SE.SERI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KIRA_TOPLAM_TUTAR from ARABALAR A,KIRALAMA_EMRI K,MUSTERI M,MARKALAR MA,MODEL MO,SERI SE where A.ARABA_ID=K.ARABA_ID and K.MUSTERI_ID=M.MUSTERI_ID and MA.MARKA_ID=A.MARKA_ID and MO.MODEL_ID=A.MODEL_ID and SE.SERI_ID=A.SERI_ID and M.MUSTERI_ID=" + MUSTERI_ID;
                VeriTabani vt = new VeriTabani();
                ds = vt.SorguCekDataSetGonder(sorgu, "MUSTERI");
                if (ds.Tables[0].Rows.Count > 0)
                {

                    vt.ExcellDoldur(ds, "MUSTERI");
                }
                else
                {
                    MessageBox.Show("Seçilen Müşteri Hareketi Bulunmamaktadır !!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            
            }
            catch (FormatException)
            {
                MessageBox.Show("Listeden Kayıt Seçmelisiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
