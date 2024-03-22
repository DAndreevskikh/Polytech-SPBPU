using System;

namespace Processing_Array_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация массива
            int[] array = { 3, -1, 2, -7, -5, 11, 6 };

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            // Вызов функции для перестановки элементов
            RearrangeArray(array);

            Console.WriteLine("Массив после перестановки:");
            PrintArray(array);
        }

        // Функция для перестановки элементов массива
        static void RearrangeArray(int[] array)
        {
            int j = -1;
            for (int i = 0; i < array.Length; i++)
            {
                // Если текущий элемент отрицательный, переместим его в начало массива
                if (array[i] < 0)
                {
                    j++;
                    // Обмен элементов местами
                    Swap(ref array[i], ref array[j]);
                }
            }
        }

        // Вспомогательная функция для обмена значениями между двумя переменными
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // Функция для вывода массива на экран
        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
