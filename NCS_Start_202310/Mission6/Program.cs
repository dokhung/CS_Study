using System;

namespace Mission6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            while (true)
            {
                if (i > 30)
                {
                    break;
                }
                if (i%3 == 0) // 3의 배수
                {
                    continue; // 제외
                }
                sum += i; // 위에서 걸러지지 않은 3의 배수가 아닌 애들을 누적 더함
                i++;
            }
        }
    }
}