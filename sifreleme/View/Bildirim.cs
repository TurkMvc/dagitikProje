using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sifreleme.Listeleme;


namespace sifreleme
{
    public partial class Bildirim : Form
    {
        public Bildirim()
        {
            InitializeComponent();
            
           
        }

        private void Bildirim_Load(object sender, EventArgs e)
        {
           
       





            kullanici_ad.Text = Gelen_Mesaj_Kontrol._bildirim_kullanici_ad;
            mesaj_icerik_lb.Text = Gelen_Mesaj_Kontrol._bildirim_mesaj;
            timer1.Enabled = true;
            timer1.Interval = 10000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            this.Close();
            timer1.Enabled = false;
        }

       

        private void Bildirim_MouseClick(object sender, MouseEventArgs e)
        {
            KullaniciListesi.kisi_id = Gelen_Mesaj_Kontrol._bildirim_id;
            this.Close();
            Sohbet f = new Sohbet();
            f.Show();
            
        }
    }
}
