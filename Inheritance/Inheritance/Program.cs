Console.WriteLine(new Car(Brand.Volvo, "V70", Color.Blue));

enum Brand { Toyota, Volvo, Kia, Ferrari, Ford }
enum Color { Red, Green, Blue, Yellow, Purple }

class Vehicle
{
    public string Brand { get; set; }

    public string Color { get; set; }

    public Vehicle(Brand brand, Color color)
    {
        Brand = brand.ToString();
        Color = color.ToString();
    }

    public Vehicle(Brand brand)
    {
        Brand = brand.ToString();
        Color = "Red";
    }

    public Vehicle()
    {
        Brand = "Ford";
        Color = "Red";
    }

    public override string ToString()
    {
        return $"A {Color} {Brand}";
    }
}

class Car : Vehicle
{
    public string Model { get; set; }

    public Car()
    {
        Brand = "Ford";
        Model = "F150";
        Color = "Red";
    }

    public Car(Brand brand, string model, Color color) : this(brand, color)
    {
        Model = model;
    }

    public Car(Brand brand, Color color) : this(color)
    {
        Brand = brand.ToString();
    }

    public Car(Color color)
    {
        Color = color.ToString();
    }

    public override string ToString()
    {
        return $"A {Color} {Model} from {Brand}";
    }
}