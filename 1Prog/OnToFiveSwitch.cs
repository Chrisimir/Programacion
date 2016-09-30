// Chris Lund Schober
using System;
public class OneToFive
{
    public static void Main()
    {
        int num;
        
        Console.Write("Enter a number: ");
        num = Convert.ToInt32( Console.ReadLine() );
        
        switch(num)
        {
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            default: Console.WriteLine("I dont recognise that number"); break;
        }
    }
}
