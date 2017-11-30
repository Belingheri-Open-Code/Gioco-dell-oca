using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gioco_dell_Oca
{
     class Oca :cas_spec 
    {
        public Oca()
        {
            Messaggio = "\nSei sulla casella oca \nAvanza ancora come da dado";
            Indirizzo_Immagine = "./oca.png";
        }
        public override int azione(int posizione_corrente, int lancioEffettuato)
        {
            return lancioEffettuato ;
        }
    }
}
