// Chris Lund Schober
using System;
public class login
{
    public static void Main()
    {
        int pass;
        
        do
        {
            Console.Write("Enter the password again: ");
            pass = Convert.ToInt32( Console.ReadLine());
            if(pass == 1234)
                break;
            }
        while(5 > 1);
        
        Console.WriteLine("Access granted");
    }
}
