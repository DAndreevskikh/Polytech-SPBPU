using System;
namespace Rhombus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество рядов (M):");
            int rowsCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество колонок (N):");
            int columnsCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту половины ромба (K):");
            int halfRhombusHeight = int.Parse(Console.ReadLine());

            for (int m = 0; m < rowsCount; m++)
            {
                // Верхняя часть ромба
                for (int k = 1; k <= halfRhombusHeight; k++)
                {
                    for (int n = 0; n < columnsCount; n++)
                    {
                        // Отступы перед началом ромба
                        for (int space = 0; space < halfRhombusHeight - k; space++)
                            Console.Write(" ");

                        // Символы ромба
                        for (int symbol = 0; symbol < (2 * k - 1); symbol++)
                            Console.Write("@");

                        // Отступы после ромба
                        for (int space = 0; space < halfRhombusHeight - k; space++)
                            Console.Write(" ");

                        // Пробел между ромбами в ряду, кроме последнего ромба
                        if (n < columnsCount - 1)
                            Console.Write(" ");
                    }

                    Console.WriteLine();
                }

                // Нижняя часть ромба (зеркальное отражение верхней части)
                for (int k = halfRhombusHeight - 1; k >= 1; k--)
                {
                    for (int n = 0; n < columnsCount; n++)
                    {
                        // Отступы перед началом ромба
                        for (int space = 0; space < halfRhombusHeight - k; space++)
                            Console.Write(" ");

                        // Символы ромба
                        for (int symbol = 0; symbol < (2 * k - 1); symbol++)
                            Console.Write("@");

                        // Отступы после ромба
                        for (int space = 0; space < halfRhombusHeight - k; space++)
                            Console.Write(" ");

                        // Пробел между ромбами в ряду, кроме последнего ромба
                        if (n < columnsCount - 1)
                            Console.Write(" ");
                    }

                    Console.WriteLine();
                }

                // Пробелы между рядами ромбов, кроме последнего ряда
                if (m < rowsCount - 1)
                    Console.WriteLine();
            }
        }
    }
}
