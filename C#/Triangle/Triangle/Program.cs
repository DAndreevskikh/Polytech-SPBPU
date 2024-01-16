namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Введите число a: ");
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Неверный ввод.");
            }
            Console.Write("Введите число b: ");
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Неверный ввод.");
            }
            Console.Write("Введите число c: ");
            if (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Неверный ввод.");
            }

            Console.Write($"ВХОД: a={a}, b={b},c={c} ");

            if ((c < a + b) && (a < c + b) && (b < a + c))
            {
                Console.Write("ВЫХОД: YES");
            }
            else { 
                Console.Write("ВЫХОД: NO");
            }
        }
    }
}