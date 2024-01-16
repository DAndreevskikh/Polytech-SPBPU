using System;
namespace PointInATriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод координат вершин треугольника и точки пользователем
            Console.WriteLine("Введите координаты первой вершины треугольника (x1 y1):");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты второй вершины треугольника (x2 y2):");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты третьей вершины треугольника (x3 y3):");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки для проверки (px py):");
            double px = Convert.ToDouble(Console.ReadLine());
            double py = Convert.ToDouble(Console.ReadLine());

            // Вызов функции для проверки принадлежности точки треугольнику и вывод результата
            string result = CheckPointInTriangle(x1, y1, x2, y2, x3, y3, px, py);
            Console.WriteLine(result);
        }

        // Функция для проверки принадлежности точки треугольнику и возврата соответствующего сообщения
        static string CheckPointInTriangle(double x1, double y1, double x2, double y2, double x3, double y3, double px, double py)
        {
            // Проверка, образуют ли заданные точки треугольник
            if (!IsTriangle(x1, y1, x2, y2, x3, y3))
            {
                return "Введенные точки не образуют треугольник.";
            }

            // Проверка, лежит ли точка внутри треугольника
            return IsPointInsideTriangle(x1, y1, x2, y2, x3, y3, px, py) ? "Точка внутри треугольника." : "Точка вне треугольника.";
        }

        // Функция для определения, образуют ли заданные точки треугольник
        static bool IsTriangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // Вычисление условия неколлинеарности точек (проверка, что точки не лежат на одной прямой)
            return (x1 - x2) * (y1 - y3) != (x1 - x3) * (y1 - y2);
        }

        // Функция для определения, лежит ли точка внутри треугольника
        static bool IsPointInsideTriangle(double x1, double y1, double x2, double y2, double x3, double y3, double px, double py)
        {
            // Вычисление положения точки относительно каждой стороны треугольника
            double d1 = Sign(px, py, x1, y1, x2, y2);
            double d2 = Sign(px, py, x2, y2, x3, y3);
            double d3 = Sign(px, py, x3, y3, x1, y1);

            // Проверка, находится ли точка с одной стороны от всех сторон треугольника
            bool has_neg = (d1 < 0) || (d2 < 0) || (d3 < 0);
            bool has_pos = (d1 > 0) || (d2 > 0) || (d3 > 0);

            // Дополнительная проверка на близость точки к границе треугольника с учетом допуска
            bool isNearBoundary = Math.Abs(d1) < 0.0001 || Math.Abs(d2) < 0.0001 || Math.Abs(d3) < 0.0001;

            return !(has_neg && has_pos) || isNearBoundary;
        }

        // Функция для вычисления положения точки относительно прямой, образованной двумя другими точками
        static double Sign(double px, double py, double x1, double y1, double x2, double y2)
        {
            // Возвращается положительное значение, если точка находится с одной стороны от прямой,
            // отрицательное - с другой, и ноль, если точка находится на прямой
            return (px - x2) * (y1 - y2) - (x1 - x2) * (py - y2);
        }
    }
}