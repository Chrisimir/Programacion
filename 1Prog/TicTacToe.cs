using System;
public class TicTacToe
{
    public static void Main()
    {
        byte[,] board = new byte[3, 3];

        bool hasWon = false;
        byte p1 = 1, p2 = 2;
        byte userRow, userCol;
        byte nowPlayer = 1;
        byte move = 0;
        Console.Write("Enter player 1 name: ");
        string p1Name = Console.ReadLine();
        Console.Write("Enter player 2 name: ");
        string p2Name = Console.ReadLine();
        do
        {
            do
            {
                Console.Clear();
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        Console.Write(" {0} ", board[row, col]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Now playing: {0}", nowPlayer==1?p1Name:p2Name);
                Console.Write("Enter row: ");
                userRow = byte.Parse(Console.ReadKey().KeyChar.ToString());
                Console.Write(" column: ");
                userCol = byte.Parse(Console.ReadKey().KeyChar.ToString());
                userRow--;
                userCol--;
                
                if( board[userRow, userCol] != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("That possition is already taken!");
                    System.Threading.Thread.Sleep(2000);
                }

            } while (  !( (userRow < 3) && (userRow >= 0) 
                       && (userCol < 3) && (userCol >= 0) 
                       && (board[userRow, userCol] == 0) ) ) ;
            
            move++;
                
            if (nowPlayer == 1)
            {
                board[userRow, userCol] = p1;
                nowPlayer++;
            }
            else
            {
                board[userRow, userCol] = p2;
                nowPlayer--;
            }

            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == board[row, 1] 
                    && board[row, 1] == board[row, 2] 
                    && board[row, 2] != 0)
                {
                    hasWon = true;
                }
            }
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == board[1, col] 
                    && board[1,col] == board[2, col] 
                    && board[2, col] != 0)
                {
                    hasWon = true;
                }
            }
            if ( (board[0, 0] == board[1, 1] && board[1,1] == board[2,2] && board[2,2] != 0 )
                || (board[0, 2] == board[1, 1] && board[1,1] == board[2,0] && board[2,0] != 0))
            {
                hasWon = true;
            }
            
        } while (!hasWon && move < 9);
        
        Console.Clear();
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(" {0} ", board[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        if ( hasWon )
        {
            Console.WriteLine();
            byte winner = (byte)(nowPlayer == p2 ? p1 : p2);
            Console.Write( (winner == p1 ? p1Name : p2Name).ToUpper() 
                + "(" + winner  + ")" + " WINS " );
        }
        else
        {
            Console.WriteLine("TIE :(");
        }
    }

}
