// Chris Lund Schober
using System;
public class StringLadder
{
    public static void Main()
    {
        byte p1 = 1, p2 = 2;
        byte nowPlayer = 1;
        
        
        do
        {
            Console.WriteLine("Now playing: {0}", nowPlayer);
            Console.Write("Enter column: ");
            userCol = byte.Parse(Console.ReadKey().KeyChar.ToString());
            userCol--;
            
            if( !( (userCol < 8) && (userCol >= 0) )
                {
                    Console.WriteLine();
                    Console.WriteLine("Have in mind the board is 7x6!");
                    System.Threading.Thread.Sleep(2000);
                }
                else if( array[chosen, 5])
                {
                    Console.WriteLine();
                    Console.WriteLine("That column is already taken!");
                    System.Threading.Thread.Sleep(2000);
                }
            
        }while(!( (userCol < 7) && (userCol >= 0) ) 
                && array[chosen, 5] != 0)
    }
    
}
