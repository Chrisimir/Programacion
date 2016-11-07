// Chris Lund Schober
using System;
public class SpacesInName
{
    public static void Main()
    {
        string userName;
        
        Console.Write("Enter your name and I'll mess it up: ");
        userName = Console.ReadLine();
        
        for (int i = 0; i < userName.Length; i++)
        {
            Console.Write(userName[i]+" ");
        }
    }
}
        
