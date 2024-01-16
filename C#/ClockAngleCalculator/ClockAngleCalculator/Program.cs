using System;

namespace ClockAngleCalculator
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите часы (0-11): ");
                byte h = byte.Parse(Console.ReadLine());
                Console.Write("Введите минуты (0-59): ");
                byte m = byte.Parse(Console.ReadLine());
                Console.Write("Введите секунды (0-59): ");
                byte s = byte.Parse(Console.ReadLine());

                if ((h >= 0 && h < 12) && (m >= 0 && m < 60) && (s >= 0 && s < 60))
                {
                // Основной угол за каждый час - 30 градусов
                // Каждая минута и секунда добавляет дополнительное смещение к часовой стрелке
                // В течение одного часа (60 минут) часовая стрелка перемещается на 30 градусов.
                // Следовательно, за одну минуту часовая стрелка перемещается на 30/60 = 0,5
                double angle = (h * 30) + (m * 0.5) + (s * (0.5 / 60));  //0.5 градуса - это величина смещения часовой стрелки за одну минуту.

                // Округляем результат до трех знаков после запятой
                angle = Math.Round(angle, 3);

                    Console.WriteLine($"Угол часовой стрелки: {angle} градусов");
                }
                else
                {
                    Console.WriteLine("Введите корректные значения времени.");
                }
            }
        }
    }