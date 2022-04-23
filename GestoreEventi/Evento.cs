using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
        //variabili//
    {
        private protected string Titolo { get; set; }
       
        private protected int numeroPostiTotali;

        private protected int numeroPostiPrenotati;

        private protected int numeroPostiRimanenti;

        private protected int postiDaRimuovere;

        private protected int numeroPrenotazioniResidue;

        private protected DateTime dataEvento = new DateTime();

        private protected DateTime dataDiOggi =  DateTime.Now;
        //costruttore//
        public Evento (string Titolo, int numeroPostiTotali, DateTime dataEvento)
        {
            this.Titolo = Titolo;
            this.numeroPostiTotali = numeroPostiTotali;
            this.dataEvento = dataEvento;

            //controlli per i parametri //
            if (Titolo == "")
            {
                throw new Exception("Mi dispiace non hai inserto nulla, per favore inserisci un titolo");
            }
            if (dataEvento < dataDiOggi)
            {
                throw new Exception("Mi dispiace la data inserita non è corretta, reinserisci la data.");
            }
            if(numeroPostiTotali< 0 || numeroPostiTotali < 1)
            {
                throw new Exception("Mi dispiace non puoi inserire un numero minore di 0 o inferiore a 1, per favore inserisci un numero divero");
            }
        
        }

      

        // sezione metodi e get-set//

        // Metodo che si occupa di cambiare il titolo
        public void RinominaTitolo(string nuovoTitolo)
        {
            Titolo = nuovoTitolo;
        }
        // Metodo che si occupa di cambiare la data
        public void CambiaData(DateTime nuovaData)
        {
            dataEvento = nuovaData;
        }



        //metodi per prenotare i posti //

        public void PrenotaPosti(int postiPrenotati)
        {
            // verifica se hai abbastanza post liberi
            // se la data dell'evento non è già passata

            this.numeroPostiPrenotati = this.numeroPostiPrenotati + postiPrenotati;
            this.numeroPostiRimanenti = this.numeroPostiTotali - this.numeroPostiPrenotati;

            if (this.dataEvento < this.dataDiOggi)
            {
                Console.WriteLine("Mi dispiace questo evento non è più disponibile");
            }
            if (this.numeroPostiPrenotati > this.numeroPostiRimanenti || this.numeroPostiRimanenti < 0 )
            {
                Console.WriteLine("Mi dispaice non sono disponibili tutti questi posti");
            }
            else
            {
                Console.WriteLine("Grazie per la sua prenotazione");
                Console.WriteLine("I posti rimanenti ora sono: " + this.numeroPostiRimanenti);
            } 
        }

        //metodo per disidire i posti//
        public void DisdiciPosti(int disdiciPosti)
        {
            this.postiDaRimuovere = this.numeroPostiPrenotati - disdiciPosti;
            this.numeroPostiRimanenti = this.numeroPostiTotali - this.postiDaRimuovere;

            if (this.numeroPostiPrenotati < disdiciPosti)
            {
                Console.WriteLine("Mi dispiace non ci sono più posti da rimuovere ");
            }
            if (this.dataEvento < this.dataDiOggi)
            {
                Console.WriteLine("Mi dispiace questo evento non è più disponibile");

            }
            else
            {
                Console.WriteLine("I posti disdetti sono: " + this.postiDaRimuovere );
                Console.WriteLine("I posti rimanenti sono: " + this.numeroPostiRimanenti);
            }

        }

        //Ho creato un metodo che chiede a ripetizione quanti posti disdire, il metodo si ferma nel momento in cui no
        public void RichiestaPerDisdire()
        {
            bool controlloRisposta = false;
            while (controlloRisposta == false)
            { 
                Console.WriteLine("Vuole disdire dei posti per questo evento (si/no) ?");
                string rispostaPosti = Console.ReadLine();
                switch (rispostaPosti)
                {
                    
                    case "si" :

                        Console.WriteLine("Quanti posti vuole disdire per questo eveto? Attualmente sono prenotati " + this.numeroPostiPrenotati + " posti.");
                        int disdiciPrenotazioni = int.Parse(Console.ReadLine());
                        DisdiciPosti(disdiciPrenotazioni);
                        numeroPrenotazioniResidue = this.numeroPostiPrenotati - this.postiDaRimuovere;
                        Console.WriteLine("Numero posti prenotati: " + this.numeroPrenotazioniResidue);
                        Console.WriteLine("Numero posti disponibili: " + this.numeroPostiRimanenti);
                        break; 
                     case "no" :
                        Console.WriteLine("Grazie mille, arrivederci");
                        controlloRisposta = true;
                        break;
                    default:
                        Console.WriteLine("Per favore scrivi solo si o no, grazie.");
                        break;
                }
            }
        }
    //metodo per stampare (override del metodo generale ToString())//

         public virtual void ToString()
         {
            Console.WriteLine("---Eventi--- \n");
            Console.WriteLine("Data e titolo dell'evento \n");
            Console.WriteLine(this.dataEvento + " " + this.Titolo);
            Console.WriteLine("Il numero di posti totali sono: " + this.numeroPostiTotali );
            Console.WriteLine("I numeri di posti prenotati è " + this.numeroPostiPrenotati);
            Console.WriteLine("I numeri di posti rimanenti è " + this.numeroPostiRimanenti);

         }
    
        //metodo per prendre tutti i dati dell'evento 
         public void AggiungiEvento()

         {
            Console.WriteLine("Ti aiuterò io ad aggiugnere il tuo evento \n");
            Console.WriteLine("Qual è il titolo dell'evento?");
            string Titolo = Console.ReadLine();
            Console.WriteLine("Quanti posti saranno disponibili?");
            int numeroPostiTotali = int.Parse(Console.ReadLine());
            Console.WriteLine("Quando si terrà questo evento?");
            DateTime dataEvento = DateTime.Parse(Console.ReadLine());
         }
    }
}
