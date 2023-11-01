using System;

namespace CopyingArray
{
    internal class Program
    {
        static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        public static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];
            
            CopyArray<int>(source,target);

            foreach (int VARIABLE in target)
            
                Console.WriteLine(VARIABLE);

                string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
                string[] target2 = new string[source2.Length];
                
                CopyArray<string>(source2,target2);

                foreach (string VARIABLE in target2)
                    Console.WriteLine(VARIABLE);
            
        }
    }
}