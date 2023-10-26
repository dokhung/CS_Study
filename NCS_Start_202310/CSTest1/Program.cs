using System;

namespace CSTest1
{
    struct ACSetting
    {
        public double currentInCelsius;
        public double target;

        public  double GetFahrenheit()
        {
            target = currentInCelsius * 1.8 + 32;
            return target;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine(acs.target);
        }
    }
}