using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class List
    {
        public List<Main> ListOfMain = new List<Main>();


        public void AddItem(Main item)
        {
            ListOfMain.Add(item);
        }

        public Main SelectItem()
        {
            int index = 1;

            Console.WriteLine("Please add your item to the list:");
            foreach (Main main in ListOfMain)
            {
                Console.WriteLine($"{index}. {main}");
                index++;
            }

            int indexSelected = Convert.ToInt32(Console.ReadLine());
            return ListOfMain[indexSelected - 1];
        }

    }
}
