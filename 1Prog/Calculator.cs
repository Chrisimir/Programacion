// Chris Lund Schober
using System;
public class Calculator
{
    public static void Main()
    {
        double num1, num2;
        char oper;
        
        Console.Write("N1? ");
        num1 = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Operation? ");
        oper = Convert.ToChar( Console.ReadLine() );
        Console.Write("N2? ");
        num2 = Convert.ToDouble( Console.ReadLine() );
        

        switch(oper)
        {
            case '+': Console.WriteLine("Result = {0}", num1 + num2); break;
            case '-': Console.WriteLine("Result = {0}", num1 - num2); break;
            case 'x':
            case 'X':
            case '*':
            case '·': Console.WriteLine("Result = {0}", num1 * num2); break;
            case '/': Console.WriteLine("Result = {0}", num1 / num2); break;
            default: Console.WriteLine("I can't understand your operator"); break;
        }

        
    }
}
