using System;
namespace CalculatingTrigonometricFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод угла в радианах и точности вычисления
            Console.WriteLine("Введите угол x в радианах:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите точность e:");
            double e = Convert.ToDouble(Console.ReadLine());

            double cos = 1.0; // Начальное значение косинуса
            double term = 1.0; // Первый член ряда
            int iteration = 0; // Счетчик итераций

            // Вычисление косинуса с заданной точностью и минимум три итерации
            while (Math.Abs(term) > e || iteration < 3)
            {
                iteration++;
                term *= -1 * x * x / (2 * iteration * (2 * iteration - 1));
                cos += term;
            }

            Console.WriteLine($"Косинус угла {x} радиан с точностью {e} равен {cos}");
        }
    }
}