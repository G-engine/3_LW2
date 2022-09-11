namespace lw2;

public class ExcellentPupil : Pupil
{
    public ExcellentPupil(string name) : base(name) {}

    public override void Study()
    {
        Console.WriteLine("Excellent marks!");
    }

    public override void Read()
    {
        Console.WriteLine("Excellent reading!");
    }

    public override void Write()
    {
        Console.WriteLine("Excellent writing!");
    }

    public override void Relax()
    {
        Console.WriteLine("Needs to sleep zzzZZZ");
    }
}