namespace task2;

public class Vehicle
{
    protected int _x;
    protected int _y;
    protected int _price;
    protected int _speed;
    protected int _releaseYear;

    protected Vehicle(int price, int speed, int releaseYear, int x = 0, int y = 0)
    {
        _price = price;
        _speed = speed;
        _releaseYear = releaseYear;
        _x = x;
        _y = y;
    }
}