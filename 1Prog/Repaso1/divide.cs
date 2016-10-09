// Chris Lund Schober
using System;
public class Divide
{
    public static void Main()
    {
        int num1, num2;
        
        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32( Console.ReadLine() );
        
        if (num2 == 0)
            Console.WriteLine("Error: I can not divide by zero");
       else
        {   
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);   
        }
    }
}
