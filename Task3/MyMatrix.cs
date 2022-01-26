using System;

namespace Task3
{
    internal class MyMatrix
    {
        private int[,] matrix = null;
        private Random rnd;

        private static MyMatrix instance = null;

        public static MyMatrix GetMyMatrix()
        {
            if (instance == null)
            {
                return new MyMatrix();
            }
            else
            {
                return instance;
            }
        }
        private MyMatrix()
        {
            matrix = new int[2, 2];
            rnd = new Random();
            matrix[0, 1] = getNewInt();
            matrix[0, 0] = getNewInt();
            matrix[1, 1] = getNewInt();
            matrix[1, 0] = getNewInt();
        }

        private int getNewInt()
        {
            return rnd.Next(1, 9);
        }

        public void ChangeMatrix(int colomn, int row)
        {
            if (colomn <= 0 || row <= 0)
            {
                Console.WriteLine("Specify parameters greater than zero ");
            }
            else
            {
                var newMatrix = new int[colomn, row];

                for (int c = 0; c < colomn; c++)
                {
                    for (int r = 0; r < row; r++)
                    {
                        if (matrix.GetLength(0) > c && matrix.GetLength(1) > r)
                        {
                            newMatrix[c, r] = matrix[c, r];
                        }
                        else
                        {
                            newMatrix[c, r] = getNewInt();
                        }
                    }
                }
                matrix = newMatrix;

            }
        }

        public void PrintMatrix()
        {
            Console.WriteLine(this[0, matrix.GetLength(0), 0, matrix.GetLength(1)]);
        }

        public string this[int cFrom, int cTo, int rFrom, int rTo]
        {
            get
            {
                var result = "Matrix:\n";
                for (int c = cFrom; c <= cTo - 1; c++)
                {
                    for (int r = rFrom; r <= rTo - 1; r++)
                    {
                        result += matrix[c, r];
                    }
                    result += "\n";
                }
                return result;
            }
        }
    }
}
