using System;

namespace _20231018_3
{
    struct Point
    {
        public float x;
        public float y;

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void PrintValue() => Console.WriteLine($"좌표 값 : [{x},{y}]");
    }
    class AA
    {
        public Point point;

        public AA(Point point)
        {
            this.point = point;
            this.point.PrintValue(); // 내 포인트 구조체 내용 확인
        }

        public void Swap()
        {
            //AA Class 의 point
            float temp = point.x;
            point.x = point.y;
            point.y = temp;
            Console.WriteLine("AA클래스 안에서의 Swap 실행한 point = ");
            point.PrintValue();
        }

        
    }
    
    class Program
    {
        static void Swap(Point point) // 구조체를 매개변수로 넘김
        {
            float temp = point.x;
            point.x = point.y;
            point.y = temp;

            Console.Write("그냥 Swap함수 안에서의, 구조체를 매개변수로 받은 point = ");
            point.PrintValue();
        }

        static void Swap(AA _a)
        {
            float temp = _a.point.x;
            _a.point.x = _a.point.y;
            _a.point.y = temp;
            Console.WriteLine("그냥 Swap함수 안에서의, AA클래스를 매개변수로 받은 point = ");
            _a.point.PrintValue();
        }
        
        public static void Main(string[] args)
        {
            Point point = new Point(10, 20);
            Swap(point);
            Console.WriteLine("현재 메인함수, Swap함수 실행 후의, 그냥 구조체로서의 point = ");
            point.PrintValue();

            Point point2 = new Point(1, 2);
            AA aa = new AA(point2); // 클래스의 맴버변수로 point2를 선언하여 넣어주고
            Swap(aa); // 클래스를 매개변수로 넘김
            Console.WriteLine("현재 메인함수, Swap함수 실행 후의, 메인함수의 point2 = ");
            point2.PrintValue();

            Console.WriteLine("*****************************************");

            point2.x = 3;
            point2.y = 4;
            aa = new AA(point2); // 3,4 라는 새로운 포인트 값을 가지는 새로운 클래스 생성.
            aa.Swap(); // 클래스 내부의 함수를 실행함

            Console.WriteLine("클래스 안의 point의 내용 확인");
            aa.point.PrintValue();

            Console.WriteLine("메인 함수의 point2의 내용 확인");
            point2.PrintValue();


        }
    }

    

    
}