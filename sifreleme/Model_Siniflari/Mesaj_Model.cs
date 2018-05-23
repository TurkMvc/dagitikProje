using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifreleme.Controller_Sinifi
{
    class Mesaj_Model
    {
        private int gonderen_id;

        public int Gonderen_id
        {
            get { return gonderen_id; }
            set { gonderen_id = value; }
        }
        private int gonderilen_id;

        public int Gonderilen_id
        {
            get { return gonderilen_id; }
            set { gonderilen_id = value; }
        }
        private String mesaj;

        public String Mesaj
        {
            get { return mesaj; }
            set { mesaj = value; }
        }
        private int durum;

        public int Durum
        {
            get { return durum; }
            set { durum = value; }
        }
    }
}
