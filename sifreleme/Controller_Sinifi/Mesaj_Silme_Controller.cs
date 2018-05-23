using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sifreleme.Model_Siniflari;
using System.Windows.Forms;

namespace sifreleme.Controller_Sinifi
{
    class Mesaj_Silme_Controller
    {
      
        VeritabaniSinifiDataContext kayit = new VeritabaniSinifiDataContext();
        Mesaj_Silme_Model mesaj_silme;
     

        public Mesaj_Silme_Controller() {
        }

        public Mesaj_Silme_Controller(Mesaj_Silme_Model mesaj_sil) {
            this.mesaj_silme = mesaj_sil;

        }

        public void setmodel(Mesaj_Silme_Model mesaj_sil) {
            this.mesaj_silme = mesaj_sil;
   
        }

        public bool kayit_islemi(Mesaj_Silme_Model mesaj_sil) {
            
            try {
                    silinenmesajlar ds = new silinenmesajlar();
                    ds.silen_kullanici_id = mesaj_sil.Mesaj_silen_id;
                    ds.silinen_kullanici_id =mesaj_sil.Mesaj_silinen_id;
                    ds.tarih = DateTime.Now;
                    kayit.silinenmesajlars.InsertOnSubmit(ds);
                    kayit.SubmitChanges();
                               
                    return true;              

            }

            catch { return false; }
            
        }
    }
}
