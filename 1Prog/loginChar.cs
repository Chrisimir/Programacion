// Chris Lund Schober
using System;
public class LoginChar
{
    public static void Main()
    {
        string user, pass;
        int tries = 0;
        
        do
        {
            Console.Write("Enter the user: ");
            user = Console.ReadLine();
            Console.Write("Enter the password: ");
            pass = Console.ReadLine();
            if(pass == "password" && user == "john")
            {
              Console.WriteLine("Access granted!");
              tries = 3; 
            }
            else
            {
                Console.WriteLine("Error in credentials, try again");
                tries++;
            }
        }
        while(tries < 3);
    }
}
