namespace lw2;

public class Pupil
{
    private string _name;

    public string Name { get => _name; }
    
    public Pupil(string name)
    {
        _name = name;
    }
    
    public virtual void Study()
    {
        Console.WriteLine("No information about marks");
    }

    public virtual void Read()
    {
        Console.WriteLine("No information about reading abilities");
    }

    public virtual void Write()
    {
        Console.WriteLine("No information about writing abilities");
    }

    public virtual void Relax()
    {
        Console.WriteLine("No information about relax");
    }
}