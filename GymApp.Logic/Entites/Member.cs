using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GymApp.Logic.Entites
{
    public enum MembershipState
    {
        InProgress,
        AboutToEnd,
        Ended
    }

    public class Member : Person
    {
        public string Address { get;  set; }
        public string Tall { get;  set; }
        public string Weigth { get;  set; }
        public string Age { get;  set; }
        public string Phone { get;  set; }
        public DateTime DateStart { get;  set; }
        public DateTime DateEnd { get;  set; }
        public MembershipState MembershipState { get;  set; }
        public Image Image { get; set; }
        public string ImgLocation { get; set; }


        public Member(string name, string code, Gender gender,string address, string tall, string weight, string age,DateTime dateStart, MembershipState membershipState)
            : base (name,code,gender)
        {
            Address = address;
            Tall = tall;
            Weigth = weight;
            Age = age;
            DateStart = dateStart;
            MembershipState = membershipState;
        }
        public Member(string code) : base(code)
        {

        }
    }
}
