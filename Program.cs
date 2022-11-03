// See https://aka.ms/new-console-template for more information
using System;

//Si richiede di creare un sistema di controllo in grado di riportare lo stato della lavanderia, in particolare si vuole richiedere:
//1 - Lo stato generale di utilizzo delle macchine: un elenco di tutte le macchine che semplicemente dica quali sono in funzione e quali non lo sono (in lavaggio / asciugatura oppure ferme)
//2 - Possa essere richiesto il dettaglio di una macchina: Tutte le informazioni relative alla macchina, nome del macchinario, stato del macchinario (in funzione o no), tipo di lavaggio in corso, quantità di detersivo presente (se una lavatrice), durata del lavaggio, tempo rimanente alla fine del lavaggio.
//3 - l’attuale incasso generato dall’utilizzo delle macchine.


string[] lavatrici = { "lavatrice 1", "lavatrice 2", "lavatrice3", "lavatrice 4", "lavatrice 5" };

for(int i = 0; i < 5; i++)
{
    Laundry lavatrici[i] = new Laundry();
}


public class Laundry
{
    public string Model { get; set; }
    public double Price { get; set; }
    public int Detergent { get; set; }
    public int Softener { get; set; }

    public Laundry()
    {

    }

    public Laundry(string model,double price,int detergent, int softener)
    {
        this.Model = model;
        this.Price = price;
        this.Detergent = detergent;
        this.Softener = softener;
    }
}

