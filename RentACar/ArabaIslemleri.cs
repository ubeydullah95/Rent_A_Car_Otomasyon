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
    public partial class ArabaIslemleri : Form
    {

        public int[] MARKA_ID;
        public int[] MODEL_ID;
        public int[] SERI_ID;
        public int SecilenArabaID;
        
        public ArabaIslemleri()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //AraçHareketleri
            try
            {
                DataSet ds = new DataSet();
                int secılenıd= SecilenArabaID = Convert.ToInt32((dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value).ToString());
                string sorgu = "select A.PLAKA_NO,M.TC_NO,M.ADI,M.SOYADI,K.ALIS_TARIHI,K.TESLIM_TARIHI,K.KIRA_TOPLAM_TUTAR from ARABALAR A,KIRALAMA_EMRI K,MUSTERI M,MARKALAR MA,MODEL MO,SERI SE where A.ARABA_ID=K.ARABA_ID and K.MUSTERI_ID=M.MUSTERI_ID and MA.MARKA_ID=A.MARKA_ID and MO.MODEL_ID=A.MODEL_ID and SE.SERI_ID=A.SERI_ID and A.ARABA_ID=" + secılenıd;
                VeriTabani vt = new VeriTabani();
                ds = vt.SorguCekDataSetGonder(sorgu, "ARABALAR");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    
                    vt.ExcellDoldur(ds, "ARABALAR");
                }
                else
                {
                    MessageBox.Show("Seçilen Arabanın Hareketi Bulunmamaktadır !!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                //TümListe();

            }
            catch (Exception)
            {
                MessageBox.Show("Listeden Kayıt Seçiniz !!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            //toolStripTextBox1.Text = toolStripTextBox1.Text.ToUpper(); 
        }

        private void toolStripTextBox1_Leave(object sender, EventArgs e)
        {
            TextArama.Text = TextArama.Text.ToUpper(); 
        }
        public void TümListe()
        {
            VeriTabani vt = new VeriTabani();
            string sorgu = "select A.ARABA_ID,A.PLAKA_NO,M.MARKA_ADI,MO.MODEL,S.SERI,A.YAKIT,A.VITES,A.KASA_TIPI,A.CEKIS,A.RENK,A.GUNLUK_UCRET,A.KULLANIM_DURUM from ARABALAR A,MARKALAR M, MODEL MO,SERI S where A.MARKA_ID=M.MARKA_ID and A.MODEL_ID=MO.MODEL_ID and A.SERI_ID=S.SERI_ID";
            vt.baglan(sorgu, dataGridView1, "ARABALAR");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[10].HeaderText = "UCRET";
            dataGridView1.Columns[11].HeaderText = "DURUM";
        }
        private void ArabaIslemleri_Load(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();
            MARKA_ID = vt.markaCek(comboMarka);
            comboMarka.Items.Add("Aradığınız Marka Yokmu ?");
            //comboModel.Items.Add("Aradığınız Model Yokmu ?");
            //comboSeri.Items.Add("Aradığınız Seri Yokmu ?");
            timer1.Enabled = true;
           // MessageBox.Show(MARKA_ID.Length.ToString());


            TümListe();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //araç güncelle
            try
            {
                SecilenArabaID = Convert.ToInt32((dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value).ToString());
                //MessageBox.Show(SecilenArabaID.ToString());
                AracGuncelle a = new AracGuncelle();
                a.GelenAraçID = SecilenArabaID;
                a.SeciliMarka = (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value).ToString();
                a.SeciliModel = (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value).ToString();
                a.SeciliSeri = (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value).ToString();
                a.Show();
                //TümListe();

            }
            catch (Exception)
            {
                MessageBox.Show("Listeden Kayıt Seçiniz !!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void TextPlakaNo_Leave(object sender, EventArgs e)
        {
            TextPlakaNo.Text = TextPlakaNo.Text.ToUpper();
        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboModel.SelectedIndex == comboModel.Items.Count - 1)
            {
                comboSeri.Items.Clear();
                comboSeri.Text = "";
                AracEkle form = new AracEkle();
                form.MARKA_ID = MARKA_ID[comboMarka.SelectedIndex];
                form.MARKA_ADI = comboMarka.SelectedItem.ToString();
                form.Show();

            }
            else
            {
                comboSeri.Text = "";
                VeriTabani vt = new VeriTabani();
                SERI_ID = vt.SeriCek(comboSeri, MODEL_ID[comboModel.SelectedIndex]);
                comboSeri.Items.Add("Aradığınız Seri Yokmu ?");
            }


            

        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMarka.SelectedIndex == comboMarka.Items.Count-1)
            {
                comboSeri.Items.Clear();
                comboModel.Items.Clear();
                comboModel.Text = "";
                comboSeri.Text = "";

                AracEkle form = new AracEkle();
                try
                {
                    form.EklenecekMarkaID = MARKA_ID[MARKA_ID.Length - 1] + 1;
                }
                catch (IndexOutOfRangeException)
                {
                    form.EklenecekMarkaID = 1;
                }
                form.Show();

            }
            else
            {
                comboModel.Text = "";
                comboSeri.Text = "";
                VeriTabani vt = new VeriTabani();
                MODEL_ID = vt.ModelCek(comboModel, MARKA_ID[comboMarka.SelectedIndex]);
                comboModel.Items.Add("Aradığınız Model Yokmu ?");
                comboSeri.Items.Clear();

            }
            

        }

        private void comboSeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSeri.SelectedIndex == comboSeri.Items.Count - 1)
            {
                comboSeri.Items.Clear();
                comboSeri.Text = "";
                AracEkle form = new AracEkle();
                form.MARKA_ID = MARKA_ID[comboMarka.SelectedIndex];
                form.MARKA_ADI = comboMarka.SelectedItem.ToString();
                form.MODEL_ID = MODEL_ID[comboModel.SelectedIndex];
                form.MODEL_ADI = comboModel.SelectedItem.ToString();
                form.Show();

            }
            else
            {
               
            }
        }
        public static int timerkontrol=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                if (timerkontrol == 1)
                {
                    VeriTabani vt = new VeriTabani();
                    MARKA_ID = vt.markaCek(comboMarka);
                    comboMarka.Text = "";
                    comboModel.Items.Clear();
                    comboSeri.Items.Clear();
                    comboMarka.Items.Add("Aradığınız Marka Yokmu ?");
                    comboModel.Items.Add("Aradığınız Model Yokmu ?");
                    comboSeri.Items.Add("Aradığınız Seri Yokmu ?");
                    timerkontrol = 0;
                }
                else if (timerkontrol == 2)
                {
                    comboModel.Text = "";
                    comboSeri.Text = "";

                    VeriTabani vt = new VeriTabani();
                    MODEL_ID = vt.ModelCek(comboModel, MARKA_ID[comboMarka.SelectedIndex]);
                    comboModel.Items.Add("Aradığınız Model Yokmu ?");
                    comboSeri.Items.Add("Aradığınız Seri Yokmu ?");
                    timerkontrol = 0;
                }
                else if (timerkontrol == 3)
                {
                    comboSeri.Text = "";
                    VeriTabani vt = new VeriTabani();
                    SERI_ID = vt.SeriCek(comboSeri, MODEL_ID[comboModel.SelectedIndex]);
                    comboSeri.Items.Add("Aradığınız Seri Yokmu ?");
                    timerkontrol = 0;
                }
                else if (timerkontrol == 4)
                {
                    TümListe();
                    timerkontrol = 0;
                }
            }
            catch (Exception)
            {
            }

        }

        private void BtnYeniKayit_Click(object sender, EventArgs e)
        {
            
            TextPlakaNo.Text = "";
            comboMarka.Text = "";
            comboModel.Text = "";
            comboSeri.Text = "";
            comboRenk.Text = "";
            comboVites.Text = "";
            comboCekis.Text = "";
            comboKasaTip.Text = "";
            comboYakıt.Text = "";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Kayıt Ekle
            try
            {
                VeriTabani vt = new VeriTabani();
                vt.ArabaEkle(TextPlakaNo.Text, MARKA_ID[comboMarka.SelectedIndex], MODEL_ID[comboModel.SelectedIndex], SERI_ID[comboSeri.SelectedIndex], comboYakıt.SelectedItem.ToString(), comboVites.SelectedItem.ToString(), comboKasaTip.SelectedItem.ToString(), comboCekis.SelectedItem.ToString(), comboRenk.SelectedItem.ToString(), int.Parse(textKiloMetre.Text), int.Parse(textUcret.Text), "BOŞTA");
                TümListe();
            }
            catch (SqlException)
            {
                MessageBox.Show("Bu Plaka Sisteme Kayıtlıdır!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //kayıt Sil
            try
            {
                SecilenArabaID = Convert.ToInt32((dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value).ToString());
                //MessageBox.Show(SecilenArabaID.ToString());
                VeriTabani vt = new VeriTabani();
                DialogResult a = MessageBox.Show("Kayıt Silinecek Onaylıyormusunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    vt.ArabaSil(SecilenArabaID);
                }
                TümListe();
               
            }
            catch (Exception)
            {
                MessageBox.Show("Listeden Kayıt Seçiniz !!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TümListe();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
