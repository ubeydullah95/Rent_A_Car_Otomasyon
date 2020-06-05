using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace RentACar
{


    class VeriTabani
    {
        public static string kaynak = "Data Source=DESKTOP-OBBRT93; Integrated Security=TRUE;Initial Catalog=RENTACAR";
        //public static string kaynak = "Data Source = DESKTOP-VN8ATIN\\SQLEXPRESS;Integrated Security = TRUE;Initial Catalog=RENTACAR";
        SqlConnection baglanti = new SqlConnection(kaynak);
        SqlCommand komut;
        SqlDataAdapter veri;
        SqlDataReader oku;

        public int UserControl()
        {
            baglanti.Open();
            string Sorgu = "select count(CALISAN_ID) from CALISAN";
            komut = new SqlCommand(Sorgu, baglanti);
            int CalısanKisi = Convert.ToInt32(komut.ExecuteScalar().ToString());
            baglanti.Close();

            return CalısanKisi;
        }

        public int KullanıcıGiris(string KULLANICI_ADI,string SIFRE)
        {
            int rol=0;
            baglanti.Open();
            string sorgu = "select ROL from CALISAN where CALISAN_ID = (SELECT CALISAN_ID FROM CALISAN_BILGI where KULLANICI_ADI=" + "'" + KULLANICI_ADI + "' and SIFRE='" + SIFRE + "')";
            veri = new SqlDataAdapter(sorgu, baglanti);
            komut= new SqlCommand(sorgu,baglanti);
            DataSet ds = new DataSet();
            veri.Fill(ds, "CALISAN");
            if (ds.Tables[0].Rows.Count == 1)
            {
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    rol = (Convert.ToInt32(oku["ROL"]));
                }
            }
            else
            {
                rol = -1;
            }

            baglanti.Close();
            return rol;

        }
        public int CalısanIDAL(string KULLANICI_ADI, string SIFRE)
        {
            int CALISAN_ID = 0;
            baglanti.Open();
            
            string sorgu = "SELECT CALISAN_ID FROM CALISAN_BILGI where  KULLANICI_ADI=" + "'" + KULLANICI_ADI + "' and SIFRE='" + SIFRE + "'";
            komut = new SqlCommand(sorgu, baglanti);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CALISAN_ID = (Convert.ToInt32(oku["CALISAN_ID"]));
            }
            //CALISAN_ID = Convert.ToInt32(komut.ExecuteScalar().ToString());

            baglanti.Close();
            return CALISAN_ID;
        }
        public void CalısanEkle(string CALISAN_TC,string ADI,string SOYADI,int ROL,string KULLANICI_ADI,string SIFRE)
        {
            
                baglanti.Open();
                string sorgu = "Insert into CALISAN Values(@CALISAN_TC,@ADI,@SOYADI,@ROL)";//@KULLANICI_ADI,@SIFRE)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@CALISAN_TC", CALISAN_TC);
                komut.Parameters.AddWithValue("@ADI", ADI);
                komut.Parameters.AddWithValue("@SOYADI", SOYADI);
                komut.Parameters.AddWithValue("@ROL", ROL);
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();

                sorgu = "SELECT top 1 CALISAN_ID FROM CALISAN order by CALISAN_ID desc ";
                komut = new SqlCommand(sorgu, baglanti);
                int SonKayıtID = Convert.ToInt32(komut.ExecuteScalar().ToString());
                baglanti.Close();


                baglanti.Open();
                sorgu = "Insert into CALISAN_BILGI Values(@CALISAN_ID,@KULLANICI_ADI,@SIFRE)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@CALISAN_ID", SonKayıtID);
                komut.Parameters.AddWithValue("@KULLANICI_ADI", KULLANICI_ADI);
                komut.Parameters.AddWithValue("@SIFRE", SIFRE);
                komut.ExecuteNonQuery();
                baglanti.Close();
            
          
        }
        public void CalısanSil(int CalısanID)
        {
            string sorgu = "delete from CALISAN where CALISAN_ID=" + CalısanID;
            baglanti.Open();
            komut = new SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();

            baglanti.Close();
        }
        public void CalısanGuncelle(int CALISAN_ID, string CALISAN_TC, string ADI, string SOYADI, int ROL, string KULLANICI_ADI, string SIFRE)
        {
            baglanti.Open();
            string sorgu = "update CALISAN set CALISAN_TC=@CALISAN_TC,ADI=@ADI,SOYADI=@SOYADI,ROL=@ROL where CALISAN_ID=@CALISAN_ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@CALISAN_TC", CALISAN_TC);
            komut.Parameters.AddWithValue("@ADI", ADI);
            komut.Parameters.AddWithValue("@SOYADI", SOYADI);
            komut.Parameters.AddWithValue("@ROL", ROL);
            komut.Parameters.AddWithValue("@CALISAN_ID", CALISAN_ID);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            baglanti.Open();
            sorgu = "update CALISAN_BILGI set KULLANICI_ADI=@KULLANICI_ADI,SIFRE=@SIFRE where CALISAN_ID=@CALISAN_ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@KULLANICI_ADI", KULLANICI_ADI);
            komut.Parameters.AddWithValue("@SIFRE", SIFRE);
            komut.Parameters.AddWithValue("@CALISAN_ID", CALISAN_ID);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void baglan(string sorgu, DataGridView Datagrid,string TabloAdı)
        {
            baglanti.Open();
            veri = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            veri.Fill(ds, TabloAdı);
            Datagrid.DataSource = ds.Tables[TabloAdı];
            Datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //Başlık sütunu da dahil tüm sütunları otomatik olarak boyutlandırır.

            //Datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            //DataGridView'deki tüm hücreleri otomatik olarak boyutlandırır fakat sütun isimlerini bu işe dahil etmez.

            //Datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            //Otomatik boyutlandırmayı sadece sütun başlıklarına göre yapar.

            //Datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            //Otomatik boyutlandırmayı DataGridView'daki görünen hücrelere göre yapar, başlıkları bu boyutlandırmaya dahil etmez.

            baglanti.Close();

        }

        public void MusteriEkle(string TC_NO,string ADI,string SOYADI,DateTime D_TARIH,string ADRES, string TEL_NO,string E_MAIL,bool DURUM)
        {
            baglanti.Open();
            string sorgu = "Insert into MUSTERI Values(@TC_NO,@ADI,@SOYADI,@D_TARIH,@ADRES,@TEL_NO,@E_MAIL,@DURUM)";//@KULLANICI_ADI,@SIFRE)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TC_NO", TC_NO);
            komut.Parameters.AddWithValue("@ADI", ADI);
            komut.Parameters.AddWithValue("@SOYADI", SOYADI);
            komut.Parameters.AddWithValue("@D_TARIH", D_TARIH);
            komut.Parameters.AddWithValue("@ADRES", ADRES);
            komut.Parameters.AddWithValue("@TEL_NO", TEL_NO);
            komut.Parameters.AddWithValue("@E_MAIL", E_MAIL);
            komut.Parameters.AddWithValue("@DURUM", DURUM);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void MusteriSil(int MUSTERI_ID)
        {
            baglanti.Open();
            string sorgu = "delete from MUSTERI where MUSTERI_ID=" + MUSTERI_ID;
            komut = new SqlCommand(sorgu, baglanti);
           
            komut.ExecuteNonQuery();

            baglanti.Close();
        }

        public DataSet MusteriGonder(int MUSTERI_ID)
        {
           
            baglanti.Open();
            string sorgu = "select * from MUSTERI where MUSTERI_ID=" + MUSTERI_ID;
            veri = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            veri.Fill(ds, "MUSTERI");
            baglanti.Close();
            return ds;   
        }

        public void MusteriGuncelle(string TC_NO, string ADI, string SOYADI, DateTime D_TARIH, string ADRES, string TEL_NO, string E_MAIL, bool DURUM,int MUSTERI_ID)
        {
            baglanti.Open();
            string sorgu = "update MUSTERI set TC_NO=@TC_NO,ADI=@ADI,SOYADI=@SOYADI,D_TARIH=@D_TARIH,ADRES=@ADRES,TEL_NO=@TEL_NO,E_MAIL=@E_MAIL,DURUM=@DURUM where MUSTERI_ID=@MUSTERI_ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TC_NO", TC_NO);
            komut.Parameters.AddWithValue("@ADI", ADI);
            komut.Parameters.AddWithValue("@SOYADI", SOYADI);
            komut.Parameters.AddWithValue("@D_TARIH", D_TARIH);
            komut.Parameters.AddWithValue("@ADRES", ADRES);
            komut.Parameters.AddWithValue("@TEL_NO", TEL_NO);
            komut.Parameters.AddWithValue("@E_MAIL", E_MAIL);
            komut.Parameters.AddWithValue("@DURUM", DURUM);
            komut.Parameters.AddWithValue("@MUSTERI_ID", MUSTERI_ID);
            komut.ExecuteNonQuery();

            baglanti.Close();
        }

        public int[] markaCek(ComboBox combomarka)
        {
            combomarka.Items.Clear();
            int[] dizi;
            baglanti.Open();
            string sorgu = "select count(MARKA_ID) from MARKALAR";
            komut = new SqlCommand(sorgu, baglanti);
            int markaSayisi = Convert.ToInt32(komut.ExecuteScalar().ToString());
            dizi = new int[markaSayisi];
            baglanti.Close();

            baglanti.Open();
            sorgu = "select * from MARKALAR";
            komut = new SqlCommand(sorgu, baglanti);
            oku = komut.ExecuteReader();
            int sayac = 0;
            while (oku.Read())
            {
                dizi[sayac] = Convert.ToInt32(oku["MARKA_ID"]);
                combomarka.Items.Add(oku["MARKA_ADI"]);
                sayac++;
            }
            baglanti.Close();
            return dizi;
        }
        public int[] ModelCek(ComboBox ComboModel,int MARKA_ID)
        {
            ComboModel.Items.Clear();
            int[] dizi;
            baglanti.Open();
            string sorgu = "select count(MODEL_ID) from MODEL where MARKA_ID=" + MARKA_ID;
            komut = new SqlCommand(sorgu, baglanti);
            int modelSayisi = Convert.ToInt32(komut.ExecuteScalar().ToString());
            dizi = new int[modelSayisi];
            baglanti.Close();

            baglanti.Open();
            sorgu = "select * from MODEL where MARKA_ID=" + MARKA_ID;
            komut = new SqlCommand(sorgu, baglanti);
            oku = komut.ExecuteReader();
            int sayac = 0;
            while (oku.Read())
            {
                dizi[sayac] = Convert.ToInt32(oku["MODEL_ID"]);
                ComboModel.Items.Add(oku["MODEL"]);
                sayac++;
            }
            baglanti.Close();
            return dizi;
        }

        public int[] SeriCek(ComboBox ComboSeri, int MODEL_ID)
        {
            ComboSeri.Items.Clear();
            int[] dizi;
            baglanti.Open();
            string sorgu = "select count(SERI_ID) from SERI where MODEL_ID=" + MODEL_ID;
            komut = new SqlCommand(sorgu, baglanti);
            int SeriSayısı = Convert.ToInt32(komut.ExecuteScalar().ToString());
            dizi = new int[SeriSayısı];
            baglanti.Close();

            baglanti.Open();
            sorgu = "select * from SERI where MODEL_ID=" + MODEL_ID;
            komut = new SqlCommand(sorgu, baglanti);
            oku = komut.ExecuteReader();
            int sayac = 0;
            while (oku.Read())
            {
                dizi[sayac] = Convert.ToInt32(oku["SERI_ID"]);
                ComboSeri.Items.Add(oku["SERI"]);
                sayac++;
            }
            baglanti.Close();
            return dizi;

        }
        public void MarkaModelSeriEkle(int MARKA_ID,string MARKA_ADI,int MODEL_ID,string MODEL,string SERI)
        {
            baglanti.Open();
            string sorgu = "insert into MARKALAR VALUES(@MARKA_ID,@MARKA_ADI)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@MARKA_ID", MARKA_ID);
            komut.Parameters.AddWithValue("@MARKA_ADI", MARKA_ADI);
            komut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            sorgu = "insert into MODEL VALUES(@MARKA_ID,@MODEL)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@MARKA_ID", MARKA_ID);
            komut.Parameters.AddWithValue("@MODEL", MODEL);
            komut.ExecuteNonQuery();
            baglanti.Close();

            //son eklenen modelin ID sini çekmemiz gerekiyor
            baglanti.Open();
            sorgu = "SELECT top 1 MODEL_ID FROM MODEL order by MODEL_ID desc ";
            komut = new SqlCommand(sorgu, baglanti);
            int SonModelID = Convert.ToInt32(komut.ExecuteScalar().ToString());
            baglanti.Close();

            baglanti.Open();
            sorgu = "insert into SERI VALUES(@MODEL_ID,@SERI)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@MODEL_ID", SonModelID);
            komut.Parameters.AddWithValue("@SERI", SERI);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public void MODELSERIekle(int MARKA_ID, string MODEL, string SERI)
        {
            baglanti.Open();
            string sorgu = "insert into MODEL VALUES(@MARKA_ID,@MODEL)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@MARKA_ID", MARKA_ID);
            komut.Parameters.AddWithValue("@MODEL", MODEL);
            komut.ExecuteNonQuery();
            baglanti.Close();

            //son eklenen modelin ID sini çekmemiz gerekiyor
            baglanti.Open();
            sorgu = "SELECT top 1 MODEL_ID FROM MODEL order by MODEL_ID desc ";
            komut = new SqlCommand(sorgu, baglanti);
            int SonModelID = Convert.ToInt32(komut.ExecuteScalar().ToString());
            baglanti.Close();

            baglanti.Open();
            sorgu = "insert into SERI VALUES(@MODEL_ID,@SERI)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@MODEL_ID", SonModelID);
            komut.Parameters.AddWithValue("@SERI", SERI);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public void SERIekle(string SERI,int MODEL_ID)
        {
            //son eklenen modelin ID sini çekmemiz gerekiyor

            baglanti.Open();
            string sorgu = "insert into SERI VALUES(@MODEL_ID,@SERI)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@MODEL_ID", MODEL_ID);
            komut.Parameters.AddWithValue("@SERI", SERI);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public void ArabaEkle(string PLAKA_NO,int MARKA_ID,int MODEL_ID,int SERI_ID,string YAKIT,string VITES, string KASA_TIPI, string CEKIS, string RENK, int KM,int GUNLUK_UCRET, string KULLANIM_DURUM)
        {
            baglanti.Open();

            string sorgu = "insert into ARABALAR values(@PLAKA_NO,@MARKA_ID,@MODEL_ID,@SERI_ID,@YAKIT,@VITES, @KASA_TIPI, @CEKIS, @RENK, @KM,@GUNLUK_UCRET, @KULLANIM_DURUM)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@PLAKA_NO", PLAKA_NO);
            komut.Parameters.AddWithValue("@MARKA_ID", MARKA_ID);
            komut.Parameters.AddWithValue("@MODEL_ID", MODEL_ID);
            komut.Parameters.AddWithValue("@SERI_ID", SERI_ID);
            komut.Parameters.AddWithValue("@YAKIT", YAKIT);
            komut.Parameters.AddWithValue("@VITES", VITES);
            komut.Parameters.AddWithValue("@KASA_TIPI", KASA_TIPI);
            komut.Parameters.AddWithValue("@CEKIS", CEKIS);
            komut.Parameters.AddWithValue("@RENK", RENK);
            komut.Parameters.AddWithValue("@KM", KM);
            komut.Parameters.AddWithValue("@GUNLUK_UCRET", GUNLUK_UCRET);
            komut.Parameters.AddWithValue("@KULLANIM_DURUM", KULLANIM_DURUM);
            komut.ExecuteNonQuery();
            
            baglanti.Close();
        }

        public void ArabaSil(int ARABA_ID)
        {
            baglanti.Open();
            string sorgu = "delete from ARABALAR where ARABA_ID=" + ARABA_ID;
            komut = new SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();

            baglanti.Close();
        }

        public DataSet ArabaCek(int ARABA_ID)
        {
            baglanti.Open();
            string sorgu = "select PLAKA_NO,YAKIT,VITES,KASA_TIPI,CEKIS,RENK,KM,GUNLUK_UCRET from ARABALAR where ARABA_ID=" + ARABA_ID;
            veri = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            veri.Fill(ds, "ARABALAR");
            baglanti.Close();
            return ds;
        }

        public void AracGuncelle(string PLAKA_NO, int MARKA_ID, int MODEL_ID, int SERI_ID, string YAKIT, string VITES, string KASA_TIPI, string CEKIS, string RENK, int KM, int GUNLUK_UCRET, int ARABA_ID)
        {
            baglanti.Open();
            string sorgu = "update ARABALAR set PLAKA_NO=@PLAKA_NO ,MARKA_ID=@MARKA_ID, MODEL_ID=@MODEL_ID, SERI_ID=@SERI_ID, YAKIT=@YAKIT ,VITES=@VITES, KASA_TIPI=@KASA_TIPI, CEKIS=@CEKIS, RENK=@RENK, GUNLUK_UCRET=@GUNLUK_UCRET WHERE ARABA_ID=" + ARABA_ID;
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@PLAKA_NO", PLAKA_NO);
            komut.Parameters.AddWithValue("@MARKA_ID", MARKA_ID);
            komut.Parameters.AddWithValue("@MODEL_ID", MODEL_ID);
            komut.Parameters.AddWithValue("@SERI_ID", SERI_ID);
            komut.Parameters.AddWithValue("@YAKIT", YAKIT);
            komut.Parameters.AddWithValue("@VITES", VITES);
            komut.Parameters.AddWithValue("@KASA_TIPI", KASA_TIPI);
            komut.Parameters.AddWithValue("@CEKIS", CEKIS);
            komut.Parameters.AddWithValue("@RENK", RENK);
            komut.Parameters.AddWithValue("@KM", KM);
            komut.Parameters.AddWithValue("@GUNLUK_UCRET", GUNLUK_UCRET);
            komut.ExecuteNonQuery();


            baglanti.Close();

        }
        public int AracKMCek(int ARABA_ID)
        {
            int km = 0;
            string sorgu = "select KM from ARABALAR where ARABA_ID=" + ARABA_ID;
            baglanti.Open();
            komut = new SqlCommand(sorgu, baglanti);
            km = int.Parse(komut.ExecuteScalar().ToString());
            baglanti.Close();
            return km;
        }

        public void KiraEmriEkle(int CALISAN_ID,int ARABA_ID,int MUSTERI_ID,DateTime ALIS_TARIHI,DateTime TESLIM_TARIHI,int TOPLAM_GUN,bool TESLIM_DURUM,int KM_START,int KM_END,int KM_TOTAL,int KIRA_TOPLAM_TUTAR, bool ODENME_DURUM)
        {
            baglanti.Open();
            string sorgu = "insert into KIRALAMA_EMRI values(@CALISAN_ID,@ARABA_ID,@MUSTERI_ID,@ALIS_TARIHI,@TESLIM_TARIHI,@TOPLAM_GUN,@TESLIM_DURUM,@KM_START,@KM_END,@KM_TOTAL,@KIRA_TOPLAM_TUTAR,@ODENME_DURUM)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@CALISAN_ID", CALISAN_ID);
            komut.Parameters.AddWithValue("@ARABA_ID", CALISAN_ID);
            komut.Parameters.AddWithValue("@MUSTERI_ID", MUSTERI_ID);
            komut.Parameters.AddWithValue("@ALIS_TARIHI", ALIS_TARIHI);
            komut.Parameters.AddWithValue("@TESLIM_TARIHI", TESLIM_TARIHI);

            komut.Parameters.AddWithValue("@TOPLAM_GUN", TOPLAM_GUN);
            komut.Parameters.AddWithValue("@TESLIM_DURUM", TESLIM_DURUM);
            komut.Parameters.AddWithValue("@KM_START", KM_START);
            komut.Parameters.AddWithValue("@KM_END", KM_END);
            komut.Parameters.AddWithValue("@KM_TOTAL", KM_TOTAL);
            komut.Parameters.AddWithValue("@KIRA_TOPLAM_TUTAR", KIRA_TOPLAM_TUTAR);
            komut.Parameters.AddWithValue("@ODENME_DURUM", ODENME_DURUM);

            komut.ExecuteNonQuery();

            baglanti.Close();

        }
        public DataSet KiraEmriCek(string sorgu)
        {
            baglanti.Open();
            veri = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            veri.Fill(ds, "KIRALAMA_EMRI");
            baglanti.Close();
            return ds;
        }
        public void AracDurumGuncelle(int ARABA_ID,string durum)
        {
            baglanti.Open();
            string sorgu = "update ARABALAR set KULLANIM_DURUM='" + durum + "' where ARABA_ID=" + ARABA_ID;
            komut = new SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();

            baglanti.Close();

        }
        public int GünlükUcretCek(string PLAKA_NO)
        {
            int ucret;
            baglanti.Open();
            string sorgu = "select GUNLUK_UCRET from ARABALAR where PLAKA_NO='" + PLAKA_NO + "'";
            komut = new SqlCommand(sorgu, baglanti);
            ucret = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            
            return ucret;

        }

        public void KiraDurumGuncelle(int KIRA_ID,bool durum,DateTime TESLIM_TARIHI,int TOPLAM_GUN,int KM_END,int KM_TOTAL,int KIRA_TOPLAM_TUTAR)
        {
            baglanti.Open();
            string sorgu = "update KIRALAMA_EMRI set TESLIM_DURUMU=@durum, TESLIM_TARIHI=@TESLIM_TARIHI, TOPLAM_GUN=@TOPLAM_GUN, KM_END=@KM_END, KM_TOTAL=@KM_TOTAL, KIRA_TOPLAM_TUTAR=@KIRA_TOPLAM_TUTAR where KIRA_ID=@KIRA_ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@durum", durum);
            komut.Parameters.AddWithValue("@TESLIM_TARIHI", TESLIM_TARIHI);
            komut.Parameters.AddWithValue("@TOPLAM_GUN", TOPLAM_GUN);
            komut.Parameters.AddWithValue("@KM_END", KM_END);
            komut.Parameters.AddWithValue("@KM_TOTAL", KM_TOTAL);
            komut.Parameters.AddWithValue("@KIRA_TOPLAM_TUTAR", KIRA_TOPLAM_TUTAR);
            komut.Parameters.AddWithValue("@KIRA_ID", KIRA_ID);

            komut.ExecuteNonQuery();

            baglanti.Close();

        }

        public int KiraOdenmeDurumCek(int KIRA_ID)
        {
            int ODENME_DURUM;
            baglanti.Open();

            string sorgu = "select ODENME_DURUMU from KIRALAMA_EMRI where KIRA_ID=" + KIRA_ID;
            komut = new SqlCommand(sorgu, baglanti);
            ODENME_DURUM = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            return ODENME_DURUM;
            

        }
        
        public void ODEMEEKLE(int KIRA_ID, DateTime ODEME_TARIH, string ODEME_SEKLI, int ODEME_TUTARI, int CALISAN_ID)
        {
            baglanti.Open();
            string sorgu = "update  KIRALAMA_EMRI set ODENME_DURUMU=@durum where KIRA_ID=" + KIRA_ID;
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@durum", true);
            komut.ExecuteNonQuery();

            baglanti.Close();


            baglanti.Open();
             sorgu = "insert into ODEMELER values(@KIRA_ID,@ODEME_TARIH,@ODEME_SEKLI,@ODEME_TUTARI,@CALISAN_ID)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@KIRA_ID", KIRA_ID);
            komut.Parameters.AddWithValue("@ODEME_TARIH", ODEME_TARIH);
            komut.Parameters.AddWithValue("@ODEME_SEKLI", ODEME_SEKLI);
            komut.Parameters.AddWithValue("@ODEME_TUTARI", ODEME_TUTARI);
            komut.Parameters.AddWithValue("@CALISAN_ID", CALISAN_ID);

            komut.ExecuteNonQuery();
            baglanti.Close();


            

        }

        public int AracIDCek(string PLAKA_NO)
        {
            baglanti.Open();
            string sorgu = "select ARABA_ID from ARABALAR where PLAKA_NO='" + PLAKA_NO + "'";
            komut = new SqlCommand(sorgu, baglanti);
            int ARAC_ID = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            return ARAC_ID;
        }
        public int AracUcretCek(int ARABA_ID)
        {
            baglanti.Open();
            string sorgu = "select GUNLUK_UCRET from ARABALAR where ARABA_ID=" + ARABA_ID;
            komut = new SqlCommand(sorgu, baglanti);
            int GUNLUK_UCRET = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            return GUNLUK_UCRET;
        }
        public void AracKmGuncelle(int ARABA_ID,int KM)
        {
            baglanti.Open();
            string sorgu = "update ARABALAR set KM=" + KM + " where ARABA_ID=" + ARABA_ID;
            komut = new SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();

            baglanti.Close();

        }
        public void RezerveEkle(int CALISAN_ID,int ARABA_ID,int MUSTERI_ID,DateTime ALIS_TAR,DateTime TESLIM_TAR,bool REZERVE_DURUM)
        {
            baglanti.Open();
            string sorgu = "insert into REZERVE values(@CALISAN_ID,@ARABA_ID,@MUSTERI_ID,@ALIS_TAR,@TESLIM_TAR,@REZERVE_DURUM)";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@CALISAN_ID", CALISAN_ID);
            komut.Parameters.AddWithValue("@ARABA_ID", ARABA_ID);
            komut.Parameters.AddWithValue("@MUSTERI_ID", MUSTERI_ID);
            komut.Parameters.AddWithValue("@ALIS_TAR", ALIS_TAR);
            komut.Parameters.AddWithValue("@TESLIM_TAR", TESLIM_TAR);
            komut.Parameters.AddWithValue("@REZERVE_DURUM", REZERVE_DURUM);
            komut.ExecuteNonQuery();

            baglanti.Close();
        }
        public void RezerveDurum(int REZERVE_ID, bool REZERVE_DURUM)
        {
            baglanti.Open();
            string sorgu = "update REZERVE set REZERVE_DURUM=@REZERVE_DURUM where REZERVE_ID=@REZERVE_ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@REZERVE_DURUM", REZERVE_DURUM);
            komut.Parameters.AddWithValue("@REZERVE_ID", REZERVE_ID);
            komut.ExecuteNonQuery();

            baglanti.Close();


        }

        public void RezerveSil(int REZERVE_ID)
        {


            baglanti.Open();
            string sorgu = "delete from REZERVE where REZERVE_ID=" + REZERVE_ID;
            komut = new SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public DataSet SorguCekDataSetGonder(string sorgu,string tabloadi)
        {
            baglanti.Open();
            veri = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            veri.Fill(ds, tabloadi);
            baglanti.Close();
            return ds;
        }
        
        
       // private Excel.Application Excelim; private Excel.Workbook CalismaKitabi; private Excel.Worksheet CalismaSayfasi;
        public void ExcellDoldur(DataSet ds, string CalismaSayfasiIsmi)
        {
            Excel.Application excelU = new Excel.Application(); excelU.UserControl = false;
            Excel.Workbook kitap = excelU.Workbooks.Add(true);
            Excel.Worksheet sayfa = (Excel.Worksheet)excelU.ActiveSheet;

            excelU.EnableAutoComplete = true;
            Int64 Satir = 2;
            Int64 Sutun = 0;

            foreach (DataColumn excelSu in ds.Tables[0].Columns)
            {

                Sutun++;
                sayfa.Cells[1, Sutun] = excelSu.ColumnName;
                Excel.Range rng = sayfa.Cells[1, Sutun];
                rng.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                rng.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.RoyalBlue);
                rng.RowHeight = 16;
                rng.Rows.VerticalAlignment = 2;
                rng.Borders.Color = System.Drawing.Color.Black;
                rng.EntireColumn.AutoFit();
                rng.Font.Bold = true;
                rng.Borders.LineStyle = Excel.XlBorderWeight.xlHairline;


            }

            sayfa.Application.ActiveWindow.SplitRow = 1;
            sayfa.Application.ActiveWindow.FreezePanes = true;

            foreach (DataRow excelSa in ds.Tables[0].Rows)
            {
               
                Sutun = 0;

                foreach (DataColumn excelSu in ds.Tables[0].Columns)
                {
                    Sutun++;
                    sayfa.Cells[Satir, Sutun] = excelSa[excelSu.ColumnName].ToString();
                }
                Satir++;
            }
            sayfa.Columns.EntireColumn.AutoFit();

            excelU.Visible = true;
        }

       




    }
    


}
