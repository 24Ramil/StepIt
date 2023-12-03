using ComputerBuilder.ComputerModel;
using ComputerBuilder;
using ComputerBuilder.Interface;


Console.WriteLine("Computer Builder\n");


IComputer officeComputerBuilder = new OficeComputer();
IComputer gamingComputerBuilder = new GamingComputer();
IComputer designerComputerBuilder = new DisangerComputer();


ComputerDirector director = new ComputerDirector();


director.MakeComputer(officeComputerBuilder, "Intel Core i5", "Integrated Graphics", "8GB RAM", "256GB SSD");
Computer officeComputer = officeComputerBuilder.Info();
Console.WriteLine("Office Computer:");
officeComputer.Info();


director.MakeComputer(gamingComputerBuilder, "Ryzen 7", "NVIDIA GeForce RTX 3080", "16GB RAM", "1TB SSD + 1TB HDD");
Computer gamingComputer = gamingComputerBuilder.Info();
Console.WriteLine("Gaming Computer:");
gamingComputer.Info();


director.MakeComputer(designerComputerBuilder, "Intel Core i7", "NVIDIA Quadro RTX 5000", "32GB RAM", "512GB NVMe SSD + 4TB HDD");
Computer designerComputer = designerComputerBuilder.Info();
Console.WriteLine("Designer Computer:");
designerComputer.Info();