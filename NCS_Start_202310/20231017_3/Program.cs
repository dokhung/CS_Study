using System;

namespace _20231017_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           // Animal animal = new Animal(); 추상클래스는 인스턴스 생성이 안됨
           FlyAnimal bird = new FlyAnimal();
           

           Tiger tiger = new Tiger();
           Fox fox = new Fox();
           Console.WriteLine("FlyAnimal 클래스 부르기 시작");
           Console.WriteLine("FlyAnimal"+bird.GetLegCount());
           bird.Eat();
           bird.Fly();
           bird.Speak();
           bird.Call();

           GroundAnimal fourleg = new GroundAnimal();
           Console.WriteLine("GroundAnimal 클래스 부르기 시작");
           Console.WriteLine("GroundAnumal 클래스의 기본 다리 개수 : " + fourleg.GetLegCount());
           
        }
    }

    public abstract class Animal
    {
        public string name="";
        public int lifeTime = 0;
        protected int legCount = 0;

        public void Eat()
        {
            Console.WriteLine("동물클래스_밥먹는다.");
        }

        protected abstract void Move();
        // {
        //     Console.WriteLine("동물클래스 _ 움직인다.");
        // }

        public virtual void Speak() // virtual == 밑에 자식클래스들이 재정의 가능하도록 허락해줌
        {
            Console.WriteLine("울음소리");
        }

        public int GetLegCount()
        {
            return legCount;
        }

        public void Call()
        {
            Move();
        }
    }

    public class FlyAnimal : Animal // 날짐승
    {
        public FlyAnimal()
        {
            legCount = 2;
        }

        protected override void Move()
        {
            Console.WriteLine("날짐승클래스 _ 움직인다");
        }
        
        public void Fly()
        {
            Console.WriteLine("날짐승 친구들 _ 난다."); 
        }
    }

    public class GroundAnimal : Animal // 땅짐승
    {
        public GroundAnimal()
        {
            legCount = 4;
        }

        protected override void Move()
        {
            Console.WriteLine("땅짐승 친구들 _ 달린다.");
        }

        public virtual void Roar() // 상속의 허락
        {
            Console.WriteLine("GroundAnimal의  Roar~~~~");
        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("울음");
        }
    }

    public class Tiger : GroundAnimal
    {
        public override void Speak()
        {
            Console.WriteLine("어흥");
        }

        public void Fly()
        {
            Console.WriteLine("날았다");
        }
        public override void Roar() //상속이 허락되었기때문에 재정의 가능.
            {
               Console.WriteLine("Tiger의 Roar~~~~");
           }
        
    }
    public class Fox : GroundAnimal
    {
    public override void Speak()
    {
    Console.WriteLine("?");
    }
    
    }
}