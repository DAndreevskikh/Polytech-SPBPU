using System;
namespace While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, count = 0, number;

            Console.WriteLine("Введите целые числа (0 для завершения):");

            while (true)
            {
                number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }

                sum += number;
                count++;
            }

            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine("Среднее арифметическое введенных чисел: " + average);
            }
            else
            {
                Console.WriteLine("Числа не были введены.");
            }
        }
    }
  }