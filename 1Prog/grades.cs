// Chris Lund Schober
using System;
public class Grades
{
    public static void Main()
    {
        int grade;
        
        Console.Write("Introduce la nota: ");
        grade = Convert.ToInt32( Console.ReadLine() );
        
        switch(grade)
        {
            case 10: Console.WriteLine("Sobresaliente"); break;
            case 9: Console.WriteLine("Sobresaliente"); break;
            case 8: Console.WriteLine("notable"); break;
            case 7: Console.WriteLine("notable"); break;
            case 6: Console.WriteLine("bien"); break;
            case 5: Console.WriteLine("aprobado"); break;
            case 4: Console.WriteLine("suspenso"); break;
            case 3: Console.WriteLine("suspenso"); break;
            case 2: Console.WriteLine("suspenso"); break;
            case 1: Console.WriteLine("suspenso"); break;
            case 0: Console.WriteLine("suspenso"); break;
            default: Console.WriteLine("Eso no es una nota"); break;
        }
    }
}
