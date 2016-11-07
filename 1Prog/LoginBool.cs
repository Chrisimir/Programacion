// Chris Lund Schober
using System;
public class login
{
    public static void Main()
    {
        string pass, user;
        string allowedPass = "password", allowedUser = "user";
        bool isCorrectName = false, correctPassword = false;
        
        
        do
        {
            Console.Write("Enter the user: ");
            user = Convert.ToString( Console.ReadLine());
            Console.Write("Enter the password: ");
            pass = Convert.ToString( Console.ReadLine());
            
            isCorrectName = allowedUser == user;
            correctPassword = allowedPass == pass;
            
        }while( !isCorrectName || !correctPassword );
        
        Console.WriteLine("Acces granted!");
    }
}
