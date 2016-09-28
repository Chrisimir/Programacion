//Chris Lund Schober
using System;
public class compare
{
    public static void Main()
    {
        int FNum, SNum;
        
        Console.WriteLine("Enter the first number you want to check");
        FNum = Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("Enter the second number you want to check");
        SNum = Convert.ToInt32( Console.ReadLine());
        
        if (FNum > SNum)
            Console.WriteLine("{0} is the greatest number", FNum);
            else
                Console.WriteLine("{0} is the greatest number", SNum);
    }
}
