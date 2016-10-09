// Chris Lund Schober
using System;
public class Multiple
{
    public static void Main()
    {
        int num;
        
        Console.Write("Enter first number: ");
        num = Convert.ToInt32( Console.ReadLine() );
        
        if (num % 2 == 0)
        {
            if (num % 3 == 0)
                Console.WriteLine("{0} is multiple of 2 and 3", num);
            else
                Console.WriteLine("{0} is multiple of 2", num);
        }
        else if (num % 3 == 0)
            Console.WriteLine("{0} is multiple of 3", num);
        else
            Console.WriteLine("{0} is not a multiple of 2 nor 3", num);
    }
}
