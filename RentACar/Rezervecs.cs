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
    public partial class Rezervecs : Form
    {
        public Rezervecs()
        {
            InitializeComponent();
        }
        public int CALISAN_ID;
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rezervecs_Load(object sender, EventArgs e)
        {
            string sorgu = "select A.ARABA_ID,R.REZERVE_ID,M.MUSTERI_ID,M.TC_NO,M.ADI,M.SOYADI,R.ALIS_TAR,R.TESLIM_TAR from MUSTERI M,REZERVE R,ARABALAR A where M.MUSTERI_ID=r.MUSTERI_ID and A.ARABA_ID=R.ARABA_ID and R.REZERVE_DURUM=0";


            VeriTabani vt = new VeriTabani();
            vt.baglan(sorgu, dataRezList, "REZERVE");
            dataRezList.Columns[0].Visible = false;
            dataRezList.Columns[1].Visible = false;
            dataRezList.Columns[2].Visible = false;


        }

        private void radioTc_CheckedChanged(object sender, EventArgs e)
        {
            lblArama.Text = "Tc No Giriniz :";

        }

        private void radioAd_CheckedChanged(object sender, EventArgs e)
        {
            lblArama.Text = "Adı Giriniz :";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioSoyad_CheckedChanged(object sender, EventArgs e)
        {
            lblArama.Text = "Soyadı Giriniz :";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            string sorgu = "select A.ARABA_ID,R.REZERVE_ID,M.MUSTERI_ID,M.TC_NO,M.ADI,M.SOYADI,R.ALIS_TAR,R.TESLIM_TAR from MUSTERI M,REZERVE R,ARABALAR A where M.MUSTERI_ID=r.MUSTERI_ID and A.ARABA_ID=R.ARABA_ID and R.REZERVE_DURUM=0";


            VeriTabani vt = new VeriTabani();
            vt.baglan(sorgu, dataRezList, "REZERVE");
            dataRezList.Columns[0].Visible = false;
            dataRezList.Columns[1].Visible = false;
            dataRezList.Columns[2].Visible = false;
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            if(radioTc.Checked==true)
            {
                string sorgu = "select A.ARABA_ID,R.REZERVE_ID,M.MUSTERI_ID,M.TC_NO,M.ADI,M.SOYADI,R.ALIS_TAR,R.TESLIM_TAR from MUSTERI M,REZERVE R,ARABALAR A where M.MUSTERI_ID=r.MUSTERI_ID and A.ARABA_ID=R.ARABA_ID and R.REZERVE_DURUM=0 and M.TC_NO='" + textArama.Text + "'";


                VeriTabani vt = new VeriTabani();
                vt.baglan(sorgu, dataRezList, "REZERVE");
                dataRezList.Columns[0].Visible = false;
                dataRezList.Columns[1].Visible = false;
                dataRezList.Columns[2].Visible = false;
            }
            else if(radioAd.Checked==true)
            {
                string sorgu = "select A.ARABA_ID,R.REZERVE_ID,M.MUSTERI_ID,M.TC_NO,M.ADI,M.SOYADI,R.ALIS_TAR,R.TESLIM_TAR from MUSTERI M,REZERVE R,ARABALAR A where M.MUSTERI_ID=r.MUSTERI_ID and A.ARABA_ID=R.ARABA_ID and R.REZERVE_DURUM=0 and M.ADI='" + textArama.Text + "'";


                VeriTabani vt = new VeriTabani();
                vt.baglan(sorgu, dataRezList, "REZERVE");
                dataRezList.Columns[0].Visible = false;
                dataRezList.Columns[1].Visible = false;
                dataRezList.Columns[2].Visible = false;
            }
            else
            {
                string sorgu = "select A.ARABA_ID,R.REZERVE_ID,M.MUSTERI_ID,M.TC_NO,M.ADI,M.SOYADI,R.ALIS_TAR,R.TESLIM_TAR from MUSTERI M,REZERVE R,ARABALAR A where M.MUSTERI_ID=r.MUSTERI_ID and A.ARABA_ID=R.ARABA_ID and R.REZERVE_DURUM=0 and M.SOYADI='" + textArama.Text + "'";


                VeriTabani vt = new VeriTabani();
                vt.baglan(sorgu, dataRezList, "REZERVE");
                dataRezList.Columns[0].Visible = false;
                dataRezList.Columns[1].Visible = false;
                dataRezList.Columns[2].Visible = false;
            }
            
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            try
            {


                VeriTabani vt = new VeriTabani();
                DateTime ALIS_TAR, TESLIM_TAR;
                int ARABA_ID, MUSTERI_ID, TOPLAM_GUN, KM_START, REZERVE_ID, TOPLAM_TUTAR;
                ARABA_ID = int.Parse(dataRezList.Rows[dataRezList.CurrentRow.Index].Cells[0].Value.ToString());
                REZERVE_ID = int.Parse(dataRezList.Rows[dataRezList.CurrentRow.Index].Cells[1].Value.ToString());
                MUSTERI_ID = int.Parse(dataRezList.Rows[dataRezList.CurrentRow.Index].Cells[2].Value.ToString());
                ALIS_TAR = DateTime.Parse(dataRezList.Rows[dataRezList.CurrentRow.Index].Cells[6].Value.ToString());
                TESLIM_TAR = DateTime.Parse(dataRezList.Rows[dataRezList.CurrentRow.Index].Cells[7].Value.ToString());
                TimeSpan fark = TESLIM_TAR - ALIS_TAR;
                TOPLAM_GUN = Convert.ToInt32(fark.TotalDays.ToString());
                KM_START = vt.AracKMCek(ARABA_ID);
                TOPLAM_TUTAR = vt.AracUcretCek(ARABA_ID) * TOPLAM_GUN;
                vt.KiraEmriEkle(CALISAN_ID, ARABA_ID, MUSTERI_ID, ALIS_TAR, TESLIM_TAR, TOPLAM_GUN, false, KM_START, 0, 0, TOPLAM_TUTAR, false);
                vt.AracDurumGuncelle(ARABA_ID, "KIRADA");
                vt.RezerveDurum(REZERVE_ID, true);
                MessageBox.Show("İşleminiz Onaylanmıştır !!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch(Exception)
            {
                MessageBox.Show("Listeden Kayıt Seçiniz  !!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();
            int ARABA_ID, REZERVE_ID;
            ARABA_ID = int.Parse(dataRezList.Rows[dataRezList.CurrentRow.Index].Cells[0].Value.ToString());
            REZERVE_ID = int.Parse(dataRezList.Rows[dataRezList.CurrentRow.Index].Cells[1].Value.ToString());
            vt.RezerveSil(REZERVE_ID);
            vt.AracDurumGuncelle(ARABA_ID, "BOŞTA");

            MessageBox.Show("Kayıt Silme İşleminiz Onaylanmıştır !!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            string sorgu = "select A.ARABA_ID,R.REZERVE_ID,M.MUSTERI_ID,M.TC_NO,M.ADI,M.SOYADI,R.ALIS_TAR,R.TESLIM_TAR from MUSTERI M,REZERVE R,ARABALAR A where M.MUSTERI_ID=r.MUSTERI_ID and A.ARABA_ID=R.ARABA_ID and R.REZERVE_DURUM=0";


            
            vt.baglan(sorgu, dataRezList, "REZERVE");
            dataRezList.Columns[0].Visible = false;
            dataRezList.Columns[1].Visible = false;
            dataRezList.Columns[2].Visible = false;

        }

    }
}
