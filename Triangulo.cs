// Chris Lund Schober

using System;
public class Triangle

{
	public static void Main()

	{
	    int x;
	    int y;
	    
	    Console.WriteLine("Insert the height");
	    x = Convert.ToInt32(Console.ReadLine());
	    Console.WriteLine("Insert the width");
	    y = Convert.ToInt32(Console.ReadLine());
	    
	    Console.Write("The area is: ");
	    Console.WriteLine(x*y);
	    
	    Console.Write("The perimeter is: ");
	    Console.WriteLine(x+y);
	}
}
