using System;

namespace ClockFace_0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите значение угла: ");
            string input = Console.ReadLine();

            double h_angle;
            if (double.TryParse(input, out h_angle) && h_angle >= 0 && h_angle < 360)
            {
                //Учитываем, что полный оборот (360 градусов) часовой стрелки соответствует 12 часам.
                //Вычислим, сколько часов(в долях) показывает часовая стрелка, (так как 360 градусов / 12 часов = 30 градусов на час).
                double hours = h_angle / 30;
                //Определите, сколько минут прошло с начала часа, умножив полученное количество часов на 60.
                double minutes = (hours - Math.Floor(hours)) * 60;
                //Полный оборот минутной стрелки (360 градусов) соответствует 60 минутам.
                //Вычислим угол минутной стрелки, умножив количество прошедших минут на 6(так как 360 градусов / 60 минут = 6 градусов на минуту).
                double m_angle = minutes * 6;
                //Округляем до 2х знаков после запятой.
                m_angle = Math.Round(m_angle, 2);

                Console.WriteLine(m_angle);
            }
            else
            {
                Console.WriteLine("Введите корректное значение.");

            }

        }
    }
}