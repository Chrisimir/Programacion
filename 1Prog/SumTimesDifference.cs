// Chris Lund Schober

using System;
public class SumTimesDifference

{
	public static void Main()

	{
	    int a, b;
	    
	    Console.WriteLine("Insert a");
	    a = Convert.ToInt32(Console.ReadLine());
	    
	    Console.WriteLine("Insert b");
	    b = Convert.ToInt32(Console.ReadLine());
	    
	    
	    Console.Write("The result of (a+b)*(a-b) is: ");
	    Console.WriteLine((a+b)*(a-b));
	    
	    Console.Write("The result of a² - b² is: ");
	    Console.WriteLine(a*a - b*b);
	}
}
