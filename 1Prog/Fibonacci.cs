// Chris Lund Schober
using System;
public class Fibonacci
{
    public static void Main()
    {
        int userNum;
        int fibnc = 0;
        int val1 = 0, val2 = 1;
        int aux = 0;
        double goldRat;
        
        Console.Write("Enter number: ");
        userNum = Convert.ToInt32( Console.ReadLine() );
        
        for(int i = 0; i < userNum; i++)
        {
            aux = val1;
            fibnc = val1 + val2;
            val1 = val2;
            val2 = fibnc;
        }
        
        Console.WriteLine("The Fibonacci in possition {0} is: {1}",
            userNum, val1);
            
        goldRat = Convert.ToDouble(val1) / Convert.ToDouble(aux);
        
        Console.WriteLine("Golden Ratio in position {0} is: {1}",
            userNum, goldRat);
        
    }
}
