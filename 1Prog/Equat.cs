// Chris Lund Schober
using System;
public class Equation
{
    public static void Main()
    {
        double aIsPow, bIsX, cIsNon;
        double ansPos, ansNeg;
        double square;
        
        Console.Write("Enter a: ");
        aIsPow = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Enter b: ");
        bIsX = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Enter c: ");
        cIsNon = Convert.ToDouble( Console.ReadLine() );
        
        square = Math.Sqrt( bIsX * bIsX - 4 * aIsPow * cIsNon);
        
        ansPos = (-bIsX + square) / (2 * aIsPow);
        ansNeg = (-bIsX - square) / (2 * aIsPow);
        
        Console.WriteLine(ansPos);
        Console.WriteLine(ansNeg);
        
    }
}
