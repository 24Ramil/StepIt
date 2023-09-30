using _DictionaryManager;


DictionaryManager dictionaryManager = new DictionaryManager();
while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Create Dictionary");
    Console.WriteLine("2. Add Word and Translation to Dictionary");
    Console.WriteLine("3. Update Word or Translation in Dictionary");
    Console.WriteLine("4. Remove Word or Translation from Dictionary");
    Console.WriteLine("5. Search for Word Translation");
    Console.WriteLine("6. Export Dictionary to File");
    Console.WriteLine("7. Exit");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            dictionaryManager.CreateDictionary();
            break;
        case 2:
            dictionaryManager.AddWordAndTranslation();
            break;
        case 3:
            dictionaryManager.UpdateWordOrTranslation();
            break;
        case 4:
            dictionaryManager.RemoveWordOrTranslation();
            break;
        case 5:
            dictionaryManager.SearchTranslation();
            break;
        case 6:
            dictionaryManager.ExportDictionary();
            break;
        case 7:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}

