using System;
using HW3.Sweets.Candies.CandiesWithChocolate;
using HW3.Sweets.Chocolates;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Present present = new Present(new Sweet[]
            {
                new CandyWithWhiteChocolate("rafaelo",90, false),
                new CandyWithBlackChocolate("Black BEE", 105, true),
                new WhiteChocolate("Korona", 314, false),
                new BlackChocolate("milka", 121, false),
            });

            Console.WriteLine("Вы получили подарок:");

            foreach (Sweet sweet in present.Sweets)
            {
                Console.WriteLine($"{sweet.Name} - калорийность {sweet.Calories}");
            }
            Console.WriteLine("Вы попытались найти конфету с калорийность равной 105, это");

            Sweet searchRessalt =  present.Sweets.Search(105);

            Console.Write($"{searchRessalt.Name} - калорийность {searchRessalt.Calories}");
        }
    }
}
