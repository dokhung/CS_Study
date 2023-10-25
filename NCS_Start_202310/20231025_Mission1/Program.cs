using System;

namespace _20231025_Mission1
{
    delegate void DelegateWalk();
    
    public class Human
    {
        public void FreeWalk(bool bw, DelegateWalk walk)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("<사람>");
            Console.WriteLine("사람이 나갑니다.");
            Console.WriteLine("그냥 아무 생각 없이 나갑니다.");
            Console.WriteLine("------------------------");
            Console.WriteLine("개랑 같이 나갈건가? : (y/n)");
            
            
        }    
    }

    public class Dog : Human
    {
        public void Walk()
        {
            Console.WriteLine("개가 산책한다.");
        }   
    }
    
    
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             *  사람클래스와 개 클래스 만들어서
             *  사람은 그냥 나간다는 함수이고
             * 변수로 함수 받을 수 있고, bool을 줘서
             * bool은 사람이 혼자 나갈건지, 개랑 같이 나갈건지 여부고
             * 함수는 개가 산책한다는 내용 => 출력하면 됨. void 여도 됨
             *
             * 메인에서 사람 혼자 나가는 것 출력하고, 사람과 개가 같이 나가는것도 출력할 것.
             */
            Human human = new Human();
            human.FreeWalk();
        }
    }
}