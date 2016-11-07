// Chris Lund Schober
using System;
public class ConvertBinHex
{
    public static void Main()
    {
        double userNum1, userNum2;
        double i;
        
        Console.Write("Enter the first number: ");
        userNum1 = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Enter the second number: ");
        userNum2 = Convert.ToDouble( Console.ReadLine() );
        
        // 1 step for
        for( i = userNum1; i <= userNum2; i++)
        {
            if( i % 2 == 0)
                Console.Write("{0} ", i);
        }
        Console.WriteLine();
        
        // 2 step for
        if( userNum1 % 2 == 0 )
        { 
            for(i = userNum1; i <= userNum2; i += 2)
            {
                Console.Write("{0} ", i);
            }
        }
        else
        { 
            userNum1++;
            for( i = userNum1; i <= userNum2; i += 2)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
        
        // while
        i = userNum1;
        while(i <= userNum2)
        {
            if( i % 2 == 0)
                Console.Write("{0} ", i);
            i++;
        }
        Console.WriteLine();
        
        //do while
        i = userNum1;
        do
        {
            if( i % 2 == 0)
                Console.Write("{0} ", i);
            i++;
        }while(i <= userNum2);
        
        
    }
}
