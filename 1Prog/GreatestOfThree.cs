// Chris Lund Schober
using System;
public class GreatestOfThree
{
    public static void Main()
    {
        int userNum1, userNum2, userNum3;
        int greatNum;
        
        Console.Write("Enter first number: ");
        userNum1 = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter second number: ");
        userNum2 = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter third number: ");
        userNum3 = Convert.ToInt32( Console.ReadLine() );
        
        greatNum = userNum1 >= userNum2 ? userNum1 : userNum2;
        greatNum = greatNum > userNum3 ? greatNum : (greatNum = userNum3);
        
        Console.WriteLine("The greatest number is: {0}",greatNum);
        
        
        
    }
}
