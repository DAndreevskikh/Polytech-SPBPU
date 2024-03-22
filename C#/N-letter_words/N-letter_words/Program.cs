using System;

namespace N_letter_words
{
    internal class Program
    {
        static readonly string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        static void Main(string[] args)
        {
            Console.Write("Введите M (<=33) и N: ");
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Решение с рекурсией:");
            GenerateWordsRecursive("", N, M);

            Console.WriteLine("\nРешение без рекурсии:");
            GenerateWordsIterative(N, M);
        }

        static void GenerateWordsRecursive(string prefix, int length, int maxLetter)
        {
            if (length == 0)
            {
                Console.WriteLine(prefix);
            }
            else
            {
                for (int i = 0; i < maxLetter; i++)
                {
                    GenerateWordsRecursive(prefix + alphabet[i], length - 1, maxLetter);
                }
            }
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


