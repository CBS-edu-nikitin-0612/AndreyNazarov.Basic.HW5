using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var matrix = MyMatrix.GetMyMatrix();
            matrix.PrintMatrix();
            matrix.ChangeMatrix(10, 10);
            matrix.PrintMatrix();
            matrix.ChangeMatrix(5, 5);
            matrix.PrintMatrix();

            Console.WriteLine(matrix[1, 3, 1, 4]);
        }
    }
}
