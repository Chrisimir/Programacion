// Chris Lund Schober

using System;
public class EvenOdd
{
    public static void Main()
    {
        int num;
        
        Console.Write("Enter your number: ");
        num = Convert.ToInt32( Console.ReadLine() );
        
        if (num % 2 == 0)
            Console.WriteLine("{0} is even", num);
            
        else
            Console.WriteLine("{0} is odd", num);
    }
}
