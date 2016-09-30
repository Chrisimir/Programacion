// Chris Lund Schober
using System;
public class Prime
{
    public static void Main()
    {
        int userNum;
        int divCheck;
        int isPrime = 0;
        
        Console.Write("Enter a number: ");
        userNum = Convert.ToInt32( Console.ReadLine() );
        
        
        for( divCheck = userNum - 1; (divCheck > 1) || (isPrime == 0); divCheck--)
        {
            if( (userNum % divCheck) == 0)
                isPrime = 1;
        }
        if(isPrime == 1)
            Console.WriteLine("Your number is prime");
        else
            Console.WriteLine("Your number is not prime");
    }
}
