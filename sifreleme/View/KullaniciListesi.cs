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
using sifreleme.Guncelleme_siniflari;
namespace sifreleme
{
    public partial class KullaniciListesi : Form
    {
        public KullaniciListesi()
        {
            InitializeComponent();
        }

        Konusma_listesi goster = new Konusma_listesi();
        Kullanici_Durum durum = new Kullanici_Durum();
        Gelen_Mesaj_Kontrol _gelen_giden = new Gelen_Mesaj_Kontrol();
        public static int kisi_id;
        public static String kisi_ad;

        private void KullaniciListesi_Load(object sender, EventArgs e)
        {
           timer1.Enabled = true;
           timer1.Interval = 10000;
           goster.Kisi_Listesi(dataGridView2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            goster.Kisi_Listesi(dataGridView2);
           
            _gelen_giden.gelen_mesaj_kontrol();
        }

        private void KullaniciListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            durum.Durum(Giris_Sinif.kullanici_id, "Çevrim dışı");
            Application.Exit();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KisiListesi kl = new KisiListesi();
            kl.ShowDialog();
        }

       

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kisi_id = Convert.ToInt16(dataGridView2.CurrentRow.Cells[2].Value.ToString());
            kisi_ad = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            Sohbet f = new Sohbet();
            f.Show();
            f.Text = kisi_ad;
        }
    }
}
