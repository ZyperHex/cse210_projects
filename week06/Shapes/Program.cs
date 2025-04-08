using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Shape[] shapes = {
            new Square("blue", 6),
            new Rectangle("red", 7, 10),
            new Circle("green", 12)
        };

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape);
        }
    }
}