using System;

namespace SectionsInTheConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Выводим запрос на ввод данных
            Console.WriteLine("Введите значения общей ширины и сегмента, разделенные пробелами:");
            string input = Console.ReadLine() + " "; // Добавляем пробел в конец строки для обозначения конца ввода
            string segment = "";
            int totalWidth = 0, sumOfSegments = 0;
            int segmentWidth1 = 0, segmentWidth2 = 0, segmentWidth3 = 0;
            bool isFirstNumber = true;
            int segmentCount = 0, currentNumber;

            // Перебираем весь ввод, чтобы разбить его на числа
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    currentNumber = int.Parse(segment); // Преобразуем накопленную строку в число
                    segment = ""; // Очищаем строку для следующего числа
                    if (isFirstNumber)
                    {
                        // Первое число - общая ширина
                        totalWidth = currentNumber;
                        isFirstNumber = false;
                    }
                    else
                    {
                        // Добавляем значение сегмента к общей сумме
                        sumOfSegments += currentNumber;
                        // Запоминаем ширину каждого сегмента
                        if (segmentCount == 0) segmentWidth1 = currentNumber;
                        else if (segmentCount == 1) segmentWidth2 = currentNumber;
                        else if (segmentCount == 2) segmentWidth3 = currentNumber;
                        segmentCount++;
                    }
                }
                else
                {
                    // Строим строку с числом
                    segment += input[i];
                }
            }
            // Рассчитываем ширину одного символа
            double unitWidth = (double)(totalWidth - segmentCount + 1) / sumOfSegments;
            // Округляем ширину каждого сегмента
            int roundedSegmentWidth1 = segmentCount > 0 ? (int)Math.Round(segmentWidth1 * unitWidth) : 0;
            int roundedSegmentWidth2 = segmentCount > 1 ? (int)Math.Round(segmentWidth2 * unitWidth) : 0;
            int roundedSegmentWidth3 = segmentCount > 2 ? (int)Math.Round(segmentWidth3 * unitWidth) : 0;

            // Проверяем, достаточно ли места для каждого сегмента
            if ((segmentCount > 0 && roundedSegmentWidth1 < 1) ||
                (segmentCount > 1 && roundedSegmentWidth2 < 1) ||
                (segmentCount > 2 && roundedSegmentWidth3 < 1))
            {
                Console.WriteLine("Error!");
                return;
            }

            // Рисуем сегменты
            if (segmentCount >= 1) Console.Write(new String('-', roundedSegmentWidth1));
            if (segmentCount >= 2) Console.Write("|" + new String('-', roundedSegmentWidth2));
            if (segmentCount >= 3) Console.Write("|" + new String('-', roundedSegmentWidth3));

            Console.WriteLine();
        }
    }
}
