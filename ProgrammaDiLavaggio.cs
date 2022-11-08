// See https://aka.ms/new-console-template for more information

public class ProgrammaDiLavaggio
{
    public string Nome { get; set; }

    public int Durata { get; set; }

    public int ConsumoAmmorbidente { get; set; }

    public int ConsumoDetersivo { get; set; }

    public int NumeroGettoni { get; set; }

    public Lavatrice Lavatrice { get; set; }

    public int TempoRimanente = new Random().Next(0, Lavatrice.ProgrammaInUso.Durata + 1);

    public ProgrammaDiLavaggio(string nome, int durata, int consumoAmmorbidente, int consumoDetersivo, int numeroGettoni)
    {
        Nome = nome;
        Durata = durata;
        ConsumoAmmorbidente = consumoAmmorbidente;
        ConsumoDetersivo = consumoDetersivo;
        NumeroGettoni = numeroGettoni;
    }


    
}



