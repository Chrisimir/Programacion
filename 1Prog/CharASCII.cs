// Chris Lund Schober
using System;
public class ConvertToAscii
{
    public static void Main()
    {
        char userChar;
        Console.Write("Enter your char: ");
        userChar = Convert.ToChar( Console.ReadLine() );
        
        Console.WriteLine( Convert.ToInt32(userChar) );
        
        for( int i = 32; i <= 127; i++)
        {
            Console.Write( Convert.ToChar(i) );
        }
    }
}
