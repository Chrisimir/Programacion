// Chris Lund Schober
using System;
public class Increments
{
    public static void Main()
    {
        double numA, numB, numC;
        
        Console.Write("Enter the first number: ");
        numA = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Enter the seconds number: ");
        numB = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Enter the third number: ");
        numC = Convert.ToDouble( Console.ReadLine() );
        
        numA++;
        numB /= 3;
        numC -= 5;
        
        Console.Write("{0} {1} {2}", numA, numB, numC);
    }
}
