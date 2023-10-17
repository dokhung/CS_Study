using System;

namespace _20230926_re
{
    class Program // 이게 this임
    {
        public static void Main(string[] args)
        {
            // Orc orc = new Orc();
            // IMove orcMove = orc;
            // IAttack orcAttack = orc;
            //
            // orcMove.Event();
        }
    }

    // interface IMove
    // {
    //     void Event();
    // }
    //
    // interface IAttack
    // {
    //     void Event();
    // }
    //
    // interface IDead
    // {
    //     void Event();
    // }
    //
    // class Orc : IMove, IAttack
    // {
    //     void IMove.Event()
    //     {
    //         Console.WriteLine("움직인다.");
    //     }
    //
    //     void IAttack.Event()
    //     {
    //         Console.WriteLine("공격한다");
    //     }
    //     
    // }

    class MM 
    {
        // public MM Main()
        // {
        //     return this;
        //     // this를 하면 MM도 리턴을 됨
        // }
        
        
    }
    
    // abstract class Animal : Mons, Mons1
    // {
    //     
    // }

    abstract class Monster
    {
        protected int hp;
        protected int mp;
        public abstract void SetData(); // 몸통이 없다.

        public virtual void Move()
        {
            Console.WriteLine($"움직인다.{hp}");
            int a = 0;
        }

        public void Attack()
        {
            Console.WriteLine("공격한다.");
        }
        // 추상클래스
        // new Monster 이거 안됨
        // public void Move()
        // {
        //     Console.WriteLine("움직인다.");
        // }
        //
        // public void Attack()
        // {
        //     Console.WriteLine("공격한다");
        // }

        
    }

    class Orc : Monster
    {
        public override void SetData()
        {
            hp = 10;
        }
        public override void Move()
        {
            Console.WriteLine("오크가 움직인다.");
            base.Move();
            hp = 200;
        }
    }

    class Skeleton : Monster
    {
        public override void SetData()
        {
            hp = 20;
        }
    }
    
    interface Mons
    {
        void Move();

    }

    interface Mons1
    {
        void Move();
    }
}