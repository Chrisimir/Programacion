// Chris Lund Schober
using System;
public class OneToFive
{
    public static void Main()
    {
        int num;
        
        Console.Write("Enter a number: ");
        num = Convert.ToInt32( Console.ReadLine() );
        
        if(num==1)
            Console.WriteLine("One");
        else if(num==2)
            Console.WriteLine("Two");
        else if(num==3)
            Console.WriteLine("Three");
        else if(num==4)
            Console.WriteLine("Four");
        else if(num==5)
            Console.WriteLine("Five");
        else
            Console.WriteLine("I dont recognise that number");
    }
}
