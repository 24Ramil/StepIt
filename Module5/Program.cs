
//try
//{
//    Journal journal1 = new Journal();
//    Journal journal2 = new Journal();
//    journal1 = journal1 + 1;
//    Console.WriteLine(journal1 > journal2);
//    Console.WriteLine(journal1 < journal1);
//    journal1.OutputData();

//}
//catch (Exception e)
//{

//    Console.WriteLine(e.Message);
//}



try
{
    Library library1 = new Library();
    Book book1 = new Book("Mumu", "Tolstoy", 5);
    Book book2 = new Book("Buratino", "Ne znayu", 2);
    library1.Add(book1);
    library1.Add(book2);
    library1.AllLibrary();
    library1[0].InfoAboutBook();
    Console.WriteLine(library1.IsThereBook(book2));

    library1[0].PriceBook = library1[0].PriceBook + 12;
    Console.WriteLine(library1[0].PriceBook);


}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}





class Journal 
{
    private string name;
    private string data;
    private string description;
    private string phoneNumber;
    private string eMail;
    private int countEmployees = 0;

    public Journal() { }
    public Journal(int value) 
    {
        countEmployees += value;
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                Console.WriteLine("Error: Name journal can not be empty or contain only spaces.");
            else
                name = value;
        }
    }
    public string Data
    {
        get => data;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                Console.WriteLine("Error: data cannot be empty or contain only spaces.");
            else
                data = value;
        }
    }
    public string Description
    {
        get => description;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                Console.WriteLine("Error: description cannot be empty or contain only spaces.");
            else
                description = value;
        }
    }
    public string PhoneNumber
    {
        get => phoneNumber;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                Console.WriteLine("Error: Phone Number cannot be empty or contain only spaces.");
            else
                phoneNumber = value;
        }
    }
    public string EMail
    {
        get => eMail;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                Console.WriteLine("Error: Email cannot be empty or contain only spaces.");
            else
                eMail = value;
        }
    }
    public int CountEmployees 
    {
        get { return countEmployees; }
        private set
        {
            if (this.countEmployees < 0)
            {
                throw new Exception("Count employees can not be less than zero");
            }
            this.countEmployees = value;
        }
    }


    public static Journal operator+(Journal journal1, int value) 
    {
        return new Journal(journal1.countEmployees += value);
    }
    public static Journal operator -(Journal journal1, int value)
    {
        if (journal1.countEmployees - value < 0)
        {
            throw new Exception("Count employees can not be less than zero");
        }
        return new Journal(journal1.countEmployees -= value);
    }
    public static bool operator ==(Journal journal1, Journal journal2)
    {
        return journal1.countEmployees == journal2.countEmployees;
    }
    public static bool operator !=(Journal journal1, Journal journal2)
    {
        return journal1.countEmployees != journal2.countEmployees;
    }
    public static bool operator >(Journal journal1, Journal journal2)
    {
        return journal1.countEmployees > journal2.countEmployees;
    }
    public static bool operator <(Journal journal1, Journal journal2)
    {
        return journal1.countEmployees < journal2.countEmployees;
    }

    public void InputData()
    {
        Console.Clear();
        Console.Write("Enter Name journal: ");
        Name = Console.ReadLine();

        Console.Write("Enter year of foundation of the journal: ");
        Data = Console.ReadLine();

        Console.Write("Enter Description: ");
        Description = Console.ReadLine();

        Console.Write("Enter Phone number: ");
        PhoneNumber = Console.ReadLine();

        Console.Write("Enter Email: ");
        EMail = Console.ReadLine();

        Console.Write("Enter count of employes: ");
        countEmployees = Convert.ToInt32(Console.ReadLine());
    }
    public void OutputData()
    {
        Console.Clear();
        Console.WriteLine($"Name journal: {Name}");
        Console.WriteLine($"Year of foundation of the journal: {Data}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Phone number: {PhoneNumber}");
        Console.WriteLine($"Email: {PhoneNumber}");
        Console.WriteLine($"Count of Employes: {CountEmployees}");
    }

}


class Market 
{
    private string name;
    private string adress;
    private string description;
    private string phoneNumber;
    private string eMail;
    private int storeArea;

