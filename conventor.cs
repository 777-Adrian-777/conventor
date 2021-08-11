using System;

namespace ConsoleApp1
{
    class Program
    {
        static double convertToFahrenheit(double celTemp)
        {
            double fTemp = 0;

            fTemp = (celTemp * 9) / 5 + 32;

            return fTemp;
        }

        static double convertToMiles(double celLength)
        {
            double fLength = 0;

            fLength = (celLength * 15625)/25146;

            return fLength;
        }

        static int convertToSeconds(int celTime)
        {
            int fTime = 0;

            fTime = (celTime * 60);

            return fTime;
        }
        static void Main(string[] args)
        {
            double celTemp = 0;
            double ferTemp = 0;

            double celLength = 0;
            double ferLength = 0;

            int celTime = 0;
            int ferTime = 0;

            Console.WriteLine("Hello, I can help you to convert some values!\n");
            Console.Write("Enter the value of temperature in Celsius(°C): ");
            celTemp = double.Parse(Console.ReadLine());

            ferTemp = convertToFahrenheit(celTemp);
            Console.WriteLine("Fahrenheit temperature is(°F) : " + ferTemp);
        
            Console.Write("\nEnter the value of length in kilometres: ");
            celLength = double.Parse(Console.ReadLine());

            ferLength = convertToMiles(celLength);
            Console.WriteLine("The lenght in miles is : " + ferLength);

            Console.Write("\nEnter the time in minutes: ");
            celTime = int.Parse(Console.ReadLine());

            ferTime = convertToSeconds(celTime);
            Console.WriteLine("The time in seconds is : " + ferTime);
        }
    }
}
           
