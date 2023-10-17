using System;

namespace Mission19_s
{
    abstract class Ride
    {
        public abstract void Move();
    }
    
    public class FlyRide{}
    public class GroundRide{}

    public class Car : GroundRide
    {
        public override void Move()
        {
            Console.WriteLine("빠르게");
            base.Move();
        }
    }

    public class Bycicle : GroundRide
    {
        protected int wheelcount = 2;
        public override void Move()
        {
            Console.WriteLine("페달을 밟습니다.");
            
        }

        public virtual void GetWheelCount()
        {
            Console.WriteLine("바퀴의 개수는 "+ wheelcount + "개 입니다.");
        }
    }

    public class OneBycicle : Bycicle
    {
        public OneBycicle()
        {
            wheelcount = 1;
        }
        // override는 재정의. 즉 내가 부모의 함수를 바로 쓰지 않을떄 인데, base.GetwheelCount만 한다면
        // 굳이 부를 필요는 없을것. 그것도 virtual 선언을 
    }

    internal class Program
    {
        
        public static void Main(string[] args)
        {
            // 각 클래스 생성해서 불러서 확인.
        }
    }
}