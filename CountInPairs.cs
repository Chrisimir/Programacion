// Chris Lund Schober
using System;
public class ThreeBetween
{
    public static void Main()
    {
        int count = 0;
        int num1, num2;
        
        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32( Console.ReadLine() );
        
        if(num1 > num2)
        {
            while(num1 % 3 == 0)
            {
                Console.Write("{0} ", num1);
                num1 = num1 +3;
                }
        else if(num1 < num2)
        {
            
            }
        else
        {
            Console.WriteLine(num1);
            }
    }
}
