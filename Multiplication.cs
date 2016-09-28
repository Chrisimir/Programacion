//Chris Lund Schober

using System;
public class Multiplication
{
    public static void Main()
    {
        int UserNum;
        
        Console.WriteLine("Welcome to the multiplying machine!");
        Console.WriteLine(" ");
        
        Console.WriteLine("Enter the number of wich you want the chart");
        
        UserNum = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine("{0} x 1 = {1}", UserNum, 1 * UserNum);
        Console.WriteLine("{0} x 2 = {1}", UserNum, 2 * UserNum);
        Console.WriteLine("{0} x 3 = {1}", UserNum, 3 * UserNum);
        Console.WriteLine("{0} x 4 = {1}", UserNum, 4 * UserNum);
        Console.WriteLine("{0} x 5 = {1}", UserNum, 5 * UserNum);
        Console.WriteLine("{0} x 6 = {1}", UserNum, 6 * UserNum);
        Console.WriteLine("{0} x 7 = {1}", UserNum, 7 * UserNum);
        Console.WriteLine("{0} x 8 = {1}", UserNum, 8 * UserNum);
        Console.WriteLine("{0} x 9 = {1}", UserNum, 9 * UserNum);
        Console.WriteLine("{0} x 10 = {1}", UserNum, 10 * UserNum);
    }
}
