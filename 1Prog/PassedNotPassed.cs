// Chris Lund Schober
using System;
public class PassedNotPassed
{
    public static void Main()
    {
        string textMark;
        double mark;
        
        Console.Write("Enter grade: ");
        mark = Convert.ToDouble( Console.ReadLine() );
        
        textMark = mark >= 60 ? "passed" : "not passed";
        
        Console.WriteLine(textMark);
        
    }
}
