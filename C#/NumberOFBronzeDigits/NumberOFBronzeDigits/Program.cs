using System;

namespace NumberOFBronzeDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество квартир в доме: ");
            short apartments;
            if (short.TryParse(Console.ReadLine(), out apartments) && apartments >= 1 && apartments <= 999)
            {
                short num = 0;

                // Для квартир с номерами от 1 до 9 требуется одна цифра на номер
                if (apartments <= 9)
                {
                    num = apartments;
                }
                // Для квартир с номерами от 10 до 99 требуется две цифры на номер
                else if (apartments <= 99)
                {
                    num = (short)(9 + (apartments - 9) * 2);
                }
                // Для квартир с номерами от 100 до 999 требуется три цифры на номер
                else
                {
                    num = (short)(9 + 90 * 2 + (apartments - 99) * 3);
                }

                Console.WriteLine($"Количество бронзовых цифр: {num}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 999.");
            }
        }
    }
}