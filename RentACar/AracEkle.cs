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
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }
        public bool Guncellemi = false;
        public int EklenecekMarkaID=0;
        public int MARKA_ID = 0;
        public int MODEL_ID = 0;
        public string MARKA_ADI;
        public string MODEL_ADI;


        private void AracEkle_Load(object sender, EventArgs e)
        {

           // MessageBox.Show(EklenecekMarkaID.ToString());
            if (MARKA_ID != 0)
            {
                //MessageBox.Show(EklenecekMarkaID.ToString());
                // model alanları identity olduğu için sorun yok
                textMarka.Text = MARKA_ADI;
                textMarka.Enabled = false;

            }
            if (MODEL_ID != 0)
            {
                textModel.Text = MODEL_ADI;
                textMarka.Enabled = false;
                textModel.Enabled = false;
            }
            

        }

        private void btnIptal_Click(object sender, EventArgs e)
        { 

            
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (EklenecekMarkaID != 0)
            {
                //tüm alanlar eklenecek
                VeriTabani vt = new VeriTabani();
                vt.MarkaModelSeriEkle(EklenecekMarkaID, textMarka.Text, MODEL_ID, textModel.Text, textSeri.Text);
                DialogResult a = MessageBox.Show("Kaydınız Başarıyla Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (a.ToString() == DialogResult.OK.ToString())
                {
                    if (!Guncellemi)
                    {
                        ArabaIslemleri.timerkontrol = 1;
                        this.Close();
                    }
                    else
                    {
                        ArabaIslemleri.timerkontrol = 1;
                        AracGuncelle.timerkontrol = 1;
                        this.Close();
                    }
                }


            }
            else if (MODEL_ID == 0)
            {
                //seri ve model alanları eklenecek
                VeriTabani vt = new VeriTabani();
                vt.MODELSERIekle(MARKA_ID, textModel.Text, textSeri.Text);
                DialogResult a = MessageBox.Show("Kaydınız Başarıyla Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!Guncellemi)
                {
                    ArabaIslemleri.timerkontrol = 2;
                    this.Close();
                }
                else
                {
                    ArabaIslemleri.timerkontrol = 2;
                    AracGuncelle.timerkontrol = 2;
                    this.Close();
                }

            }
            else if (MARKA_ID != 0 && MODEL_ID != 0)
            {
                // sadece seri alanı eklenecek
                VeriTabani vt = new VeriTabani();
                vt.SERIekle(textSeri.Text,MODEL_ID);
                DialogResult a = MessageBox.Show("Kaydınız Başarıyla Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (a.ToString() == DialogResult.OK.ToString())
                {
                    if (!Guncellemi)
                    {
                        ArabaIslemleri.timerkontrol = 3;
                        this.Close();
                    }
                    else
                    {
                        ArabaIslemleri.timerkontrol = 3;
                        AracGuncelle.timerkontrol = 3;
                        this.Close();
                    }
                }

            }




        }

        private void textMarka_Leave(object sender, EventArgs e)
        {
            textMarka.Text = textMarka.Text.ToUpper();
        }

        private void textModel_Leave(object sender, EventArgs e)
        {
            textModel.Text = textModel.Text.ToUpper();
        }

        private void textSeri_Leave(object sender, EventArgs e)
        {
            textSeri.Text = textSeri.Text.ToUpper();
        }


    }
}
