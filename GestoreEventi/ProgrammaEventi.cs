using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        private protected string Titolo;

        public ProgrammaEventi (string Titolo)
        {
            this.Titolo = Titolo;
            List<Evento> listaDegliEventi = new List<Evento>();
        }

        //metodo che aggiunge alla lista del programma eventi un Evento, passato come parametro al metodo

        /*public void AggiungiEventoAllaLista()
        {
            AggiungiEvento()

        }*/





    }
}
