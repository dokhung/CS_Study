using System;

namespace Misstion8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 배열써서 국영수 점수 이력해서 평균내기...
             * int[] score; // 요거 반드시 활용할것...
             * 
             */
            try
            {
                
                
                while (true)
                {
                    Console.WriteLine("국영수 점수를 입력해주세요");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int c = int.Parse(Console.ReadLine());
                    int[] score = new [] {a,b,c};
                    int sum = 0;
                    for (int i = 0; i < score.Length; i++)
                    {
                        if (a == 0 || b == 0 || c == 0)
                        {
                            Console.WriteLine("0입력했음");
                        }
                        else
                        {
                            sum += score[i];
                        }
                        
                    }

                    double average = (double)sum / score.Length;

                    Console.WriteLine("평균: " + average);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            {
                Console.WriteLine("----------------------");
                int sum = 0;
                int[] score = new int[3]{0,0,0};
                while (true)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 0)
                        {
                            Console.WriteLine("국어 점수를 입력해주세요 : ");
                        }
                        else if (i == 1)
                        {
                            Console.WriteLine("영어점수를 입력해주세요");
                        }
                        else if (i == 2)
                        {
                            Console.WriteLine("수학점수를 입력하세요");
                        }

                        if (int.TryParse(Console.ReadLine(), out int val))
                        {
                            score[i] = val;
                            sum += val;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력");
                        } // 국영수 입력의 끝
                        Console.WriteLine("국영수 점수의 평균값은 " + (sum / score.Length));
                    }
                    Console.WriteLine("while문 밖임");
                }
            }
        }
    }
}