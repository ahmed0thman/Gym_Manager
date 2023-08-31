using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymApp.Logic.Entites
{
    public class OtherActs
    {
        public string Name { get;   set; }
        public DateTime Date { get;   set; }
        public string Details { get;   set; }
        public double Price { get;   set; }
        public int? ID { get; set; }
        public OtherActs(string name,DateTime date, string details, double price)
        {
            Name = name;
            Date = date;
            Details = details;
            Price = price;
        }
        public OtherActs(int id = 0)
        {
            ID = id;
        }
    }
}
