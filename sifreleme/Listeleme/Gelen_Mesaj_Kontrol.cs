using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sifreleme.Sifreleme_Okuma;

namespace sifreleme.Listeleme
{
    
    class Gelen_Mesaj_Kontrol
    {
        VeritabaniSinifiDataContext baglan = new VeritabaniSinifiDataContext();
        public static String _bildirim_mesaj = "";
        public static int _bildirim_id;
        public static String _bildirim_kullanici_ad="";
        public static int _bildirim_mesaj_sayi = 0;
       
        public void gelen_mesaj_kontrol()
        {
             int kullanici_id=  Giris_Sinif.kullanici_id;
             Bildirim f = new Bildirim();
                            var sorgular = from gelen_mesaj in baglan.mesajlars
                            where gelen_mesaj.alan_id == kullanici_id && gelen_mesaj.okundu == 0
                            select new {gelen_mesaj.gonderen_id,gelen_mesaj.mesaj };

            foreach(var result in sorgular)
            if(!(result==null))
            {
                var kullanici = from _kullanici in baglan.kullanicilars
                                 where _kullanici.id == result.gonderen_id
                                 select new {_kullanici.kullanici_ad};

                foreach (var ad in kullanici)
                    _bildirim_kullanici_ad = ad.kullanici_ad;
                    _bildirim_mesaj= Sifrele_Coz.SifreyiCozAES(result.mesaj,Sohbet.Anahtar_Takas);
                    _bildirim_id = result.gonderen_id;
                    _bildirim_mesaj_sayi++;
                     f.Show();
            }
                

        
        }

        }

    }

