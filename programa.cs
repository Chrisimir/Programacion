// Chris Lund Schober

using System;
public class programa

{
	public static void Main()
	{
		int x;
		int y;
		
		Console.WriteLine("Introduce el dato:");
		x = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce el dato 2:");
		y = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Lo uno más lo otro da {0} + {1} = {2}", x, y, x+y);
		}
	}
