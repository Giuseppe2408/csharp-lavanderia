// See https://aka.ms/new-console-template for more information

public class Asciugatrice : Macchina
{
    

    public int GettoniInseriti { get; set; }

    public ProgrammaDiLavaggio[] arrayProgrammi;

    public ProgrammaDiLavaggio ProgrammaInUso { get; private set; }

    public Asciugatrice(string modello,int gettoniInseriti) : base(modello)
    {
        GettoniInseriti = gettoniInseriti;
        //this.arrayProgrammi = arrayProgrammi;
        //ProgrammaInUso = programmaInUso;
    }

    public override bool inFunzione()
    {
        if (ProgrammaInUso != null)
        {
            return true;
        }

        return false;
    }
}



