// Chris Lund Schober
using System;
public class ReverseName
{
    public static void Main()
    {
        string userName;
        
        Console.Write("Enter your name and I'll mess it up: ");
        userName = Console.ReadLine();
        
        for (int i = userName.Length - 1; i >= 0 ; i--)
        {
            Console.Write(userName[i]);
        }
    }
}
