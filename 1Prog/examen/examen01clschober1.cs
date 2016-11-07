//Chris Lund Schober
public class examen01clschober1
{
    public static void Main()
    {
        int PrimNum, SegNum;
        int suma, resta, multi;
        
        System.Console.Write("Introduce un número: ");
        PrimNum = System.Convert.ToInt32( System.Console.ReadLine() );
        
        System.Console.Write("Introduce otro número: ");
        SegNum = System.Convert.ToInt32( System.Console.ReadLine() );
        
        suma = PrimNum + SegNum;
        resta = PrimNum - SegNum;
        multi = PrimNum * SegNum;
        
        System.Console.Write("Su suma es ");
        System.Console.WriteLine(suma);
        System.Console.Write("Su resta es ");
        System.Console.WriteLine(resta);
        System.Console.Write("Su multiplicación es ");
        System.Console.WriteLine(multi);
    }
}
