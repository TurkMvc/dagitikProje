using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifreleme.Guncelleme_siniflari
{


    class Mesaj_Sil_Güncelle
    {
        VeritabaniSinifiDataContext baglan = new VeritabaniSinifiDataContext();
        silinenmesajlar ds = new silinenmesajlar();
        static bool durum=true;
        public static String zaman = "1990-01-01 01:01:01.001";
        public bool Sil_Kontrol(int silen__mesaj_id, int silinen_mesaj_id)
        {
            durum = true;

            var sorgu = from silinen_mesaj in baglan.silinenmesajlars
                        where silinen_mesaj.silen_kullanici_id == silen__mesaj_id
                        && silinen_mesaj.silinen_kullanici_id == silinen_mesaj_id
                        select new { silinen_mesaj.silen_kullanici_id, silinen_mesaj.silinen_kullanici_id, silinen_mesaj.tarih,silinen_mesaj.id};

            foreach (var result in sorgu)
            {   

                if (result.silen_kullanici_id == silen__mesaj_id && result.silinen_kullanici_id == silinen_mesaj_id)
                {
                    ds = baglan.silinenmesajlars.First(x => x.id== result.id);
                    ds.tarih = DateTime.Now;
             
                    baglan.SubmitChanges();
                  
                    durum = false;

                }
                else { durum = true; }


            }

            return durum;



        }
        
        /// mesajların daha önce silinip silinmediğin kontrol eden kısımdır
      
        public String Silinen_mesaj_tarih(int silen_id, int silinen_id)
        {
            zaman = "1990-01-01 01:01:01.001";
           
            var sorgu = from silinen_mesaj in baglan.silinenmesajlars
                        where silinen_mesaj.silen_kullanici_id == silen_id
                        && silinen_mesaj.silinen_kullanici_id == silinen_id
                        select new { silinen_mesaj.silen_kullanici_id, silinen_mesaj.silinen_kullanici_id, silinen_mesaj.tarih };


            foreach (var result in sorgu)
            {

                if (result.silen_kullanici_id == silen_id && result.silinen_kullanici_id == silinen_id)
                {
                    zaman = result.tarih.ToString();
                }
            }

            return zaman;
        }
       

    }
}
