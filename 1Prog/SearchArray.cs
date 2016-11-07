// Chris Lund Schober
using System;
public class SearchArray
{
    public static void Main()
    {
        int[] data = new int[10];
        int userSearch;
        bool isInArray;
        
        for(int i = 9; i >= 0; i--)
        {
            Console.Write("Enter data for array: ");
            data[i] = Convert.ToInt32( Console.ReadLine() );
        }
        
        do
        {
            isInArray = false;
            Console.Write("Search number: ");
            userSearch = Convert.ToInt32( Console.ReadLine() );
            
            for(int i = 9; i >= 0 && isInArray == false; i--)
            {
                isInArray = userSearch == data[i];
                if (isInArray)
                    Console.WriteLine("The data is in the array");
            }
            
            if(!isInArray)
                Console.WriteLine("The data isn't in the array");
            
        }while(userSearch != 0);
        
        Console.WriteLine("Bye");
    }
}
