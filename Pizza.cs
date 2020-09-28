using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Choose_Your_Class
{
    public class Pizza
    {
        //constructors
        public Pizza()
        {
            Price = "Five";
        }
        public Pizza(string name, string price, bool veggie, string size, bool isThinCrust)
        {
            Name = name;
            Veggie = veggie;
            Size = size;
            IsThinCrust = isThinCrust;
        }

        //properties
        public string Store { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public bool Veggie { get; set; }
        public string Size { get; set; }
        public bool IsThinCrust { get; set; }

        // methods
        public string GetStore()
        {
            return Store;
        }

        public void SetStore(string store)
        {
            Store = store;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetPrice()
        {
            return Price;
        }

        public void SetPrice(string price)
        {
            Price = price;
        }

        public string GetSize()
        {
            return Price;
        }

        public void SetSize(string price)
        {
            Price = price;
        }

    }
}
