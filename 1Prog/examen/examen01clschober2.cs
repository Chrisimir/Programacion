/*Chris Lund Schober
20-sept-2016*/

using System;
public class examen01clschober2
{
    public static void Main()
    {
        int longitudBase, longitudAltura, superficie;
        
        Console.Write("Introduce la base: ");
        longitudBase = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Introduce la altura: ");
        longitudAltura = Convert.ToInt32( Console.ReadLine() );
        
        superficie = longitudBase * longitudAltura / 2;
        
        Console.WriteLine
            ("La superficie de un triángulo de base {0} y altura {1} es {2}",
            longitudBase, longitudAltura, superficie );
        
        
        superficie = longitudBase  * longitudAltura / 2;
        
        Console.WriteLine
            ("Con más precisón será {0}",
             superficie + longitudBase * longitudAltura % 2 / 2);
        
    }
}
