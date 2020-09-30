using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            Main main = new Main();

            List<Main> listOfMain = new List<Main>();
            List newItem = new List();


            Console.WriteLine("Life is full of obstacles, let's get our To Do list going");

            bool toDo = true;
            while (toDo)
            {
                Console.WriteLine("Welcome to your To Do List");
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. Describe your task");
                Console.WriteLine("3. Add an urgency to your task");
                Console.WriteLine("4. Display your list");
                Console.WriteLine("5. Clear your list");
                Console.WriteLine("6. Quit");

                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("What task are we adding?");
                        item.Title = Console.ReadLine();
                        Console.WriteLine($"You have added {item.GetTitle()} to your list");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Add a description to your tasks");
                        item.Description = Console.ReadLine();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Add a number from 1 to 5 to gauge the urgency of this task");
                        item.Description = Console.ReadLine();
                        Console.ReadKey();
                        break;
                    case "4":
                        foreach (Main selectedItem in listOfMain)
                        {
                            Console.WriteLine($"{selectedItem.GetTitle()}");
                        }
                        Console.ReadKey();
                        break;
                    case "5":
                        listOfMain.Clear();
                        break;
                    case "6":
                        toDo = false;
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
