namespace lw2;

public class BadPupil : Pupil
{
    public BadPupil(string name) : base(name) {}

    public override void Study()
    {
        Console.WriteLine("Bad marks :(");
    }

    public override void Read()
    {
        Console.WriteLine("Bad reading :(");
    }

    public override void Write()
    {
        Console.WriteLine("Bad writing :(");
    }

    public override void Relax()
    {
        Console.WriteLine("Too long rest :|");
    }
}