using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gioco_dell_Oca
{
    public class Mago : cas_spec 
    {
        private string domanda;
        private string risposta;
        public Mago()
        {
            Messaggio = "\nSei sulla casella mago\nrispondi alla domanda";
            Indirizzo_Immagine = "./mago.jpg";
            domanda = "2^10 ?";
            risposta = "1024";
        }
        public string Domanda
        {
            get { return domanda; }
        }
        public string Risposta
        {
            get { return risposta; }
        }
        public override int azione(int posizione_corrente, int lancioEffettuato)
        {
            Form_Mago nuovo = new Form_Mago() ;
            nuovo.ShowDialog();
            return 0;
        }
    }
}
