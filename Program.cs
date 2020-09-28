using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

            Food item = new Food();

            List<Food> ListOfFood = new List<Food>();

            Console.WriteLine("Hello! Welcome to Virtual Pets\n");

            object time = null;
            bool hasItem = true;
            while (hasItem)
            {
                Console.WriteLine("What would you like to do? You have $25 to spend and 5 minutes to grab it all");
                Console.WriteLine("1. Which store are we going to?");
                Console.WriteLine("2. Add an item to your cart");
                Console.WriteLine("3. Display your cart");
                Console.WriteLine("4. Check the time");
                Console.WriteLine("5. Clear your cart");
                Console.WriteLine("6. Quit");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("What store are we headed to?");
                        string store = Console.ReadLine();
                        Console.WriteLine($"Welcome to {store}");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Add a pizza item to your cart, each items costs $5");
                        string item = Console.ReadLine();
                        ///cart = new (item);
                        ///Cart.Add(item);
                        Console.ReadKey();
                        break;
                    case "3":
                        foreach (Food selectedItem in Cart.ListOfFood)
                        {
                            selectedItem.DisplayStatus();
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine($"You have {time} left");
                        break;
                    case "5":
                        ListOfFood.Clear();
                        break;
                    case "6":
                        hasItem = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry.");
                        break;
                }

                Console.WriteLine("Press Enter to continue.");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
