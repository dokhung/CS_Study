using System;

namespace Study
{
    // 상속
    public class Monster
    {
        // 비공개 사항
        
        
        

        private int hp;
        private int speed;

        public Monster(int hp, int speed)
        {
            Console.WriteLine("생성했다.");
            this.hp = hp;
            this.speed = speed;
        }
        private bool isMove = false;
        
        
        // 행동
        // protected void Attack()
        // {
        //     
        // }
        
        public void Move()
        {
            isMove = true;
            /*
             * int speed = 10;
             * speed값이 있으면 this 해야됨
             */
        }
        
        // protected void Dead()
        // {
        //     
        // }
        //
        // protected void Hit()
        // {
        //     
        // }
        // public int hp = 10;
        
    }

    // class Orc : Monster // <- 상속받음
    // {
    //     public void Main()
    //     {
    //         // Move(); // 이동을 한다. 그러면 Move()가 활성화된다.
    //         // Hit();
    //         // Move();
    //         // Hit();
    //         Hp = 20;
    //     }
    // }
    //
    // class Goblin : Orc
    // {
    //     public void GMain()
    //     {
    //         
    //     }
    // }
}