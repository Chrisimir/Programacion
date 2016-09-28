// Chris Lund Schober
using System;
public class stars
{
    public static void Main()
    {
        int num;
        int count = 0;
        
        Console.Write("Enter the amount of asteriks: ");
        num = Convert.ToInt32( Console.ReadLine() );
        
        while(num>count)
        {
            Console.Write("*");
            count = count +1;
        }
    }
}
