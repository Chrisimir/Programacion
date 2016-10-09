// Chris Lund Schober
using System;
public class BreakLogin
{
    public static void Main()
    {
        int pass;
        
        do
        {
            Console.Write("Enter the password: ");
            pass = Convert.ToInt32( Console.ReadLine());
            if(pass == 1234)
                break;
            else
                Console.WriteLine("Incorrect");
            }
        while(5 > 1);
        
        Console.WriteLine("Access granted");
    }
}
