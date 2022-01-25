using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new Store();

            Console.WriteLine(store[2]);
            Console.WriteLine();
            Console.WriteLine(store["item2"]);
            Console.WriteLine();
            Console.WriteLine(store["item4"]);
        }
    }
}
