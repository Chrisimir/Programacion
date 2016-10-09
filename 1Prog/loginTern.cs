// Chris Lund Schober
using System;
public class login
{
    public static void Main()
    {
        int pass, user;
        int tries = 0;
        
        do
        {
            Console.Write("Enter the user: ");
            user = Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter the password: ");
            pass = Convert.ToInt32( Console.ReadLine());
            if(pass == 1234 && user == 5678)
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
