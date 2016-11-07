// Chris Lund Schober
using System;
public class Floaters
{
    public static void Main()
    {
        double num1;
        double num2;
        
        Console.Write("Mete un num: ");
        num1 = Convert.ToDouble( Console.ReadLine() );
        
        Console.Write("Mete un num: ");
        num2 = Convert.ToDouble( Console.ReadLine() );
        
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1/num2);
    }
}
