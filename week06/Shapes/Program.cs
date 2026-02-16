using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("green", 3));
        shapes.Add(new Rectangle("red", 4, 5));
        shapes.Add(new Circle("blue", 7));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }

    }
}