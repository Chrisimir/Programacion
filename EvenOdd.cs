//Chris Lund Schober
using System;
public class EvenOdd
{
    public static void Main()
    {
        int Num;
        
        Console.WriteLine("Enter the number you want to check");
        Num = Convert.ToInt32( Console.ReadLine());
        
        if ((Num % 2) == 0)
            Console.WriteLine("Your number is even");
            else
                Console.WriteLine("Your number is odd");
    }
}
