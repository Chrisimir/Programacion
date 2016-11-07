// Chris Lund Schober
using System;
public class EvenBool
{
    public static void Main()
    {
        int numA, numB;
        bool bothEven;
        
        Console.Write("Enter the first number: ");
        numA = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter the seconds number: ");
        numB = Convert.ToInt32( Console.ReadLine() );
        
        bothEven = (numA % 2 == 0) && (numB % 2 == 0);
        
        Console.WriteLine(bothEven);
    }
}
