using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gioco_dell_Oca
{
    public  class Pedina
    {
        public Pedina()
        {
            n = 0;
            casellaCorrente = 1;
            Nome = null;
            attesa = 0;
        }
        public int attesa;
        private int n;
        public string Nome;
        public int NumeroConcorrente
        {
            set
            {
                if (value > 0)
                    n = value;
                else
                    n = 1;
            }
            get
            {
                return n;
            }

        }
        private int casellaCorrente;
        public int CasellaCorrente {
            set
            {
                if (value > 0)
                {  
                    casellaCorrente = value;
                    if (casellaCorrente > 63)
                    {
                        int i = 63 - casellaCorrente;
                        casellaCorrente += i;
                    }
                        
                }
                else
                    casellaCorrente = 0;
            }
            get
            {
                return casellaCorrente;
            }
        }
        
    }
}
