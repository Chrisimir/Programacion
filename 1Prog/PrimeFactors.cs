// Chris Lund Schober
using System;
public class Prime
{
    public static void Main()
    {
        int userNum;
        
        Console.Write("Enter a number: ");
        userNum = Convert.ToInt32( Console.ReadLine() );
        
        for(int div = 2; userNum > 1; div++)
        {
            while(userNum % div == 0)
            {
                userNum = userNum / div;
                Console.Write("{0} ", div);
            }
        }
        
    }
}
