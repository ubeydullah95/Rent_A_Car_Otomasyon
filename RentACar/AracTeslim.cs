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
    public partial class AracTeslim : Form
    {
        public AracTeslim()
        {
            InitializeComponent();
        }
        public int CALISAN_ID;
        public int ARABA_ID;
        public int KIRA_ID;
        public string TeslimTarihi;
        public int TOPLAM_GUN;
        int toplam;
        
        private void textTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (durum)
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
            else
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
                    e.Handled = false;//bunların dışındaysa hiçbirisini yazdırma
                }
            }
        }

        private void textTc_Leave(object sender, EventArgs e)
        {
            if (durum)
            {
                if (textTc.TextLength != 11 && textTc.TextLength != 0)
                {
                    MessageBox.Show("TC alanı Eksik Girildi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textTc.Focus();


                }
            }
            else
            {
                textTc.Text = textTc.Text.ToUpper();
            }
            
           
               
        }

        private void AracTeslim_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
        public bool durum=true;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Tc Kimlik No :";
            durum = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Araç Plaka No : ";
            durum = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sorguya teslim alınan araçları dahil etmicez !!

            if (radioButton1.Checked == true)
            {
                //tc alanına göre arama yapılıyor
                string sorgu = "select K.KIRA_ID,A.PLAKA_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KM_START,K.KIRA_TOPLAM_TUTAR from KIRALAMA_EMRI K,ARABALAR A,MUSTERI M WHERE K.MUSTERI_ID=M.MUSTERI_ID AND A.ARABA_ID=K.ARABA_ID AND M.TC_NO='" + textTc.Text + "' and K.TESLIM_DURUMU=0";
                VeriTabani vt = new VeriTabani();
                DataSet ds = vt.KiraEmriCek(sorgu);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    lblDurum.Visible = true;
                }
                else
                {
                    lblSonuc.Text = "Plaka No :";
                    TeslimTarihi = (ds.Tables[0].Rows[0].ItemArray[5].ToString());
                    toplam = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[7].ToString());
                    KIRA_ID = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                    //MessageBox.Show(KIRA_ID.ToString());
                    textSonuc.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                    ARABA_ID = vt.AracIDCek(textSonuc.Text);
                    textAd.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    textSoyad.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                    textAlisTar.Text = DateTime.Parse(ds.Tables[0].Rows[0].ItemArray[4].ToString()).ToShortDateString();
                    dateTimeTeslimTar.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                    textKmStart.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
                    textTopTutar.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
                    
                }
            }
            else
            {
                //plakaya göre arama yapılıyor
                string sorgu = "select K.KIRA_ID,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KM_START,K.KIRA_TOPLAM_TUTAR from KIRALAMA_EMRI K,ARABALAR A,MUSTERI M WHERE K.MUSTERI_ID=M.MUSTERI_ID AND A.ARABA_ID=K.ARABA_ID AND A.PLAKA_NO='" + textTc.Text + "' and K.TESLIM_DURUMU=0";
                VeriTabani vt = new VeriTabani();
                DataSet ds = vt.KiraEmriCek(sorgu);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    lblDurum.Visible = true;
                }
                else
                {
                    ARABA_ID = vt.AracIDCek(textTc.Text);
                    KIRA_ID = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                    lblSonuc.Text = "Tc Kimlik No:";
                    TeslimTarihi = (ds.Tables[0].Rows[0].ItemArray[5].ToString());
                    toplam = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[7].ToString());
                    //MessageBox.Show(KIRA_ID.ToString());
                    textSonuc.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                    textAd.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    textSoyad.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                    textAlisTar.Text = DateTime.Parse(ds.Tables[0].Rows[0].ItemArray[4].ToString()).ToShortDateString();
                    dateTimeTeslimTar.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                    textKmStart.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
                    textTopTutar.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
                    
                }
               

            }
         
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (textKmEnd.Text == "")
            {
                MessageBox.Show("Aracın Teslim Kilometresini Giriniz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                TimeSpan b = Convert.ToDateTime(dateTimeTeslimTar.Text) - Convert.ToDateTime(textAlisTar.Text);
                TOPLAM_GUN = Convert.ToInt32(Math.Abs(b.TotalDays));
                //Araç Telim İşlemi Yapılacak !!
                VeriTabani vt = new VeriTabani();
                
                vt.KiraDurumGuncelle(KIRA_ID, true, Convert.ToDateTime(dateTimeTeslimTar.Text), TOPLAM_GUN, int.Parse(textKmEnd.Text), int.Parse(textKmFark.Text), int.Parse(textTopTutar.Text));//bazı alanlar daha güncellenecek !
                vt.AracDurumGuncelle(ARABA_ID, "BOŞTA");
                vt.AracKmGuncelle(ARABA_ID, Convert.ToInt32(textKmEnd.Text));

                int ODENME_DURUM = vt.KiraOdenmeDurumCek(KIRA_ID);
                if (ODENME_DURUM == 0)
                {
                    MessageBox.Show("Sistemde Kira Ödemesi Gözükmemektedir. \nSizi Ödeme Sayfasına Yönlendiriyorz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OdemeYap form = new OdemeYap();
                    form.KIRA_ID = KIRA_ID;
                    form.CALISAN_ID = CALISAN_ID;
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Araç Tesliminiz Başarıyla Gerçekleşmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                


            }
        }
        public int sayac=0;
        private void dateTimeTeslimTar_ValueChanged(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                string PLAKA_NO;
                int ucret, indirim, fark = 0, toplamtutar;

                if (radioButton1.Checked == true)
                {
                    PLAKA_NO = textSonuc.Text;
                }
                else
                {
                    PLAKA_NO = textTc.Text;
                }
                toplamtutar = toplam;
                VeriTabani vt = new VeriTabani();
                ucret = vt.GünlükUcretCek(PLAKA_NO);

                TimeSpan a = Convert.ToDateTime(textAlisTar.Text) - Convert.ToDateTime(dateTimeTeslimTar.Text);
                TimeSpan b = Convert.ToDateTime(dateTimeTeslimTar.Text) - Convert.ToDateTime(textAlisTar.Text);
                TOPLAM_GUN = Convert.ToInt32(Math.Abs(b.TotalDays));
               // MessageBox.Show(TOPLAM_GUN.ToString());
                if (a.TotalDays > 0)
                {
                    MessageBox.Show("Teslim Tarihini Alış Tarihinden Once giremessiniz!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTimeTeslimTar.Text = Convert.ToDateTime(TeslimTarihi).ToShortDateString();
                }
                else
                {
                    DateTime TeslimTar = Convert.ToDateTime(TeslimTarihi);
                    DateTime SecilenTarih = Convert.ToDateTime(dateTimeTeslimTar.Text);
                    TimeSpan Sonuc = SecilenTarih - TeslimTar;
                    fark = Convert.ToInt32(Sonuc.TotalDays.ToString());
                    if (fark == 0)
                    {
                        textTopTutar.Text = toplamtutar.ToString();
                    }
                    else if (fark < 0)
                    {
                        indirim = ucret * 2 / 3;
                        toplamtutar = toplamtutar + fark * indirim;
                        textTopTutar.Text = toplamtutar.ToString();
                    }
                    else
                    {
                        toplamtutar = toplamtutar + fark * ucret;
                        textTopTutar.Text = toplamtutar.ToString();
                    }


                }
                
            }
            else
                sayac++;
            
         
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textKmEnd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textKmEnd_Leave(object sender, EventArgs e)
        {
            try
            {
                int kmstart = Convert.ToInt32(textKmStart.Text);
                int kmend = Convert.ToInt32(textKmEnd.Text);
                if (kmend < kmstart)
                {
                    MessageBox.Show("KM Başlangıç kilometresinden Küçük Giremessiniz!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textKmEnd.Focus();
                }
                else
                {
                    textKmFark.Text = (kmend - kmstart).ToString();
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void textTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
