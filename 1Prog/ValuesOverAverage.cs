// Chris Lund Schober
using System;
public class ValuesOverAverage
{
    public static void Main()
    {
        int[] data = new int[10];
        int sum = 0;
        float average;
        
        for(int i = 0; i < 10; i++)
        {
            Console.Write("Enter number: ");
            data[i] = Convert.ToInt32( Console.ReadLine() );
            sum = sum + data[i];
        }
        
        average = sum / 10;
        
        for(int i = 0; i < 10; i++)
        {
            if( data[i] > average )
                Console.Write("{0} ", data[i]);
        }
    }
}
