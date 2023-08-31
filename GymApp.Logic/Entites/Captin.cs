using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymApp.Logic.Entites
{
    public enum Privilliges { 
        admin,
        captinMen,
        captinWomen
    }
    public class Captin : Person
    {
        public string Address { get; set; }
        public int Salary { get; set; }
        public string Age { get; set; }
        public Privilliges Privilliges { get; set; }
        public string Password { get; set; }


        public Captin(string name, string phone, Gender gender, string address, int salary, string age, Privilliges privilliges)
            : base(name, phone, gender)
        {
            Address = address;
            Age = age;
            Salary = salary;
            Privilliges = privilliges;

        }
        public Captin(string phone)
            : base(phone)
        {

        }
        public Captin()
        {

        }
    }
}
