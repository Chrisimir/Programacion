// Chris Lund Schober
using System;
public class login
{
    public static void Main()
    {
        int num;
        int count = 0;
        int countNeg = 0;
        
        Console.Write("Enter a number: ");
        num = Convert.ToInt32( Console.ReadLine());
        
        
        while(num != 0)
        {
            if(num<0)
                countNeg = countNeg + 1;
            count = count + 1;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32( Console.ReadLine());
            }
        
        Console.WriteLine("You have entered the number {0} times", count);
        Console.WriteLine("You have entered a negative number {0} times", countNeg);
    }
}
