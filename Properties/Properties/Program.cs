using System;
using System.Drawing;
using System.Text;

Person person = new Person();
person.FirstName = "Lars";
person.lastName = "Larsson";
Console.WriteLine(person.FullName);

StepCounter stepCounter = new StepCounter();

for (int i = 0; i < 1000; i++)
{
    stepCounter.Step();
}
Console.WriteLine(stepCounter.Steps);

Car car = new Car("Ford F150");
Console.WriteLine(car.Model);
Console.WriteLine(car.Color);
Console.WriteLine(car.Price);
car.HalfPrice();
Console.WriteLine(car.Price);

BlueAndRed blueAndRed = new BlueAndRed();
blueAndRed.Blue = 47.5;
Console.WriteLine($"blue: {blueAndRed.Blue}, red: {blueAndRed.Red}");

RaceCar[] raceCars = new RaceCar[9];

for (int i = 0; i < raceCars.Length; i++)
{
    raceCars[i] = new RaceCar();
}

Console.WriteLine(RaceCar.GetCombinedLengthOfGreenCars(raceCars));

while (true)
{
    Thread.Sleep(1000);
    Console.Clear();

    for (int i = 0; i < raceCars.Length; i++)
    {
        raceCars[i].DriveForOneHour();
        char[] graphCharArr = GetGraph(raceCars[i], i).ToCharArray();
        for (int j = 0; j < graphCharArr.Length; j++)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            if (graphCharArr[j] == 'x')
            {
                Console.ForegroundColor = raceCars[i].Color;
            }
            Console.Write(graphCharArr[j]);
        }
        Console.WriteLine();
    }
}

static string GetGraph(RaceCar raceCar, int carIndex)
{
    Console.ForegroundColor = raceCar.Color;
    string returnGraph = $"Race Car {carIndex+1}: |";
    decimal distancePerSegment = 10000 / 18;

    for (int i = 0; i < 18; i++)
    {
        if(raceCar.Distance > (distancePerSegment * i) && raceCar.Distance < (distancePerSegment * (i+1)))
        {
            returnGraph += "x";
        }
        else
        {
            returnGraph += "-";
        }
    }

    returnGraph += "|";
    return returnGraph;
}

class Person
{
    private string _firstName = "default name";

    public string lastName { get; set; }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string FullName
    {
        get { return _firstName + " " + lastName; }
    }
}

class StepCounter
{
    private int _steps;

    public int Steps
    {
        get { return _steps; }
    }

    public void Step()
    {
        _steps++;
    }

    public void Reset()
    {
        _steps = 0;
    }
}

class RaceCar
{
    static Random rand = new Random();
    private int _length;
    private ConsoleColor _color;
    private int _speed;
    private int _distance = 0;

    public int Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }

    public int Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public int Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public ConsoleColor Color
    {
        get { return _color; }
        set { _color = value; }
    }
    
    private static ConsoleColor GetRandomColor()
    {
        var consoleColors = Enum.GetValues(typeof(ConsoleColor));
        return (ConsoleColor)consoleColors.GetValue(rand.Next(1, consoleColors.Length));
    }

    public RaceCar()
    {
        Length = rand.Next(3, 6);
        Speed = rand.Next(60, 241);
        Color = GetRandomColor();
    }

    public RaceCar(ConsoleColor color)
    {
        Length = rand.Next(3, 6);
        Speed = rand.Next(60, 241);
        Color = color;
    }

    public void DriveForOneHour()
    {
        Distance += Speed;
    }

    public static Car[] InstantiateAndGetNewCars(Car car)
    {
        Car[] cars = new Car[10];

        for (int i = 0; i < cars.Length; i++)
        {
            cars[i] = new Car(car.Color);
        }
        return cars;
    }

    public static int GetCombinedLengthOfGreenCars(RaceCar[] racerCars)
    {
        int lengthOfGreenCars = 0;
        for (int i = 0; i < racerCars.Length; i++)
        {
            if (racerCars[i].Color == ConsoleColor.Green)
            {
                lengthOfGreenCars += racerCars[i].Length;
            }
        }
        return lengthOfGreenCars;
    }
}

class Car
{
    private string _model = "Volvo V70";
    private Color _color = Color.Green;
    private int _price = 100;

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    public Color Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public int Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public Car()
    {

    }

    public Car(string model)
    {
        Model = model;
    }

    public Car(Color color)
    {
        Color = _color;
    }

    public Car(int price)
    {
        _price = price;
    }

    public void HalfPrice()
    {
        _price /= 2;
    }
}

class GlassOfWater
{
    private bool _isFull = false;
    private bool _isSmashed;

    public void FillGlass()
    {
        if(_isSmashed)
        {
            Console.WriteLine("You can't empty a smashed glass");
            return;
        }

        if(_isFull)
        {
            Console.WriteLine("Glass is already full");
            return;
        }
        _isFull = true;
    }

    public void EmptyGlass()
    {
        if (_isSmashed)
        {
            Console.WriteLine("You can't fill a smashed glass");
            return;
        }

        if (!_isFull)
        {
            Console.WriteLine("Glass is already empty");
            return;
        }
        _isFull = false;
    }

    public void SmashGlass()
    {
        if (_isSmashed)
        {
            Console.WriteLine("The glass is already smashed");
            return;
        }

        if (_isFull)
        {
            Console.WriteLine("The filled glass breaks");
        }

        if (!_isFull)
        {
            Console.WriteLine("The empty glass breaks");
        }
        _isSmashed = true;
    }
}

class BlueAndRed
{
    private double _blue = 50;
    private double _red = 50;

    public double Blue
    {
        get { return _blue; }
        set { _blue = value; _red = 100-_blue ; }
    }

    public double Red
    {
        get { return _red; }
        set { _red = value; _blue = 100 - _red; }
    }
}