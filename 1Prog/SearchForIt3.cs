// Chris Lund Schober
using System;
public class SearchForIt
{
    public static void Main()
    {
        sbyte forCount, whileCount;
        
        
        for( forCount = -30; forCount < -9; forCount++)
        {
            if( forCount % 3 == 0 && forCount % 7 != 0 )
                Console.Write("{0} ", forCount);
        }
        Console.WriteLine();
        
        for( forCount = -30; forCount < -9; forCount += 3)
        {
            if( forCount % 7 != 0 )
                Console.Write("{0} ", forCount);
        }
        Console.WriteLine();
        
        whileCount = -30;
        while(whileCount < -9)
        {
            if( whileCount % 3 == 0 && whileCount % 7 != 0 )
                Console.Write("{0} ", whileCount);
            whileCount++;
        }
        Console.WriteLine();

        
        whileCount = -30;
        do
        {
            if( whileCount % 3 == 0 && whileCount % 7 != 0 )
                Console.Write("{0} ", whileCount);
            whileCount++;
        }while(whileCount < -9);
    }
}
