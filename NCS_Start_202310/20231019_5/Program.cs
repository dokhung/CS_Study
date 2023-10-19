/*
 * boxing : 값 형식을 object형식 또는
 *
 */

using System.Collections.Generic;

namespace _20231019_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * object // 참조타입.. 아무거나 다 담을 수 있음
             * 
             */

            int a = 5;
            object obj = a;

            A aa = new A();
            int b = 10;
            b += (int)obj;
            b += aa.a;

            List<object> AddListAnything = new List<object>();
            AddListAnything.Add(1);
            AddListAnything.Add("a");
            AddListAnything.Add("b");
            AddListAnything.Add(0.45f);
            
            


        }
    }

    class A
    {
        public int a = 5;
    }
}