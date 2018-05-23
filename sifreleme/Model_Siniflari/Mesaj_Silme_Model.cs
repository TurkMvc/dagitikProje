using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifreleme.Model_Siniflari
{
    class Mesaj_Silme_Model
    {
        private int mesaj_silen_id;
        private int mesaj_silinen_id;

        public int Mesaj_silen_id
        {
            get
            {
                return mesaj_silen_id;
            }

            set
            {
                mesaj_silen_id = value;
            }
        }

        public int Mesaj_silinen_id
        {
            get
            {
                return mesaj_silinen_id;
            }

            set
            {
                mesaj_silinen_id = value;
            }
        }
    }
}
