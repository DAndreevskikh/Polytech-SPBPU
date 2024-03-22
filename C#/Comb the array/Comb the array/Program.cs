using System;
namespace Comb_the_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = { -6, -2, -3, 0, 6, 1, 3, 11, 11, 14 };
            int[] newArray = PruneArray(originalArray);

            Console.WriteLine("Новый массив:");
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
        }

        static int[] PruneArray(int[] originalArray)
        {
            // Проверка на пустой входной массив
            if (originalArray.Length == 0) return new int[0];

            int[] tempArray = new int[originalArray.Length];
            int validCount = 1;
            tempArray[0] = originalArray[0];

            for (int i = 1; i < originalArray.Length; i++)
            {
                // Проверяем, чтобы текущий элемент был больше или
                // равен предыдущему добавленному в tempArray
                if (originalArray[i] >= tempArray[validCount - 1])
                {
                    tempArray[validCount++] = originalArray[i];
                }
            }

            // Создаем итоговый массив точного размера
            int[] resultArray = new int[validCount];
            Array.Copy(tempArray, resultArray, validCount);

            return resultArray;
        }
    }
}
