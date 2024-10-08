﻿using System;
using System.Drawing;

Random rand = new Random();

Console.WriteLine(new Car(Brand.Volvo, "V70", Color.Blue));
Circle circle = new Circle(5);
Console.WriteLine(circle);
Console.WriteLine($"Area: {circle.Area:f2}");
Console.WriteLine($"Circumference: {circle.Circumference:f2}");
circle.Print();

Square square = new Square(5);
Console.WriteLine(square);
Console.WriteLine($"Area: {square.Area:f2}");
Console.WriteLine($"Circumference: {square.Circumference:f2}");
square.Print();

Shape[] shapes = new Shape[10];

for (int i = 0; i < shapes.Length; i++)
{
    int randomNumber = rand.Next(0, 2);
    ConsoleColor color = (ConsoleColor)rand.Next((int)ConsoleColor.DarkBlue, (int)ConsoleColor.White);

    if (randomNumber == 0)
    {
        shapes[i] = new Square(rand.NextDouble() * 10, color);
    }
    else
    {
        shapes[i] = new Circle(rand.NextDouble() * 10, color);
    }
}
Shape.PrintAll(shapes);

Shape.PrintCircles(shapes);

Console.ReadLine();

enum Brand { Toyota, Volvo, Kia, Ferrari, Ford }
enum Color { Red, Green, Blue, Yellow, Purple }

public abstract class Shape
{
    protected ConsoleColor color = ConsoleColor.Gray;
    public abstract double Area { get; }
    public abstract double Circumference { get; }

    public void Print()
    {
        if(this is Square)
        {
            Console.ForegroundColor = color;
            Square square = (Square)this;
            Console.WriteLine($"A square with side {square.SideLength:f} has an area of {Area:f} and a circumference of {Circumference:f}.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else if(this is Circle)
        {
            Console.ForegroundColor = color;
            Circle circle = (Circle)this;
            Console.WriteLine($"A circle with radius {circle.Radius:f} has an area of {Area:f} and a circumference of {Circumference:f}.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    public static void PrintAll(Shape[] shapes)
    {
        for (int i = 0; i < shapes.Length; i++)
        {
            shapes[i].Print();
        }
    }

    public static void PrintCircles(Shape[] shapes)
    {
        for (int i = 0; i < shapes.Length; i++)
        {
            (shapes[i] as Circle) ? .Print();
        }
    }
}

class Square : Shape
{
    public override double Area { get; }
    public override double Circumference { get; }
    public double SideLength { get; set; }

    public Square(double sideLength, ConsoleColor color) : this(sideLength)
    {
        this.color = color;
    }

    public Square(double sideLength)
    {
        SideLength = sideLength;
        Area = sideLength * sideLength;
        Circumference = sideLength * 4;
    }

    public override string ToString()
    {
        return $"A square with side {SideLength}";
    }
}

class Circle : Shape
{
    public double Radius { get; set; }
    public override double Area { get; }
    public override double Circumference { get; }

    public Circle(double radius, ConsoleColor color) : this(radius)
    {
        this.color = color;
    }
    public Circle(double radius)
    {
        Radius = radius;
        Circumference = Math.PI * 2 * Radius;
        Area = (Radius * Radius) * Math.PI;
    }

    public override string ToString()
    {
        return $"A circle with the radius of {Radius}";
    }
}

class Vehicle
{
    Random rand = new Random();
    public Size Size { get; set; }

    public Brand Brand { get; set; }
    public Color Color { get; set; }

    public Vehicle()
    {
        this.Size = new Size((rand.NextDouble()*2)+2, (rand.NextDouble() * 1.5) + 1, (rand.NextDouble()*0.5) + 1);
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
        Brand = Brand.Ford;
        Model = "F150";
        Color = Color.Red;
    }

    public Car(Brand brand, string model, Color color)
    {
        Model = model;
        Brand = brand;
        Color = color;
    }

    public override string ToString()
    {
        return $"A {Color} {Size.Length:f} meter long {Model} from {Brand}";
    }
}

public struct Size
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public Size(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }
}