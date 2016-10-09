// Chris Lund Schober
using System;
public class Product
{
    public static void Main()
    {
        int num1, num2;
        
        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32( Console.ReadLine() );
        
        if (num1 == 0)
            Console.WriteLine("The product of 0 by any number is 0");
       else
        {
            Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32( Console.ReadLine() );
            
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            
        }
    }
}
