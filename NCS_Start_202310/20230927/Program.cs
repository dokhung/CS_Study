using System;
using System.Collections.Generic;

namespace _20230927
{
    class Program
    {
        public static void Main(string[] args)
        {
            // MM mm = new MM();
            // mm.Main(10).Print().End();
            // mm.Main(10);
            // mm.Print();
            // mm.End();
            // mm.Print().Main(10).End();

            List<int> list = new List<int>();
            list.Add(5);
            list.Add(5);
            list.Add(5);
            list.Add(5);
            
            list.Clear(); // 다 삭제함




        }
        
        interface Mons
        {
            void Move();

        }

        

        class MM
        {
            public int hp;
            public MM Main(int hp)
            {
                hp = hp;
                return this;
                // 전역변수의 hp를 사용해야되면 this.hp를 해야됨
                // this는 무조건 클래스 안헤서만 된다.
                // 인터페이스와 추상클래스는 크게 차이가 없다. 인터페이스는 다중상속 단일, 추상클래스는 단일 상속
            }
            
            

            public MM Print()
            {
                return this;
            }

            public void End()
            {
                
            }
        }
        
        
    }
}