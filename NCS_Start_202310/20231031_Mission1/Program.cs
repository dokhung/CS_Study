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
        public abstract void Wear();
    }

    class Consultation : Shop
    {
        public Consultation()
        {
            Console.Write("상의 가격 설정  :");
            int prise = int.Parse(Console.ReadLine());
            Console.WriteLine($"{prise}원으로 설정 완료");

        }
        public override void Wear()
        {
            Console.WriteLine("상의 착용");
        }

        
    }

    class Bottom : Shop
    {
        public Bottom()
        {
            Console.Write("하의 가격 설정 :");
            int prise = int.Parse(Console.ReadLine());
            Console.WriteLine($"{prise}원으로 설정 완료");
        }
        public override void Wear()
        {
            Console.WriteLine("하의 착용");
        }
        
    }

    class Hat : Shop
    {
        public Hat()
        {
            Console.Write("모자 가격 설정 :");
            int prise = int.Parse(Console.ReadLine());
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
            Hat hat = new Hat();
            Bottom bottom = new Bottom();
            Accessories accessories = new Accessories();
            Consultation consultation = new Consultation();
            
            Console.WriteLine("옷가게");
            Console.WriteLine("가게주인인지 손님인지 판단함 맞으면 y 아니면 n");
            string ok = Console.ReadLine();
            switch (ok)
            {
                case "y" :
                    Console.WriteLine("옷가게 주인 확인");
                    break;
                case "n" :
                    Console.WriteLine("손님 확인");
                    break;
            }
        }
    }
}