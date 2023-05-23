using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class FileModerator
    {
        public static void FileModeratorFunc(string[] args)
        {
            Console.WriteLine("Введіть шлях до файлу з текстом:");
            string textFilePath = Console.ReadLine();

            Console.WriteLine("Введіть шлях до файлу зі словами для модерації:");
            string moderationFilePath = Console.ReadLine();

            try
            {
                string text = File.ReadAllText(textFilePath);
                string[] wordsForModeration = File.ReadAllLines(moderationFilePath);

                foreach (string word in wordsForModeration)
                {
                    string replacement = new string('*', word.Length);
                    text = text.Replace(word, replacement);
                }

                File.WriteAllText(textFilePath, text);

                Console.WriteLine("Модерація успішно завершена.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка при роботі з файлом: " + ex.Message);
            }
        }
    }
}
