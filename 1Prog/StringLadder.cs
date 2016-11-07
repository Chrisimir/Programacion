// Chris Lund Schober
using System;
public class StringLadder
{
    public static void Main()
    {
        string name;
        
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        
        for (int i = 1; i <= name.Length; i++)
        {
            Console.WriteLine( name.Substring(0,i) );
        }
    }
}
        
