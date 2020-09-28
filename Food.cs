using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Choose_Your_Class
{
    public class Food
    {
        //constructors
        public Food()
        {
            
        }

        //properties
        public string Store { get; set; }
        public string Item { get; set; }
        public int Budget { get; set; }
        public string List { get; set; }
        public int Time { get; set; }

        // methods
        public virtual void SetStore(string store)
        {
            Store = store;
        }

        public virtual string GetStore()
        {
            return Store;
        }
        public virtual void SetFood(string item)
        {
            Item = item;
        }
        public virtual string GetFood()
        {
            return Item;
        }

        public virtual int GetBudget()
        {
            return Budget;
        }

        public virtual void SetBudget(int budget)
        {
            Budget = budget;
        }

        public virtual int GetTime()
        {
            return Time;
        }

        public virtual void SetTime(int time)
        {
            Time = time;
        }

        public virtual string GetList()
        {
            return List;
        }

        public virtual void SetList(string list)
        {
            List = list;
        }
        //public void Tick()
        //{
            
        //}

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"{Store}, {List}, {Budget},");
        }
    }
}
