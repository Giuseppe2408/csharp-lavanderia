// See https://aka.ms/new-console-template for more information

using System.Data.SqlTypes;

public class Lavatrice : Macchina
{
    int programmaCasuale = new Random().Next(0, 3); //variabile per assegnare un indice casuale all' array di programmi


    public int Detersivo{ get; set; }

    public int GettoniInseriti { get; set; }

    public int Ammorbidente { get; set; }

    ProgrammaDiLavaggio[] ArrayProgrammi { get; set; }

    public ProgrammaDiLavaggio ProgrammaInUso { get; private set; } 


    public Lavatrice(string model, int gettoniinseriti) : base(model)
    {
        GettoniInseriti = gettoniinseriti;
        Detersivo = 1000;
        Ammorbidente = 500;
        ArrayProgrammi = new ProgrammaDiLavaggio[3];
        ArrayProgrammi[0] = new ProgrammaDiLavaggio("Rinfrescante", 20, 5, 20, 2);
        ArrayProgrammi[1] = new ProgrammaDiLavaggio("Rinnovante", 40, 10, 40, 3);
        ArrayProgrammi[2] = new ProgrammaDiLavaggio("Sgrassante", 60, 15, 60, 4);
        ProgrammaInUso = ArrayProgrammi[programmaCasuale];
    }


    public override bool inFunzione()
    {
        if (ProgrammaInUso != null)
        {
            return true;
        }

        return false;
    }
    //nome modello, se il macchinario singolo è in funzione, tipo di programma lavaggio quantità detersivo presente, durata lavaggio e tempo rimanente alla fine
    public int DetersivoRimasto()
    {
        return Detersivo - ProgrammaInUso.ConsumoDetersivo; //tolgo dal detersivo totale il consumo di detersivo del programma in uso ma una sola volta
    }

    public int AmmorbidenteRimasto()
    {
        return Ammorbidente - ProgrammaInUso.ConsumoAmmorbidente; //tolgo dal ammorbidente totale il consumo di ammorbidente del programma in uso ma una sola volta
    }

    public void SimulaAvanzamento()
    {
        ProgrammaInUso.TempoRimanente = new Random().Next(0, ProgrammaInUso.TempoRimanente);
    }

}



