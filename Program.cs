using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            Pizza item = new Pizza();

            List<Pizza> listOfPizzas = new List<Pizza>();
            Cart cart = new Cart();


            Console.WriteLine("Hello! Let's chow down on some pizza!");

            bool hasItem = true;
            while (hasItem)
            {
                Console.WriteLine("What would you like to do? You have $25 to spend and 5 minutes to grab it all");
                Console.WriteLine("1. Which store are we going to?");
                Console.WriteLine("2. Add an item to your cart");
                Console.WriteLine("3. Display your cart");
                Console.WriteLine("4. Clear your cart");
                Console.WriteLine("5. Quit");

                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("What Pizza place are we headed to?");
                        string store = Console.ReadLine();
                        Console.WriteLine($"Welcome to {store}");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("What kind of pizza do you want? Meat Lovers, Veggie or Classic");
                        item.Name = Console.ReadLine();
                        Console.WriteLine("Okay, is that a veggie option or no?");
                        
                        /// if else for two booleans and cw  
                        /// cw for size, item.size 
                        Console.WriteLine("What size pizza would you like?");
                        item.Size = Console.ReadLine();
                        cart.AddGrocery(item);
                        Console.ReadKey();
                        break;
                    case "3":
                        foreach (Pizza selectedItem in listOfPizzas)
                        {
                            Console.WriteLine($"{selectedItem.Name}");
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        listOfPizzas.Clear();
                        break;
                    case "5":
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
