// Chris Lund Schober
using System;
public class Calendar
{
    public static void Main()
    {
        int monthDays;
        int daysOfWeekBefore1;
        
        Console.Write("How long is the moth? ");
        monthDays = Convert.ToInt32( Console.ReadLine() );
        Console.Write("How many days of the week has passed for the 1st? ");
        daysOfWeekBefore1 = Convert.ToInt32( Console.ReadLine() );
        
        for( int spaces = 0; spaces < daysOfWeekBefore1; spaces++)
            Console.Write("   ");
        for( int i = 1; i <= monthDays; i++)
        {
            if( i < 10 )
                Console.Write(" ");
            Console.Write(i);
            Console.Write(" ");
            
            if( (i + daysOfWeekBefore1) % 7 == 0 )
                Console.WriteLine();
        }
    }
}
