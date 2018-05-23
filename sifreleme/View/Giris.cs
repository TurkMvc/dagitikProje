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
using sifreleme.Sifreleme_Okuma;
  
namespace sifreleme
{
    
    public partial class Giris : Form
    {
        public static int sayi = 0;
        public Giris()
        {
            InitializeComponent();
        }

        KullaniciListesi f = new KullaniciListesi();
        Giris_Sinif kontrol = new Giris_Sinif();
        Kullanici_Durum durum = new Kullanici_Durum();
        MD5_Sifrele md5 = new MD5_Sifrele();
        
        private void Giris_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             kayit form = new kayit();
             form.Show();
                 
          this.Hide();
            
        }

        private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            kayit g = new kayit();
            Application.Exit();
        }

        private void Giris_yap_Click(object sender, EventArgs e)
        {
            String sifre_md5 = md5.MD5Sifrele(Sifre_giris.Text);
           
            if (kontrol.giris(Kullanici_giris, sifre_md5))
            {
                durum.Durum(Giris_Sinif.kullanici_id,"Çevrim içi");
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Yanlış.","Bilgilendirme Penceresi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sifre_giris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Giris_yap_Click(sender, e);
        }

        private void Kullanici_giris_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
