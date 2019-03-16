using System;

namespace SumOfRows
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            int n;

            Console.Write("Input the number of rows in the matrix: ");
            Int32.TryParse(Console.ReadLine(), out m);

            Console.Write("Input the number of columns in the matrix: ");
            Int32.TryParse(Console.ReadLine(), out n);

            int[,] sumArray = new int[m, n];
            int[] results = new int[m];

            for(int i = 0; i < sumArray.GetLength(0); i++)
            {
                int value = 0;

                for (int j = 0; j < sumArray.GetLength(1); j++)
                {
                    sumArray[i, j] = GetRandomNumber();
                    value += sumArray[i, j];
                }

                results[i] = value;
            }

            Console.WriteLine("[{0}]", string.Join(", ", results));
            Console.ReadLine();


        }

        private static int GetRandomNumber()
        {
            Random random = new Random();
            int value = random.Next(-100, 100);
            return value;
        }
    }
}
