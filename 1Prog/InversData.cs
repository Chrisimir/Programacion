// Chris Lund Schober
using System;
public class InversData
{
    public static void Main()
    {
        int[] data = new int[5];
        
        for(int i = 4; i >= 0; i--)
        {
            Console.Write("Enter number: ");
            data[i] = Convert.ToInt32( Console.ReadLine() );
        }
        
        for(int i = 0; i <= 4; i++)
        {
            Console.Write("{0} ", data[i]);
        }
    }
}
