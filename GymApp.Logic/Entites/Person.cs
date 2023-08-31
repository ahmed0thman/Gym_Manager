using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymApp.Logic
{
    public enum Gender
    {
        male, female, none
    }
    public class Person
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public Gender Gender { get; set; }

        public Person(string name, string code, Gender gender)
        {
            Name = name;
            Code = code;
            Gender = gender;
        }
        public Person(string phone)
        {
            Code = phone;
        }
        public Person()
        {

        }
    }
}
