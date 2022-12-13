//композиция
public class Oop
{
    public static void Main()
    {
        Car car = new Car(new Engine("MK 23", 223, 2.5));
        Console.WriteLine(car.GetPower());
        car.Engine = new Engine("test", 110, 1.6);
        Console.WriteLine(car.GetPower());
    }
}


public class Engine
{
    private string name;
    private long power;
    private double volume;

    public Engine(string name, long power, double volume)
    {
        this.name = name;
        this.power = power;
        this.volume = volume;
    }

    public string Name { get => name; set => name = value; }
    public long Power { get => power; set => power = value; }
    public double Volume { get => volume; set => volume = value; }

}

public class Car
{
    private Engine engine;

    public Car(Engine engine)
    {
        this.engine = engine;
    }

    public Engine Engine { set => engine = value; }

    public string GetPower()
    {
        return "Объем = " + engine.Volume + " Мощность = " + engine.Power;

    }
}