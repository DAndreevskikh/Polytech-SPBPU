using System;
namespace TheComputerGuessesTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение M:");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество шагов:");
            int steps = Convert.ToInt32(Console.ReadLine());

            // Функция для применения операций к N
            Func<int, int, int> ApplyOperations = null;
            ApplyOperations = (N, remainingSteps) =>
            {
                if (remainingSteps == 0) return N;
                return ApplyOperations(N % 2 == 0 ? N / 2 : N + 3, remainingSteps - 1);
            };

            // Функция для поиска возможных начальных значений N
            List<int> possibleNs = new List<int>();
            for (int N = 1; N < 1000; N += 2) // Предполагаем, что N всегда нечетное
            {
                if (ApplyOperations(N, steps) == M)
                {
                    possibleNs.Add(N);
                }
            }

            // Вывод возможных значений N
            Console.WriteLine("Возможные значения N для заданного M и количества шагов:");
            for (int i = 0; i < possibleNs.Count; i++)
            {
                Console.WriteLine(possibleNs[i]);
            }
        }
    }
}