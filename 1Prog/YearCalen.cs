// Chris Lund Schober
using System;
public class Calendar
{
    public static void Main()
    {
        int year;
        string startDay;
        int dayNum = 7;
        
        
        Console.Write("In what year are we? ");
        year = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("What day does the year start? ");
        Console.Write("Mon/Tue/Wed/Thu/Fri/Sat/Sun: ");
        startDay = Console.ReadLine().ToLower();
        
        do
        {
            switch (startDay)
            {
                    case "mon":
                    case "monday":
                    case "m0n": 
                        dayNum = 0; break;
                    case "tue":
                    case "tuesday": 
                        dayNum = 1; break;
                    case "wed":
                    case "wednesday": 
                        dayNum = 2; break;
                    case "thu":
                    case "thursday": 
                        dayNum = 3; break;
                    case "fri":
                    case "friday": 
                        dayNum = 4; break;
                    case "sat":
                    case "saturday": 
                        dayNum = 5; break;
                    case "sun":
                    case "sunday": 
                        dayNum = 6; break;
                    default: Console.WriteLine("I cant understad the day");
                        Console.Write("Mon/Tue/Wed/Thu/Fri/Sat/Sun: ");
                        break;
            }
        }while(dayNum == 7);
        
        for( int spaces = 0; spaces < dayNum; spaces++)
            Console.Write("   ");
        for( int i = 1; i <= daysInMonth; i++)
        {
            if( i < 10 )
                Console.Write(" ");
            Console.Write(i);
            Console.Write(" ");
            
            if( (i + dayNum) % 7 == 0 )
                Console.WriteLine();
        }
    }
}
