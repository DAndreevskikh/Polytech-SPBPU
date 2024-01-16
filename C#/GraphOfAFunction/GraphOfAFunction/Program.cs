using System;
using System.Globalization;

namespace GraphOfAFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            string input = Console.ReadLine().Replace(',', '.'); // Замена запятой на точку для корректного парсинга

            if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double x))
            {
                // Приведение x к основному периоду от -2 до 2
                x = (x % 2 + 2) % 2;
                if (x > 1) x -= 2;

                // Вычисление значения функции в зависимости от сегмента
                double result = x >= -1 ? -x - 1 : x + 2;

                // Вывод результата
                Console.WriteLine($"вход={input}, результат={result:F1}".Replace('.', ','));
            }
            else
            {
                Console.WriteLine("Введено не числовое значение. Пожалуйста, введите число.");
            }
        }
    }
}
 