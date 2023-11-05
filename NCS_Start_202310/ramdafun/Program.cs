namespace ramdafun
{
    class MyClass
    {
        public string fuck(string you)
        {
            you = "nininin";
            return you = "ninin";
        }
        
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            string you = "";
            myClass.fuck(you);
        }
    }
}