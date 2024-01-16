using System;
namespace DisplayingNumbersOnTheScreen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное целое число N:");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write(i + " ");
                if (i % 10 == 0)  // Каждые 10 чисел переходим на новую строку
                {
                    Console.WriteLine();
                }
            }

            // Для случая, когда N не кратно 10, чтобы курсор не оставался в той же строке
            if (N % 10 != 0)
            {
                Console.WriteLine();
            }
        }
    }
}