namespace lw2;

public static class Program
{
    public static void Main(string[] args)
    {
        ExcellentPupil p1 = new ExcellentPupil("Max");
        GoodPupil p2 = new GoodPupil("Dan");
        BadPupil p3 = new BadPupil("Alex");
        Pupil p4 = new Pupil("Mike");
        
        ClassRoom class1 = new ClassRoom(p2, p3, p1, p4);
        
        class1.GetPupilInfo();
    }
}