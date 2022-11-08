// See https://aka.ms/new-console-template for more information

using System.Data.SqlTypes;

public class Lavatrice : Macchina
{
    public int Detersivo{ get; set; }

    public int GettoniInseriti { get; set; }

    public int Ammorbidente { get; set; }

    public ProgrammaDiLavaggio[] arrayProgrammi;

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

    public void CalcoloConsumoAmmorbidente()
    {

    }
}



