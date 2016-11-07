// Chris Lund Schober
using System;
public class Module
{
    public static void Main()
    {
        int numVectors = 3;
        int[] vectors = new int[numVectors];
        int[] squareOfVectors = new int[numVectors];
        int sumOfSqVectors = 0;
        double squareRootOfSum;
        
        for (int numInp = 0; numInp < numVectors; numInp++)
        {
            Console.Write("Enter the {0}# vector: ", numInp + 1 );
            vectors[numInp] = Convert.ToInt32( Console.ReadLine() );
        }
        
        for (int Sqr = 0; Sqr < numVectors; Sqr++)
        {
            squareOfVectors[Sqr] = vectors[Sqr] * vectors[Sqr];
        }
        
        for (int sum = 0; sum < numVectors; sum++)
        {
            sumOfSqVectors = squareOfVectors[sum] + sumOfSqVectors;
        }
        
        squareRootOfSum = Math.Sqrt(sumOfSqVectors);
        
        Console.WriteLine("The module of your vector is: " + 
            squareRootOfSum);
    }
}
