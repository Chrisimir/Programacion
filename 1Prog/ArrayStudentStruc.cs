// Chris Lund Schober
using System;
public class StudentsStructs
{
    struct student
        {
            public string name;
            public byte age;
            public char group;
            public float averageMark;
        }
        
    public static void Main()
    {
        student[] s = new student[3];
        
        for (int i = 0; i < )
        Console.Write("Enter name");
        s[i].name = Console.ReadLine();
        Console.Write("Enter age");
        s[i].age = Convert.ToByte( Console.ReadLine() );
        Console.Write("Enter group");
        s[i].group = Convert.ToChar( Console.ReadLine() );
        Console.Write("Enter average mark");
        s[i].averageMark = Convert.ToSingle( Console.ReadLine() );
    }
}
