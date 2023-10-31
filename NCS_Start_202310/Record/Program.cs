using System;
using System.Runtime.CompilerServices;
using System.Runtime.CompilerServices.IsExternalInit;

namespace Record
{
    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            RTransaction tr1 = new RTransaction
            {
                From = "Alice", To = "Bob", Amount = 100
            };
            Console.WriteLine(tr1);
        }
    }
}