namespace task2;

public class Car : Vehicle
{
    public Car(int price, int speed, int releaseYear, int x = 0, int y = 0) :
        base(price, speed, releaseYear, x, y) { }

    public void GetInfo()
    {
        Console.WriteLine($"Type of vehicle: Car {Environment.NewLine}" +
                          $"Price: {_price} {Environment.NewLine}" +
                          $"Max speed: {_speed} {Environment.NewLine}" +
                          $"Release year: {_releaseYear} {Environment.NewLine}" +
                          $"Coordinates: ({_x}; {_y}) {Environment.NewLine}");
    }
}