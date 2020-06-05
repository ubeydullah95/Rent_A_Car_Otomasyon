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
    public partial class AracSorguları : Form
    {
        int ARABA_ID=0;
        public int[] MARKA_ID;
        public int[] MODEL_ID;
        public int[] SERI_ID;
        int MARKA = 0, MODEL = 0, SERI = 0;
        public AracSorguları()
        {
            InitializeComponent();
        }

        private void btnAracArama_Click(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();
            ARABA_ID = vt.AracIDCek(TextPlakaArama.Text);
            if (ARABA_ID == 0)
            {
                lblDurum.Visible = true;
            }
            else
                lblDurum.Visible = false;
        }

        private void btnAraclisteYenile_Click(object sender, EventArgs e)
        {
            ARABA_ID = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        
        private void checkTarih_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTarih.Checked==true)
            {
                groupBox1.Enabled = true;
              
            }
            else
                groupBox1.Enabled = false;
        }

        private void checkMarka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMarka.Checked == true)
            {
                groupBox2.Enabled = true;
                checkplaka.Checked = false;
            }
            else
                groupBox2.Enabled = false;
        }

        private void checkplaka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkplaka.Checked == true)
            {
                groupBox7.Enabled = true;
                checkMarka.Checked = false;
            }
            else
            {
                groupBox7.Enabled = false;
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime bTarih = Convert.ToDateTime(dateTimeBitis.Text);
            DateTime kTarih = Convert.ToDateTime(dateTimeBas.Text);
            TimeSpan Sonuc = bTarih - kTarih;
            string txtToplamGun;
            txtToplamGun = Sonuc.TotalDays.ToString();
            if (Convert.ToInt32(txtToplamGun) < 0)
            {
                MessageBox.Show("Başlangıç Tarihinden Önce Tarih Veremessiniz !!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimeBas.Text = DateTime.Now.ToShortDateString();
                dateTimeBitis.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void dateTimeBas_ValueChanged(object sender, EventArgs e)
        {
            DateTime bTarih = Convert.ToDateTime(dateTimeBitis.Text);
            DateTime kTarih = Convert.ToDateTime(dateTimeBas.Text);
            TimeSpan Sonuc = bTarih - kTarih;
            string txtToplamGun;
            txtToplamGun = Sonuc.TotalDays.ToString();
            if (Convert.ToInt32(txtToplamGun) < 0)
            {
                MessageBox.Show("Bitiş Tarihinden Sonrasına Tarih Veremessiniz !!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimeBas.Text = DateTime.Now.ToShortDateString();
                dateTimeBitis.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void AracSorguları_Load(object sender, EventArgs e)
        {
            
            VeriTabani vt = new VeriTabani();
            MARKA_ID = vt.markaCek(comboMarka);
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();
            MODEL_ID = vt.ModelCek(comboModel, MARKA_ID[comboMarka.SelectedIndex]);
            comboSeri.Items.Clear();
            MARKA = MARKA_ID[comboMarka.SelectedIndex];
            MODEL = 0;
            SERI = 0;
        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();
            SERI_ID = vt.SeriCek(comboSeri, MODEL_ID[comboModel.SelectedIndex]);
            MODEL = MODEL_ID[comboModel.SelectedIndex];
            SERI = 0;
        }

        private void comboSeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            SERI = SERI_ID[comboSeri.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bas = dateTimeBas.Value.ToString("yyyy-MM-dd HH:mm:ss.FFF");
            string bit = dateTimeBitis.Value.ToString("yyyy-MM-dd HH:mm:ss.FFF");
            if (checkplaka.Checked && checkTarih.Checked)
            {
                
               // string a = "select * from satislar where tarih>='" + datetimepicker1.text + "' and tarih<='" + datetimepicker2.text + "'";
                string sorgu = "select A.PLAKA_NO,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KIRA_TOPLAM_TUTAR from ARABALAR A,KIRALAMA_EMRI K,MUSTERI M,MARKALAR MA,MODEL MO,SERI SE where A.ARABA_ID=K.ARABA_ID and K.MUSTERI_ID=M.MUSTERI_ID and MA.MARKA_ID=A.MARKA_ID and MO.MODEL_ID=A.MODEL_ID and SE.SERI_ID=A.SERI_ID and A.PLAKA_NO='" + TextPlakaArama.Text + "' and K.TESLIM_TARIHI>='" + bas + "' and K.TESLIM_TARIHI <='" + bit + "'";
                VeriTabani vt = new VeriTabani();
                DataSet ds = new DataSet();
                ds=vt.SorguCekDataSetGonder(sorgu, "ARABA");
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Seçilen Arabanın Hareketi Bulunmamaktadır !!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    vt.ExcellDoldur(ds, "ARABA");
                }
            }
            else if (checkMarka.Checked && checkTarih.Checked)
            {
                string sorgu = "";
                if( MARKA!=0 && MODEL!=0 && SERI!=0)
                {
                      sorgu = "select A.PLAKA_NO,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KIRA_TOPLAM_TUTAR from ARABALAR A,KIRALAMA_EMRI K,MUSTERI M,MARKALAR MA,MODEL MO,SERI SE where A.ARABA_ID=K.ARABA_ID and K.MUSTERI_ID=M.MUSTERI_ID and MA.MARKA_ID=A.MARKA_ID and MO.MODEL_ID=A.MODEL_ID and SE.SERI_ID=A.SERI_ID and  K.TESLIM_TARIHI>='" + bas + "' and K.TESLIM_TARIHI <='" + bit + "' and (MA.MARKA_ID=" + MARKA_ID[comboMarka.SelectedIndex] + " and MO.MODEL_ID=" + MODEL_ID[comboModel.SelectedIndex] + " and SE.SERI_ID=" + SERI_ID[comboSeri.SelectedIndex] + ")";
                }
                else if (MARKA != 0 && MODEL != 0)
                {
                    sorgu = "select A.PLAKA_NO,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KIRA_TOPLAM_TUTAR from ARABALAR A,KIRALAMA_EMRI K,MUSTERI M,MARKALAR MA,MODEL MO,SERI SE where A.ARABA_ID=K.ARABA_ID and K.MUSTERI_ID=M.MUSTERI_ID and MA.MARKA_ID=A.MARKA_ID and MO.MODEL_ID=A.MODEL_ID and SE.SERI_ID=A.SERI_ID and  K.TESLIM_TARIHI>='" + bas + "' and K.TESLIM_TARIHI <='" + bit + "' and (MA.MARKA_ID=" + MARKA_ID[comboMarka.SelectedIndex] + " and MO.MODEL_ID=" + MODEL_ID[comboModel.SelectedIndex] + ")";
                }
                else if (MARKA != 0)
                {
                    sorgu = "select A.PLAKA_NO,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KIRA_TOPLAM_TUTAR from ARABALAR A,KIRALAMA_EMRI K,MUSTERI M,MARKALAR MA,MODEL MO,SERI SE where A.ARABA_ID=K.ARABA_ID and K.MUSTERI_ID=M.MUSTERI_ID and MA.MARKA_ID=A.MARKA_ID and MO.MODEL_ID=A.MODEL_ID and SE.SERI_ID=A.SERI_ID and  K.TESLIM_TARIHI>='" + bas + "' and K.TESLIM_TARIHI <='" + bit + "' and (MA.MARKA_ID=" + MARKA_ID[comboMarka.SelectedIndex] + ")";
                }
                else if( MARKA==0)
                {
                    MessageBox.Show("Listeden Kayıt Seçiniz !!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                VeriTabani vt = new VeriTabani();
                DataSet ds = new DataSet();
                ds = vt.SorguCekDataSetGonder(sorgu, "ARABA");
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Seçilen Arabanın Hareketi Bulunmamaktadır !!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    vt.ExcellDoldur(ds, "ARABA");
                }
            }
            else if (checkTarih.Checked)
            {
               string sorgu = "select A.PLAKA_NO,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KIRA_TOPLAM_TUTAR from ARABALAR A,KIRALAMA_EMRI K,MUSTERI M,MARKALAR MA,MODEL MO,SERI SE where A.ARABA_ID=K.ARABA_ID and K.MUSTERI_ID=M.MUSTERI_ID and MA.MARKA_ID=A.MARKA_ID and MO.MODEL_ID=A.MODEL_ID and SE.SERI_ID=A.SERI_ID and  K.TESLIM_TARIHI>='" + bas + "' and K.TESLIM_TARIHI <='" + bit + "'";
               VeriTabani vt = new VeriTabani();
               DataSet ds = new DataSet();
               ds = vt.SorguCekDataSetGonder(sorgu, "ARABA");
               if (ds.Tables[0].Rows.Count == 0)
               {
                   MessageBox.Show("Seçilen Tarihlerde Hareket Bulunmamaktadır !!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                   vt.ExcellDoldur(ds, "ARABA");
               }
            }
            else if (checkplaka.Checked)
            {
                // string a = "select * from satislar where tarih>='" + datetimepicker1.text + "' and tarih<='" + datetimepicker2.text + "'";
                string sorgu = "select A.PLAKA_NO,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KIRA_TOPLAM_TUTAR from ARABALAR A,KIRALAMA_EMRI K,MUSTERI M,MARKALAR MA,MODEL MO,SERI SE where A.ARABA_ID=K.ARABA_ID and K.MUSTERI_ID=M.MUSTERI_ID and MA.MARKA_ID=A.MARKA_ID and MO.MODEL_ID=A.MODEL_ID and SE.SERI_ID=A.SERI_ID and A.PLAKA_NO='" + TextPlakaArama.Text + "'";
                VeriTabani vt = new VeriTabani();
                DataSet ds = new DataSet();
                ds = vt.SorguCekDataSetGonder(sorgu, "ARABA");
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Seçilen Arabanın Hareketi Bulunmamaktadır !!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    vt.ExcellDoldur(ds, "ARABA");
                }
            }
            else if (checkMarka.Checked)
            {
                string sorgu = "";
                if (MARKA != 0 && MODEL != 0 && SERI != 0)
                {
                    sorgu = "select A.PLAKA_NO,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KIRA_TOPLAM_TUTAR from ARABALAR A,KIRALAMA_EMRI K,MUSTERI M,MARKALAR MA,MODEL MO,SERI SE where A.ARABA_ID=K.ARABA_ID and K.MUSTERI_ID=M.MUSTERI_ID and MA.MARKA_ID=A.MARKA_ID and MO.MODEL_ID=A.MODEL_ID and SE.SERI_ID=A.SERI_ID and (MA.MARKA_ID=" + MARKA_ID[comboMarka.SelectedIndex] + " and MO.MODEL_ID=" + MODEL_ID[comboModel.SelectedIndex] + " and SE.SERI_ID=" + SERI_ID[comboSeri.SelectedIndex] + ")";
                }
                else if (MARKA != 0 && MODEL != 0)
                {
                    sorgu = "select A.PLAKA_NO,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KIRA_TOPLAM_TUTAR from ARABALAR A,KIRALAMA_EMRI K,MUSTERI M,MARKALAR MA,MODEL MO,SERI SE where A.ARABA_ID=K.ARABA_ID and K.MUSTERI_ID=M.MUSTERI_ID and MA.MARKA_ID=A.MARKA_ID and MO.MODEL_ID=A.MODEL_ID and SE.SERI_ID=A.SERI_ID and  (MA.MARKA_ID=" + MARKA_ID[comboMarka.SelectedIndex] + " and MO.MODEL_ID=" + MODEL_ID[comboModel.SelectedIndex] + ")";
                }
                else if (MARKA != 0)
                {
                    sorgu = "select A.PLAKA_NO,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KIRA_TOPLAM_TUTAR from ARABALAR A,KIRALAMA_EMRI K,MUSTERI M,MARKALAR MA,MODEL MO,SERI SE where A.ARABA_ID=K.ARABA_ID and K.MUSTERI_ID=M.MUSTERI_ID and MA.MARKA_ID=A.MARKA_ID and MO.MODEL_ID=A.MODEL_ID and SE.SERI_ID=A.SERI_ID  and (MA.MARKA_ID=" + MARKA_ID[comboMarka.SelectedIndex] + ")";
                }
                else if (MARKA == 0)
                {
                    MessageBox.Show("Listeden Kayıt Seçiniz !!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                VeriTabani vt = new VeriTabani();
                DataSet ds = new DataSet();
                ds = vt.SorguCekDataSetGonder(sorgu, "ARABA");
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Seçilen Arabanın Hareketi Bulunmamaktadır !!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    vt.ExcellDoldur(ds, "ARABA");
                }
            }
            else
            {
                // string a = "select * from satislar where tarih>='" + datetimepicker1.text + "' and tarih<='" + datetimepicker2.text + "'";
                string sorgu = "select A.PLAKA_NO,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KIRA_TOPLAM_TUTAR from ARABALAR A,KIRALAMA_EMRI K,MUSTERI M,MARKALAR MA,MODEL MO,SERI SE where A.ARABA_ID=K.ARABA_ID and K.MUSTERI_ID=M.MUSTERI_ID and MA.MARKA_ID=A.MARKA_ID and MO.MODEL_ID=A.MODEL_ID and SE.SERI_ID=A.SERI_ID";
                VeriTabani vt = new VeriTabani();
                DataSet ds = new DataSet();
                ds = vt.SorguCekDataSetGonder(sorgu, "ARABA");
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Seçilen Arabanın Hareketi Bulunmamaktadır !!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    vt.ExcellDoldur(ds, "ARABA");
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {


            MessageBox.Show(düzenle(dateTimeBas.Text));
        }
        public string düzenle(string tarih)
        {
            string[] düz = tarih.Split('.');
            string dönen = düz[2] + "-" + düz[1] + "-" + düz[0];
            return dönen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
