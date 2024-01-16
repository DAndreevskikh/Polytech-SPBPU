namespace EconomClassTrain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер места: ");
            byte placeNumber = Convert.ToByte(Console.ReadLine());

            // Определяем купе ('к') или боковушку ('б')
            char placeType = placeNumber <= 36 ? 'к' : 'б';

            // Определяем уровень места: верхнее ('в') или нижнее ('н')
            // Для купейных мест верхние места - четные, для боковушек - нечетные
            char level = (placeNumber % 2 == 0) ? (placeType == 'к' ? 'в' : 'в') : (placeType == 'к' ? 'н' : 'н');

            // Вычисляем номер блока для купейных и боковых мест
            // Для купейных мест блоки идут по порядку, для боковушек - в обратном
            byte blockNumber = placeType == 'к'
                ? (byte)((placeNumber - 1) / 4 + 1)
                : (byte)(9 - (placeNumber - 37) / 2);

            // Выводим результат
            Console.WriteLine($"{blockNumber}{placeType}{level}");
        }
    }
}
