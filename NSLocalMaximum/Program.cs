using System;

namespace NSLocalMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[30];
            int randomMin = 0;
            int randomMax = 10;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(randomMin, randomMax);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0 && numbers[i] > numbers[i + 1])
                {
                    Console.Write(numbers[i] + " ");
                }

                if (i > 0 && i < numbers.Length - 1)
                {
                    if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }

                if (i == numbers.Length - 1 && numbers[i] > numbers[i - 1])
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}