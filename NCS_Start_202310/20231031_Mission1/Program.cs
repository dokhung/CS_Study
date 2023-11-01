using System;

namespace _20231031_Mission1
{
    /*
     * 옷가게 입니다. 옷을 팝니다.
     * 옷은 사의, 하의 , 모자가 있습니다.
     * 모든 옷은 착용을 요청 할 수 있습니다. 착용하다 라는 함수 존재.
     * 가격은 주인만 설정 가능하며, 손님은 가격을 물어보는 것 밖에 안됩니다
     * 가격 변수가 있고, 가격변수 세팅은 그 옷이 처음 만들어질떄 만 가능.
     * 해당 옷들은 클래스로 만들어보기.
     * 인터페이스와 추상클래스 둘다 사용하기
     */

    public interface IUsing
    {
        void UseAccessories();
    }
    abstract class Shop
    {
        protected int prise = 0;
        public abstract void Wear();

        public virtual void setting()
        {
            prise = int.Parse(Console.ReadLine());
        }
    }

    class Consultation : Shop
    {
        public override void setting()
        {
            Console.Write("상의 가격 설정  :");
            base.setting();
            Console.WriteLine($"{prise}원으로 설정 완료");
        }
        public override void Wear()
        {
            Console.WriteLine("상의 착용");
        }

        
    }

    class Bottom : Shop
    {
        public void setting()
        {
            Console.Write("하의 가격 설정 :");
            base.setting();
            Console.WriteLine($"{prise}원으로 설정 완료");
        }
        public override void Wear()
        {
            Console.WriteLine("하의 착용");
        }
        
    }

    class Hat : Shop
    {
        public void setting()
        {
            Console.Write("모자 가격 설정 :");
            base.setting();
            Console.WriteLine($"{prise}원으로 설정 완료");
        }
        public override void Wear()
        {
            Console.WriteLine("모자 착용");
        }
    }

    class Accessories : IUsing
    {
        public void UseAccessories()
        {
            Console.WriteLine("착용테스트 불가");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("가게를 오픈 합니다.");
            Hat hat = new Hat();
            Bottom bottom = new Bottom();
            Accessories accessories = new Accessories();
            Consultation consultation = new Consultation();
            while (true)
            {
                Console.WriteLine("옷가게");
                Console.WriteLine("가게주인인지 손님인지 판단함 맞으면 y 아니면 n");
                string ok = Console.ReadLine();
                switch (ok)
                {
                    case "y" :
                        Console.WriteLine("옷가게 주인 확인");
                        Console.WriteLine("물품 가격 셋팅");
                        hat.setting();
                        bottom.setting();
                        consultation.setting();
                        break;
                    case "n" :
                        Console.WriteLine("손님 확인");
                        Console.WriteLine("원하는 착용은?");
                        Console.WriteLine("1. 모자");
                        Console.WriteLine("2. 상의");
                        Console.WriteLine("3. 하의");
                        Console.WriteLine("4. 악세사리");
                        int selnum = int.Parse(Console.ReadLine());
                        if (selnum == 1)
                        {
                            hat.Wear();
                        }
                        else if (selnum == 2)
                        {
                            consultation.Wear();
                        }
                        else if (selnum == 3)
                        {
                            bottom.Wear();
                        }
                        else if (selnum == 4)
                        {
                            accessories.UseAccessories();
                        }
                        else
                        {
                            Console.WriteLine("틀린 입력");
                        }
                        break;
                }
            }
        }
    }
}