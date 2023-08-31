using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymApp.Logic.Entites
{
    public class Lesson
    {
        public Person person { get; set; }
        public Captin Captin { get; set; }
        public DateTime Date { get; set; }
        public string TradeMile { get; set; }
        public double Price { get; set; }

        public Lesson() { }
        public Lesson(Person person, Captin captin, DateTime date, string tradeMile, double price)
        {
            this.person = person;
            Captin = captin;
            Date = date;
            TradeMile = tradeMile;
            Price = price;
        }

    }
}
