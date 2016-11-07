// Chris Lund Schober
using System;
public class CompoundInterest
{
    public static void Main()
    {
        double money, interest, years;
        double save;
        double res;
        
        Console.Write("Enter the money in the bank: ");
        money = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Enter the interest: ");
        interest = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Enter the years: ");
        years = Convert.ToDouble( Console.ReadLine() );
        
        save = 1 + interest;
        
        for(int i = 1; i < years; i++)
        {
            save = save * save;
        }
        
        res = save * money;
        
        Console.WriteLine(res);
    }
}
