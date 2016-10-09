// Chris Lund Schober
using System;
public class CountDown11
{
    public static void Main()
    {
        for(int i = 0; i < 11; i++)
        {
            for(int u = 10; u >= 0; u = u-2)
            {
                Console.Write("{0} ", u);
            }
            Console.WriteLine();
        }
    
    }
}
