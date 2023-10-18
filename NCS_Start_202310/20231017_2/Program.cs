namespace _20231017_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Parent _pare = new Parent();
        }
    }

    public class Parent
    {
        public int a;
        protected string b;
        private bool c;

        public virtual void A()
        {
            // parent에서의 A함수~ 
        }
        // protected void B(){}
        // protected abstract void B(){} // 추상클래스다. 그래야 가능.

        void C()
        {
        }
    }

    public class Child : Parent // < = 상속
    {
        public int aa;
        protected string bb;
        private bool cc;

        void AA()
        {
            a = 10;
            b = "스트링";
            // c 는 프라이빗이라서 부모꺼여도 안됨
            A();
            

        }

        public override void A()
        {
            /*
             * Child안에서의 A작용...
             * this. => 나 내것
             * base. => 부모의 것~
             * base.A();
             * 실드 라는것이 있는데 이것은 더이상 자신의 자식을 만들지 않겠다는 의미
             * public
             */
        }
    }
}
