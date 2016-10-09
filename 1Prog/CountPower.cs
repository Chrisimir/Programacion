// Chris Lund Schober
using System;
public class CountPower
{
    public static void Main()
    {
        int userNum;
        int count = 1;
        
        Console.Write("Enter number: ");
        userNum = Convert.ToInt32( Console.ReadLine() );
        
        while(count < userNum)
        {
                Console.Write("{0} ", count*count);
                count++;
        }
        Console.Write("{0}", count*count);
    }
}
