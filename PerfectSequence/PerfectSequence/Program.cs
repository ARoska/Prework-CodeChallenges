using System;

namespace PerfectSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[3];
            int sum = 0;
            int product = 1;

            Console.WriteLine("Please input 3 numbers:");
            for(int i = 0; i < test.Length; i++)
            {
                int number;
                Int32.TryParse(Console.ReadLine(), out number);
                test[i] = number;
            }

            foreach(int number in test)
            {
                if(number >= 0)
                {
                    sum += number;
                    product *= number;
                }

                else
                {
                    product = 0;
                }
            }

            if(sum == product)
            {
                Console.WriteLine("Yes.");
            }

            else
            {
                Console.WriteLine("No.");
            }

            Console.ReadLine();
        }
    }
}
