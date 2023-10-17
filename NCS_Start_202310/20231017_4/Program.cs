namespace _20231017_4
{
    internal class Program
    {
        public interface IInterface // 계약
        {
            // 맴버변수 이런거 못씀
            void A();
            int B();
            string C(string val1, string val2);
        }
        public interface ISomething
        {
            void A();
            void B();
        }
        public class ExampleIntedrface : IInterface
        {
            public void A(){}
            public int B(){}
            public string C(string val1, string val2){}
        }
        public abstract class AA
        {
            private int a = 0;

            public abstract void A()
            {
                
            }

            public virtual void B()
            {
                
            }

            void C()
            {
                
            }
        }
        
        public class CD
        {
            
        }
        
        public class ABC : AA,IInterface,ISomething
        {
            public void
        }
        public static void Main(string[] args)
        {
            /*
             * 인터페이스
             * 
             */
            
        }
    }
}