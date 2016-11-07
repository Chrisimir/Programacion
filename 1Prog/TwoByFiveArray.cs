using System;
public class TwoByFiveArray
{
    public static void Main()
    {
        double[,] data = new double[5, 2];
        
        for( int i = 0; i < 5; i++)
        {
            Console.Write("Enter data of table 1: ");
            data[i,0] = Convert.ToDouble( Console.ReadLine() );
        }
        
        for( int e = 0; e < 5; e++)
        {
            Console.Write("Enter data of table 2: ");
            data[e,1] = Convert.ToDouble( Console.ReadLine() );
        }
        
        for( int u = 0; u < 5; u++)
        {
            Console.Write(data[u,0]);
        }
        
        for( int o = 0; o < 5; o++)
        {
            Console.Write(data[o,1]);
        }
    }
}
