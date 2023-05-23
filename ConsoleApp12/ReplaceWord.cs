using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class ReplaceWord
    {
        public static void ReplaceWordFunc(string[] args)
        {
            Console.WriteLine("Введіть слово для пошуку:");
            string wordToFind = Console.ReadLine();

            Console.WriteLine("Введіть слово для заміни:");
            string wordToReplace = Console.ReadLine();

            string filePath = "file.txt"; // Шлях до вашого файлу

            try
            {
                string text = File.ReadAllText(filePath);

                int count = Regex.Matches(text, wordToFind).Count;
                text = text.Replace(wordToFind, wordToReplace);

                File.WriteAllText(filePath, text);

                Console.WriteLine($"Кількість заміненого слова '{wordToFind}': {count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка при роботі з файлом: " + ex.Message);
            }
        }
    }
}
