// Chris Lund Schober
using System;
public class SquareRoot
{
    public static void Main()
    {
        double userNum;
        
        try
        {
            Console.Write("Enter number: ");
            userNum = Convert.ToDouble( Console.ReadLine() );
        
            Console.WriteLine( Math.Sqrt(userNum) );
        }
        
        catch (Exception)
        {
            Console.WriteLine("Error");
        }
    }
}
