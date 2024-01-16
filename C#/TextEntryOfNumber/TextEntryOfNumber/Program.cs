using System;
namespace TextEntryOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ВХОД: ");
            if (!byte.TryParse(Console.ReadLine(), out byte number) || number < 1 || number > 99)
            {
                Console.WriteLine("Введено некорректное значение.");
                return;
            }

            string result = "";
            switch (number)
            {
                case < 20:
                    switch (number)
                    {
                        case 1: result = "один"; break;
                        case 2: result = "два"; break;
                        case 3: result = "три"; break;
                        case 4: result = "четыре"; break;
                        case 5: result = "пять"; break;
                        case 6: result = "шесть"; break;
                        case 7: result = "семь"; break;
                        case 8: result = "восемь"; break;
                        case 9: result = "девять"; break;
                        case 10: result = "десять"; break;
                        case 11: result = "одиннадцать"; break;
                        case 12: result = "двенадцать"; break;
                        case 13: result = "тринадцать"; break;
                        case 14: result = "четырнадцать"; break;
                        case 15: result = "пятнадцать"; break;
                        case 16: result = "шестнадцать"; break;
                        case 17: result = "семнадцать"; break;
                        case 18: result = "восемнадцать"; break;
                        case 19: result = "девятнадцать"; break;
                    }
                    break;
                default:
                    switch (number / 10)
                    {
                        case 2: result = "двадцать"; break;
                        case 3: result = "тридцать"; break;
                        case 4: result = "сорок"; break;
                        case 5: result = "пятьдесят"; break;
                        case 6: result = "шестьдесят"; break;
                        case 7: result = "семьдесят"; break;
                        case 8: result = "восемьдесят"; break;
                        case 9: result = "девяносто"; break;
                    }
                    switch (number % 10)
                    {
                        case 1: result += " один"; break;
                        case 2: result += " два"; break;
                        case 3: result += " три"; break;
                        case 4: result += " четыре"; break;
                        case 5: result += " пять"; break;
                        case 6: result += " шесть"; break;
                        case 7: result += " семь"; break;
                        case 8: result += " восемь"; break;
                        case 9: result += " девять"; break;
                    }
                    break;
            }

            Console.Write("ВЫХОД: " + result);
        }
    }
}