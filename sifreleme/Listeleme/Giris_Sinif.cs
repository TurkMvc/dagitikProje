using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifreleme.Listeleme
{

    class Giris_Sinif
    {
        VeritabaniSinifiDataContext baglan = new VeritabaniSinifiDataContext();
        public static int kullanici_id;
        public static string kullanici_ad;

        public bool giris(TextBox ad, String sifre)
        {
            var a = from _kullanici in baglan.kullanicilars
                    where _kullanici.kullanici_ad==ad.Text && _kullanici.sifre==sifre
                    select new { _kullanici.kullanici_ad, _kullanici.id, _kullanici.sifre };


            if (!(a == null))
            {
                foreach(var result in a ) 
                    
               {
                        kullanici_id= result.id;
                        kullanici_ad = result.kullanici_ad;
                        return true;
                }

            }
            else
            {
                return false;
            }
          return  false;
        }
    }
}
