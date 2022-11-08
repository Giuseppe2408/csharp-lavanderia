// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

//Si richiede di creare un sistema di controllo in grado di riportare lo stato della lavanderia, in particolare si vuole richiedere:
//1 - Lo stato generale di utilizzo delle macchine: un elenco di tutte le macchine che semplicemente dica quali sono in funzione e quali non lo sono (in lavaggio / asciugatura oppure ferme)
//2 - Possa essere richiesto il dettaglio di una macchina: Tutte le informazioni relative alla macchina, nome del macchinario, stato del macchinario (in funzione o no), tipo di lavaggio in corso, quantità di detersivo presente (se una lavatrice), durata del lavaggio, tempo rimanente alla fine del lavaggio.

//3 - l’attuale incasso generato dall’utilizzo delle macchine. farlo con un for creando due array

//istanze lavatrici
Lavatrice[] lavatrici = new Lavatrice[5];
Lavatrice lavatrice = new Lavatrice("Lavatrice", 20);

for (int i = 0; i < lavatrici.Length; i++)
{
    lavatrice = new Lavatrice("Lavatrice " + (i + 1), 20);
    lavatrici[i] = lavatrice;

}
//istanze asciugatrici
Asciugatrice[] asciugatrici = new Asciugatrice[5];
Asciugatrice asciugatrice = new Asciugatrice("Asciugatrice", 40);

for (int i = 0; i < asciugatrici.Length; i++)
{
    asciugatrice = new Asciugatrice("Asciugatrice " + (i + 1), 40);
    asciugatrici[i] = asciugatrice;
}


lavatrice.inFunzione();

Console.WriteLine("Buongiorno benvenuto nella lavanderia");
Console.WriteLine();
Console.WriteLine("digita 0 per vedere quali macchine sono in funzione");
Console.WriteLine("digita 1 per vedere il dettaglio di una macchina");
Console.WriteLine("digita 2 per avere l'incasso generale dalle macchine");
int inputUtente = Convert.ToInt32(Console.ReadLine());



switch (inputUtente)
{
    case 0:
            Console.WriteLine("lavatrici in funzione");
            bool lavatriceInFunzione = lavatrice.inFunzione();
            for (int i = 0; i < lavatrici.Length; i++)
            {
                if (lavatriceInFunzione)
                    Console.WriteLine(lavatrici[i] + " " + (i + 1) + " in funzione");
                else
                    Console.WriteLine(lavatrici[i] + " " + (i + 1) + " spenta");
            }
            Console.WriteLine();
            Console.WriteLine("asciugatrici in funzione");
            bool asciugatriceInFunzione = asciugatrice.inFunzione();
            for (int i = 0; i < asciugatrici.Length; i++)
            {
                if (asciugatriceInFunzione)
                    Console.WriteLine(asciugatrici[i] + " " + (i + 1) + " in funzione");
                else
                    Console.WriteLine(asciugatrici[i] + " " + (i + 1) + " spenta");
            }
        break;


    case 1:
        Console.WriteLine("dettaglio macchina");
        Console.WriteLine("inserisci il modello per sapere le specifiche");
        string inputModello = Console.ReadLine();
        //for per cercare le lavatrici
        for (int i = 0; i < lavatrici.Length; i++)
        {
            
                if (inputModello == lavatrici[i].Modello)
                {
                    // nome modello, se il macchinario singolo è in funzione, tipo di programma lavaggio quantità detersivo presente, durata lavaggio e tempo rimanente alla fine
                    Console.WriteLine("modello: {0}", lavatrici[i].Modello);
                    bool lavatriciSingola = lavatrici[i].inFunzione();
                    if (lavatriciSingola)
                    {
                        Console.WriteLine(lavatrici[i] + " in funzione");
                    }
                    else
                    {
                        Console.WriteLine(lavatrici[i] + " spenta");
                    }

                Console.WriteLine("programma in uso {0}", lavatrici[i].ProgrammaInUso.Nome);
                int detersivo = lavatrici[i].DetersivoRimasto();
                    Console.WriteLine("detersivo presente {0}", detersivo);
                    int ammorbidente = lavatrici[i].AmmorbidenteRimasto();
                    Console.WriteLine("ammorbidente presente {0}", ammorbidente);
                    Console.WriteLine("durata lavaggio: {0}", lavatrici[i].ProgrammaInUso.Durata);
                Console.WriteLine("tempo rimanente: {0}", lavatrici[i].ProgrammaInUso.TempoRimanente);
            }
            
        }
        //for per cercare le asciugatrici
        for (int i = 0; i < asciugatrici.Length; i++)
        {
            if (inputModello == asciugatrici[i].Modello)
            {
                // nome modello, se il macchinario singolo è in funzione, tipo di programma lavaggio quantità detersivo presente, durata lavaggio e tempo rimanente alla fine
                Console.WriteLine("modello: {0}", asciugatrici[i].Modello);
                bool asciugatriciSingola = asciugatrici[i].inFunzione();
                if (asciugatriciSingola)
                {
                    Console.WriteLine(asciugatrici[i] + " in funzione");
                }
                else
                {
                    Console.WriteLine(asciugatrici[i] + " spenta");
                }
                //Console.WriteLine("programma in uso {0}", asciugatrici[i].ProgrammaInUso.Nome);

            }

        }
        break;

    case 2:
        Console.WriteLine("incassi di tutte le macchine");
        //algoritmo per vedere il dettaglio di una macchina
        break;
}

//TempoRimanente = new Random().Next(0, ProgrammaInEsecuzione.Durata + 1);
//public void SimulaAvanzamento()
//{
//    TempoRimanente = new Random().Next(0, TempoRimanente);
//}



