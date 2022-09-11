namespace lw2;

public class GoodPupil : Pupil
{
    public GoodPupil(string name) : base(name) {}

    public override void Study()
    {
        Console.WriteLine("Good marks");
    }

    public override void Read()
    {
        Console.WriteLine("Good reading");
    }

    public override void Write()
    {
        Console.WriteLine("Good writing");
    }

    public override void Relax()
    {
        Console.WriteLine("Moderate rest");
    }
}