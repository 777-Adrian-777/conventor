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

        static double convertToMiles(double celLenght)
        {
            double fLenght = 0;

            fLenght = (celLenght * 15625)/25146;

            return fLenght;
        }

        static int convertToSeconds(int celTime)
        {
            int fTime = 0;

            fTime = (celTime * 1)*60;

            return fTime;
        }
        static void Main(string[] args)
        {
            double celTemp = 0;
            double ferTemp = 0;

            double celLenght = 0;
            double ferLenght = 0;

            int celTime = 0;
            int ferTime = 0;

            Console.WriteLine("Hello, I help you to convert some values!\n");
            Console.Write("Enter the value of temperature in Celsius(°C): ");
            celTemp = double.Parse(Console.ReadLine());

            ferTemp = convertToFahrenheit(celTemp);
            Console.WriteLine("Fahrenheit temperature is(°F) : " + ferTemp);
        
            Console.Write("\nEnter the value of lenght in kilometres: ");
            celLenght = double.Parse(Console.ReadLine());

            ferLenght = convertToMiles(celLenght);
            Console.WriteLine("The lenght in miles is : " + ferLenght);

            Console.Write("\nEnter the time in minutes: ");
            celTime = int.Parse(Console.ReadLine());

            ferLenght = convertToSeconds(celTime);
            Console.WriteLine("The time in seconds is : " + ferTime);
        }
    }
}
           
