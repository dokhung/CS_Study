using System;

namespace _20231018_7
{
    internal class Program
    {
        static void Plus(int a, int b, ref int result)
        {
            result = a + b;
        }
        static void Minus(char a, char b, out int result)
        {
            result = (a - '0') - (b - '0');
        }
        static void Divide1(int a, int b, ref int result)
        {
            int c = a / b;
        }
        static void Divide2(int a, int b, out int result)
        {
            int c = a / b;
            result = c;
        }
        public static void Main(string[] args)
        {

            string maths = "";
            int result = 0;
            Console.WriteLine("수식 입력");
            Console.WriteLine("수식 입력 : ");
            maths = Console.ReadLine();
            switch (maths[1])
            {
                case '+':
                    Plus((int)(maths[0] - '0'),(int)(maths[2] - '0'), ref result);
                    break;
                case '-':
                    break;
                case '*':
                    break;
                case '/':
                    break;
                default:
                    Console.WriteLine("잘못된 수식");
                    break;
            }
        }
    }
}