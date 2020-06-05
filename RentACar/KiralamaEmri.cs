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
    public partial class KiralamaEmri : Form
    {
        public KiralamaEmri()
        {
            InitializeComponent();
        }
        public int[] MARKA_ID;
        public int[] MODEL_ID;
        public int[] SERI_ID;
        public int CALISAN_ID;
        public int RezerveKiraDurum;
       
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KiralamaEmri_Load(object sender, EventArgs e)
        {

            if(RezerveKiraDurum==1)
            {

                label8.Visible = false;
                TextKiloMetre.Visible = false;
                this.Text = "Araç Rezerve :";

            }
            string sorgu = "select MUSTERI_ID,TC_NO,ADI,SOYADI from MUSTERI";
            VeriTabani vt = new VeriTabani();
            vt.baglan(sorgu, dataMusteri, "MUSTERI");
            dataMusteri.Columns[0].Visible = false;
            dataMusteri.Columns[1].HeaderText = "Kimlik No";
            sorgu = "select A.ARABA_ID,A.PLAKA_NO,M.MARKA_ADI,MO.MODEL,S.SERI,A.YAKIT,A.VITES,A.KASA_TIPI,A.GUNLUK_UCRET,A.KULLANIM_DURUM from ARABALAR A,MARKALAR M, MODEL MO,SERI S where A.MARKA_ID=M.MARKA_ID and A.MODEL_ID=MO.MODEL_ID and A.SERI_ID=S.SERI_ID and A.KULLANIM_DURUM='BOŞTA'";

            vt.baglan(sorgu, dataArac, "ARABALAR");
            dataArac.Columns[1].HeaderText = "PLAKA";
            dataArac.Columns[2].HeaderText = "MARKA";

            dataArac.Columns[7].HeaderText = "TİP";
            dataArac.Columns[8].HeaderText = "G.UCRET";
            dataArac.Columns[9].HeaderText = "DURUM";

            dataArac.Columns[0].Visible = false;
          
            
            MARKA_ID = vt.markaCek(comboMarka);
            
        }

        private void radioTc_CheckedChanged(object sender, EventArgs e)
        {
            lblArama.Text = "TC No Giriniz : ";
            textArama.MaxLength = 11;
        }

        private void radioAd_CheckedChanged(object sender, EventArgs e)
        {
            lblArama.Text = "Soyadı Giriniz : ";
            textArama.MaxLength = 11111;
        }

        private void radioSoyad_CheckedChanged(object sender, EventArgs e)
        {
            lblArama.Text = "Soyadı Giriniz : ";
            textArama.MaxLength = 11111;
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            if (radioTc.Checked == true)
            {
                VeriTabani vt = new VeriTabani();
                string sorgu = "select MUSTERI_ID,TC_NO,ADI,SOYADI from MUSTERI where TC_NO like '" + textArama.Text + "'";
                vt.baglan(sorgu, dataMusteri, "MUSTERI");

            }
            else if (radioAd.Checked == true)
            {
                VeriTabani vt = new VeriTabani();
                string sorgu = "select MUSTERI_ID,TC_NO,ADI,SOYADI from MUSTERI where ADI like '%" + textArama.Text + "%'";

                vt.baglan(sorgu, dataMusteri, "MUSTERI");

            }
            else if (radioSoyad.Checked == true)
            {
                VeriTabani vt = new VeriTabani();
                string sorgu = "select MUSTERI_ID,TC_NO,ADI,SOYADI from MUSTERI where SOYADI like '%" + textArama.Text + "%'";
                vt.baglan(sorgu, dataMusteri, "MUSTERI");
            }
            dataMusteri.Columns[0].Visible = false;
            dataMusteri.Columns[1].HeaderText = "Kimlik No";

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            string sorgu = "select MUSTERI_ID,TC_NO,ADI,SOYADI from MUSTERI";
            VeriTabani vt = new VeriTabani();
            vt.baglan(sorgu, dataMusteri, "MUSTERI");
            dataMusteri.Columns[0].Visible = false;
            dataMusteri.Columns[1].HeaderText = "Kimlik No";
            textArama.Text = "";

        }

        private void TextPlakaArama_Leave(object sender, EventArgs e)
        {
            TextPlakaArama.Text = TextPlakaArama.Text.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "select A.ARABA_ID,A.PLAKA_NO,M.MARKA_ADI,MO.MODEL,S.SERI,A.YAKIT,A.VITES,A.KASA_TIPI,A.GUNLUK_UCRET,A.KULLANIM_DURUM from ARABALAR A,MARKALAR M, MODEL MO,SERI S where A.MARKA_ID=M.MARKA_ID and A.MODEL_ID=MO.MODEL_ID and A.SERI_ID=S.SERI_ID and A.KULLANIM_DURUM='BOŞTA' and PLAKA_NO='" + TextPlakaArama.Text + "'";
            VeriTabani vt = new VeriTabani();
            vt.baglan(sorgu, dataArac, "ARABALAR");
            dataArac.Columns[1].HeaderText = "PLAKA";
            dataArac.Columns[2].HeaderText = "MARKA";

            dataArac.Columns[7].HeaderText = "TİP";
            dataArac.Columns[8].HeaderText = "G.UCRET";
            dataArac.Columns[9].HeaderText = "DURUM";

            dataArac.Columns[0].Visible = false;
        
        }

        private void btnAraclisteYenile_Click(object sender, EventArgs e)
        {
            string sorgu = "select A.ARABA_ID,A.PLAKA_NO,M.MARKA_ADI,MO.MODEL,S.SERI,A.YAKIT,A.VITES,A.KASA_TIPI,A.GUNLUK_UCRET,A.KULLANIM_DURUM from ARABALAR A,MARKALAR M, MODEL MO,SERI S where A.MARKA_ID=M.MARKA_ID and A.MODEL_ID=MO.MODEL_ID and A.SERI_ID=S.SERI_ID and A.KULLANIM_DURUM='BOŞTA'";
            VeriTabani vt = new VeriTabani();
            
            vt.baglan(sorgu, dataArac, "ARABALAR");
            dataArac.Columns[1].HeaderText = "PLAKA";
            dataArac.Columns[2].HeaderText = "MARKA";

            dataArac.Columns[7].HeaderText = "TİP";
            dataArac.Columns[8].HeaderText = "G.UCRET";
            dataArac.Columns[9].HeaderText = "DURUM";

            dataArac.Columns[0].Visible = false;
            TextPlakaArama.Text = "";
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();
            MODEL_ID=vt.ModelCek(comboModel, MARKA_ID[comboMarka.SelectedIndex]);
            string sorgu = "select A.ARABA_ID,A.PLAKA_NO,M.MARKA_ADI,MO.MODEL,S.SERI,A.YAKIT,A.VITES,A.KASA_TIPI,A.GUNLUK_UCRET,A.KULLANIM_DURUM from ARABALAR A,MARKALAR M, MODEL MO,SERI S where A.MARKA_ID=M.MARKA_ID and A.MODEL_ID=MO.MODEL_ID and A.SERI_ID=S.SERI_ID and A.KULLANIM_DURUM='BOŞTA' and M.MARKA_ADI='" + comboMarka.SelectedItem.ToString() + "'";

            vt.baglan(sorgu, dataArac, "ARABALAR");
            dataArac.Columns[1].HeaderText = "PLAKA";
            dataArac.Columns[2].HeaderText = "MARKA";

            dataArac.Columns[7].HeaderText = "TİP";
            dataArac.Columns[8].HeaderText = "G.UCRET";
            dataArac.Columns[9].HeaderText = "DURUM";
            dataArac.Columns[0].Visible = false;


        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(comboModel.SelectedItem.ToString());
            VeriTabani vt = new VeriTabani();
            SERI_ID = vt.SeriCek(comboSeri, MODEL_ID[comboModel.SelectedIndex]);
            string sorgu = "select A.ARABA_ID,A.PLAKA_NO,M.MARKA_ADI,MO.MODEL,S.SERI,A.YAKIT,A.VITES,A.KASA_TIPI,A.GUNLUK_UCRET,A.KULLANIM_DURUM from ARABALAR A,MARKALAR M, MODEL MO,SERI S where A.MARKA_ID=M.MARKA_ID and A.MODEL_ID=MO.MODEL_ID and A.SERI_ID=S.SERI_ID and A.KULLANIM_DURUM='BOŞTA' and M.MARKA_ADI='" + comboMarka.SelectedItem.ToString() + "' and MO.MODEL='" + comboModel.SelectedItem.ToString() + "'";

            vt.baglan(sorgu, dataArac, "ARABALAR");

            dataArac.Columns[1].HeaderText = "PLAKA";
            dataArac.Columns[2].HeaderText = "MARKA";

            dataArac.Columns[7].HeaderText = "TİP";
            dataArac.Columns[8].HeaderText = "G.UCRET";
            dataArac.Columns[9].HeaderText = "DURUM";
            dataArac.Columns[0].Visible = false;
        }

        private void comboSeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();

            string sorgu = "select A.ARABA_ID,A.PLAKA_NO,M.MARKA_ADI,MO.MODEL,S.SERI,A.YAKIT,A.VITES,A.KASA_TIPI,A.GUNLUK_UCRET,A.KULLANIM_DURUM from ARABALAR A,MARKALAR M, MODEL MO,SERI S where A.MARKA_ID=M.MARKA_ID and A.MODEL_ID=MO.MODEL_ID and A.SERI_ID=S.SERI_ID and A.KULLANIM_DURUM='BOŞTA' and M.MARKA_ADI='" + comboMarka.SelectedItem.ToString() + "' and MO.MODEL='" + comboModel.SelectedItem.ToString() + "' and S.SERI='" + comboSeri.SelectedItem.ToString() + "'";

            vt.baglan(sorgu, dataArac, "ARABALAR");

            dataArac.Columns[1].HeaderText = "PLAKA";
            dataArac.Columns[2].HeaderText = "MARKA";

            dataArac.Columns[7].HeaderText = "TİP";
            dataArac.Columns[8].HeaderText = "G.UCRET";
            dataArac.Columns[9].HeaderText = "DURUM";
            dataArac.Columns[0].Visible = false;

        }

        private void dateTimeAlıs_ValueChanged(object sender, EventArgs e)
        {
            //Burdan deevam edilecek

            TimeSpan fark = Convert.ToDateTime(dateTimeAlıs.Text) - DateTime.Now;
           
            if (fark.TotalDays < -1)
            {
                MessageBox.Show("Günümüz Tarihinden Önce Kira Emri Veremessiniz!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimeAlıs.Text = DateTime.Now.ToShortDateString();
            }
            else
            {
                DateTime bTarih = Convert.ToDateTime(dateTimeTeslim.Text);
                DateTime kTarih = Convert.ToDateTime(dateTimeAlıs.Text);
                TimeSpan Sonuc = bTarih - kTarih;
                txtToplamGun.Text = Sonuc.TotalDays.ToString();
            }

        }

        private void dateTimeTeslim_ValueChanged(object sender, EventArgs e)
        {
            DateTime bTarih = Convert.ToDateTime(dateTimeTeslim.Text);
            DateTime kTarih = Convert.ToDateTime(dateTimeAlıs.Text);
            TimeSpan Sonuc = bTarih - kTarih;
            txtToplamGun.Text = Sonuc.TotalDays.ToString();
            if (Convert.ToInt32(txtToplamGun.Text) < 0)
            {
                MessageBox.Show("Alış Tarihinden Önce Tarih Veremessiniz !!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimeTeslim.Text = DateTime.Now.ToShortDateString();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataArac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                VeriTabani vt = new VeriTabani();
                int ARABA_ID = 0;
                ARABA_ID = Convert.ToInt32((dataArac.Rows[dataArac.CurrentRow.Index].Cells[0].Value).ToString());
                TextKiloMetre.Text = vt.AracKMCek(ARABA_ID).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtToplamGun_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textToplamTutar.Text = (Convert.ToInt32((dataArac.Rows[dataArac.CurrentRow.Index].Cells[8].Value).ToString()) * Convert.ToInt32(txtToplamGun.Text)).ToString();
                if (textToplamTutar.Text == "0")
                {
                    textToplamTutar.Text=(Convert.ToInt32((dataArac.Rows[dataArac.CurrentRow.Index].Cells[8].Value).ToString()).ToString());
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Lütfen Listeden Araç Seçiniz!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Kira Kaydetme İşlemi Yapılacak 
            if (RezerveKiraDurum == 0)
            {
                //normal kira işlemi çalışacak
                int ARABA_ID, MUSTERI_ID;
                DateTime ALIS_TARIHI, TESLIM_TARIHI;
                ARABA_ID = int.Parse(dataArac.Rows[dataArac.CurrentRow.Index].Cells[0].Value.ToString());
                MUSTERI_ID = int.Parse(dataMusteri.Rows[dataMusteri.CurrentRow.Index].Cells[0].Value.ToString());
                ALIS_TARIHI = Convert.ToDateTime(dateTimeAlıs.Text);
                TESLIM_TARIHI = Convert.ToDateTime(dateTimeTeslim.Text);

                VeriTabani vt = new VeriTabani();
                vt.KiraEmriEkle(CALISAN_ID, ARABA_ID, MUSTERI_ID, ALIS_TARIHI, TESLIM_TARIHI, int.Parse(txtToplamGun.Text), false, int.Parse(TextKiloMetre.Text), 0, 0, int.Parse(textToplamTutar.Text), false);
                vt.AracDurumGuncelle(ARABA_ID, "KIRADA");
                MessageBox.Show("Kiralama Emriniz Başarıyla Oluşturulmuştur...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // rezerve emir işlemi çalışacak
                int ARABA_ID, MUSTERI_ID;
                DateTime ALIS_TARIHI, TESLIM_TARIHI;
                ARABA_ID = int.Parse(dataArac.Rows[dataArac.CurrentRow.Index].Cells[0].Value.ToString());
                MUSTERI_ID = int.Parse(dataMusteri.Rows[dataMusteri.CurrentRow.Index].Cells[0].Value.ToString());
                ALIS_TARIHI = Convert.ToDateTime(dateTimeAlıs.Text);
                TESLIM_TARIHI = Convert.ToDateTime(dateTimeTeslim.Text);
                VeriTabani vt = new VeriTabani();
                vt.RezerveEkle(CALISAN_ID, ARABA_ID, MUSTERI_ID, ALIS_TARIHI, TESLIM_TARIHI, false);
                vt.AracDurumGuncelle(ARABA_ID, "REZERVE");
                MessageBox.Show("Araç Rezerve İşleminiz Başarıyla Oluşturulmuştur...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
                        
        }
    }
}
