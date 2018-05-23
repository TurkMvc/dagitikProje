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
using sifreleme.Sifreleme_Okuma;

namespace sifreleme
{
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        Kayıt_Kontrol _kullanici_kontrol = new Kayıt_Kontrol();
        MD5_Sifrele md5 = new MD5_Sifrele();
        Kullanici_Kayit _kullanici_kayit = new Kullanici_Kayit();


        private void kayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris g = new Giris();
            g.Show();
            this.Hide();

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            String Sifremd5 = md5.MD5Sifrele(Sifre.Text);
            _kullanici_kayit.Kullanici_Ekle(Ad, Soyad, Kullanici_Ad, Sifremd5, Dogum_Tarih.Text,"Çevrım dışı", Mail);
        }

        
        private void Kullanici_Ad_TextChanged(object sender, EventArgs e)
        {

            if (!(_kullanici_kontrol.Kullanici_Kontrol(Kullanici_Ad))&&(Kullanici_Ad.TextLength!=0||Kullanici_Ad.TextLength>3))
            {
                btnKaydet.Enabled = true;
                uyari.ForeColor = Color.Green;
                uyari.Text = "Kullanici Adi Uygundur";
            }
            else 
            {
                uyari.ForeColor = Color.Red;
                uyari.Text = "Kullanıcı Adı uygun Değildir ";
                btnKaydet.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
