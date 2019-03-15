using System;

namespace ArrayMaxResult
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int selection;
            int counter = 0;
            int score;

            Console.WriteLine("Please input five(5) numbers between one(1) and ten(10).");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Input number { i + 1 }: ");
                int number;
                Int32.TryParse(Console.ReadLine(), out number);
                numbers[i] = number;
            }

            Console.Write("Your numbers are:");
            foreach (int number in numbers)
            {
                Console.Write($" {number}");
            }
            Console.WriteLine($". Please input one number from this list.");
            Int32.TryParse(Console.ReadLine(), out selection);

            foreach (int number in numbers)
            {
                if (number == selection)
                {
                    counter++;
                }
            }

            score = selection * counter;

            Console.WriteLine($"Your score is: {score}");
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
