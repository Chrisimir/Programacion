// Chris Lund Schober
using System;
public class InverseTriangle
{
    public static void Main()
    {
        int num;
        int space = 0;
        
        Console.Write("Enter the decisive number: ");
        num = Convert.ToInt32( Console.ReadLine() );
        
        while(num >= 0)
        {
            for(int u = 0; u < space; u++)
                Console.Write(" ");
            for(int i = num; i > 0; i--)
                Console.Write("#");
            Console.WriteLine();
            num--;
            space++;
        }
        
    }
}
