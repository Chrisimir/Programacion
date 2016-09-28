// Chris Lund Schober
using System;
public class login
{
    public static void Main()
    {
        int pass, user;
        
        Console.Write("Enter the user: ");
        user = Convert.ToInt32( Console.ReadLine());
        Console.Write("Enter the password: ");
        pass = Convert.ToInt32( Console.ReadLine());
        
        while((pass != 1234) || (user != 1))
        {
            Console.WriteLine("ERROR - Incorrect data");
            Console.Write("Enter the user again: ");
            user = Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter the password again: ");
            pass = Convert.ToInt32( Console.ReadLine());
            }
        
        Console.WriteLine("Access granted");
    }
}
