using System;
namespace BigClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largestCount = 0;
            int largestClass = 0;
            int largestSchool = 0;
            int currentCount = 0;
            int currentClass = 0, currentSchool = 0;

            while (true)
            {
                Console.WriteLine("Введите номер класса: ");
                string classInput = Console.ReadLine();
                if (classInput == "0") break; // Конец ввода, если введено 0

                Console.WriteLine("Введите номер школы: ");
                string schoolInput = Console.ReadLine();
                if (schoolInput == "0") break; // Конец ввода, если введено 0

                int classNumber = int.Parse(classInput);
                int schoolNumber = int.Parse(schoolInput);

                // Если класс и школа совпадают с текущими, увеличиваем счетчик
                if (classNumber == currentClass && schoolNumber == currentSchool)
                {
                    currentCount++;
                }
                else
                {
                    // Если это новый класс, сравниваем его размер с максимальным
                    if (currentCount > largestCount)
                    {
                        largestCount = currentCount;
                        largestClass = currentClass;
                        largestSchool = currentSchool;
                    }

                    // Обновляем текущий класс и школу и счетчик
                    currentClass = classNumber;
                    currentSchool = schoolNumber;
                    currentCount = 1;
                }
            }

            // Проверяем последний класс после окончания цикла
            if (currentCount > largestCount)
            {
                largestCount = currentCount;
                largestClass = currentClass;
                largestSchool = currentSchool;
            }

            Console.WriteLine($"Самый многочисленный класс: {largestClass} класс, школа {largestSchool}, количество учеников: {largestCount}");
        }
    }
}
