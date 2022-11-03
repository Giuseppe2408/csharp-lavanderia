// See https://aka.ms/new-console-template for more information
using System;

//Si richiede di creare un sistema di controllo in grado di riportare lo stato della lavanderia, in particolare si vuole richiedere:
//1 - Lo stato generale di utilizzo delle macchine: un elenco di tutte le macchine che semplicemente dica quali sono in funzione e quali non lo sono (in lavaggio / asciugatura oppure ferme)
//2 - Possa essere richiesto il dettaglio di una macchina: Tutte le informazioni relative alla macchina, nome del macchinario, stato del macchinario (in funzione o no), tipo di lavaggio in corso, quantità di detersivo presente (se una lavatrice), durata del lavaggio, tempo rimanente alla fine del lavaggio.

//3 - l’attuale incasso generato dall’utilizzo delle macchine. farlo con un for creando due array

//Laundry[] lavatrici = new Laundry[5]; L'ARRAY PUO ESSERE DI TIPO CLASSE

//for (int i=0; i<lavatrici.Length; i++)
//{
//    lavatrici[i] = new Laundry(); CREA 5 LAVATRICI UGUALI 
//}
//lavatrici
Laundry[] arrayLavatrici = new Laundry[5];
Laundry lavatrice1 = new Laundry("lavatrice1", 1, 0.50, 1, 500, arrayLavatrici);
Laundry lavatrice2 = new Laundry("lavatrice2", 1, 0.50, 1, 500, arrayLavatrici);
Laundry lavatrice3 = new Laundry("lavatrice3", 1, 0.50, 1, 500, arrayLavatrici);
Laundry lavatrice4 = new Laundry("lavatrice4", 1, 0.50, 1, 500, arrayLavatrici);
Laundry lavatrice5 = new Laundry("lavatrice5", 1, 0.50, 1, 500, arrayLavatrici);
//Array lavatrici da usare


lavatrice1.Print();
//arrayLavatrici = { lavatrice1, lavatrice2, lavatrice3, lavatrice4, lavatrice5 };


//Laundry asciugatrice1 = new Laundry("asciugatrice1", 1, 0.50);
//Laundry asciugatrice2 = new Laundry("asciugatrice2", 1, 0.50);
//Laundry asciugatrice3 = new Laundry("asciugatrice3", 1, 0.50);
//Laundry asciugatrice4 = new Laundry("asciugatrice4", 1, 0.50);
//Laundry asciugatrice5 = new Laundry("asciugatrice5", 1, 0.50);


//Laundry ProgrammaLavaggio = new Laundry();

//Laundry[] arrayAsciugatrici = { asciugatrice1, asciugatrice2, asciugatrice3, asciugatrice4, asciugatrice5 };

//ciclo sull'array di lavatrici per determinare quelle in funzione e quelle spente
    



public class Laundry
{

    public Laundry[] ArrayLavatrici { get; set; }

    public Laundry[] ArrayAsciugatrici { get; set; }

    public string Model { get; private set; }
    public int Token { get; set; }

    public int IsActive { get; set; }

    public double TokenPrice { get; set; }
    public int Detergent { get; set; }
    public int Softener { get; set; }

    //costruttore asciugatrici visto che non hanno il detergente
    public Laundry(string model, int token, double tokenPrice, Laundry[] arrayAsciugatrici)
    {
        this.Model = model;
        this.IsActive = new Random().Next(0, 2);
        this.TokenPrice = tokenPrice;
        this.ArrayAsciugatrici = arrayAsciugatrici;
    }

    public Laundry(string model, int token, double tokenPrice, int detergent, int softner, Laundry[] arrayLavatrici)
    {
        this.Model = model;

        this.Token = token;
        this.IsActive = new Random().Next(0, 2);
        this.TokenPrice = tokenPrice;
        this.Detergent = detergent;
        this.Softener = softner;
        this.ArrayLavatrici = arrayLavatrici;
    }

//costruttore per i programmi
    //public Laundry()
    //{

    //}



    public bool Start()
    {
        if (this.IsActive == 0)
        {
            return false;
        }
        else
        {
            return true;
        }

    }

    public void Print()
    {
        for (int i = 0; i < this.ArrayLavatrici.Length; i++)
        {
            if (!this.ArrayLavatrici[i].Start())
            {
                Console.WriteLine((i + 1) + " lavatrice spenta");
            }
            else
            {
                Console.WriteLine((i + 1) + " lavatrice accesa");
            }


            Console.WriteLine(this.ArrayLavatrici[i].IsActive);

        }
        //ciclo sull'array di asciugatrici per determinare quelle in funzione e quelle spente
        for (int i = 0; i < this.ArrayAsciugatrici.Length; i++)
        {
            if (!this.ArrayAsciugatrici[i].Start())
            {
                Console.WriteLine("Asciugatrice spenta");
            }
            else
            {
                Console.WriteLine("Asciugatrice accesa");
            }


            Console.WriteLine(this.ArrayAsciugatrici[i].IsActive);
        }
    }    
    
}

