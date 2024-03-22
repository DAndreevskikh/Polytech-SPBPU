using System;
namespace Best_teacher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] arrMarks = {
            {3.6, 3.1, 2.8, 1, 4, 3.3, 3.2, 3},
            {3.5, 3.6, 4.1, 3.9, 3.5, 5, 4, 5},
            {2.2, 2.7, 3.1, 3, 4.5, 2.2, 3.1, 3.7},
            {4.2, 3.4, 3, 4.3, 4.1, 4.6, 4.4, 4.5},
            {4.7, 4.1, 3.6, 2.1, 2.7, 2, 2.5, 2.7}
        };

            var result = FindBestTeacher(arrMarks);
            Console.WriteLine($"Лучший преподаватель: {result.Item1}, Средний балл: {result.Item2:F2}");
        }

        static Tuple<int, double> FindBestTeacher(double[,] marks)
        {
            int bestTeacherIndex = -1;
            double highestAverage = 0.0;
            int n = marks.GetLength(0); // Количество преподавателей
            int m = marks.GetLength(1); // Количество студентов

            for (int i = 0; i < n; i++)
            {
                double minMark = 5.0;
                double maxMark = 0.0;
                double sum = 0.0;

                for (int j = 0; j < m; j++)
                {
                    double mark = marks[i, j];
                    sum += mark;
                    if (mark < minMark) minMark = mark;
                    if (mark > maxMark) maxMark = mark;
                }

                // Вычитаем минимальную и максимальную оценку и уменьшаем количество оценок на 2
                double average = (sum - minMark - maxMark) / (m - 2);

                if (average > highestAverage)
                {
                    highestAverage = average;
                    bestTeacherIndex = i;
                }
            }

            return Tuple.Create(bestTeacherIndex, highestAverage);
        }
    }
}