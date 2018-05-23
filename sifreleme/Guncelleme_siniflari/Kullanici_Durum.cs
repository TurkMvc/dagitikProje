using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifreleme.Guncelleme_siniflari
{
    class Kullanici_Durum
    {
        VeritabaniSinifiDataContext baglan = new VeritabaniSinifiDataContext();
        public void Durum(int id,string durum)
        {
            kullanicilar _kullanici_durum = new kullanicilar();
            _kullanici_durum = baglan.kullanicilars.First(x => x.id ==id);
            _kullanici_durum.aktif_durum = durum;
             baglan.SubmitChanges();
        }
    }
}
