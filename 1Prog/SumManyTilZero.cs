// Chris Lund Schober
using System;
public class SumManyTilZero
{
    public static void Main()
    {
        int num=1;
        int sum=0;
        
        while(num != 0)
        {
            Console.Write("Enter number: ");
            num = Convert.ToInt32( Console.ReadLine() );
            sum = num + sum;
        }
        
        Console.WriteLine("The sum of all numbers is {0}", sum);
    }
}

