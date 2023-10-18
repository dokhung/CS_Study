using System;

/*
 * 힙 : 변수 할당과 해제 책임 - 원본이 있는 위치
 * 스택 : 값 형식이 들어가는 메모리 공간 - Main함수전에 쌓인 데이터를 치우고 마지막에 실행
 * 가비지 컬렉터 : 지워
 * 뭔가 막 만들면 지우는데 이떄 느려질수있음
 * 
 */

namespace _20231018
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 각 클래스 생성해서 불러서 확인 해보면 좋음
            B bstruct = new B();
            bstruct.aa = 10;
            B bstruct2 = new B();

            Point point;
            point.x = 5f;
            point.y = 1.05f;
            Console.WriteLine("좌표 출력 : ["+point.x +","+ point.y + "]");

        }
    }

    class A
    {
        // public void AAA(string name, string address, int age, bool sex, string[] family) // 매개변수 등등
        public void AAA(PersonInfo _info, PersonInfo _info2) // 매개변수 // 매개체로 넘겨줌
        {
            _info.name = "";
            string newname = _info.name;
        }
        // public A()
        // {
        //     
        // }
        // ~A(){} // 소멸자

        struct PersonInfo
        {
            public string name;

            public string address;

            public int age;
            /*
             * 사람이름
             * 주소지
             * 나이
             * 성별
             * 가족관계
             * 성적 ( 학년별 )
             * 교우관계
             * 기타 선생님의 평가
             */
        }
    }

    struct Point // 대표적인 예로 좌표 정보를 담은 구조체가 있다.
    {
        public float x;
        public float y;

        public Point(float x,float y)
        {
            this.x = x;
            this.y = y;
        }
    }

    struct B    // 구조체는 변수내용의 값이 비어있으면 안됨.
    {
        public int aa;

        public B(int bbb)
        {
            aa = bbb;
        }
    }
}