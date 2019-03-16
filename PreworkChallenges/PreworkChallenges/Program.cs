using System;

namespace PreworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge 1: Array Max Result:");
            ArrayMaxResult();
            Console.WriteLine("Challenge 2: Leap Year Calculator:");
            LeapYearCalculator();
            Console.WriteLine("Challenge 3: Perfect Sequence:");
            PerfectSequence();
            Console.WriteLine("Challenge 4: Sum of Rows:");
            SumOfRows();
        }

        private static void ArrayMaxResult()
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
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

        }

        private static void LeapYearCalculator()
        {
            int year;

            Console.Write("Please input a year: ");
            Int32.TryParse(Console.ReadLine(), out year);

            if(year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        Console.WriteLine($"{year} IS a Leap Year.");
                    }

                    else
                    {
                        Console.WriteLine($"{year} is NOT a Leap Year.");
                    }
                }

                else
                {
                    Console.WriteLine($"{year} IS a Leap Year.");
                }
            }

            else
            {
                Console.WriteLine($"{year} is NOT a Leap Year.");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

        private static void PerfectSequence()
        {
            int n;
            int sum = 0;
            int product = 1;

            Console.Write("Please input the length of the array: ");
            Int32.TryParse(Console.ReadLine(), out n);

            int[] test = new int[n];

            Console.WriteLine($"Please input {test.Length} numbers:");
            for(int i = 0; i<test.Length; i++)
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

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

        private static void SumOfRows()
        {
            int m;
            int n;

            Console.Write("Input the number of rows in the matrix: ");
            Int32.TryParse(Console.ReadLine(), out m);

            Console.Write("Input the number of columns in the matrix: ");
            Int32.TryParse(Console.ReadLine(), out n);

            int[,] sumArray = new int[m, n];
            int[] results = new int[m];

            for(int i = 0; i<sumArray.GetLength(0); i++)
            {
                int value = 0;

                for (int j = 0; j<sumArray.GetLength(1); j++)
                {
                    sumArray[i, j] = GetRandomNumber();
                    value += sumArray[i, j];
                }

                results[i] = value;
            }

            Console.WriteLine("[{0}]", string.Join(", ", results));
            Console.WriteLine("Press Enter to exit.");
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
