using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sifreleme.Model_Siniflari;

namespace sifreleme.Controller_Sinifi
{
    class Kullanici_Controller
    {
        VeritabaniSinifiDataContext kayit = new VeritabaniSinifiDataContext();
        Kullanici_Sinif kullanici;

        public Kullanici_Controller()
        { }

        public Kullanici_Controller(Kullanici_Sinif kullanici_kayit)
        {
            this.kullanici = kullanici_kayit;

        }

        public void Setmodel(Kullanici_Sinif kullanici_kayit)
        {
            this.kullanici = kullanici_kayit;

        }

        public bool kayit_islemi(Kullanici_Sinif kullanici_kayit)
        {

            try
            {
                kullanicilar ds = new kullanicilar();
                ds.ad = kullanici_kayit.Ad;
                ds.soyad = kullanici_kayit.Soyad;
                ds.kullanici_ad = kullanici_kayit.Kullanici_ad;
                ds.mail = kullanici_kayit.Mail;
                ds.sifre = kullanici_kayit.Sifre;
                ds.dogum_tarih = kullanici_kayit.Dogum_tarih;
                ds.aktif_durum = kullanici_kayit.Aktif_durum;
                kayit.kullanicilars.InsertOnSubmit(ds);
                kayit.SubmitChanges();

              return true;
            }
            catch
            {
                return false;
            }

            
        }

    }
}
