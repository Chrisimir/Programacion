// Chris Lund Schober
using System;
public class SpeedUnits
{
    public static void Main()
    {
        double miles, seconds;
        
        Console.Write("Enter the miles it has moved: ");
        miles = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Enter the duration of the movement in seconds: ");
        seconds = Convert.ToDouble( Console.ReadLine() );
        
        Console.Write("{0} m/s, {1} km/h, {2} mi/h", (miles / seconds) * 1609.34,
            (miles / seconds) * 1.60934 / 3600, (miles / seconds) / 3600);
    }
}
