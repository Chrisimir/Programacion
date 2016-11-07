// Chris Lund Schober
using System;
public class Rectangle
{
    public static void Main()
    {
        double rectangleBase;
        double rectangleHeight;
        double perimeter;
        double area;
        double diagonal;
        
        Console.Write("Enter the base of the rectangle: ");
        rectangleBase = Convert.ToDouble( Console.ReadLine() );
        
        Console.Write("Enter the height of the rectangle: ");
        rectangleHeight = Convert.ToDouble( Console.ReadLine() );
        
        perimeter = rectangleBase * 2 + rectangleHeight * 2;
        Console.WriteLine(perimeter);
        
        area = rectangleBase * rectangleHeight;
        Console.WriteLine(area);
        
        diagonal = Math.Sqrt
        (
            rectangleBase  * rectangleBase + rectangleHeight * rectangleHeight
        );
        Console.WriteLine(diagonal);
    }
}
