//Chris Lund Schober


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
        
        if((num1 > 0) && (num2>0))
            Console.WriteLine("2 positives");
        else
            if ((num1 > 9) || (num2 > 9))
                Console.WriteLine("1 positive");
            else
                Console.WriteLine("0 positives");
    }
}
