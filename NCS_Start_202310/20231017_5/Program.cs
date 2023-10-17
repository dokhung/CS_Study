using System;

namespace _20231017_5
{
    interface IShoot
    {
        void Attacked(float damage);
    }
    class Creature
    {
        
    }

    class Player
    {
        
    }

    class Monster : IShoot
    {
        private float hp = 0;

        public void Attacked(float damage)
        {
            hp -= damage;
            Console.WriteLine(damage + "의 피해를 입었습니다.");
        }
    }

    class Objects : IShoot
    {
        private float hp = 0;
        public void Attacked(float damage)
        {
            hp -= damage;
            Console.WriteLine(damage + "의 피해를 입었습니다.");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Player player = new Player();
            Monster monster = new Monster();
            Objects objects = new Objects();
            // as키워드랑 is 키워드가 있어요
            if (monster is IShoot)
            {
                monster.Attacked(2.2f);
            }
            IShoot shoot = objects as IShoot;
            if (shoot != null)
            {
                shoot.Attacked(3f);
            }
            else
            {
                Console.WriteLine("Player는 IShoot형식을 포함하고 있지 않음");
            }
            IShoot shoot2 = player as IShoot;
            if (shoot2 != null)
            {
                
            }


        }
    }
}