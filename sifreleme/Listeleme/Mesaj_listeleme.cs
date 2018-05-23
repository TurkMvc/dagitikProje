using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using sifreleme.Guncelleme_siniflari;
using sifreleme.Sifreleme_Okuma;
namespace sifreleme.Listeleme
  
{
    class Mesaj_listeleme
    {

        VeritabaniSinifiDataContext baglan = new VeritabaniSinifiDataContext();
        mesajlar _mesaj_durum = new mesajlar();
        Mesaj_Sil_Güncelle _sil_guncelle = new Mesaj_Sil_Güncelle();
        static DateTime zaman = Convert.ToDateTime(Mesaj_Sil_Güncelle.zaman);
        public static int _son_mesaj_id=0;
      
       
        public void mesaj_sorgu(int okuyan_id, int gelen_id,RichTextBox _mesajlar)
        {
           
            _sil_guncelle.Silinen_mesaj_tarih(okuyan_id, gelen_id);
            zaman = Convert.ToDateTime(Mesaj_Sil_Güncelle.zaman);
        
           _mesajlar.Clear();
            var sorgu = from _mesaj in baglan.mesajlars
                        where _mesaj.gonderen_id == okuyan_id && _mesaj.alan_id == gelen_id 
                        && _mesaj.tarih>zaman
                        || _mesaj.alan_id == okuyan_id && _mesaj.gonderen_id == gelen_id 
                        && _mesaj.tarih > zaman
                      
                        select new { _mesaj.mesaj, _mesaj.tarih, _mesaj.gonderen_id,_mesaj.id};
            foreach (var result in sorgu)
            {
                
                var kisi = from _kullanici in baglan.kullanicilars
                           where _kullanici.id == result.gonderen_id
                           select new { _kullanici.kullanici_ad };
                foreach (var k in kisi)
                {

                    if (okuyan_id == result.gonderen_id)    
                        _mesajlar.SelectionColor = Color.Green;
                    else  _mesajlar.SelectionColor = Color.Red;

                    String Mesaj_icerik = Sifrele_Coz.SifreyiCozAES(result.mesaj, Sohbet.Anahtar_Takas);

                    _mesajlar.AppendText("\n" + k.kullanici_ad + " :" + Mesaj_icerik + "\n"
                        + "\t" + result.tarih.ToString());
                    _mesaj_durum = baglan.mesajlars.First(x => x.id == result.id);
                    _mesaj_durum.okundu = 1;
                    baglan.SubmitChanges();
                    _mesajlar.ScrollToCaret();

                }
                _son_mesaj_id = result.id;
            }
        }

        public void mesaj_listeme_timer(int okuyan_id, int gelen_id, RichTextBox mesaj,String gelen_kisi)
        {
           
            var sorgu = from _mesaj in baglan.mesajlars
                        where _mesaj.alan_id == okuyan_id && _mesaj.gonderen_id == gelen_id
                        && _mesaj.okundu == 0 && _mesaj.id > _son_mesaj_id 
                        && _mesaj.tarih > zaman

                        select new { _mesaj.mesaj, _mesaj.tarih, _mesaj.gonderen_id,_mesaj.id};

            foreach (var result in sorgu)
            {


                mesaj.SelectionColor = Color.Red;
                String Mesaj_icerik = Sifrele_Coz.SifreyiCozAES(result.mesaj, Sohbet.Anahtar_Takas);
                mesaj.AppendText("\n" + gelen_kisi + " :" + Mesaj_icerik + "\n"
                        + "\t" + result.tarih.ToString());
                //Durum güncellmesi yapılması için kullanılan sınıftır
                _mesaj_durum = baglan.mesajlars.First(x => x.id ==result.id);
                _mesaj_durum.okundu = 1;
                baglan.SubmitChanges();
                mesaj.ScrollToCaret();

                



            }
        }

     
        

    }
}
