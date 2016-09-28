// Chris Lund Schober
using System;
public class SumManyTilZeroDoWhile
{
    public static void Main()
    {
        int num;
        int sum=0;
        
        do
        {
            Console.Write("Enter number: ");
            num = Convert.ToInt32( Console.ReadLine() );
            sum = num + sum;
        }
        while(num != 0);
        
        Console.WriteLine("The sum of all numbers is {0}", sum);
    }
}

