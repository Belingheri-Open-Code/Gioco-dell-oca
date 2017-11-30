using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Gioco_dell_Oca
{
    public class Sveglia : cas_spec 
    {
        public Sveglia()
        {
            Random genera = new Random();
            int numeroRandom = genera.Next(2, 12);
            punizione_attiva = false;
            Messaggio = "Sei sulla casella della Sveglia\n devi attendere "+numeroRandom.ToString()+" secondi";
            Indirizzo_Immagine = "./sveglia.jpg";
            tempoattesa = numeroRandom;
        }
        public bool punizione_attiva;
        public int tempoattesa;
        public override int azione(int a, int b)
        {
            punizione_attiva = true;
            Thread.Sleep(tempoattesa);
            punizione_attiva = false;
            return 300;
        }
    }
}
