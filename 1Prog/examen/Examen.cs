//Chris Lund Schober
using System;
public class suerte
{
    public static void Main()
    {
        int Prim, Seg;
        
        Console.Write("Enter LUCKY number");
        Prim = Convert.ToInt32( Console.ReadLine() );
        
        Prim = Prim * 3 / 2 % 6 + 7 - 2 / 2 *9 % 2 - 3 +20;
        
        Console.WriteLine(Prim);
    }
}
