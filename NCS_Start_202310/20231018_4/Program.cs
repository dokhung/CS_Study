using System;

namespace _20231018_4
{
    
    
    internal class Program
    {
        static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void SwapRef(ref int x,int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void SwapRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        
        struct structA
        {
            public int x;
            public int y;

            public structA(int x,int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        
        public static void Swapstruct(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Swap(structA sa)
        {
            int temp = sa.x;
            sa.x = sa.y;
            sa.y = temp;
        }
        
        static void Swap(ref structA sa)
        {
            int temp = sa.x;
            sa.x = sa.y;
            sa.y = temp;
        }
        
        
        
        
        
        public static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            Swap(x, y);
            Console.WriteLine($"x = {x}, y = {y}"); 
            
            
            x = 1;
            y = 2;
            SwapRef(ref x, y);
            Console.WriteLine($"x = {x}, y = {y}"); 
            
            
            x = 1;
            y = 2;
            SwapRef(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}");
            structA aa = new structA(11, 22);
            
            Console.WriteLine("생성된 구조체 aa = "  + aa.x + "," + aa.y);
            
            Swap(aa);
            Swap(aa.x, aa.y);
            
            Console.WriteLine("그냥 스왑 후의 구조체 aa = " + aa.x + "," + aa.y);
            
            structA structA = new structA();
            structA.x = 1;
            structA.y = 2;
            Swapstruct(ref x, ref y);
            Console.WriteLine($"x : {x} y : {y}");
            
            // 정답
            


        }
    }
}