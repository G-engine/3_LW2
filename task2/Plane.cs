namespace task2;

public class Plane : Vehicle
{
    private int _numberOfPassengers;
    private int _height;

    public Plane(int price, int speed, int releaseYear, int numberOfPassengers, int height, int x = 0, int y = 0) :
        base(price, speed, releaseYear, x, y)
    {
        _numberOfPassengers = numberOfPassengers;
        _height = height;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Type of vehicle: Plane {Environment.NewLine}" +
                          $"Price: {_price} {Environment.NewLine}" +
                          $"Max speed: {_speed} {Environment.NewLine}" +
                          $"Release year: {_releaseYear} {Environment.NewLine}" +
                          $"Max number of passengers: {_numberOfPassengers} {Environment.NewLine}" +
                          $"Max height: {_height} {Environment.NewLine}" +
                          $"Coordinates: ({_x}; {_y}) {Environment.NewLine}");
    }
}