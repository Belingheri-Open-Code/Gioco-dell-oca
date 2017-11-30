using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gioco_dell_Oca
{
    public class Casella
    {
        public Casella()
        {
            n = 0;
        }
        private int n;
        public int NumeroCasella
        {
            set
            {
                if (value > 0)
                    n = value;
                else
                    n = 0;
            }
            get
            {
                return n;
            }

        }
        public virtual int azione(int posizione_corrente, int lancioEffettuato)
        {return 0;}
    }
}
