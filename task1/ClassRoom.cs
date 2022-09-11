namespace lw2;

public class ClassRoom
{
    private Pupil _p1;
    private Pupil _p2;
    private Pupil? _p3;
    private Pupil? _p4;

    public ClassRoom(Pupil p1, Pupil p2, Pupil? p3 = null, Pupil? p4 = null)
    {
        _p1 = p1;
        _p2 = p2;
        _p3 = p3;
        _p4 = p4;
    }

    public void GetPupilInfo()
    {
        Console.WriteLine(_p1.Name);
        _p1.Study();
        _p1.Read();
        _p1.Write();
        _p1.Relax();
        
        Console.WriteLine();
        Console.WriteLine(_p2.Name);
        _p2.Study();
        _p2.Read();
        _p2.Write();
        _p2.Relax();

        if (_p3 != null)
        {
            Console.WriteLine();
            Console.WriteLine(_p3.Name);
            _p3.Study();
            _p3.Read();
            _p3.Write();
            _p3.Relax();
        }
        
        if(_p4 != null)
        {
            Console.WriteLine();
            Console.WriteLine(_p4.Name);
            _p4.Study();
            _p4.Read();
            _p4.Write();
            _p4.Relax();
        }
    }
}