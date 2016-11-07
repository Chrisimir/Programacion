// Chris Lund Schober 
using System;
public class TypeOfChar
{
    public static void Main()
    {
        char userChar;
        
        Console.Write("Enter char: ");
        userChar = Convert.ToChar( Console.ReadLine() );
        
        switch(userChar)
        {
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
            case '0': Console.Write("Its a digit"); break;
            case ',':
            case '.':
            case ';':
            case ':':Console.Write("Its a punctuation mark"); break;
            default: Console.WriteLine("Other symbol"); break;
        }
            
    }
}
