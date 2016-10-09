// Chris Lund Schober
using System;
public class EmptySquare
{
    public static void Main()
    {
        int num;
        
        Console.Write("Enter the decisive number: ");
        num = Convert.ToInt32( Console.ReadLine() );
        
        for(int row = 0; row < num; row++)
        {
            for(int col = 0; col < num; col++)
            {
                if(row == 0 || row == num-1 || col == 0 || col == num-1)
                    Console.Write("x");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        
    }
}
