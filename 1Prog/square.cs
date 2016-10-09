// Chris Lund Schober
using System;
public class square
{
    public static void Main()
    {
        int x;
        
        Console.Write("Enter size: ");
        x = Convert.ToInt32( Console.ReadLine() );
        
        for(int size = 0; size < x; size++)
        {
            for(int size1 = 0; size1 < x; size1++)
                Console.Write("*");
                
            Console.WriteLine();
        }
    }
}
