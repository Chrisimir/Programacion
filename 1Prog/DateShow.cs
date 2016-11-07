// Chris Lund Schober
using System;
public class DateShow
{
    public static void Main()
    {
        int userDay, userMonth, userYear;
        
        Console.Write("Enter day: ");
        userDay = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter month number: ");
        userMonth = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter year: ");
        userYear = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine("{0}/{1}/{2}", userDay.ToString("00"),
            userMonth.ToString("00"), userYear.ToString("0000"));
            
    }
}
