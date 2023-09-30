using System;
using System.Collections.Generic;
using System.Formats.Asn1;


namespace _DictionaryManager
{
    using Dictionary;
    using CsvHelper;
    using CsvHelper.Configuration;
    using System.Collections;
    using System.Xml;

    internal class DictionaryManager
    {
        private List<Dictionary> dictionaries;
        public DictionaryManager()
        {
            dictionaries = new List<Dictionary>();
        }

        public void CreateDictionary()
        {
            Console.Write("Enter the language of the dictionary: ");
            string language = Console.ReadLine();
            dictionaries.Add(new Dictionary(language));
            Console.WriteLine("Dictionary created.");
        }

        public void AddWordAndTranslation()
        {
            Console.Write("Enter the language of the dictionary: ");
            string language = Console.ReadLine();
            var dictionary = dictionaries.FirstOrDefault(d => d.Language == language);
            if (dictionary == null)
            {
                Console.WriteLine("Dictionary not found.");
                return;
            }

            Console.Write("Enter the word: ");
            string word = Console.ReadLine();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Enter translation(s), separating them with a comma: ");

            List<string> translations = Console.ReadLine().Split(',').Select(t => t.Trim()).ToList();

            dictionary.AddEntry(word, translations);
            Console.WriteLine("Word and translation(s) added to the dictionary.");
        }

        public void UpdateWordOrTranslation()
        {
            Console.Write("Enter the language of the dictionary: ");
            string language = Console.ReadLine();
            var dictionary = dictionaries.FirstOrDefault(d => d.Language == language);
            if (dictionary == null)
            {
                Console.WriteLine("Dictionary not found.");
                return;
            }

            Console.Write("Enter the word you want to update: ");
            string word = Console.ReadLine();
            Console.Write("Enter new translation(s), separating them with a comma: ");
            List<string> newTranslations = Console.ReadLine().Split(',').Select(t => t.Trim()).ToList();

            if (dictionary.UpdateEntry(word, newTranslations))
            {
                Console.WriteLine("Word or translation(s) updated.");
            }
            else
            {
                Console.WriteLine("Word not found in the dictionary.");
            }
        }

        public void RemoveWordOrTranslation()
        {
            Console.Write("Enter the language of the dictionary: ");
            string language = Console.ReadLine();
            var dictionary = dictionaries.FirstOrDefault(d => d.Language == language);
            if (dictionary == null)
            {
                Console.WriteLine("Dictionary not found.");
                return;
            }

            Console.Write("Enter the word you want to remove: ");
            string word = Console.ReadLine();

            if (dictionary.RemoveEntry(word))
            {
                Console.WriteLine("Word or translation(s) removed.");
            }
            else
            {
                Console.WriteLine("Word not found in the dictionary.");
            }
        }

        public void SearchTranslation()
        {
            Console.Write("Enter the language of the dictionary: ");
            string language = Console.ReadLine();
            var dictionary = dictionaries.FirstOrDefault(d => d.Language == language);
            if (dictionary == null)
            {
                Console.WriteLine("Dictionary not found.");
                return;
            }

            Console.Write("Enter a word to search for its translation: ");
            string word = Console.ReadLine();

            var results = dictionary.Search(word);
            if (results.Any())
            {
                Console.WriteLine("Search results:");
                foreach (var entry in results)
                {
                    Console.WriteLine($"{entry.Word}: {string.Join(", ", entry.Translations)}");
                }
            }
            else
            {
                Console.WriteLine("Translation not found.");
            }
        }

        public void ExportDictionary()
        {
            Console.Write("Enter the language of the dictionary: ");
            string language = Console.ReadLine();
            var dictionary = dictionaries.FirstOrDefault(d => d.Language == language);
            if (dictionary == null)
            {
                Console.WriteLine("Dictionary not found.");
                return;
            }

            Console.Write("Enter a file name for export: ");
            string fileName = Console.ReadLine();
            string filePath = $"{fileName}.csv";

            dictionary.ExportToFile(filePath);

            Console.WriteLine($"Dictionary exported to the CSV file {filePath}.");
        }
    }
}
