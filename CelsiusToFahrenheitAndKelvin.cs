//Chris Lund Schober
using System;
public class CelciusToFahrenheitAndKelvin
{
    public static void Main()
    {
		int celsius;
		int fahrenheit, kelvin;
		
		Console.WriteLine("How many Celsius degrees?");
		celsius = Convert.ToInt32( Console.ReadLine() );
		
		fahrenheit = celsius * 18 / 10 + 32;
		Console.WriteLine("{0} ºC are {1} ºF ", celsius, fahrenheit);
		
		kelvin = celsius + 273;
		Console.WriteLine("{0} ºC are {1} K ", celsius, kelvin);
    }
}
