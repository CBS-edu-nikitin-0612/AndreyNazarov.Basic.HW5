using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            Console.WriteLine("Please type int");
            if (int.TryParse(Console.ReadLine(), out length))
            {
                var array = getArray(length);
                Console.WriteLine($"AVG: {array.getAVG()}\n" +
                    $"Max: {array.getMax()}\n" +
                    $"Min: {array.getMin()}\n" +
                    $"Amount: {array.getAmount()}\n");
                for (int i = 0; i < array.Length-1; i++)
                {
                    if(array[i]%2 != 0)
                    {
                        Console.WriteLine($"Odd element: {array[i]}");
                    }
                }
            }
        }

        public static int[] getArray(int length)
        {
            int[] result = new int[length];
            var rnd = new Random();
            for (int i = 0; i < length - 1; i++)
            {
                result[i] = rnd.Next(1,100);
            }
            return result;
        }
    }
}
