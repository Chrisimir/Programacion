// Chris Lund Schober
using System;
public class ConvertBinHex
{
    public static void Main()
    {
        int userNum;
        
        Console.Write("Enter the number: ");
            userNum = Convert.ToInt32( Console.ReadLine() );
        
        do
        {
            Console.Write("Hex: ");
            Console.WriteLine( Convert.ToString(userNum, 16) );
            Console.Write("Bin: ");
            Console.WriteLine( Convert.ToString(userNum, 2) );
            Console.Write("Enter the number: ");
            userNum = Convert.ToInt32( Console.ReadLine() );
        }while( userNum != -1);
    }
}
