/*Chris Lund Schober
20-sept-2016*/

using System;
public class PosNegCount
{
    public static void Main()
    {
        int num1, num2;
        
        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32( Console.ReadLine() );
        
        if((num1 > 0) && (num2 > 0))
            Console.WriteLine("There are 2 positive numbers");
        if((num1 < 0) && (num2 < 0))
            Console.WriteLine("There are 0 positive numbers");
        if((num1 > 0) && (num2 < 0))
            Console.WriteLine("There are 1 positive number");
        if((num1 < 0) && (num2 > 0))
            Console.WriteLine("There are 1 positive number");
        if((num1 == 0) && (num2 == 0))
            Console.WriteLine("There are 0 positive numbers");
    }
}
