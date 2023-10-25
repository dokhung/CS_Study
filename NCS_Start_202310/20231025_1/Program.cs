using System;
using System.Collections.Generic;

 public enum EOperator
    {
        PLUS, 
        MINUS,
        MULTI,
        DIVIDE,

        END
    }

    public class Mathmatics
    {
        public delegate int CalDelegate(int x, int y);

        CalDelegate[] delArr;
        Dictionary<EOperator, CalDelegate> delDic = new Dictionary<EOperator, CalDelegate>();

        public static void AA()
        { }
        public Mathmatics()
        {
            delArr = new CalDelegate[4] { Plus, Minus, Multiply, Divide } ;
            //int a=  delArr[0](1,2);  //이런식으로 Plus 사용 가능.

            delDic.Add(EOperator.PLUS, Plus);
            delDic.Add(EOperator.MINUS, Minus);
            delDic.Add(EOperator.MULTI, Multiply);
            delDic.Add(EOperator.DIVIDE, Divide);
        }

        public void Calculate(EOperator _oper, int x, int y)
        {
            Console.WriteLine("배열에 담긴 함수를 부른 결과 : " + delArr[(int)_oper](x,y));

            Console.WriteLine("딕셔너리로 부른 결과 : " + delDic[_oper](x, y)); //_oper를 바로 키로 쓸 수 있기때문에 switch로 굳이 판별 안해도 됨
            
        }

        public int Calculate(CalDelegate caldel, int x, int y)
        {
            return caldel(x,y);
        }

        public int Plus(int x, int y)
        {
            Console.WriteLine("Plus 함수 : " + (x + y));
            return x + y;
        }
        public int Minus(int x, int y)
        {
            Console.WriteLine("Minus 함수 : " + (x - y));
            return x - y;
        }
        public int Multiply(int x, int y)
        {
            Console.WriteLine("Multiply 함수 : " + (x * y));
            return x * y;
        }
        public int Divide(int x, int y)
        {
            Console.WriteLine("Divide 함수 : " + (x / y));
            return x / y;
        }
    }

    class Program
    {
        delegate void MathmaticsDelegate(EOperator _oper, int x, int y);
        delegate int CalculDelegate(int x, int y);

        public static int Remain(int x, int y)
        {
            return x % y;
        }

        static void Main(string[] args)
        {
            Mathmatics mathm = new Mathmatics();
            MathmaticsDelegate mathdel = mathm.Calculate;
            Console.WriteLine("MathmaticsDelegate 형식의 mathdel을 부름. 인자로 EOperator.PLUS, 1, 2 주었음");
            mathdel(EOperator.PLUS, 1, 2);

            Console.WriteLine("MathmaticsDelegate 형식의 mathdel을 부름. 인자로 EOperator.MINUS, 10, 4 주었음");
            mathdel(EOperator.MINUS, 10, 4);
            Console.WriteLine("MathmaticsDelegate 형식의 mathdel을 부름. 인자로 EOperator.Multi, 3, 6 주었음");
            mathdel(EOperator.MULTI, 3, 6);
            Console.WriteLine("MathmaticsDelegate 형식의 mathdel을 부름. 인자로 EOperator.divide, 20, 5 주었음");
            mathdel(EOperator.DIVIDE, 20, 5);

            Console.WriteLine("Mathmatics 클래스의 Calculate를 불러 매개변수로 나의 Remain을 넣었음 " +
                mathm.Calculate(Remain, 10, 3));

            Console.WriteLine("델리게이트 체인 확인");

            CalculDelegate calculdel = mathm.Plus;
            calculdel += mathm.Minus;
            calculdel += mathm.Multiply;
            calculdel += mathm.Divide;
            calculdel(10,5);

            Console.WriteLine("델리게이트 체인에서 함수를 빼보겠음");

            calculdel -= mathm.Multiply;
            calculdel -= mathm.Divide;
            calculdel(10, 5);


            Console.WriteLine("델리게이트 체인에 빼기 함수 두번 추가함");
            calculdel += mathm.Minus;
            calculdel += mathm.Minus;

            //이렇게 생각지못한 같은 함수가 여러번 작용하는 일이 생길 수 있어서, 델리게이트 체인은 위험함
            calculdel(10, 5);
        }
    }