using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class CalisanGuncelle : Form
    {
        public int GelenID,ROL;
        public string TC;
        public string ADI, SOYADI, KULLANICI_ADI, SIFRE;
       
        public CalisanGuncelle()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CalisanGuncelle_Load(object sender, EventArgs e)
        {
            if (GelenID == 0)
            {
                //ilk kayıtta çalışacak kısım
                comboRol.Text = "ADMİN";
                comboRol.Enabled = false;

            }
            else
            {
                //Formdan veri geldiğinde doldurulacak !!
                textTC.Text = TC;
                textAdi.Text = ADI;
                textSoyadi.Text = SOYADI;
                comboRol.SelectedIndex = ROL;
                textKullaniciAdi.Text = KULLANICI_ADI;
                textSifre.Text = SIFRE;

            }


        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (GelenID == 0)
            {
                //ilk kayıtta çalışacak kısım
                VeriTabani vt = new VeriTabani();
                vt.CalısanEkle(textTC.Text, textAdi.Text, textSoyadi.Text, 0, textKullaniciAdi.Text, textSifre.Text);
                MessageBox.Show("İlk Kullanıcı Eklenmiştir Devam etmek için sisteme Giriş Yapınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                this.Close();
                Giris a = new Giris();
                a.Visible = true;

            }
            else
            {
                if (textTC.Text.Length == 11)
                {
                    try
                    {
                        //Formdan veri geldiğinde doldurulacak !!
                        VeriTabani vt = new VeriTabani();
                        vt.CalısanGuncelle(GelenID, textTC.Text, textAdi.Text, textSoyadi.Text, comboRol.SelectedIndex, textKullaniciAdi.Text, textSifre.Text);
                        MessageBox.Show("Kaydınız Güncellenmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        CalisanIs.deneme = 1;
                        this.Close();
                        //Liste Güncellenmesi eklenecek !!
                    }
                    catch (Exception)
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

        private void textTC_Leave(object sender, EventArgs e)
        {
            if (textTC.TextLength != 11 && textTC.TextLength != 0)
            {


                MessageBox.Show("TC alanı Eksik Girildi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textTC.Focus();
            
            
            }
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
    }
}
