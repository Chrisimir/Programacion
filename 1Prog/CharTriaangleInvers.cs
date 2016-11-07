// Chris Lund Schober
using System;
public class CharTriangleInvers
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
            Console.Write(userChar);
            Console.Write(" ");
            Console.WriteLine(userChar);
            Console.Write(" ");
            Console.WriteLine(userChar);
            }
        else
        {
            for( int i = userNum, z = 0; i >= 0; i = i - 2, z++ )
            {
                for( int u = z; u > 0; u-- )
                    Console.Write(" ");
                for( int e = 0; e <= i; e++ )
                    Console.Write(userChar);
                Console.WriteLine();
            }
        }
    }
}
