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
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle()
        {
            InitializeComponent();
        }

        public int Gelen_ID;


        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();
            DataSet ds = vt.MusteriGonder(Gelen_ID);
            vt.ExcellDoldur(ds, "Deneme");
            textTc.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            textAd.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            textSoyad.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            textDogumTar.Text = Convert.ToDateTime(ds.Tables[0].Rows[0].ItemArray[4].ToString()).ToShortDateString();
            textTel.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            textEmail.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
            textAdres.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (textTc.Text.Length==11)
            {
                try
                {

                    VeriTabani vt = new VeriTabani();
                    vt.MusteriGuncelle(textTc.Text, textAd.Text, textSoyad.Text, Convert.ToDateTime(textDogumTar.Text), textAdres.Text, textTel.Text, textEmail.Text, false, Gelen_ID);
                    MessageBox.Show("Kaydınız Güncellenmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MusteriIslemleri.deneme = 1;
                    this.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Bu TC Sisteme Kayıtlı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textTc.Text = "";
                    textTc.Focus();

                }
            }
            else
            {
                MessageBox.Show("Hatalı Veya Eksik TC no girişi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textTc.Focus();
            }

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
        private bool tc;
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

        private void textAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool a = tc;
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

      
    }
}
