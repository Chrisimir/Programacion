// Chris Lund Schober
using System;
public class MaxGradeStudents
{
    public static void Main()
    {
        string[] student = new string[5];
        double[] mark = new double[5];
        double greatestMark;
        int arrayPos;
         
        student[0] = "Sergio";
        student[1] = "Fernando";
        student[2] = "Antonio";
        student[3] = "Irene";
        student[4] = "Samuel";
        
        mark[0] = 8.2;
        mark[1] = 8.1;
        mark[2] = 7.9;
        mark[3] = 8.0;
        mark[4] = 8.0;
        
        // Values preasigned to simplify the for, and to get array poss
        greatestMark = mark[0];
        arrayPos = 0;
        
        for (int i = 1; i < 4; i++)
        {
            greatestMark = mark[i] > greatestMark ? mark[i] : greatestMark;
            
            if( greatestMark == mark[i] )
            {
                arrayPos = i;
            }
        }
        
        Console.WriteLine("The stundent with the highest grade is " + 
            student[arrayPos] + " with a mark on: {0}", greatestMark );
        
    }
}
