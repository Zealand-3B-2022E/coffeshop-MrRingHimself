// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

Console.WriteLine("Hello, World!");

BlackCoffee blackCoffee1 = new BlackCoffee();
Latte latte1 = new Latte();
Cortado cortado1 = new Cortado();

List<Coffee> coffeeList = new List<Coffee>();

coffeeList.Add(blackCoffee1);
coffeeList.Add(latte1);
coffeeList.Add(cortado1);

foreach (Coffee coffee in coffeeList)
{
    Console.WriteLine(coffee);
}