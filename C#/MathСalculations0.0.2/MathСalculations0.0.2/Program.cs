using System;

namespace MathСalculations0._0._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запрос ввода от пользователя
            Console.Write("Введите значение a: ");
            bool isADouble = double.TryParse(Console.ReadLine(), out double a);

            Console.Write("Введите значение b: ");
            bool isBDouble = double.TryParse(Console.ReadLine(), out double b);

            if (isADouble && isBDouble)
            {
                // Вычислить выражения и сохранить их в переменных
                double numerator = (2 / ((Math.Pow(a, 2)) + 25)) + b;
                double denominator = Math.Sqrt(b) + ((a + b) / 2);
                double x = numerator / denominator;

                //Вывести результат
                Console.WriteLine($"Результат: {Math.Round(x, 3)}");
            }
            else
            {
                // Сообщение об ошибке при неверном вводе
                Console.WriteLine("Неверный ввод. Пожалуйста, введите числовое значение."); 
            }
        }
    }
}