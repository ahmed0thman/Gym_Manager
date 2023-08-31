using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymApp.Logic.Entites
{
    public enum ActivityType
    {
        AddMember, RenewMembership, AddLesson, RemoveMember, RemoveMemberShip
    }
    public class Activity
    {
        public DateTime Date { get; set; }
        public ActivityType ActType { get; set; }
        public Captin Captin { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Activity() { }
        public Activity(DateTime date, ActivityType actType, Captin captin, string name, double price)
        {
            Date = date;
            ActType = actType;
            Captin = captin;
            Name = name;
            Price = price;
        }

    }
}
