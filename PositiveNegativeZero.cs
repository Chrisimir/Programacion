//Chris Lund Schober
using System;
public class positiveNegativeZerop
{
    public static void Main()
    {
        int x;
        
        Console.WriteLine("Enter the number you want to check");
        x = Convert.ToInt32( Console.ReadLine() );
        
        if(x > 0)
        
            Console.WriteLine("{0} is positive", x);
        
        if(x < 0)
        
            Console.WriteLine("{0} is negative", x);
        
        if(x == 0)
        
            Console.WriteLine("{0} is zero", x);
        
    }
}
