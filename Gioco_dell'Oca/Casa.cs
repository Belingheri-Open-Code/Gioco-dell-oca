using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gioco_dell_Oca
{
    class Casa :cas_spec 
    {
        public Casa()
        {
            Messaggio = "\nSei sulla casella Casa\n devi attendere 1 turno";
            Indirizzo_Immagine = "./casa.png";
            Rimani_fermo = 1;
        }
        private int Rimani_fermo;
        public override int azione(int a, int b)
        {
            
            return Rimani_fermo*100;
        }
    }
}
