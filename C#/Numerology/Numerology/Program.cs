namespace Numerology
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату в формате ddmmyyyy:");
            ulong number = Convert.ToUInt64(Console.ReadLine());

            int sum;
            do
            {
                sum = 0;
                while (number > 0)
                {
                    sum += (int)(number % 10);  // Добавляет последнюю цифру числа к sum
                    number /= 10;  // Удаляет последнюю цифру из числа.
                }
                number = (ulong)sum; // Подготовка числа для следующего возможного цикла суммирования

            } while (sum > 9); // Повторять, пока сумма не станет однозначной

            Console.WriteLine($"Число судьбы: {sum}");
        }
    }
}