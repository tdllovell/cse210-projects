using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Shape sq = new Square("red", 4);
        shapes.Add(sq);
        Shape rect = new Rectangle("scarlet", 3, 7);
        shapes.Add(rect);
        Shape circ = new Circle("blue", 2);
        shapes.Add(circ);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine("The area is " + shape.GetArea() + " units.");
            Console.WriteLine();
        }
    }
}