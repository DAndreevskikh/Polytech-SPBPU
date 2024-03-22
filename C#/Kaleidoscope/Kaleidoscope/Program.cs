namespace Kaleidoscope
{
    internal class Program
    {
        private static int[] colors = { 0, 8, 7, 15, 14, 6, 12, 4, 5, 13, 11, 3, 9, 1, 2, 10 };
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер калейдоскопа (от 3 до 20): ");
            int size = Convert.ToInt32(Console.ReadLine());
            if (size < 3 || size > 20)
            {
                Console.WriteLine("Размер вне допустимого диапазона.");
                return;
            }
            size *= 2;
            int[,] kaleidoscope = new int[size, size];
            GenerateKaleidoscope(kaleidoscope, size);
            PrintKaleidoscope(kaleidoscope, size);
        }

        static void GenerateKaleidoscope(int[,] kaleidoscope, int size)
        {
            Random rnd = new Random();
            int halfSize = size / 2;
            int previousColorIndex = rnd.Next(colors.Length); // Инициализация индекса предыдущего цвета
            for (int i = 0; i < halfSize; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    int nextColorIndex;
                    do
                    {
                        nextColorIndex = rnd.Next(colors.Length); // Выбор следующего индекса цвета
                    }
                    while (Math.Abs(nextColorIndex - previousColorIndex) > 2 || nextColorIndex == previousColorIndex);

                    int color = colors[nextColorIndex]; // Получаем цвет по индексу

                    // Заполняем одну четверть и зеркально отображаем на остальные части
                    kaleidoscope[i, j] = color;
                    kaleidoscope[j, i] = color; // Диагональная симметрия

                    kaleidoscope[size - i - 1, j] = color;
                    kaleidoscope[size - j - 1, i] = color;

                    kaleidoscope[i, size - j - 1] = color;
                    kaleidoscope[j, size - i - 1] = color;

                    kaleidoscope[size - i - 1, size - j - 1] = color;
                    kaleidoscope[size - j - 1, size - i - 1] = color;

                    previousColorIndex = nextColorIndex; // Обновляем индекс предыдущего цвета
                }
            }
        }


        static void PrintKaleidoscope(int[,] kaleidoscope, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.ForegroundColor = (ConsoleColor)kaleidoscope[i, j];
                    Console.Write("█");
                }
                Console.WriteLine();
            }
            Console.ResetColor(); // Сброс цвета после вывода
        }

    }
}