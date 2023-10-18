using System;

namespace _20231018_8
{
    internal class Program
    {
        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static Point GetLeftTop(Point firstPoint, int width, int height)
        {
            // 1번 방법
            Point point = new Point();
            point.x = firstPoint.x;
            point.y = firstPoint.y + height;
            return point;
            
            // 2번방법
            firstPoint.y += height;
            return new Point(firstPoint.x, firstPoint.y);
        }

        static void GetRightBottom2(ref Point firstPoint, int width, int height) // 1번 방법
        {
            firstPoint.x += width;
        }
        static void GetRightBottom(Point firstPoint, int width, int height, ref Point resultPoint) // 2번방법
        {
            firstPoint.x += width;
        }

        static void GetRightTop( /* out 사용 */ Point editedPoint, int width, int height, out Point resultPoint) // 1번 방법 - 수정 당한
        {
            // 방법 1
            resultPoint = new Point(editedPoint.x, editedPoint.y + height);
            // 방법 2
            resultPoint = new Point();
            resultPoint.x = editedPoint.x;
            resultPoint.y = editedPoint.y + height;
        }
        
        static void GetRightTop2( /* out 사용 */ Point editedPoint, int width, int height, out Point resultPoint) // 2번 방법 - 수정 없이
        {
            // 방법 1
            resultPoint = new Point(editedPoint.x, editedPoint.y + height);
            // 방법 2
            resultPoint = new Point();
            resultPoint.x = editedPoint.x + height;
            resultPoint.y = editedPoint.y + height;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("한 점과, 가로, 세로 길이로 사각형의 모든 꼭짓점을 출력하겠습니다.");
            Console.WriteLine("한 점의 좌표값을 입력해주세요");
            Console.Write("x = ");
            // Console.ReadLine(); //숫자로 바꾸기
            Console.Write("y = ");
            // Console.ReadLine(); //숫자로 바꾸기
           
            //=> 이렇게 받은 x,y 값을 구조체 안에 넣기..

            Console.WriteLine("가로값을 입력해주세요");
            // Console.ReadLine(); //숫자로 바꾸기
            Console.WriteLine("세로값을 입력해주세요");
            // Console.ReadLine(); //숫자로 바꾸기 
        }
    }
}