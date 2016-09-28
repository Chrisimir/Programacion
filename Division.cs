// Chris Lund Schober


public class Division

{
	public static void Main()

	{
	    int a, b;
	    int division, reminder;
	    
	    System.Console.WriteLine("Insert a");
	    a = System.Convert.ToInt32(System.Console.ReadLine());
	    
	    System.Console.WriteLine("Insert b");
	    b = System.Convert.ToInt32(System.Console.ReadLine());
        
        while(b==0)
        {
        System.Console.WriteLine("You cant divide by 0 silly");
        System.Console.WriteLine("Insert b again");
	    b = System.Convert.ToInt32(System.Console.ReadLine());
        }
	    division = a / b;
	    reminder = a % b;
	    
	    System.Console.Write("{0} / {1} = {2}; {0} % {1} = {3} ",
            a, b, division, reminder);
	    
	    
	}
}
