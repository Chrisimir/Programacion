/*Chris Lund Schober
20-sept-2016*/

using System;
public class PosNegCount
{
    public static void Main()
    {
        int num1, num2;
        int countNeg = 0, countPos = 0;
        
        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32( Console.ReadLine() );
        
        if(num1>0)
            countPos = countPos + 1;
        else if(num1<0)
            countNeg = countNeg + 1;
        
        if(num2>0)
            countPos = countPos + 1;
        else if(num2<0)
            countNeg = countNeg + 1;
        
        
        Console.Write("{0} positive numbers and {1} negative numbers",
            countPos, countNeg);
    }
}
