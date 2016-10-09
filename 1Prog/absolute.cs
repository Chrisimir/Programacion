// Chris Lund Schober
using System;
public class Absolute
{
    public static void Main()
    {
        int abs;
        
        Console.Write("Enter number: ");
        abs = Convert.ToInt32( Console.ReadLine() );
        
        if(abs < 0)
            Console.WriteLine("Absolute value: {0}", abs * -1);
        else
            Console.WriteLine("Absolute value: {0}", abs);
    }
}
