using System;
using _20231025_5;

namespace _20231025_5
{
    class FuncSample
    {
        public bool GetJustBool(int x, int y)
        {
            return x > y;
        }
        public int GetJustInt(int x)
        {
            return x * 2;
        }
        public string GetJustString(string val, int val2)
        {
            return val + val2;
        }

        public void VoidFunc(float val)
        {
            Console.WriteLine(val + "이 들어온 함수");
        }
    }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            FuncSample funcSample = new FuncSample();
            Func<int, int, bool> returnboolFunc = funcSample.GetJustBool;
            Console.WriteLine("returnboolFunc(10,5)를 부름"+returnboolFunc(10,5));
            
            //GetJustString 변수에 담아서 불러보기
            Func<int, int> returnintFunc = funcSample.GetJustInt;
            Console.WriteLine(returnintFunc(6));

            Func<string, int,string> GetString = funcSample.GetJustString; // 매개변수 매개변수 => 반환 자료형
            Console.WriteLine(GetString("val",10));  // 반환형이 있어야 Func 사용 가능

            Action<float> GetFloat = funcSample.VoidFunc;
            GetFloat(0.1f); // 반환형이 없어서 cw 안됨


        }
    }
