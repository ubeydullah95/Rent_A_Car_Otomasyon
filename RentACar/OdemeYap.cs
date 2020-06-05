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
    public partial class OdemeYap : Form
    {
        public OdemeYap()
        {
            InitializeComponent();
        }
        public bool durum;
        public int KIRA_ID = 0;
        public int CALISAN_ID;
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

        private void OdemeYap_Load(object sender, EventArgs e)
        {
            if (KIRA_ID != 0)
            {
                //tc alanına göre arama yapılıyor
                string sorgu = "select K.KIRA_ID,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KM_START,K.KIRA_TOPLAM_TUTAR from KIRALAMA_EMRI K,ARABALAR A,MUSTERI M WHERE K.MUSTERI_ID=M.MUSTERI_ID AND A.ARABA_ID=K.ARABA_ID AND K.KIRA_ID=" + KIRA_ID;
                VeriTabani vt = new VeriTabani();
                DataSet ds = vt.KiraEmriCek(sorgu);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    lblDurum.Visible = true;
                }
                else
                {
                    lblSonuc.Text = "Plaka No :";
                    //TeslimTarihi = (ds.Tables[0].Rows[0].ItemArray[5].ToString());
                    //toplam = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[7].ToString());
                    KIRA_ID = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                    //MessageBox.Show(KIRA_ID.ToString());
                    textSonuc.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                    textAd.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    textSoyad.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                    textAlisTar.Text = DateTime.Parse(ds.Tables[0].Rows[0].ItemArray[4].ToString()).ToShortDateString();
                    dateTimeTeslimTar.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                   // textKmStart.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
                    textTopTutar.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
                    groupBox2.Enabled = false;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                lblOnay.Visible = false;
                if (radioButton1.Checked == true)
                {
                    //tc alanına göre arama yapılıyor
                    string sorgu = "select K.KIRA_ID,A.PLAKA_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KM_START,K.KIRA_TOPLAM_TUTAR from KIRALAMA_EMRI K,ARABALAR A,MUSTERI M WHERE K.MUSTERI_ID=M.MUSTERI_ID AND A.ARABA_ID=K.ARABA_ID AND M.TC_NO='" + textTc.Text + "' and K.ODENME_DURUMU=0";
                    VeriTabani vt = new VeriTabani();
                    DataSet ds = vt.KiraEmriCek(sorgu);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        lblDurum.Visible = true;
                    }
                    else
                    {
                        lblSonuc.Text = "Plaka No :";
                        // TeslimTarihi = (ds.Tables[0].Rows[0].ItemArray[5].ToString());
                        //toplam = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[7].ToString());
                        KIRA_ID = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                        //MessageBox.Show(KIRA_ID.ToString());
                        textSonuc.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                        textAd.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                        textSoyad.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                        textAlisTar.Text = DateTime.Parse(ds.Tables[0].Rows[0].ItemArray[4].ToString()).ToShortDateString();
                        dateTimeTeslimTar.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                        //textKmStart.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
                        textTopTutar.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();

                    }
                }
                else
                {
                    //plakaya göre arama yapılıyor
                    string sorgu = "select K.KIRA_ID,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KM_START,K.KIRA_TOPLAM_TUTAR from KIRALAMA_EMRI K,ARABALAR A,MUSTERI M WHERE K.MUSTERI_ID=M.MUSTERI_ID AND A.ARABA_ID=K.ARABA_ID AND A.PLAKA_NO='" + textTc.Text + "' and K.ODENME_DURUMU=0";
                    VeriTabani vt = new VeriTabani();
                    DataSet ds = vt.KiraEmriCek(sorgu);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        lblDurum.Visible = true;
                    }
                    else
                    {
                        KIRA_ID = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                        lblSonuc.Text = "Tc Kimlik No:";
                        // TeslimTarihi = (ds.Tables[0].Rows[0].ItemArray[5].ToString());
                        //toplam = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[7].ToString());
                        //MessageBox.Show(KIRA_ID.ToString());
                        textSonuc.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                        textAd.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                        textSoyad.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                        textAlisTar.Text = DateTime.Parse(ds.Tables[0].Rows[0].ItemArray[4].ToString()).ToShortDateString();
                        dateTimeTeslimTar.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                        // textKmStart.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
                        textTopTutar.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();

                    }


                }
           


        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (KIRA_ID != 0)
            {
                if (comboOdemeSekli.Text != "")
                {
                    //Ödeme İşlemi Yapılacak !!
                    int ODENME_DURUM;
                    VeriTabani vt = new VeriTabani();
                    ODENME_DURUM = vt.KiraOdenmeDurumCek(KIRA_ID);
                    if (ODENME_DURUM == 0)
                    {
                        vt.ODEMEEKLE(KIRA_ID, DateTime.Now, comboOdemeSekli.SelectedItem.ToString(), int.Parse(textTopTutar.Text), CALISAN_ID);
                        lblOnay.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Bu Kira Emrinin Ödemesi Mevcuttur Tekrardan Ödeme Yapamassınız !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                else
                {

                    MessageBox.Show("Lütfen Bir Ödeme Türü Seçiniz !!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

            }
        }
    }
}
