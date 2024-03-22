using System;

namespace N_letter_words_No_recursion_
{
    internal class Program
    {
        static readonly string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        static void Main(string[] args)
        {
            Console.Write("Введите M (<=33) и N: ");
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Вывод:");
            GenerateWordsIterative(N, M);
        }

        static void GenerateWordsIterative(int length, int maxLetter)
        {
            int[] positions = new int[length];
            while (true)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(alphabet[positions[i]]);
                }
                Console.WriteLine();

                int currentPosition = length - 1;
                while (currentPosition >= 0 && ++positions[currentPosition] == maxLetter)
                {
                    positions[currentPosition] = 0;
                    currentPosition--;
                }

                if (currentPosition < 0) break;
            }
        }
    }
}
