using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Cart
    {
        public List<Food> ListOfFood = new List<Food>();


        public void AddGrocery(Food item)
        {
            ListOfFood.Add(item);
        }

        public Food SelectItem()
        {
            int index = 1;

            Console.WriteLine("Please add your item to the cart:");
            foreach (Food item in ListOfFood)
            {
                Console.WriteLine($"{index}. {item}");
                index++;
            }

            int indexSelected = Convert.ToInt32(Console.ReadLine());
            return ListOfFood[indexSelected - 1];
        }

    }
}
