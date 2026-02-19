using System;

public class Program
{
    public static void Main(string[] args)
    {
        Pentagon p1 = new Pentagon();
        Console.WriteLine("Pentagon p1");
        Console.WriteLine("--------------------");
        p1.display();

        Console.WriteLine();
        Pentagon p2 = new Pentagon(5);
        Console.WriteLine("Pentagon p2");
        Console.WriteLine("--------------------");
        p2.display();

    }
}


class Pentagon
{

    private double side;

    public Pentagon(double side)
    {
        this.side = side;
    }

    public Pentagon() : this(0.0) { } // Default constructor using constructor chaining

    public double GetPerimeter()
    {
        double perimeter = this.side * 5;
        return perimeter;
    }

    public double GetArea()
    {
        double area = (Math.Sqrt(5 * (5 + (2 * Math.Sqrt(5)))) * (this.side * this.side)) / 4;
        return area;
    }

    public void display()
    {
        Console.WriteLine("Side length: {0}", this.side);
        Console.WriteLine("Perimeter: {0:F3}", this.GetPerimeter());
        Console.WriteLine("Area: {0:F3}", this.GetArea());
    }

}


