using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using k = Microsoft.VisualBasic.Interaction;

namespace RentACar
{
    public partial class AdminAnaSayfa : Form
    {
        public int CalısanID;
        public int Rol;
        public AdminAnaSayfa()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ArabaIslemleri a = new ArabaIslemleri();
            a.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MusteriIslemleri a = new MusteriIslemleri();
            a.Show();
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OdemeYap form = new OdemeYap();
            form.CALISAN_ID = CalısanID;
            form.Show();
        }

        private void AdminAnaSayfa_Load(object sender, EventArgs e)
        {
          // MessageBox.Show(CalısanID.ToString());
            if (Rol == 1)
            {
                toolStripButton2.Enabled = false;
                toolStripButton7.Enabled = false;
                this.Text = "AnaSayfa";

            }
            

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            KiralamaEmri form = new KiralamaEmri();
            form.CALISAN_ID = CalısanID;
            form.RezerveKiraDurum = 0;
            form.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            AracTeslim form = new AracTeslim();
            form.CALISAN_ID = CalısanID;
            form.Show();

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            CalisanIs form = new CalisanIs();
            form.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void rEZERVEEMRİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiralamaEmri form = new KiralamaEmri();
            form.CALISAN_ID = CalısanID;
            form.RezerveKiraDurum = 1;
            form.Show();
        }

        private void rEZERVEONAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervecs form = new Rezervecs();
            form.CALISAN_ID = CalısanID;
            form.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AracSorguları a = new AracSorguları();
            a.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DateTime bas = Convert.ToDateTime(k.InputBox("Başlangıç Tarihini Giriniz ? ", "Başlangıç Tarihi", DateTime.Now.ToShortDateString()));
            DateTime bit = Convert.ToDateTime(k.InputBox("Bitiş Tarihini Giriniz ? ", "Bitiş Tarihi", DateTime.Now.ToShortDateString()));
            string baslangıc = bas.ToString("yyyy-MM-dd HH:mm:ss.FFF");
            string bitis = bit.ToString("yyyy-MM-dd HH:mm:ss.FFF");

            string sorgu = "select A.PLAKA_NO,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KIRA_TOPLAM_TUTAR from ARABALAR A,KIRALAMA_EMRI K,MUSTERI M,MARKALAR MA,MODEL MO,SERI SE where A.ARABA_ID=K.ARABA_ID and K.MUSTERI_ID=M.MUSTERI_ID and MA.MARKA_ID=A.MARKA_ID and MO.MODEL_ID=A.MODEL_ID and SE.SERI_ID=A.SERI_ID and  K.TESLIM_TARIHI>='" + baslangıc + "' and K.TESLIM_TARIHI <='" + bitis + "'";
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
    }
}
