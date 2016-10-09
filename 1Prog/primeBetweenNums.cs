// Chris Lund Schober
using System;
public class hash
{
    public static void Main()
    {
        int numOne, numTwo;
        int countPrimes = 0;
        int countTries = 0;
        
        Console.Write("Enter first number: ");
        numOne = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Enter second number: ");
        numTwo = Convert.ToInt32( Console.ReadLine() );
        
        while( numOne <= numTwo )
        {
            for( int i = 2; i < numOne && countTries == 0; i++ )
            {
                if( (numOne % i) == 0)
                {
                    countTries++;
                }
            }
            
            if( countTries == 0 )
            {
                    countPrimes++;
                    Console.WriteLine("Prime digit #{0}: {1}", countPrimes, numOne);
            }
            
            countTries = 0;
            
            numOne++;
        }
        
        Console.WriteLine("There are/is {0} prime numbers", countPrimes);
    }
}
