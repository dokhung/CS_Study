/*
 * 업캐스팅 : 자식 클래스 -> 부모 클래스 ( 형변환 생략 가능 )
 * 다운캐스팅 : 부모 클래스 -> 자식 클래스 ( 형변환 생략 불가 )
 * 동일하게 참조변수 -> 참조변수 로 변한다.
 * 다운캐스팅이 가능하려면 , 다운 캐스팅 전에 부모클래스가 참조하고 있던 객체가 자식 클래스의 것이여야 가능.
 */

// 클래스의 형변환

using System;

namespace _20231019_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Parent parent = new Parent(); // Parent 형식을 담는 내용물도 Parent...

            Child child = new Child();
            Child2 child2 = new Child2();

            Parent child_p = new Child(); //  업캐스팅... Parent .. 형식을 Parent로 활용하긴 할건데 ... 실제 내용물은 Child

            parent.parentInt = 1;
            parent.ParentFunc();
            // parent.childfunc(); 접근 불가
            
            //상속 받았고, 해당 기능이 public이기 떄문에 밖에서도 접근 가능...
            // child.parentInt = 1;
            // child.ParentFunc();
            // child.childStr = "dd";
            // child.ChildFunc();
            //
            // Parent temParent;
            // temParent = child;
            //
            // Child tempChild; // 큰쪽에다가
            // tempChild = parent; // 작은걸 넣을 수 없다.
            // 자식 클래스가 부모 클래스것도 사용하지만 부모 클래스는 자식클래스를 사용할수없다.

            Console.WriteLine("child_p는 Parent형식의 Child 입니다.");
            
            Console.WriteLine("child_p를 Child 본래 형식으로 다운캐스팅 합니다.");
            (child_p as Child).ChildFunc(); // 에러는 안남.. 빨간줄은 안남
            
            Console.WriteLine("child_p를 Child 본래 형식으로 다운캐스팅 합니다.");
            if (child_p is Child2)
            {
                (child_p as Child2).Child2Func(); // 에러는 안남.. 빨간줄은 안남 // 실행하면 빨간줄 됨
            }
            else
            {
                Console.WriteLine("child_p는 Child2 형식으로 바꿀 수 없습니다.");
            }

            // switch (child_p.FamilyType)
            // {
            //     case FamilyType.Parent:
            //         (child_p as Parent). 하고싶은거 함// 가능
            //         break;
            //     case FamilyType.Child:
            //         (child_p as Child). 하고싶은거~ // 가능
            //         break;
            //     case FamilyType.Child2:
            //         (child_p as Child2) // 가능)
            //         break;
            //     default:
            //         break;
            // }
            
            
            


        }

        static Parent GetParentsClass(FamilyType type)
        {
            switch (type)
            {
                case FamilyType.Parent:
                    (child_p as Parent). 하고싶은거 함// 가능
                    break;
                case FamilyType.Child:
                    (child_p as Child). 하고싶은거~ // 가능
                    break;
                case FamilyType.Child2:
                    (child_p as Child2) // 가능)
                    break;
                default:
                    break;
            }
        }
    }
    
    

    enum FamilyType
    {
        Parent,
        Child,
        Child2,
        End
    }
    class Parent // 자식과는 상관없어요.
    {
        // public int parentInt;
        public FamilyType FamilyType = FamilyType.Parent;
        public int parentInt;

        public void ParentFunc()
        {
        }
    }
    
    class Child : Parent
    {
        public string childStr;
        
        
        public void ChildFunc()
        {
            Console.WriteLine("ChildFunc()");
        }
    }
    
    class Child2 : Parent
    {
        public float child2Float;

        public void Child2Func()
        {
            Console.WriteLine("Child2Func()");
        }
    }
}