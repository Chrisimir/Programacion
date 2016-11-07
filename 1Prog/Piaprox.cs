// Chris Lund Schober
using System;
public class PIaproxs
{
    public static void Main()
    {   
        double userNum;
        double primeNum = 1;
        bool primeFound;
        double searchPrime;
        
        Console.Write("Enter the amount of aproximatión: ");
        userNum = Convert.ToDouble( Console.ReadLine() );
        
        for(int i = 2; i <= userNum; i++)
        {
            searchPrime = primeNum;
            do
            {
                if( primeNum % (searchPrime + 1) == 0)
                {
                    primeNum = searchPrime;
                    primeFound = true;
                }
                i++;
            }while(!primeFound);
            
        }
    }
}
