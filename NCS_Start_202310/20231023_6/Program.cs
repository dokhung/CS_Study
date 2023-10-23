namespace _20231023_6
{

    class GenericClass<T>
    {
        public T member;

        public GenericClass(T t)
        {
            member = t;
        }

        public override string ToString()
        {
            return "member의 값 : " + member;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}