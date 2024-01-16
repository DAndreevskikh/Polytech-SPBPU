using System;
using System.Globalization;

namespace Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры коробки (a1, b1, c1) и почтового ящика (a2, b2, c2):");

            if (!double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double a1) || a1 <= 0)
            {
                Console.WriteLine("Неверный ввод для a1");
                return;
            }

            if (!double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double b1) || b1 <= 0)
            {
                Console.WriteLine("Неверный ввод для b1");
                return;
            }

            if (!double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double c1) || c1 <= 0)
            {
                Console.WriteLine("Неверный ввод для c1");
                return;
            }

            if (!double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double a2) || a2 <= 0)
            {
                Console.WriteLine("Неверный ввод для a2");
                return;
            }

            if (!double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double b2) || b2 <= 0)
            {
                Console.WriteLine("Неверный ввод для b2");
                return;
            }

            if (!double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double c2) || c2 <= 0)
            {
                Console.WriteLine("Неверный ввод для c2");
                return;
            }

            if ((a1 <= a2 && b1 <= b2 && c1 <= c2) ||
                (a1 <= a2 && b1 <= c2 && c1 <= b2) ||
                (a1 <= b2 && b1 <= a2 && c1 <= c2) ||
                (a1 <= b2 && b1 <= c2 && c1 <= a2) ||
                (a1 <= c2 && b1 <= a2 && c1 <= b2) ||
                (a1 <= c2 && b1 <= b2 && c1 <= a2))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
