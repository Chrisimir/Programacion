/* Chris Lund Schober
 * IES San Vicente
 */
 using System;
 public class Parking
 {
    public static void Main()
    {
        string userInp;
        int enterTime, exitTime;
        int enterTimeHours, enterTimeMins, exitTimeHours, exitTimeMins;
        int toChargeHour, toChargeMinute;
        float hourCharge, minuteCharge;
        
        
        Console.WriteLine("Enter \"end\" to exit program");
        Console.Write("Enter time of entrance as 4 numbers: ");
        userInp = Console.ReadLine();
        
        while(userInp != "end")
        {
            // Separate enter time in hours and minutes
            enterTime = Convert.ToInt32( userInp );
            enterTimeHours = Convert.ToInt32( enterTime / 100 );
            enterTimeMins = Convert.ToInt32( enterTime - (enterTimeHours * 100) );
            
            Console.Write("Enter time of exit as a 4 numbers: ");
            exitTime = Convert.ToInt32( Console.ReadLine() );

            // Separate exit time in hours and minutes
            exitTimeHours = Convert.ToInt32( exitTime / 100 );
            exitTimeMins = Convert.ToInt32( exitTime - (exitTimeHours * 100) );
            
            // Calculates time spent in the parking
            toChargeHour = Convert.ToInt32( exitTimeHours - enterTimeHours );
            toChargeMinute = Convert.ToInt32( exitTimeMins - enterTimeMins );
            
            // Calculates price for full hour version
            hourCharge = Convert.ToSingle( toChargeHour * 2.2 );
            if( toChargeMinute > 0 )
                hourCharge++;
            
            // Calculates price for minute version
            minuteCharge = Convert.ToSingle( toChargeHour * 2.2 );
            minuteCharge += Convert.ToSingle( toChargeMinute * 2.2 / 60 );
            
            Console.WriteLine("Charging per hour: {0}€",
                hourCharge.ToString("00.00"));
            
            Console.WriteLine("Charging per minute: {0}€",
                minuteCharge.ToString("00.00"));
            
            Console.WriteLine();
            Console.WriteLine("Enter \"end\" to exit the program");
            Console.WriteLine("Enter time of entrance as 4 numbers: ");
            userInp = Console.ReadLine();
        }
        
        Console.Clear();
        Console.WriteLine("Bye!");
        Console.WriteLine("Have a good trip!");
    }
}
