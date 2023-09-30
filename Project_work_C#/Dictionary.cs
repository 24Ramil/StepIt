using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dictionary
{
    using DictonaryEntry;
    internal class Dictionary
    {
        public string Language { get; private set; }
        private List<DictonaryEntry> entries;
        
        public Dictionary(string language)
        {
            Language = language;
            entries = new List<DictonaryEntry>();
        }
        
        public void AddEntry(string word, List<string> translations)
        {
            entries.Add(new DictonaryEntry { Word = word, Translations = translations });
        }
        
        public bool RemoveEntry(string word)
        {
            var entry = entries.FirstOrDefault(e => e.Word == word);
            if (entry != null)
            {
                entries.Remove(entry);
                return true;
            }
            return false;
        }
        
        public bool UpdateEntry(string word, List<string> newTranslations)
        {
            var entry = entries.FirstOrDefault(e => e.Word == word);
            if (entry != null)
            {
                entry.Translations = newTranslations;
                return true;
            }
            return false;
        }
        
        public List<DictonaryEntry> Search(string word)
        {
            return entries.Where(e => e.Word == word).ToList();
        }
        
        public void ExportToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var entry in entries)
                {
                writer.WriteLine(entry.Word + ": " + string.Join(", ", entry.Translations));
                }
            }
        }
    }

}
