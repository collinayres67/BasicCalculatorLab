using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC WEATHER CALCULATOR ***");

            // declare variables
            string input;
            int temp;
            int relhumidity;
            int dewpoint;
            int windspeed;


            // ASK FOR TEMP 
            Console.WriteLine("Enter a temp");
            input = Console.ReadLine();
            temp = int.Parse(input);


            // ASK FOR REL HUMIDITY
            Console.WriteLine("Enter RH");
            input = Console.ReadLine();
            relhumidity = int.Parse(input);
            //CALCULATE THE DEW POINT
            dewpoint = temp - 9 * (100 - relhumidity) / 25;
            //  PRINT DEW POINT
            Console.WriteLine("Dew point = " + dewpoint);
            // ask for windspeed
            Console.WriteLine("Enter windspeed");
            input = Console.ReadLine();
            windspeed = int.Parse(input);
            // calculate wind chill
            double windChill = 35.74
                + (0.6125 * temp)
                - 35.75 * Math.Pow(windspeed, 0.16)
                + 0.4275 * temp * Math.Pow(windspeed, 0.16);



            // print wind chill 
            Console.WriteLine("The wind chill is " + windChill);
        }
    }
}