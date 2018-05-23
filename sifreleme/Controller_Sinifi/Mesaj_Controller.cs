using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sifreleme.Model_Siniflari;
namespace sifreleme.Controller_Sinifi
{
    class Mesaj_Controller
    {
        VeritabaniSinifiDataContext kayit = new VeritabaniSinifiDataContext();
        
        Mesaj_Model mesaj;
        public Mesaj_Controller()
        { }

        public Mesaj_Controller(Mesaj_Model mesaj_kayit)
        {
            this.mesaj = mesaj_kayit;

        }

        public void Setmodel(Mesaj_Model mesaj_kayit)
        {
            this.mesaj = mesaj_kayit;

        }

        public bool kayit_islemi(Mesaj_Model mesaj_kayit)
        {
            
            try
            {
               
                mesajlar ds = new mesajlar();

                ds.gonderen_id = mesaj_kayit.Gonderen_id;
                ds.alan_id = mesaj_kayit.Gonderilen_id;
                ds.mesaj = mesaj_kayit.Mesaj;
                ds.okundu = mesaj_kayit.Durum;
                ds.tarih = DateTime.Now;
                kayit.mesajlars.InsertOnSubmit(ds);
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
