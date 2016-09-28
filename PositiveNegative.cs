//Chris Lund Schober
using System;
public class positiveNegative
{
    public static void Main()
    {
        int x;
        
        Console.WriteLine("Enter the number you want to check");
        x = Convert.ToInt32( Console.ReadLine() );
        
        if(x > 0)
        
            Console.WriteLine("{0} is positive", x);
            
        else
        
            Console.WriteLine("{0} is negative", x);
        
    }
}
