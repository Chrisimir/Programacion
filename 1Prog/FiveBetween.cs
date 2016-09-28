// Chris Lund Schober
using System;
public class FiveBetween
{
    public static void Main()
    {
        int end = 0;
        int num1, num2;
        int count = 0;
        
        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32( Console.ReadLine() );
        
        while(end == 0)
        {
            if(num1 < num2)
            {
                while((num1 % 5 == 0) && (num1 <= num2))
                {
                    count = count +1;
                    num1 = num1 +5;
                    end = 1;
                }
                num1 = num1 +1;
            }
            else if(num1 > num2)
            {
                while((num1 % 5 == 0) && (num1 >= num2))
                {
                    count = count +1;
                    num1 = num1 -5;
                    end = 1;
                }
                num1 = num1 -1;
            }
            else if(num1 == num2)
            {
                end = 1;
            }
        }
        Console.WriteLine("The are {0} multiples between the numbers you gave",
            count);
    }
}

