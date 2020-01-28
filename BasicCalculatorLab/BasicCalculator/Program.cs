using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter TemperatureNumber");

            // int.Parse will take a string data type and convert it to an int data type
            int TemperatureNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter RelativeHumidityNumber");
            int RelativeHumidityNumber = int.Parse(Console.ReadLine());

            int sum = TemperatureNumber-((100-RelativeHumidityNumber)/5);

            Console.WriteLine("The answer is " + sum);
        }
    }
}