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
            int firstIndex = 0;
            int lastIndex = numbers.Length - 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(randomMin, randomMax);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            if (numbers[firstIndex] > numbers[firstIndex + 1])
            {
                Console.Write(numbers[firstIndex] + " ");
            }

            for (int i = 0; i < numbers.Length; i++)
            {             
                if (i > 0 && i < numbers.Length - 1)
                {
                    if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }               
            }

            if (numbers[lastIndex] > numbers[lastIndex - 1])
            {
                Console.Write(numbers[lastIndex] + " ");
            }
        }
    }
}