// Chris Lund Schober
using System;
public class CharTriangle
{
    public static void Main()
    {
        int userNum;
        char userChar;
        
        Console.Write("Enter size: ");
        userNum = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter char: ");
        userChar = Convert.ToChar( Console.ReadLine() );
        
        if( userNum == 2)
            {
            Console.Write(" ");
            Console.WriteLine(userChar);
            Console.Write(userChar);
            Console.Write(" ");
            Console.WriteLine(userChar);
            }
        else
        {
            for( int i = 0, z = 0; i <= userNum; i = i + 2, z++ )
            {
                for( int u = userNum/2 - z; u > 0; u-- )
                    Console.Write(" ");
                for( int e = 0; e <= i; e++ )
                    Console.Write(userChar);
                Console.WriteLine();
            }
        }
    }
}
