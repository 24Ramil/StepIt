using System.Diagnostics;
using System.Reflection;



Money money1 = new Money(12, 12);
Money money2 = new Money(3, 15);
Products product = new(money1);
product.Spend(money2);
money1.Balans();



//MusicalInstrument? ukuleli = new Violin("Skripka Version2", "super", "pridumal kto kto ochen krutoy muzikant v kakom to ochen starom godu");
//ukuleli.Sound();
//ukuleli.Show();
//ukuleli.Desc();
//ukuleli.HistoryInfo();



//Worker? president = new President("John Doe", 1001);
//Worker? security = new Security("Alice Smith", 2001);
//Worker? manager = new Manager("Bob Johnson", 3001);
//Worker? engineer = new Engineer("Eve Brown", 4001);

//president.Print();
//security.Print();
//manager.Print();
//engineer.Print();


class Money 
{
    private int wholePart = 0;
    private int kopecks = 0;

    public Money() { }
    public Money(int wholePart, int kopecks) 
    {
        WholePart = wholePart;
        Kopecks = kopecks;
    }
    public int WholePart 
    {
        get => this.wholePart;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Can not be negative");
            this.wholePart = value;
        }
    }
    public int Kopecks
    {
        get => this.kopecks;
        set
        {
            if (value < 0 || value > 99)
                throw new ArgumentOutOfRangeException("Can not be negative or more than 99");
            this.kopecks = value;
        }
    }

    public void Balans() 
    {
        Console.WriteLine($"WholePart: {this.wholePart}");
        Console.WriteLine($"Kopecks: {this.kopecks}");
    }
    public static Money operator +(Money a, Money b)
    {
        if ((a.kopecks + b.kopecks) > 100)
        {
            a.wholePart = a.wholePart + b.WholePart + 1;
            a.kopecks = (a.kopecks + b.kopecks) - 100;
        }
        else 
        {
            a.wholePart = a.wholePart + b.WholePart;
            a.kopecks = a.kopecks + b.kopecks;
        }
        return a;
    }
    public static Money operator -(Money a, Money b)
    {
        if ((a.kopecks - b.kopecks) < 0)
        {
            a.wholePart = a.wholePart - b.WholePart - 1;
            a.kopecks = 100 - (b.kopecks - a.kopecks);
        }
        else 
        {
            a.wholePart = a.wholePart - b.WholePart;
            a.kopecks = a.kopecks - b.kopecks;
        }
        return a;
    }

}
class Products 
{
    private Money money;

    public Products() { }
    public Products(Money money)
    {
        this.money = money;
    }

    public Money Spend(Money money) 
    {
        // кешбэк типо
        int cashBack = money.WholePart / 100;
        if (money.WholePart > 0)
        {
            this.money.WholePart += cashBack;
            if (cashBack > 0)
                Console.WriteLine($"Ura, cash back: {cashBack}");

            return this.money - money;
        }
        return this.money - money;
    }

}




abstract class Device 
{
    private string model = "";
    private int price = 0;
    public Device(string model, int price) 
    {
        Model = model;
        Price = price;
    }

    public string Model
    {
        get { return model; }
        set
        {
            if (value == null)
                throw new ArgumentNullException("Model can not be void");
            this.model = value;
        }
    }
    public int Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
                throw new Exception("Price can not be less than zero");
            this.price = value;
        }
    }

    public virtual void Sound() { }

    public virtual void Show() { }

    public virtual void Desc() { }

}

class Kettle: Device
{
    private double volume = 0;
    public Kettle(string model, int price, double volume) :base(model, price)
    {
        Volume = volume;
    }
    public double Volume
    {
        get { return volume; }
        set
        {
            if (value < 0)
                throw new Exception("Volume can not be less than zero");
            this.volume = value;
        }
    }

    public override void Sound()
    {
        Console.WriteLine("*Svist");
    }
    public override void Show() 
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Volume: {Volume}");
    }

    public override void Desc() 
    {
        Console.WriteLine($"Xoroshiy caynik ot {Model}, za {Price} s obyomom: {Volume}");
    }

}

class Microwave : Device
{
    private int maxTemp = 0;
    public Microwave(string model, int price, double volume) : base(model, price)
    {
        MaxTemp = maxTemp;
    }
    public int MaxTemp
    {
        get { return maxTemp; }
        set
        {
            if (value < 0)
                throw new Exception("Max Temp can not be less than zero");
            this.maxTemp = value;
        }
    }
    public override void Sound()
    {
        Console.WriteLine("*zvuki microvolnovki");
    }
    public override void Show()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Max temp: {MaxTemp}");
    }
    public override void Desc()
    {
        Console.WriteLine($"Xoroshiy microvolnovka ot {Model}, za {Price} s max temp: {MaxTemp}");
    }
}

