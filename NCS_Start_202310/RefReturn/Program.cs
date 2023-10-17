using System;

namespace RefReturn
{
    internal class Program
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price:{price}");
        }
        
    }

    class MainApp
    {
        public static void Main(string[] args)
        {
            
        }
    }