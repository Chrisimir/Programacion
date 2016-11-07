// Chris Lund Schober
using System;
public class Hexagon
{
    public static void Main()
    {
        double hexaBase;
        double perimeter;
        double area;
        
        Console.Write("Enter the side of the hexagon: ");
        hexaBase = Convert.ToDouble( Console.ReadLine() );
        
        perimeter = hexaBase * 6;
        Console.WriteLine(perimeter);
        
        area = hexaBase * hexaBase * 3 * Math.Sqrt(3.0 / 2.0);
        Console.WriteLine(area);
    }
}
