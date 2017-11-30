using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gioco_dell_Oca
{
    class Prigione : cas_spec 
    {
        public Prigione()
        {
            Messaggio = "\nSei sulla casella Prigione\n devi attendere 3 turni";
            Indirizzo_Immagine = "./prigione.png";
            Rimani_fermo = 3;
        }
        private int Rimani_fermo;
        public override int azione(int a, int b)
        {
            
            return Rimani_fermo*100;
        }
    }
}
