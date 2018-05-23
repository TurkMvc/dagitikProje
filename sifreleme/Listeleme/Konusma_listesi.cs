using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using sifreleme.Listeleme;

namespace sifreleme.Listeleme
{
    class Konusma_listesi
    {

        VeritabaniSinifiDataContext baglan = new VeritabaniSinifiDataContext();
        DataGridViewCellStyle renklendir = new DataGridViewCellStyle();
       

        int id = Giris_Sinif.kullanici_id;
        public void Kisi_Listesi( DataGridView listele )
        {
            
            listele.DataSource = from _kullanici in baglan.kullanicilars
                                 where _kullanici.id!=Giris_Sinif.kullanici_id
                                 select new { _kullanici.kullanici_ad, _kullanici.aktif_durum,_kullanici.id };

            listele.Columns[0].HeaderText = "Kullanici ad";
            listele.Columns[1].HeaderText = "Durum";
            listele.Columns[2].Visible = false;
            listele.Columns[0].Width = 170;
            listele.Columns[1].Width = 60;

           
            for(int i=0; i<listele.Rows.Count;i++)
            {

            if (listele.Rows[i].Cells[1].Value.ToString()=="Çevrim içi")
            {
                    listele.Rows[i].Cells[1].Style.BackColor = Color.LightGreen;
            }
            else
            {
                    listele.Rows[i].Cells[1].Style.BackColor = Color.Red;
            }
            }
        }
    }
}
