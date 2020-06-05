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
    public partial class AracGuncelle : Form
    {
        public AracGuncelle()
        {
            InitializeComponent();
        }
        public int GelenAraçID;
        public int[] MARKA_ID;
        public int[] MODEL_ID;
        public int[] SERI_ID;
        public string SeciliMarka, SeciliModel, SeciliSeri;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //Burası değişesek

            



        }
        public bool a = false;
        private void AracGuncelle_Load(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();
            MARKA_ID = vt.markaCek(comboMarka);
            comboMarka.SelectedItem = SeciliMarka;

            MODEL_ID = vt.ModelCek(comboModel, MARKA_ID[comboMarka.SelectedIndex]);
            comboModel.SelectedItem = SeciliModel;

            SERI_ID = vt.SeriCek(comboSeri, MODEL_ID[comboModel.SelectedIndex]);
            comboSeri.SelectedItem = SeciliSeri;

            comboMarka.Items.Add("Aradığınız Marka Yokmu ?");
            comboModel.Items.Add("Aradığınız Model Yokmu ?");
            comboSeri.Items.Add("Aradığınız Seri Yokmu ?");
            timer1.Enabled = true;
            //MessageBox.Show(GelenAraçID.ToString());
            a = true; // a yı doğu yapmamızın nedeni lood olayında kodlar yüklenirken sistemin karışması!!

            DataSet ds = new DataSet();
            ds = vt.ArabaCek(GelenAraçID);
            textPlaka.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            comboYakıt.SelectedItem = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            comboVites.SelectedItem = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            comboKasaTip.SelectedItem = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            comboCekis.SelectedItem = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            comboRenk.SelectedItem = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            textKiloMetre.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            textGunlukUcret.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textKiloMetre_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a)
            {
                if (comboMarka.SelectedIndex == comboMarka.Items.Count - 1)
                {
                    comboSeri.Items.Clear();
                    comboModel.Items.Clear();
                    comboModel.Text = "";
                    comboSeri.Text = "";

                    AracEkle form = new AracEkle();
                    
                    try
                    {
                        form.EklenecekMarkaID = MARKA_ID[MARKA_ID.Length - 1] + 1;
                        form.Guncellemi = true;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        form.EklenecekMarkaID = 1;//ilk araba kayıtında bos deger alamayacagı ıcın 1 gonderıyoruz
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
        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a)
            {
                if (comboModel.SelectedIndex == comboModel.Items.Count - 1)
                {
                    comboSeri.Items.Clear();
                    comboSeri.Text = "";
                    AracEkle form = new AracEkle();
                    form.MARKA_ID = MARKA_ID[comboMarka.SelectedIndex];
                    form.MARKA_ADI = comboMarka.SelectedItem.ToString();
                    form.Guncellemi = true;
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
        }

        private void comboSeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a)
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
                    form.Guncellemi = true;
                    form.Show();

                }
                else
                {

                }
            }
        }
        public static int timerkontrol=0;
        private void timer1_Tick(object sender, EventArgs e)
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


        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //araç güncelleme kısmı
           
            VeriTabani vt = new VeriTabani();
            vt.AracGuncelle(textPlaka.Text, MARKA_ID[comboMarka.SelectedIndex], MODEL_ID[comboModel.SelectedIndex], SERI_ID[comboSeri.SelectedIndex], comboYakıt.SelectedItem.ToString(), comboVites.SelectedItem.ToString(), comboKasaTip.SelectedItem.ToString(), comboCekis.SelectedItem.ToString(), comboRenk.SelectedItem.ToString(), int.Parse(textKiloMetre.Text), int.Parse(textGunlukUcret.Text), GelenAraçID);
            MessageBox.Show("Kaydınız Güncellenmiştir !", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ArabaIslemleri.timerkontrol = 4;
            this.Close();
        }
    }
}
