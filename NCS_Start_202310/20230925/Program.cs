using System;

namespace _20230925
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainClass main = new MainClass();
            IControl control = main;
            ISurface surface = main;
        }
    }

    public interface IControl
    {
        void Paint();
    }

    public interface ISurface
    {
        void Paint();
    }

    public class MainClass : IControl, ISurface
    {
        public void Paint()
        {
            Console.WriteLine("Paint()");
        }
    }
}