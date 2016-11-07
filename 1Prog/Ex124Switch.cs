// Chris Lund Schober
using System;
public class Ex124Switch
{
    public static void Main()
    {
        char userInp;
        
        Console.Write("Enter symbol: ");
        userInp = Convert.ToChar( Console.ReadLine() );
        
        switch(userInp)
        {
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9': Console.WriteLine("The symbol is a digit"); break;
            case 'a':
            case 'b':
            case 'c':
            case 'd':
            case 'e':
            case 'f':
            case 'g':
            case 'h':
            case 'i':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'o':
            case 'p':
            case 'q':
            case 'r':
            case 's':
            case 't':
            case 'u':
            case 'v':
            case 'w':
            case 'x':
            case 'y':
            case 'z': Console.WriteLine("The symbol is a letter"); break;
            case '\"': Console.WriteLine("The symbol is a double quote"); break;
            default: Console.WriteLine("It's none of the listed symbols"); break;
        }
        
        if( userInp < '9' && userInp >= '0' )
            Console.WriteLine("The symbol is a digit");
        else if( userInp == '\"' )
            Console.WriteLine("The symbols is a double quote");
        else if( userInp < 'z' && userInp > 'a')
            Console.WriteLine("The symbol is a letter");
        else
            Console.WriteLine("It's none of the listed symbols");
    }
}
