using MealAbstractFabric.Fabrics.Class;
using MealAbstractFabric.Food.Class;
using MealAbstractFabric.Food.Model;

Console.WriteLine("Hello, World!\n\n");


var fanta1 = new FantaFabric(new Beverage("Fanta Classic", 1.2, 300, 0.5));
fanta1.Info();

Console.WriteLine("-------------------");

var fanta2 = new FantaFabric(new Beverage("Fanta Apple", 2.4, 600, 2));
fanta2.Info();



//FoodFabric foodFabric = new FoodFabric();

//Beverage fanta = foodFabric.CreateMeal(new Beverage("Fanta",1.2, 300, 0.5)) as Beverage;

//fanta.Info();