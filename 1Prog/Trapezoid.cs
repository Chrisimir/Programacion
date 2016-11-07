// Chris Lund Schober
using System;
public class Trapezoid
{
    public static void Main()
    {
        byte width, height;
        
        Console.Write("Enter the desired width: ");
        width = Convert.ToByte( Console.ReadLine() );
        Console.Write("Enter the desired height: ");
        height = Convert.ToByte( Console.ReadLine() );
        
        for( byte i = 0; i < height; i++ )
        {
            for( byte z = 0; z < i; z++ )
                Console.Write("·");
            
            for( byte u = 0; u < width; u++ )
            {
                Console.Write("*");
            }
            
            for( byte z = 0; z < i; z++ )
                Console.Write("·");
            
            Console.WriteLine();
        }
    }
}
