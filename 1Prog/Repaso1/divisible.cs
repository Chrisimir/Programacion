// Chris Lund Schober
using System;
public class Divisible
{
    public static void Main()
    {
        int num1, num2;
        
        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32( Console.ReadLine() );
        
        if (num1 % num2 == 0)
            Console.WriteLine("{0} is a multiple of {1}", num1, num2);
        else 
            Console.WriteLine("{0} is not a multiple of {1}", num1, num2);
    }
}
