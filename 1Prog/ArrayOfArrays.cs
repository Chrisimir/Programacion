// Chris Lund Schober
using System;
public class ArrayOfArrays
{
    public static void Main()
    {
        int[][] data = new int[3][];
        
        data[0] = new int[] { 1, 2, 3 };
        data[1] = new int[] { 1, 2, 3, 4, 5};
        data[2] = new int [] { 1, 2, 3, 4};
        
        for (byte row1 = 0; row1 < 3; row1++)
        {
            Console.Write(data[0][row1]+" ");
        }
        for (byte row2 = 0; row2 < 5; row2++)
        {
            Console.Write(data[1][row2]+" ");
        }
        for (byte row3 = 0; row3 < 4; row3++)
        {
            Console.Write(data[2][row3]+" ");
        }
        
        Console.WriteLine();
        
        for (byte col = 0; col < 3; col++)
        {
            for (byte row = 0; row < data[col].Length; row++)
            {
                Console.Write(data[col][row]+" ");
            }
            
        }
        
        
        
    }
}
