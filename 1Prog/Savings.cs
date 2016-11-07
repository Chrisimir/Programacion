// Chris Lund Schober
using System;
public class Sanvings
{
    public static void Main()
    {
        byte age;
        short birthYear;
        uint savings;
        uint population;
        
        Console.Write("Enter age: ");
        age = Convert.ToByte( Console.ReadLine() );
        Console.Write("Enter brith year: ");
        birthYear = Convert.ToInt16( Console.ReadLine() );
         Console.Write("Enter expected savings: ");
        savings = Convert.ToUInt32( Console.ReadLine() );
         Console.Write("Enter the population of your country: ");
        population = Convert.ToUInt32( Console.ReadLine() );
    }
}
