// Chris Lund Schober
using System;
public class login
{
    public static void Main()
    {
        int pass;
        
        do
        {
            Console.WriteLine("Enter your password");
            pass = Convert.ToInt32(Console.ReadLine());
            
            if (pass != 1234)
                Console.WriteLine("Incorrect");
                
        }
        while (pass != 1234);
        
        Console.WriteLine("Access granted");
    }
}
