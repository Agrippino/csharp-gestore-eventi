using GestoreEventi;
//creo un costruttore//
Console.WriteLine("Titolo: ");
string Titolo = Console.ReadLine();
Console.WriteLine("numero posti totali: ");
int  numeroPostiTotali=int.Parse(Console.ReadLine());
Console.WriteLine("data evento: ");
DateTime dataEvento = DateTime.Parse(Console.ReadLine());




Evento nuovoEventoInProgramma = new Evento(Titolo,numeroPostiTotali,dataEvento) ;

nuovoEventoInProgramma.ToString();

Console.WriteLine("Qual è il nuovo titolo dell'evento? Attualmente il titolo è: " + Titolo);
string nuovoTitolo = Console.ReadLine() ;
nuovoEventoInProgramma.RinominaTitolo(nuovoTitolo);

nuovoEventoInProgramma.ToString();

Console.WriteLine("Qual è la nuova data dell'evento? La data dell'evento attuale è : " + dataEvento);
DateTime nuovaData = DateTime.Parse(Console.ReadLine());
nuovoEventoInProgramma.CambiaData(nuovaData);

nuovoEventoInProgramma.ToString();


Console.WriteLine("Quanti posti vuole prenotare per questo eveto? Attualmente sono disponibili " + numeroPostiTotali + " posti.");
int postiPrenotati = int.Parse(Console.ReadLine());
nuovoEventoInProgramma.PrenotaPosti(postiPrenotati);   

nuovoEventoInProgramma.ToString();

Console.WriteLine("Vuole disdire dei posti per questo evento ? [Si/No] ");
string richiestaPosti = Console.ReadLine();
nuovoEventoInProgramma.RichiestaPerDisdire(richiestaPosti);

nuovoEventoInProgramma.ToString();



//creo una lista//
/*List<Evento> listaDegliEventi = new List<Evento>();

Console.WriteLine("Quanti eventi devi programmare?");
int numeroDiEventiInProgramma = int.Parse(Console.ReadLine());

for (int i = 0; i < numeroDiEventiInProgramma; i++)
{
    Console.WriteLine("Ciao sono il tuo aiutante per programmare gli eventi, ho visto che hai inserito " + numeroDiEventiInProgramma + " eventi \n ");
    Console.WriteLine("Qual è il nome dell'evento ? \n");
    string nome = Console.ReadLine();

    //creo una varaibile booleana da inserire in un ciclo while per controllare la data inserita//
    bool controlloData = false;
    while (controlloData == false)
    {
        try
        {

            Console.WriteLine("Inserisci la data dell'evento \n ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            controlloData = true;
        }
        catch (Exception erroreData)
        {
            Console.WriteLine(erroreData.Message);
        }
    }
    //creo una variabile booleana da insrire in un ciclo while per controllare il numero di posti inseriti//
    bool controlloNumeroPosti = false;
    while (controlloNumeroPosti == false) ;
    {
        try 
        {
            Console.WriteLine("Inserisci il numero di posti totali");
            int numeroDiPosti = int.Parse(Console.ReadLine());

            controlloNumeroPosti= true;
        } catch (Exception erroreNumeroPosti)
        {
            Console.WriteLine(erroreNumeroPosti.Message);
        }
    }


   
}*/

