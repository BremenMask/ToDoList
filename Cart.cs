using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Cart
    {
        public List<Pizza> ListOfPizza = new List<Pizza>();


        public void AddGrocery(Pizza item)
        {
            ListOfPizza.Add(item);
        }

        public Pizza SelectItem()
        {
            int index = 1;

            Console.WriteLine("Please add your item to the cart:");
            foreach (Pizza item in ListOfPizza)
            {
                Console.WriteLine($"{index}. {item}");
                index++;
            }

            int indexSelected = Convert.ToInt32(Console.ReadLine());
            return ListOfPizza[indexSelected - 1];
        }

    }
}
