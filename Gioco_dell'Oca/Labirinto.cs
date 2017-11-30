using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gioco_dell_Oca
{
    public class Labirinto : cas_spec 
    {
        public Labirinto()
        {
            Messaggio = "\nSei sulla casella Labirinto\n torna indietro di tre caselle";
            Indirizzo_Immagine = "Labirinto.jpg";
        }
        public override int azione(int posizione_corrente, int lancioEffettuato)
        {
            return -3;
        }

            
    }
}
