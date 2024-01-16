using System;

class MathCalculation
{
    static void Main()
    {
        Console.Write("Введите значение a: ");
        double a;
        // Пробуем конвертировать введенное значение в double
        if (double.TryParse(Console.ReadLine(), out a))
        {
            // Считаем значение под корнем и результат
            double valueUnderRoot = (2 * a + Math.Sin(Math.Abs(3 * a))) / 3.56;
            double x = Math.Sqrt(valueUnderRoot);

            // Выводим результат с округлением до трех знаков после запятой
            Console.WriteLine("Результат x: " + Math.Round(x, 3));
        }
        else
        {
            // Если введенное значение не является числом, сообщаем об ошибке
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
        }
    }
}
