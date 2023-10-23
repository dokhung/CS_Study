/*
 * 어떤 수가 입력되었을때, 천단위 구분 기호 콤마 (,) 넣어서 그 수를 다시 출력하기
 * 1000 => 1,000
 */

using System;
using System.Collections.Generic;

namespace _20231023_Mission4
{
    class SolveProb
    {
        
        
        public string comma(int intvalue)
        {
            return intvalue.ToString("N0");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("입력하면 콤마 생김 000 단위로 : ");
            int InputVal = int.Parse(Console.ReadLine());
            SolveProb prob = new SolveProb();
            string result = prob.comma(InputVal);
            Console.WriteLine(result);
        }
    }
}