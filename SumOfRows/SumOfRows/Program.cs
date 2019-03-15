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


        }
    }
}
