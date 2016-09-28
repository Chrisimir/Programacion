// Chris Lund Schober
using System;
public class CountInPairs
{
    public static void Main()
    {
        int count = 2;
        int num;
        
        Console.Write("Enter the number: ");
        num = Convert.ToInt32( Console.ReadLine() );
        
        while(count <= num)
        {
            count = count + 1;
            
            if((count % 2 == 0) && (count <= num))
                Console.WriteLine("{0}", count);
            }
    }
}
