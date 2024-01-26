using System;
using System.IO;

namespace ListOfFiles
{
    internal class Program
    {
        // Константа для размера отступа
        private const int IndentSize = 4;
        static void Main(string[] args)
        {
            Console.WriteLine("Программа выводит список подпапок и файлов в заданной папке.");
            Console.Write("Введите имя папки: ");
            string directoryPath = Console.ReadLine();

            if (Directory.Exists(directoryPath))
            {
                DisplayFilesInDirectory(directoryPath, 0);
            }
            else
            {
                Console.WriteLine("Указанной папки не существует. Проверьте введенный путь и попробуйте снова.");
            }
        }

        static void DisplayFilesInDirectory(string path, int indentLevel)
        {
            string indent = new string(' ', indentLevel * IndentSize); // Создаем строку для отступа

            try
            {
                // Выводим все файлы в текущей папке
                var filesEnumerator = Directory.EnumerateFiles(path).GetEnumerator();
                while (filesEnumerator.MoveNext())
                {
                    Console.WriteLine($"{indent}├── {Path.GetFileName(filesEnumerator.Current)}");
                }

                // Выводим все подпапки и рекурсивно их содержимое
                var directoriesEnumerator = Directory.EnumerateDirectories(path).GetEnumerator();
                while (directoriesEnumerator.MoveNext())
                {
                    string currentDirectory = directoriesEnumerator.Current;
                    string dirName = Path.GetFileName(currentDirectory);
                    Console.ForegroundColor = ConsoleColor.Yellow; // Устанавливаем цвет текста для папок
                    Console.WriteLine($"{indent}└── [{dirName}]");
                    Console.ResetColor(); // Сбрасываем цвет текста
                    DisplayFilesInDirectory(currentDirectory, indentLevel + 1);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Вывод сообщения об ошибке доступа с сохранением отступа и форматирования
                Console.WriteLine($"{indent}└── Доступ к папке '{Path.GetFileName(path)}' запрещен.");
            }
        }
    }
}