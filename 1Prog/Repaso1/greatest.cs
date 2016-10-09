// Chris Lund Schober

using System;
public class Greatest
{
    public static void Main()
    {
        int num1, num2;
        
        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32( Console.ReadLine() );
        
        if (num1 > num2)
            Console.WriteLine("{0} is greatest", num1);
        else if (num2 > num1)
            Console.WriteLine("{0} is greatest", num2);
        else
            Console.WriteLine("Both are equaly great");

        
    }
}
