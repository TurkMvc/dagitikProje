using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sifreleme.Kayit_Siniflari;
using sifreleme.Listeleme;
using sifreleme.Model_Siniflari;
using sifreleme.Controller_Sinifi;
using sifreleme.Guncelleme_siniflari;
using sifreleme.Sifreleme_Okuma;

namespace sifreleme
{
    public partial class Sohbet : Form
    {
        public Sohbet()
        {
            InitializeComponent();
        }
        Mesaj_kayit _mesaj_kayit = new Mesaj_kayit();
        Mesaj_listeleme _gelen_giden_mesaj = new Mesaj_listeleme();
        int kullanici_id = Giris_Sinif.kullanici_id;
        String kullanici_ad = Giris_Sinif.kullanici_ad;
        int alici_id = KullaniciListesi.kisi_id;
        string alici_ad = KullaniciListesi.kisi_ad;
        Mesaj_Silme_Model _mesaj_silme_model = new Mesaj_Silme_Model();
        Mesaj_Silme_Controller _mesaj_silme_controller = new Mesaj_Silme_Controller();
        Mesaj_Sil_Güncelle _mesaj_sil_guncelle = new Mesaj_Sil_Güncelle();
        public static String Anahtar_Takas="24";
     
        Sifrele_Coz _sifleme_coz = new Sifrele_Coz();





        private void Sohbet_Load(object sender, EventArgs e)
        {
           
            _gelen_giden_mesaj.mesaj_sorgu(kullanici_id,alici_id,gelen_giden_mesaj);
            timer2.Enabled = true;
            timer2.Interval = 2000;
            mesaj_icerik.Focus();
            
        }

        private void Sohbet_FormClosed(object sender, FormClosedEventArgs e)
        {
           /// Application.Exit();
        }

        private void mesaj_gonder_Click(object sender, EventArgs e)
        {
            gelen_giden_mesaj.SelectionColor = Color.Green;

            gelen_giden_mesaj.AppendText("\n" + kullanici_ad + " ->  " + mesaj_icerik.Text.ToString() + ""
                        + "\t \t" + DateTime.Now.ToString());

            String Mesaj;

            if(mesaj_icerik.TextLength>0)
            { 
            Mesaj= Sifrele_Coz.SifreleAES(mesaj_icerik.Text,Anahtar_Takas);
     

            _mesaj_kayit.mesaj_ekle(kullanici_id, alici_id,Mesaj,0);

            gelen_giden_mesaj.ScrollToCaret();

            mesaj_icerik.Clear();
            }
           
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            _gelen_giden_mesaj.mesaj_listeme_timer(kullanici_id,alici_id, gelen_giden_mesaj,alici_ad);
                     
        }

        private void mesaj_icerik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
               mesaj_gonder_Click(sender, e);
                mesaj_icerik.Clear();
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            _mesaj_silme_model.Mesaj_silen_id = kullanici_id;
            _mesaj_silme_model.Mesaj_silinen_id = alici_id;
            _mesaj_silme_controller.setmodel(_mesaj_silme_model);

            if(_mesaj_sil_guncelle.Sil_Kontrol(kullanici_id,alici_id))
        
            {_mesaj_silme_controller.kayit_islemi(_mesaj_silme_model);}

            _gelen_giden_mesaj.mesaj_sorgu(kullanici_id, alici_id, gelen_giden_mesaj);

           
         
        }

      
    }
}
