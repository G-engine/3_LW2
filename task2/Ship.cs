namespace task2;

public class Ship : Vehicle
{
    private int _numberOfPassengers;
    private string _portName;

    public Ship(int price, int speed, int releaseYear, int numberOfPassengers, string portName, int x = 0, int y = 0) :
        base(price, speed, releaseYear, x, y)
    {
        _numberOfPassengers = numberOfPassengers;
        _portName = portName;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Type of vehicle: Ship {Environment.NewLine}" +
                          $"Price: {_price} {Environment.NewLine}" +
                          $"Max speed: {_speed} {Environment.NewLine}" +
                          $"Release year: {_releaseYear} {Environment.NewLine}" +
                          $"Max number of passengers: {_numberOfPassengers} {Environment.NewLine}" +
                          $"Registered port: {_portName} {Environment.NewLine}" +
                          $"Coordinates: ({_x}; {_y}) {Environment.NewLine}");
    }
}