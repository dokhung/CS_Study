/*
 * 앵무새, 고양이 , 개 ... 앵무새를 반드시 포함하여 3개이상의 클래스를 만든다.
 * 각 동물들은 울음소리를 내는 함수가 있다.
 * 이 함수는 매개변수로 int를 받고, 해당 매개변수는 울음의 횟수가 된다.
 * 예) 원래는 멍 이 기본이면 멍 x count 횟수 출력
 * 해당 매개변수의 횟수만큼 반복하여 울음 출력하기
 *
 * 앵무새는 울다라는 함수로
 * 본인의 울음소리와
 * 고양이, 개같은 타 클래스의 우는 함수를 매개변수로 받아서 다른 소리도 흉내낼 수 있음
 *
 * 딜리게이트, Func / Action  셋중 하나이상 활영하여 만들기
 *
 */

using System;
using System.Text;

namespace _20231025_Mission3
{
    public class Dog : Parrot
    {
        public void Dogbark(int count)
        {
            
            for (int i = 0; i < count; i++)
            {
                Console.Write("멍.");
            }
        }
    }

    public class Cat : Parrot
    {
        public string Catbark(int count)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append("야옹.");
            }
            return result.ToString();
        }
    }


    public class Parrot
    {
        // private Dog dog = new Dog();
        // private Cat cat = new Cat();
        public void bark(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine();
            }
            
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Parrot parrot = new Parrot();

            Action<int> OnBark = dog.Dogbark;
            OnBark(5);
            Func<int, string> TwoBark = cat.Catbark;
            Console.Write(TwoBark(3));
        }
    }
}
/*
 * 앵무새, 고양이 , 개 ... 앵무새를 반드시 포함하여 3개이상의 클래스를 만든다.
 * 각 동물들은 울음소리를 내는 함수가 있다.
 * 이 함수는 매개변수로 int를 받고, 해당 매개변수는 울음의 횟수가 된다.
 * 예) 원래는 멍 이 기본이면 멍 x count 횟수 출력
 * 해당 매개변수의 횟수만큼 반복하여 울음 출력하기
 *
 * 앵무새는 울다라는 함수로
 * 본인의 울음소리와
 * 고양이, 개같은 타 클래스의 우는 함수를 매개변수로 받아서 다른 소리도 흉내낼 수 있음
 *
 * 딜리게이트, Func / Action  셋중 하나이상 활영하여 만들기
 *
 */