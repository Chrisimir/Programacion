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
        student s1;
        
        s1.name = "John";
        s1.age = 18;
        s1.group = 'b';
        s1.averageMark = 9.2f;
    }
}
