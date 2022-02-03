using System;

namespace Task2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random randon = new Random();
            Console.WriteLine("Enter array size: ");
            int size = Int32.Parse(Console.ReadLine());

            // Array initialization
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randon.Next(0, 100);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            MinMaxElements(array, out int max, out int min);
            Console.WriteLine($"Min = {min}, max = {max}");

            Console.WriteLine($"Sum of array elements = {SumOfArrayElements(array)}");

            double avg = SumOfArrayElements(array) / array.Length;
            Console.WriteLine($"Average value = {avg}");

            OddElements(array);

            static void MinMaxElements(int[] array, out int max, out int min)
            {
                max = array[0];
                min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                        max = array[i];
                    if (array[i] < min)
                        min = array[i];
                }
            }

            static int SumOfArrayElements(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                    sum += array[i];
                return sum;
            }

            static void OddElements(int[] array)
            {
                Console.Write("Odd elements: ");
                for (int i = 0; i < array.Length; i++)
                    if (array[i] %2 != 0)
                        Console.Write($"{array[i]} ");
                Console.WriteLine();
            }
        }
    }
}