class Steamboat : Device
{
    private int maxSpeed= 0;
    public Steamboat(string model, int price, double volume) : base(model, price)
    {
        MaxSpeed = maxSpeed;
    }
    public int MaxSpeed
    {
        get { return maxSpeed; }
        set
        {
            if (value < 0)
                throw new Exception("Max Speed can not be less than zero");
            this.maxSpeed = value;
        }
    }
    public override void Sound()
    {
        Console.WriteLine("*zvuki paraxoda");
    }
    public override void Show()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Max speed: {MaxSpeed}");
    }
    public override void Desc()
    {
        Console.WriteLine($"Xoroshiy paraxod ot {Model}, za {Price} s max speed: {MaxSpeed}");
    }
}

class Automobile : Device
{
    private int maxSpeed = 0;
    public Automobile(string model, int price, double volume) : base(model, price)
    {
        MaxSpeed = maxSpeed;
    }
    public int MaxSpeed
    {
        get { return maxSpeed; }
        set
        {
            if (value < 0)
                throw new Exception("Max Speed can not be less than zero");
            this.maxSpeed = value;
        }
    }
    public override void Sound()
    {
        Console.WriteLine("*zvuki avtomobila");
    }
    public override void Show()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Max temp: {MaxSpeed}");
    }
    public override void Desc()
    {
        Console.WriteLine($"Xoroshiy avtomobil ot {Model}, za {Price} s max speed: {MaxSpeed}");
    }
}




abstract class MusicalInstrument
{
    public string Name { get; }
    public string Characteristics { get; }
    public string History { get; }

    public MusicalInstrument(string name, string characteristics, string history)
    {
        Name = name;
        Characteristics = characteristics;
        History = history;
    }

    public virtual void Sound() { }

    public virtual void Show() { }

    public virtual void Desc() { }

    public virtual void HistoryInfo() { }
}

class Violin : MusicalInstrument
{
    public Violin(string name, string characteristics, string history) : base(name, characteristics, history) { }

    public override void Sound()
    {
        Console.WriteLine("Zvuki skripki");
    }
    public override void Show()
    {
        Console.WriteLine($"Instrument Name: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Description: {Characteristics}");
    }

    public override void HistoryInfo()
    {
        Console.WriteLine($"History of Creation: {History}");
    }

}

class Trombone : MusicalInstrument
{
    public Trombone(string name, string characteristics, string history) : base(name, characteristics, history) { }

    public override void Sound()
    {
        Console.WriteLine($"Zvuki Trambona");
    }
    public override void Show()
    {
        Console.WriteLine($"Instrument Name: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Description: {Characteristics}");
    }

    public override void HistoryInfo()
    {
        Console.WriteLine($"History of Creation: {History}");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string characteristics, string history) : base(name, characteristics, history) { }

    public override void Sound()
    {
        Console.WriteLine("Zvuki Ukuleli");
    }
    public override void Show()
    {
        Console.WriteLine($"Instrument Name: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Description: {Characteristics}");
    }

    public override void HistoryInfo()
    {
        Console.WriteLine($"History of Creation: {History}");
    }

}

class Cello : MusicalInstrument
{
    public Cello(string name, string characteristics, string history) : base(name, characteristics, history) { }

    public override void Sound()
    {
        Console.WriteLine("Zvuki Violoncheli");
    }
    public override void Show()
    {
        Console.WriteLine($"Instrument Name: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Description: {Characteristics}");
    }

    public override void HistoryInfo()
    {
        Console.WriteLine($"History of Creation: {History}");
    }

}




abstract class Worker
{
    public string Name { get; }
    public int EmployeeId { get; }

    public Worker(string name, int employeeId)
    {
        Name = name;
        EmployeeId = employeeId;
    }

    public abstract void Print();
}

class President : Worker
{
    public President(string name, int employeeId) : base(name, employeeId) { }

    public override void Print()
    {
        Console.WriteLine($"President: {Name}, Employee ID: {EmployeeId}");
    }
}

class Security : Worker
{
    public Security(string name, int employeeId) : base(name, employeeId) { }

    public override void Print()
    {
        Console.WriteLine($"Security: {Name}, Employee ID: {EmployeeId}");
    }
}

class Manager : Worker
{
    public Manager(string name, int employeeId) : base(name, employeeId) { }

    public override void Print()
    {
        Console.WriteLine($"Manager: {Name}, Employee ID: {EmployeeId}");
    }
}

class Engineer : Worker
{
    public Engineer(string name, int employeeId) : base(name, employeeId) { }

    public override void Print()
    {
        Console.WriteLine($"Engineer: {Name}, Employee ID: {EmployeeId}");
    }
}
