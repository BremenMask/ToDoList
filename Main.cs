using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Choose_Your_Class
{
    public class Main
    {
        //constructors

        public Main(string title, string description, bool isDone, int number, int urgency)
        {
            Title = title;
            Description = description;
            IsDone = isDone;
            Number = number;
        }

        //properties
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public int Number { get; set; }
        public int Urgency { get; set; }

        //make description a method
        //menu interaction a method
        //display status a method

        // methods

        public string GetTitle()
        {
            return Title;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }

        public string GetDescription()
        {
            return Description;
        }

        public void SetDescription(string description)
        {
            Description = description;
        }

        public bool GetIsDone()
        {
            return IsDone;
        }

        public void SetIsDone(bool isDone)
        {
            IsDone = isDone;
        }

        public int GetNumber()
        {
            return Number;
        }

        public void SetNumber(int number)
        {
            Number = number;
        }

        public int GetUrgency()
        {
            return Urgency;
        }

        public void SetUrgency(int urgency)
        {
            Urgency = urgency;
        }
    }
}
