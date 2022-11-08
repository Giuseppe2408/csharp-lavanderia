// See https://aka.ms/new-console-template for more information

public class ProgrammaDiLavaggio
{
    //programmi lavatrice

    //Rinfrescante, costo di 2 gettoni, durata di 20 minuti, consumo di 20ml di detersivo e 5ml di ammorbidente.
    //Rinnovante, costo di 3 gettoni, durata di 40 minuti, consumo di 40ml di detersivo e 10ml di ammorbidente.
    //Sgrassante, costo di 4 gettoni, durata di 60 minuti, consumo di 60 ml di detersivo e 15ml di ammorbidente.

    public string Nome { get; set; }

    public int Durata { get; set; }

    public int ConsumoAmmorbidente { get; set; }

    public int ConsumoDetersivo { get; set; }

    public int NumeroGettoni { get; set; }

    public ProgrammaDiLavaggio(string nome, int durata, int consumoAmmorbidente, int consumoDetersivo, int numeroGettoni)
    {
        Nome = nome;
        Durata = durata;
        ConsumoAmmorbidente = consumoAmmorbidente;
        ConsumoDetersivo = consumoDetersivo;
        NumeroGettoni = numeroGettoni;
    }


    
}



