// Chris Lund Schober
using System;
public class Great
{
    public static void Main()
    {
        int numA, numB;
        int greatestNumber;
        
        Console.Write("Enter first number: ");
        numA = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter second number: ");
        numB = Convert.ToInt32( Console.ReadLine() );
        
        
        if(numA > numB)
            greatestNumber = numA;
        else
            greatestNumber = numB;
            
        Console.WriteLine("With if/else: {0}", greatestNumber);
        
        
        
        greatestNumber = numA > numB ? numA : numB;
        Console.WriteLine("With CondOp: {0}", greatestNumber);
    }
}
