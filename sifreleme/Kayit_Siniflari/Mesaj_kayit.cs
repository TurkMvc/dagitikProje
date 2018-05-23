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
    class Mesaj_kayit
    {
        VeritabaniSinifiDataContext baglan = new VeritabaniSinifiDataContext();

        
        public void mesaj_ekle(int gonderen_id,int gonderilen_id,String mesaj,int mesaj_durum)
        {
           
        
            Mesaj_Model _mesaj_model = new Mesaj_Model(); 
            Mesaj_Controller _mesaj_controller = new Mesaj_Controller();

            _mesaj_model.Gonderen_id = gonderen_id;
            _mesaj_model.Gonderilen_id = gonderilen_id;
            _mesaj_model.Mesaj = mesaj;
            _mesaj_model.Durum = mesaj_durum;


            _mesaj_controller.Setmodel(_mesaj_model);

            if(!(_mesaj_controller.kayit_islemi(_mesaj_model)))
            {

                MessageBox.Show("Mesaj kayıt edilirken sorun oldu");
            }
             
        }
    }
}
