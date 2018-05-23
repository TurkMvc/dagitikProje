using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sifreleme.Controller_Sinifi;
using sifreleme.Model_Siniflari;

namespace sifreleme.Kayit_Siniflari
{
    class Kullanici_Kayit
    {
        VeritabaniSinifiDataContext kayit = new VeritabaniSinifiDataContext();
       
        public void Kullanici_Ekle(TextBox ad, TextBox soyad, TextBox kullanici_ad, String sifre, string dogum_tarih, string aktif_durum, TextBox mail)
        {
            Kullanici_Controller _kullanici_controller = new Kullanici_Controller();
            Kullanici_Sinif _kullanici_sinif = new Kullanici_Sinif();

            _kullanici_sinif.Ad = ad.Text;
            _kullanici_sinif.Soyad = soyad.Text;
            _kullanici_sinif.Kullanici_ad = kullanici_ad.Text;
            _kullanici_sinif.Sifre = sifre;
            _kullanici_sinif.Dogum_tarih = Convert.ToDateTime(dogum_tarih);
            _kullanici_sinif.Mail = mail.Text;
            _kullanici_sinif.Aktif_durum = aktif_durum;

            _kullanici_controller.Setmodel(_kullanici_sinif);

            if (_kullanici_controller.kayit_islemi(_kullanici_sinif))

            {
                MessageBox.Show("Kişi kayıt edildi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Kayit Başarısız","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
           }

        }







    }
}
