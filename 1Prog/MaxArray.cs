// Chris Lund Schober
using System;
public class MaxArray
{
    public static void Main()
    {
        double[,] num = new double[2,5];
        double greatestCol1, greatestCol2;
        double greatOfAll;
        
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
        
        greatestCol1 = num[0,0];
        greatestCol2 = num[1,0];
        
        for (int o = 0; o < 5; o++)
        {
            greatestCol1 = num[0,o] > greatestCol1 ? num[0,o] : greatestCol1;
        }
        Console.Write("Maximum number in colum 1: ");
        Console.WriteLine(greatestCol1);
        
        for (int e = 0; e < 5; e++)
        {
            greatestCol2 = num[1,e] > greatestCol2 ? num[1,e] : greatestCol2;
        }
        Console.Write("Maximum number in colum 2: ");
        Console.WriteLine(greatestCol2);
        
        greatOfAll = greatestCol1 > greatestCol2 ? greatestCol1 : greatestCol2;
        Console.Write("The greatest of all is: ");
        Console.WriteLine(greatOfAll);
    }
}
