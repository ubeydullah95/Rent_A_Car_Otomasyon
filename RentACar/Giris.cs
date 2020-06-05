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
    public partial class Giris : Form
    {
        public int timerkontrol = 0;
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();
            int rol = vt.KullanıcıGiris(textKullaniciAdi.Text, textSifre.Text);
            //MessageBox.Show(rol.ToString());
            if (rol == -1)
            {
                MessageBox.Show("Şifre Veya Parola Yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textKullaniciAdi.Text = "";
                textSifre.Text = "";
                textKullaniciAdi.Focus();
            
            }
            else if (rol == 0|| rol==1)
            {
                AdminAnaSayfa form = new AdminAnaSayfa();  
                int GElenID = vt.CalısanIDAL(textKullaniciAdi.Text, textSifre.Text);
                form.CalısanID = GElenID;
                form.Rol = rol;
                form.Show();
                this.Hide();
            }
            else
            {

                //çalışan ana sayfası açılacak

            }
            
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            textKullaniciAdi.Text = "ubey";
            textSifre.Text = "1";
            VeriTabani vt = new VeriTabani();
            int sayi = vt.UserControl();
            if (sayi == 0)
            {
                CalisanGuncelle form = new CalisanGuncelle();
                form.GelenID = sayi;
                form.Text = "İlk Giriş İçin Hesap Oluşturma";
                MessageBox.Show("Sisteme İlk kez giriş yaptığınızı görmüş bulunmaktayız\n"
                    + "Sisteme giriş yapabilmeniz için üye tanımlanamız gereklidir\n", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.Show();
                timerkontrol = 0;
                timer1.Enabled = true;


            }
            else
            {
                timerkontrol = 1;
            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerkontrol == 0)
            {
                this.Visible = false;
            }
            else
            {

            }

        }
    }
}
