
/*
 * 가장 상위 부모 클래스로 탈것 클래스 만들기
 * 이 탈것 클래스를 추상적인 Move()함수를 가지고 있습니다.
 * 탈것 클래스를 상속받은 하늘 탈것/ 땅 탈것 두가지 클래스 존재
 * 땅 탈것 클래스를 상속받은 자동차 / 자전거 두가리 클래스 존재
 * 자전거 클래스를 상속받은 외발 자전거
 * 즉 6개 클래스
 * 하늘 탈것의 Move함수를 부르면 날고 있습니다. 출력
 * 땅 탈것의 Move함수를 부르면 달리고 있습니다. 출력
 * 자동차 클래스의 Move함수를 부르면 빠르게 달리고 있습니다. 출력
 * 자전거의 Move 함수를 부르면 사람이 직접 페달을 밟고 있습니다. 만 출력하기
 * 자전거에만 상속을 허락한 - GetWheelCount 라는 함수 있음
 * 이 함수는 바퀴의 개수는 2개 입니다. 를 출력함
 * 자전거를 상속받은 외발자전거에서 GetWheelCount 함수를 부르면 바퀴의 개수는 1개입니다. 를 출력
 * 외발 자전거에서의 Move함수는 자전거의 Move함수와 동일함...
 */

using System;
using System.Security.Policy;

namespace Mission19
{
    // 가장 상위 부모 클래스로 탈것 클래스 만들기
    public abstract class Ride //내가 내부에 하나라도 추상적인게 있다면 나는 추상클래스다..
    {
        //이 탈것 클래스는 추상적인 Move()함수를 가지고 있습니다
        public abstract void Move(); //추상 메서드는 추상 == 실체가 없기 때문에 {} 요 구현이 없고 선언 ; 만 있음
    }
    // 탈것 클래스를 상속받은 하늘 탈것/ 땅 탈것 두가지 클래스 존재
    
    public class FlyRide  : Ride
    {
        public override void Move()//하늘 탈것의 Move함수를 부르면  "날고 있습니다" 출력
        {
            Console.WriteLine("날고 있습니다");
        }
    }
    public class GroundRide : Ride
    {
        public override void Move() //땅 탈것의 Move함수를 부르면 "달리고 있습니다" 출력
        {
            Console.WriteLine("달리고 있습니다");
        }
    }

    

    public class Car : GroundRide
    {
        public override void Move()//자동차 의 Move함수를 부르면 "빠르게 달리고 있습니다" 출력
        {
            Console.Write("빠르게 ");
            base.Move();            
        }
    }

    // class Cycle : GroundRide
    // {
    //     protected int wheelcount = 2;
    //     public override void Move()
    //     {
    //         Console.WriteLine("사람이 직접 페달을 밟고 있습니다.");
    //     }
    //
    //     public virtual void GetWheeCount()
    //     {
    //         Console.WriteLine("바퀴의 개수는 "+wheelcount+"개 입니다.");
    //     }
    // }

    public class Bycicle : GroundRide
    {
        protected int wheelcount = 2;
        public override void Move()//자전거의 Move 함수를 부르면 "사람이 직접 페달을 밟고 있습니다"  만  출력하기
        {
            Console.WriteLine("사람이 직접 페달을 밟고 있습니다");  
        }
        public virtual void GetWheelCount()
        {
            Console.WriteLine("바퀴의 개수는 "+ wheelcount + "개입니다");
        }
    }
    // 자전거 클래스를 상속받은      외발자전거     클래스 존재
    public class OneBycicle : Bycicle
    {
        public OneBycicle()
        {
            wheelcount = 1; //생성자에서 세팅하거나
        }

        //override는 재정의. 즉 내가 부모의 함수를 바로 쓰지 않을때 인데, base.GetWheelCount만 한다면
        //굳이 부를필요는 없을것. 그것도 virtual 선언을 했기때문에 재정의 해도되고 안해도 됨.
        public override void GetWheelCount()
        {
            wheelcount = 1; //그냥 이 함수를 부르기 직전에 세팅하거나..
            base.GetWheelCount();
        }
    } 
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}