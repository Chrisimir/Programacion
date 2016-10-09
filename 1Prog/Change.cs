// Chris Lund Schober
using System;
public class Change
{
    public static void Main()
    {
        int amount, payed;
        int change;
        
        Console.Write("Amount? ");
        amount = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Payed? ");
        payed = Convert.ToInt32( Console.ReadLine() );
        
        change = payed - amount;
        
        while(change > 0)
        {
            int count = 0;
            while(change % 50 == 0 && change > 0 )
            {
                Console.Write("50 ");
                change = change - 50;
            }
            while(change % 20 == 0 && change > 0 && count == 0 )
            {
                Console.Write("20 ");
                change = change - 20;
                count = 1;
            }
            while(change % 10 == 0 && change > 0 && count == 0 )
            {
                Console.Write("10 ");
                change = change - 10;
                count = 1;
            }
            while(change % 5 == 0 && change > 0 && count == 0 )
            {
                Console.Write("5 ");
                change = change - 5;
                count = 1;
            }
            while(change % 2 == 0 && change > 0 && count == 0 )
            {
                Console.Write("2 ");
                change = change - 2;
                count = 1;
            }
            while(change % 1 == 0 && change > 0 && count == 0 )
            {
                Console.Write("1 ");
                change = change - 1;
                count = 1;
            }
        }
    }
}
