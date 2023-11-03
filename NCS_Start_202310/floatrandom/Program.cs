using System;

namespace floatrandom
{
    class Singleton
    {
        private static Singleton instance;
        private static readonly 
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            {
                
                    Random random = new Random();

                    double minValue = 1.0;
                    double maxValue = 10.0;

                    // 1.0 이상 10.0 미만의 double 난수 생성
                    double randomDoubleInRange = minValue + (random.NextDouble() * (maxValue - minValue));

                    Console.WriteLine("1.0과 10.0 사이의 랜덤 double 값: " + randomDoubleInRange);
                
            }

        }
    }
}