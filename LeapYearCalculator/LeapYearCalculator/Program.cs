using System;

namespace LeapYearCalculator
{
    class Program
    {
        static void Main(string[] args)
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

            Console.ReadLine();
        }
    }
}
