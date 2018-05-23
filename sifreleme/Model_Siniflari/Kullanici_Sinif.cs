using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifreleme.Model_Siniflari
{
    class Kullanici_Sinif
    {
        private int ıd;
        private string ad;
        private string soyad;
        private string kullanici_ad;
        private string sifre;
        private DateTime dogum_tarih;
        private String aktif_durum;
        private String mail;

        public int Id
        {
            get
            {
                return ıd;
            }

            set
            {
                ıd = value;
            }
        }

        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value;
            }
        }

        public string Kullanici_ad
        {
            get
            {
                return kullanici_ad;
            }

            set
            {
                kullanici_ad = value;
            }
        }

        public string Sifre
        {
            get
            {
                return sifre;
            }

            set
            {
                sifre = value;
            }
        }

        public DateTime Dogum_tarih
        {
            get
            {
                return dogum_tarih;
            }

            set
            {
                dogum_tarih = value;
            }
        }

        public String Aktif_durum
        {
            get
            {
                return aktif_durum;
            }

            set
            {
                aktif_durum = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }
    }
}
