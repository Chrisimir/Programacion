// Chris Lund Schober
using System;
public class SameNumInArray
{
    public static void Main()
    {
        double[,] num = new double[2,5];
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter num for column 1: ");
            num[0,i] = Convert.ToDouble( Console.ReadLine() );
        }
        for (int u = 0; u < 5; u++)
        {
            Console.Write("Enter num for column 2: ");
            num[1,u] = Convert.ToDouble( Console.ReadLine() );
        }
        
        for (int e = 0; e < 5; e++)
        {
            for (int o = 0; o < 5; o++)
            {
                if( num[0,e] == num[1,o] )
                {
                    Console.WriteLine(num[0,e]);
                }
            }
        }
    }
}
        
