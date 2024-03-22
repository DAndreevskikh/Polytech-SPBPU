namespace Attendance_log
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Хранить даннсы о посещаемости учеников (25 человек) за каждый день месяца,
            //по 5и предметам

            //понадобится трёх мерный массив, тип ячеек - bool
            //номер ученика, номер дня, номер предмета.

            bool[,,] school = new bool[25, 31, 5];

            school[4, 28, 1] = true;

        }
    }
}