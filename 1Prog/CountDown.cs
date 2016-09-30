// Chris Lund Schober
using System;
public class CountDown
{
    public static void Main()
    {
        for(int num = 10; num > 0; num--)
        {
            if(num > 1)
                Console.Write("{0} ", num);
            else
                Console.Write("{0}", num);
        }
    }
}
