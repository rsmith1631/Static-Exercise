using System.Runtime.CompilerServices;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           var celsius = TempConverter.FahrenheitToCelsius(68); 

            Console.WriteLine($"It's {celsius} degrees Celsius today!");

            var farhrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine($"It's {farhrenheit} degrees today!");


        }
    }
}
