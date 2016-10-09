// Chris Lund Schober
using System;
public class Sign
{
    public static void Main()
    {
        int userNum;
        int sign;
        
        Console.Write("Enter number: ");
        userNum = Convert.ToInt32( Console.ReadLine() );
        
        sign = userNum > 0 ? 1 : (userNum == 0 ? 0 : -1);
        
        Console.WriteLine(sign);
        
        
        
    }
}
