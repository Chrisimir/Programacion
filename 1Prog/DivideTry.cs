// Chris Lund Schober
using System;
public class DivideTry
{
    public static void Main()
    {
        int fNum, sNum;
        
        try
        {
            Console.Write("Enter the first number: ");
            fNum = Convert.ToInt32( Console.ReadLine() );
            Console.Write("Enter the second number: ");
            sNum = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("{0} / {1} = {2}", fNum, sNum, fNum / sNum );
        }    
        catch (FormatException)
        {
            Console.Write("It's not a valid number.");
        }
        catch (DivideByZeroException)
        {
            Console.Write("You can't divide by zero.");
        }
    }
}
