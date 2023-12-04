
using AutomobileFabric.Automobiles.Intreface;
using AutomobileFabric.Factories_Automobile.Interface_Factory;
using AutomobileFabric.Factories_Automobile.Model_Factory;

Console.WriteLine("Hello, World!\n\n");


IAutomobileFactory automobileFactory = new SedanFactory();
var sedan = automobileFactory.CreateMachine() as ISedan;
sedan.Info();
Console.WriteLine("-------------------------------------\n\n");

automobileFactory = new SUVFactory();
var suv = automobileFactory.CreateMachine() as ISUV;
suv.Info();
Console.WriteLine("-------------------------------------\n\n");

automobileFactory = new TruckFactory();
var truck = automobileFactory.CreateMachine() as ITruck;
truck.Info();
