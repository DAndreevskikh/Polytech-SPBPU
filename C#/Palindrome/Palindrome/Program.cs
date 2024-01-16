using System;
namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запрос ввода слова для проверки
            Console.WriteLine("Введите слово для проверки на палиндром:");
            string input = Console.ReadLine();

            // Инициализация переменных для проверки палиндрома
            int start = 0;
            int end = input.Length - 1;
            bool isPalindrome = true;

            // Рекурсивная функция заменена циклом while
            while (start < end)
            {
                // Приведение символов к нижнему регистру для корректного сравнения
                if (Char.ToLower(input[start]) != Char.ToLower(input[end]))
                {
                    isPalindrome = false;
                    break;
                }
                start++;
                end--;
            }

            // Вывод результатов
            Console.WriteLine($"{input} - {isPalindrome}");

            // Запросить закрытие консоли
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}