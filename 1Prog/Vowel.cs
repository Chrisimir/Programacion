// Chris Lund Schober
using System;
public class Vowel
{
    public static void Main()
    {
        char userInpt;
        
        Console.Write("Enter your symbol: ");
        userInpt = Convert.ToChar( Console.ReadLine() );
        
        
        if( userInpt >= '0' && userInpt <= '9' )
        {
            Console.WriteLine("The symbol is a number");
        }
        else if( userInpt == 'a' || userInpt == 'e' || userInpt == 'i'
                || userInpt == 'o' || userInpt == 'u')
        {
            Console.WriteLine("The symbol is a vowel");
        }
        else
        {
            Console.WriteLine("The symbol isn't listed");
        }
    }
}
