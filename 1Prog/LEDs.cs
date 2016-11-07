using System;
public class LEDs
{
    public static void Main()
    {
        ulong secPast;
        byte[] time = new byte[6];
        ulong sumOfLeds = 36;
        byte[] ledCuant = new byte[6];
       // Not sure if needed byte[,] endClockTime = new byte[3,2]
       
       Console.Write("Enter the number of seconds past: ");
       secPast = Convert.ToUInt64( Console.ReadLine() );
        
        // Calculates the time at the moment the seconds has past
        for( ulong secCount = 0; secCount < secPast; secCount++)
        {
            if( time[5] < 9 )
            {
                time[5]++;
            }
            else if( time[4] < 5 )
            {
                time[4]++;
                time[5] = 0;
            }
            else if( time[3] < 9 )
            {
                time[3]++;
                time[4] = 0;
            }
            else if( time[2] < 5 )
            {
                time[2]++;
                time[3] = 0;
            }
            else if( time[1] < 9 )
            {
                time[1]++;
                time[2] = 0;
            }
            else if( time[0] < 2)
            {
                time[0]++;
                time[1] = 0;
            }
            
            // Convert the time to the LED values
            for( byte i = 0; i < 6; i++ )
            {
                switch( time[i] )
                {
                    case 0: ledCuant[i] = 6; break;
                    case 1: ledCuant[i] = 2; break;
                    case 2: ledCuant[i] = 5; break;
                    case 3: ledCuant[i] = 5; break;
                    case 4: ledCuant[i] = 4; break;
                    case 5: ledCuant[i] = 5; break;
                    case 6: ledCuant[i] = 6; break;
                    case 7: ledCuant[i] = 3; break;
                    case 8: ledCuant[i] = 7; break;
                    case 9: ledCuant[i] = 6; break;
                }
            }
            
            // Sums the LED values on the clock
            for( byte digitPoss = 0; digitPoss < 6; digitPoss++ )
            {
                sumOfLeds = ledCuant[digitPoss] + sumOfLeds;
            }
        }
        
        
        Console.WriteLine("The amount of LEDs that have been turned on in" +
            "the span of {0} seconds is {1}", secPast, sumOfLeds);
        
    }
}
