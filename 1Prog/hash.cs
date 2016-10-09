// Chris Lund Schober
using System;
public class hash
{
    public static void Main()
    {
        int num;
        
        Console.Write("Enter the decisive number: ");
        num = Convert.ToInt32( Console.ReadLine() );
        
        while(num >= 0)
        {
            for(int i = 0; i <= num; i++)
                Console.Write("#");
        Console.WriteLine();
        num--;
        }
        
    }
}
