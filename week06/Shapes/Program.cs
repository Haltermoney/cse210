using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Square square = new Square(5);
        //Console.WriteLine($"The area of the {square.GetColor()} {square.GetShape()} is {square.GetArea()}");
        //Console.WriteLine();

        Rectangle rectangle = new Rectangle("purple", 6, 7);
        //Console.WriteLine($"The area of the {rectangle.GetColor()} {rectangle.GetShape()} is {rectangle.GetArea()}");
        //Console.WriteLine();

        Circle circle = new Circle(4);
        //Console.WriteLine($"The area of the {circle.GetColor()} {circle.GetShape()} is {circle.GetArea()}");

        List<Shape> shapes = new List<Shape>
        {
            square,
            rectangle,
            circle
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.DisplayShapeInfo());
        }
    }
}