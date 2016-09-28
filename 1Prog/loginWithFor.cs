// Chris Lund Schober
using System;
public class login
{
    public static void Main()
    {
        int pass, user;
        int fail = 0;
        
        Console.Write("Enter the user: ");
        user = Convert.ToInt32( Console.ReadLine());
        Console.Write("Enter the password: ");
        pass = Convert.ToInt32( Console.ReadLine());
        
        for(int tries = 0; (pass != 1234) || (user != 1) || (tries != 3); tries++)
        {
            Console.WriteLine("ERROR - Incorrect data");
            Console.Write("Enter the user again: ");
            user = Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter the password again: ");
            pass = Convert.ToInt32( Console.ReadLine());
            if(tries == 2)
            {
                Console.WriteLine("You have tried to many times");
                fail = 1;
        }   }
        
        if(fail >0)
            Console.WriteLine("Acces denied");
        else
            Console.WriteLine("Access granted");
    }
}
