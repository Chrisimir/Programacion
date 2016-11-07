// Chris Lund Schober
using System;
public class CuantOfEven
{
    public static void Main()
    {
        int n1, n2;
        int evenNumbers;
        
        Console.Write("Enter first number: ");
        n1 = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter second number: ");
        n2 = Convert.ToInt32( Console.ReadLine() );
        
        evenNumbers = 
            n1 % 2 == 0 && n2 % 2 == 0 ? 2 :
            n1 % 2 == 0 || n2 % 2 == 0 ? 1 : 0;
            
        Console.WriteLine(evenNumbers);
    }
}
