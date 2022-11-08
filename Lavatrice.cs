// See https://aka.ms/new-console-template for more information

using System.Data.SqlTypes;

public class Lavatrice : Macchina
{
    public int Detersivo{ get; set; }

    public int GettoniInseriti { get; set; }

    public int Ammorbidente { get; set; }

    public ProgrammaDiLavaggio[] arrayProgrammi = new ProgrammaDiLavaggio[3];

    public ProgrammaDiLavaggio rinfrescante = new ProgrammaDiLavaggio("Rinfrescante", 20, 5, 20, 2);

    

    public ProgrammaDiLavaggio ProgrammaInUso { get; private set; } 


    public Lavatrice(string model, int gettoniinseriti) : base(model)
    {
        GettoniInseriti = gettoniinseriti;
        Detersivo = 1000;
        Ammorbidente = 500;    
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
    public DetersivoRimasto
}



