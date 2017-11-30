using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gioco_dell_Oca
{
    public class Scheletro: cas_spec 
    {
        public Scheletro()
        {
            Messaggio = "\nSei sulla casella scheletro\nRitorna alla casella 1";
            Indirizzo_Immagine = "./scheletro.jpg";
        }
        public override int azione(int posizione_corrente, int lancioEffettuato)
        {
            return -(posizione_corrente)+1;
        }
    }
}
