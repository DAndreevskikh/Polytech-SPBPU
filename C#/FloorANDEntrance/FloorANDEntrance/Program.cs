using System;

namespace FloorANDEntrance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер квартиры: ");
            if (!short.TryParse(Console.ReadLine(), out short apartment) || apartment < 1)
            {
                Console.WriteLine("Ошибка ввода.");
                return;
            }

            Console.Write("Сколько этажей в доме?: ");
            if (!short.TryParse(Console.ReadLine(), out short floor) || floor < 1)
            {
                Console.WriteLine("Ошибка ввода.");
                return;
            }

            Console.Write("Сколько квартир на этаже?: ");
            if (!short.TryParse(Console.ReadLine(), out short landing) || landing < 1)
            {
                Console.WriteLine("Ошибка ввода.");
                return;
            }

            // Определяем общее количество квартир в подъезде
            int apartmentsPerEntrance = floor * landing;

            // Определяем номер подъезда
            int entranceNumber = (apartment - 1) / apartmentsPerEntrance + 1;

            // Определяем номер этажа
            int apartmentPosition = (apartment - 1) % apartmentsPerEntrance;
            int floorNumber = apartmentPosition / landing + 1;

            Console.WriteLine($"Квартира находится:\n" +
                              $"В {entranceNumber} подъезде.\n" +
                              $"И на {floorNumber} этаже.");
        }
    }
}
