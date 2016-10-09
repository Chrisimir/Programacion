// Chris Lund Schober
using System;
public class while
{
    public static void Main()
    {
        int counter = 0;
        
        while(counter<10)
        {
            counter++;
            if( counter == 5 )
                continue;
            Console.Write("{0} ", counter);
        }
        
    }
}
