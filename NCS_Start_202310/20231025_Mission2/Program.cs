/*
 * Predicate는 리턴형이 반드시 bool 이어야 하고, 입력 파라미터도 1개로 제한됨...
 * 매개변수 있는거 1개 부르기
 */

using System;

namespace _20231025_Mission2
{
    public class PredicateSample
    {
        public bool GetJustBool(int x)
        {
            return x - 1 == 0;
        }

        public void GetVoid(string msg)
        {
            Console.WriteLine(msg + "<= GetVoid 발동");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            PredicateSample predicateSample = new PredicateSample();
            Func<int, bool> boolFun = predicateSample.GetJustBool;
            Console.WriteLine(boolFun(1));

            Action<string> GetMsg = predicateSample.GetVoid;
            GetMsg("에로우펑션");
        }
    }
}