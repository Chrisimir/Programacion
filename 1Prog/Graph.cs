// Chris Lund Schober
using System;
public class Graph
{
    public static void Main()
    {   
        double y;
        for(int x = 0; x <= 30; x++)
        {
            y = Math.Sqrt( x * 10);
            
            if(y < 11)
            {
                Console.SetCursorPosition(x, Convert.ToInt32(y) + 12);
                Console.Write("*");
            }
        }
    }
}
