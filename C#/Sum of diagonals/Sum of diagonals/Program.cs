//namespace Sum_of_diagonals

//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,,] arrZ = {
//            { { 23, 6, 2 }, { 4, 8, 19 }, { 10, 77, 15 } },
//            { { 33, 21, 53 }, { 10, 1, 97 }, { 49, 3, 42 } },
//            { { 99, 32, 55 }, { 71, 8, 7 }, { 7, 1, 8 } }
//        };

//            int sum = SumOfDiagonals(arrZ);
//            Console.WriteLine($"Сумма элементов на диагоналях: {sum}");
//        }

//        static int SumOfDiagonals(int[,,] cube)
//        {
//            int n = cube.GetLength(0);
//            if (cube.GetLength(1) != n || cube.GetLength(2) != n)
//            {
//                throw new ArgumentException("Массив не является кубом");
//            }

//            int sum = 0;

//            for (int i = 0; i < n; i++)
//            {
//                sum += cube[i, i, i]; // Диагональ от (0,0,0) до (N-1,N-1,N-1)
//                sum += cube[i, n - 1 - i, i]; // Диагональ от (0,N-1,0) до (N-1,0,N-1)
//                sum += cube[i, i, n - 1 - i]; // Диагональ от (N-1,N-1,0) до (0,0,N-1)
//                sum += cube[n - 1 - i, i, i]; // Диагональ от (N-1,0,0) до (0,N-1,N-1)
//            }

//            // Убираем повторно добавленные элементы центра, если N нечетно
//            if (n % 2 != 0)
//            {
//                int center = n / 2;
//                sum -= 3 * cube[center, center, center];
//            }

//            return sum;
//        }
//    }
//}

//вариант 2
namespace Sum_of_diagonals

{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[,,] arrX = {
            { { 23, 30, 2, 11 }, { 4, 8, 12, 5 }, { 9, 11, 16, 7 }, { 44, 46, 2, 8 } },
            { { 46, 31, 5, 31 }, { 30, 13, 41, 7 }, { 4, 25, 11, 60 }, { 18, 44, 78, 41 } },
            { { 74, 24, 15, 64 }, { 77, 20, 59, 13 }, { 13, 3, 62, 78 }, { 95, 34, 20, 67 } },
            { { 2, 4, 77, 50 }, { 7, 8, 54, 10 }, { 74, 21, 68, 9 }, { 39, 14, 87, 58 } }
        };

            int sum = SumOfDiagonals(arrX);
            Console.WriteLine($"Сумма элементов на диагоналях: {sum}");
        }

        static int SumOfDiagonals(int[,,] cube)
        {
            int n = cube.GetLength(0);
            if (cube.GetLength(1) != n || cube.GetLength(2) != n)
            {
                throw new ArgumentException("Массив не является кубом");
            }

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += cube[i, i, i];
                sum += cube[i, n - 1 - i, i];
                sum += cube[i, i, n - 1 - i];
                sum += cube[n - 1 - i, i, i];
            }

            // Убираем повторно добавленные элементы центра, если N нечетно
            if (n % 2 != 0)
            {
                int center = n / 2;
                sum -= 3 * cube[center, center, center];
            }

            return sum;
        }
    }
}