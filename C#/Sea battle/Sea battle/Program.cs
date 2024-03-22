namespace Sea_battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] battle = new int [10, 10]; //поле 

            //В ячейку массива с координатами. Записываем некое состояние.
            //Вообще состояние лучше закодировать, объявить enumeration. из 4х констант
            // и Указывать одну из констант
            battle[2, 8] = 2;
        }
    }
}