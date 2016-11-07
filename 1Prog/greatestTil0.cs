// Chris Lund Schober
using System;
public class SumManyTilZeroDoWhile
{
    public static void Main()
    {
        int num;
        int great = 0;
        
        do
        {
            Console.Write("Enter number: ");
            num = Convert.ToInt32( Console.ReadLine() );
            great = great > num ? great : num;
        }
        while(num != 0);
        
        Console.WriteLine("The greatest is {0}", great);
    }
}

