/*
 * char 를 키로 갖고, 값으로 숫자를 갖는 딕셔너리를 선언
 * 5개의 값을 더하고
 * char 'a' 를 검색해서 키가 존재한다면 내가 이름 지은 딕셔너리.ContainKey('a')
 * 개를 없애라 하고 전체 출력...
 */

using System;
using System.Collections.Generic;

namespace _20231023_Mission5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            dictionary.Add('a',1);
            dictionary.Add('b',2);
            dictionary.Add('c',3);
            dictionary.Add('d',4);
            dictionary.Add('f',5);
            Console.WriteLine("*****");
            foreach (var VARIABLE in dictionary)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine("*****");
            Console.Write("key를 검색하여 삭제 : ");
            char a = char.Parse(Console.ReadLine());
            if (dictionary.ContainsKey(a))
            {
                dictionary.Remove(a);
            }

            foreach (var VARIABLE in dictionary)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}