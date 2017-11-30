using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gioco_dell_Oca
{
    public class Ponte: cas_spec 
    {
        public Ponte()
        {
            Messaggio = "\nSei sulla casella Ponte\nRaddoppi il lancio";
            Indirizzo_Immagine = "./ponte.png";
        }
        public override int azione(int posizione_corrente, int lancioEffettuato)
        {
            return lancioEffettuato * 2;
        }
    }
}
