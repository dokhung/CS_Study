using System;

namespace PropertiesInInterface
{
    interface INamedValue
    {
        string Name
        {
            get;
            set;
        }

        string Value
        {
            get;
            set;
        }
    }

    class NamedValue : INamedValue
    {
        public string Name
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            {
                Name = "이름", Value = "박상현"
            };

            Console.WriteLine($"{name.Name} : {name.Value}");
        }
    }
}