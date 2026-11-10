using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        //Create an instance for each shape
        Square mySquare = new Square("Green", 5);
        Rectangle myRectangle = new Rectangle("Blue", 2, 4);
        Circle myCircle = new Circle("Purple", 10);

        //Create a list of shapes to hold shapes
        List<Shape> myShapes = new List<Shape>();
        
        //Add each instance created to the list
        myShapes.Add(mySquare);
        myShapes.Add(myRectangle);
        myShapes.Add(myCircle);

        //Iterate through the list
        foreach (Shape shape in myShapes)
        {
        
        //Get all necessary info
        string color = shape.GetColor();
        double area = shape.GetArea();

        //Display info
        Console.WriteLine($"Shape- Color: {color}, Area: {area}");
        }
    }
}