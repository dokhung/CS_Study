using System;

namespace StaticField
{
    class Global
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine($"Global.Count:{Global.Count}");
            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB(); // 4개잔아
            
            
            Console.WriteLine($"Global.Count:{Global.Count}");
        }
    }
}