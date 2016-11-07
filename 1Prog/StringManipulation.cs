// Chris Lund Schober
using System;
public class StringManipulation
{
    public static void Main()
    {
        string userString;
        
        Console.Write("Enter your string and I'll mess it up: ");
        userString = Console.ReadLine();
        
        string upperString = userString.ToUpper();
        Console.WriteLine(upperString);
        
        string lowerString = userString.ToLower();
        Console.WriteLine(lowerString);
        
        string removeString = userString.Remove(1,2);
        Console.WriteLine(removeString);
        
        string insertString = userString.Insert(2,"yo");
        Console.WriteLine(insertString);
        
        string replaceString = userString.Replace(" ","_");
        Console.WriteLine(replaceString);
        
        string trimStartString = userString.TrimStart();
        Console.WriteLine(trimStartString);
        
        string trimEndString = userString.TrimEnd();
        Console.WriteLine(trimEndString);
        
        string trimString = userString.Trim();
        Console.WriteLine(trimString);
        
        string replace2String = userString.Replace("a","A");
        Console.WriteLine(replace2String);
        
        string[] parts = userString.Split();
        for (int i = 0; i < parts.Length; i++)
        {
            Console.WriteLine( parts[i] );
        }
        
    }
}