    public Market() { }
    public Market(int value)
    {
        storeArea += value;
    }


    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                Console.WriteLine("Error: Name market can not be empty or contain only spaces.");
            else
                name = value;
        }
    }
    public string Adress
    {
        get => adress;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                Console.WriteLine("Error: Adress cannot be empty or contain only spaces.");
            else
                adress = value;
        }
    }
    public string Description
    {
        get => description;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                Console.WriteLine("Error: description cannot be empty or contain only spaces.");
            else
                description = value;
        }
    }
    public string PhoneNumber
    {
        get => phoneNumber;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                Console.WriteLine("Error: Phone Number cannot be empty or contain only spaces.");
            else
                phoneNumber = value;
        }
    }
    public string EMail
    {
        get => eMail;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                Console.WriteLine("Error: Email cannot be empty or contain only spaces.");
            else
                eMail = value;
        }
    }
    public int StoreArea
    {
        get => storeArea;
        private set 
        {
            if (this.storeArea < 0)
            {
                throw new Exception("Count employees can not be less than zero");
            }
            this.storeArea = value;
        }
    }

    public static Market operator +(Market journal1, int value)
    {
        return new Market(journal1.storeArea += value);
    }
    public static Market operator -(Market journal1, int value)
    {
        if (journal1.storeArea - value < 0)
        {
            throw new Exception("Store Area can not be less than zero");
        }
        return new Market(journal1.storeArea -= value);
    }
    public static bool operator ==(Market journal1, Market journal2)
    {
        return journal1.storeArea == journal2.storeArea;
    }
    public static bool operator !=(Market journal1, Market journal2)
    {
        return journal1.storeArea != journal2.storeArea;
    }
    public static bool operator >(Market journal1, Market journal2)
    {
        return journal1.storeArea > journal2.storeArea;
    }
    public static bool operator <(Market journal1, Market journal2)
    {
        return journal1.storeArea < journal2.storeArea;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Market otherMarket = (Market)obj;
        return StoreArea.Equals(otherMarket.StoreArea);
    }

    public void InputData()
    {
        Console.Clear();
        Console.Write("Enter Name market: ");
        Name = Console.ReadLine();

        Console.Write("Enter Adress of the market: ");
        Adress = Console.ReadLine();

        Console.Write("Enter Description: ");
        Description = Console.ReadLine();

        Console.Write("Enter Phone number: ");
        PhoneNumber = Console.ReadLine();

        Console.Write("Enter Email: ");
        EMail = Console.ReadLine();

        Console.Write("Enter Store area: ");
        StoreArea = Convert.ToInt32(Console.ReadLine());

    }
    public void OutputData()
    {
        Console.Clear();
        Console.WriteLine($"Name the market: {Name}");
        Console.WriteLine($"Adress of the market: {Adress}");
        Console.WriteLine($"the Description: {Description}");
        Console.WriteLine($"Phone number: {PhoneNumber}");
        Console.WriteLine($"Email: {PhoneNumber}");
        Console.WriteLine($"Store area: {StoreArea}");
    }
}



class Book
{
    private string nameBook = "";
    private string authorBook = "";
    private double priceBook = 0;

    public Book() { }

    public Book(double value)
    {
        priceBook += value;
    }

    public Book(string bookName, string bookAuthor, double bookprice)
    {
        NameBook = bookName;
        AuthorBook = bookAuthor;
        PriceBook = bookprice;
    }

    public string NameBook 
    {
        get => nameBook;
        set
        {
            if ( value == null)
                throw new ArgumentNullException("Name book can not be null");
                            
            nameBook = value;
        }
    }
    public string AuthorBook
    {
        get => authorBook;
        set
        {
            if (value == null)
                throw new ArgumentNullException("Author book can not be null");

            authorBook = value;
        }
    }
    public double PriceBook
    {
        get => priceBook;
        set
        {
            if (value < 0)
                throw new ArgumentNullException("Price book can not be less than zero");

            priceBook = value;
        }
    }
    public void InfoAboutBook() 
    {
        Console.WriteLine($"Name Book: {NameBook}");
        Console.WriteLine($"Author Book: {AuthorBook}");
        Console.WriteLine($"Price Book: {PriceBook} azn");
    }
    public static Book operator +(Book book, double value)
    {
        return new Book(book.PriceBook + value);
    }
    public static Book operator -(Book book, double value)
    {
        if (book.PriceBook - value < 0)
        {
            throw new Exception("Price can not be less than zero");
        }
        return new Book(book.PriceBook - value);
    }

}
class Library 
{
    private List<Book> books = new();

    public Library() { }

    public Library(string bookName, string bookAuthor, double bookprice)
    {
        this.books[books.Count - 1].NameBook = bookName;
        this.books[books.Count - 1].AuthorBook = bookAuthor;
        this.books[books.Count - 1].PriceBook = bookprice;
    }
    public void Add(Book book) 
    {
        books.Add(book);
    }
    public void Remove(Book book) 
    { 
        books.Remove(book);
    }
    public bool IsThereBook(Book book)
    {
        bool isThereBook = false;
        for (int i = 0; i < books.Count; i++) 
        {
            if (books[i] == book)
            {
                isThereBook = true;
            }
        }
        return isThereBook;
    }
    public void AllLibrary() 
    {
        for (int i = 0; i < this.books.Count; i++)
        {
            Console.WriteLine($"1){books[i].NameBook}");
        }
    }

    public Book this[int index]
    {
        get
        {
            if (index >= 0 && index < books.Count)
                return books[index];

            else
                throw new IndexOutOfRangeException("The index is out of range.");
        }
    }    

}