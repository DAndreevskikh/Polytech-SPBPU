namespace VowelOrConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            char symbol = Char.ToLower(Convert.ToChar(Console.ReadLine()));

            if (symbol >= 'а' && symbol <= 'я')
            {
                switch (symbol)
                {
                    case 'а':
                    case 'е':
                    case 'и':
                    case 'о':
                    case 'у':
                    case 'э':
                    case 'ю':
                    case 'я':
                        Console.WriteLine("Гласная буква");
                        break;
                    default:
                        Console.WriteLine("Согласная буква");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}