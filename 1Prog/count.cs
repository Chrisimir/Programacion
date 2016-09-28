// Chris Lund Schober
using System;
public class Count
{
    public static void Main()
    {
        int num1, num2;
        
        Console.Write("N1? ");
        num1 = Convert.ToInt32( Console.ReadLine() );
        Console.Write("N2? ");
        num2 = Convert.ToInt32( Console.ReadLine() );
        
        if(num1 > num2)
        {
            while(num1 >= num2)
            {
                Console.Write("{0} ", num2);
                num2 = num2 +1;
            }
        }
        else if(num1 <= num2)
        {
            while(num2 >= num1)
            {
            Console.Write("{0} ", num1);
            num1 = num1 +1;
            }
        }     
    }
}
