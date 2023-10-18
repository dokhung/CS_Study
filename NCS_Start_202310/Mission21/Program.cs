using System;

namespace Mission21
{
    internal class Program
    {
        struct Xy
        {
            public int x;
            public int y;

            public Xy(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public static void Main(string[] args)
        {
            /*
             * 점의 좌표값을 표시할 구조체 선언 ( 예를 들어 int x, int y 를 멤버변수로 갖는 형식)
             * 사용자가 사각형을 이룰 한 점의 좌표와 사각형의 가로길이, 세로길이를 입력했을때
             * 니머지 꼭짓점 세 개에 대한 좌표를 출력하기
             * 단, 한번은 반환형으로 좌표받기
             * 한번은 ref 키워드로 좌표받기
             * 한번은 out 키워드로 좌표받기
             * 이렇게 사각형을 이루는 네 좌표를 모두 출력하기
             */
            Xy xy = new Xy();
            Console.WriteLine("한 점과, 가로, 세로 길이로 사각형의 모든 꼭짓점을 출력하겠습니다.");
            Console.WriteLine("한 점의 좌표값을 입력해주세요");
            Console.Write("x = ");
            xy.x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            xy.y = int.Parse(Console.ReadLine());
            Console.Write("가로값을 입력해주세요");
            int Transverse = int.Parse(Console.ReadLine());
            Console.Write("세로값을 입력해주세요");
            int length = int.Parse(Console.ReadLine());
            
        }
    }
}