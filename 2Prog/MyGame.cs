//Chris Lund Schober
using System;
public class MyGame
{
    public static void Main()
    {
        // Rectángulo
        Console.SetCursorPosition(30, 10);
        Console.Write("--------------------");
        Console.SetCursorPosition(30, 14);
        Console.Write("--------------------");
        
        Console.SetCursorPosition(30, 11);
        Console.Write("|");
        Console.SetCursorPosition(30, 12);
        Console.Write("|");
        Console.SetCursorPosition(30, 13);
        Console.Write("|");
        
        Console.SetCursorPosition(49, 11);
        Console.Write("|");
        Console.SetCursorPosition(49, 12);
        Console.Write("|");
        Console.SetCursorPosition(49, 13);
        Console.Write("|");
        
        // La C
        Console.SetCursorPosition(40, 12);
        Console.Write("C");
        
        // Los puntos 
            //variables
        int randomx;
        int randomy;
        
            // 1
        randomx = DateTime.Now.Millisecond % 80;
        randomy = DateTime.Now.Millisecond % 24;
        Console.SetCursorPosition(randomx, randomy);
        Console.Write("x");
        
            // 2
        randomx = 2* DateTime.Now.Millisecond % 80;
        randomy = 3* DateTime.Now.Millisecond % 24;
        Console.SetCursorPosition(randomx, randomy);
        Console.Write(":)");
        
            // Dentro del cuadro
        randomx = DateTime.Now.Millisecond % 18 +31;
        randomy = DateTime.Now.Millisecond % 3 +11;
        Console.SetCursorPosition(randomx, randomy);
        Console.Write("0");
        
        // Mensaje de consola
        Console.SetCursorPosition(79, 23);
    }
}
