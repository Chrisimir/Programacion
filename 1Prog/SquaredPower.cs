// Chris Lund Schober
using System;
public class SquaredPower
{
    public static void Main()
    {
         int firstNum, secondNum;
         int squareOfsecondNum;
        
        Console.Write("Enter first number: ");
        firstNum = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter second number: ");
        secondNum = Convert.ToInt32( Console.ReadLine() );
        
        squareOfsecondNum = Convert.ToInt32( Math.Sqrt(secondNum) );
        
        for(int count = 1; count <= squareOfsecondNum; count++)
        {
            if(count*count >= firstNum)
                Console.Write("{0} ", count*count);
        }
    }
}
