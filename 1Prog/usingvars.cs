using System;
public class usingvars
{
    public static void Main()
    {
    int x;
    int y;
    
    Console.WriteLine("Enter the first number: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number: ");
    y = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Sum: ");
    Console.WriteLine(x+y);
    }
}
