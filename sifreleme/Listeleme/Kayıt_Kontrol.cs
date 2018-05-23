using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifreleme.Listeleme
{
    class Kayıt_Kontrol
    {
        VeritabaniSinifiDataContext baglan = new VeritabaniSinifiDataContext();
        public bool Kullanici_Kontrol(TextBox ad)
        {
            var a = from _kullanici in baglan.kullanicilars
                    where _kullanici.ad.Contains(ad.Text)
                    select new { _kullanici.kullanici_ad };
            
            if(!(a==null))
            {
                foreach(var result in a) 
                    if(result.kullanici_ad==ad.Text)
                    {
                        return true;
                    }
            }
            else
            {
                return false;
            }

            return false;
        }
    }
}

