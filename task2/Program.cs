namespace task2;

public class Program
{
    public static void Main(string[] args)
    {
        Car kia = new Car(800000, 220, 2017, 165, 20);
        Plane boing = new Plane(150000000, 380, 2009, 94, 20000);
        Ship cargo = new Ship(80000000, 70, 2011, 16, "Taman'", 245, 93);
        
        kia.GetInfo();
        boing.GetInfo();
        cargo.GetInfo();
    }
}