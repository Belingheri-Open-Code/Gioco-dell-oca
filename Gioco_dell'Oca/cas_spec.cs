using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gioco_dell_Oca
{
    public class cas_spec : Casella
    {
        public cas_spec()
        {
            n_img = "./marrone.png";
            mgx = "";
        }
        private string n_img;
        public int colonna;
        public int riga;
        public string Indirizzo_Immagine
        {
            set
            {
                if (value != null)
                    n_img = value;
            }
            get { return n_img; }
        }
        private string mgx;
        public string Messaggio
        {
            set
            {
                if (value != null)
                    mgx = value;
            }
            get { return mgx; }
        }
    }
}
