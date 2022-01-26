using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга", Dictionary.Language.Rus]);
            Console.WriteLine(dictionary["sun", Dictionary.Language.Eng]);
            Console.WriteLine(dictionary["Стола", Dictionary.Language.Ua]);
            Console.WriteLine(dictionary["Вино", Dictionary.Language.Rus]);


            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
