using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymApp.Logic.Entites
{
    public class Membership
    {
        public Member Member { get;  set; }
        public Captin Captin { get;  set; }
        public DateTime DateStart { get;  set; }
        public DateTime DateEnd { get;  set; }
        public string TradeMile { get;  set; }
        public double Price { get; set; }
        public Membership( Member member, Captin captin, DateTime dateStart, DateTime dateEnd, string tradeMile, double price)
        {
            Member = member;
            Captin = captin;
            DateStart = dateStart;
            DateEnd = dateEnd;
            TradeMile = tradeMile;
            Price = price;
        }
        public Membership()
        {
                
        }

        public override string ToString()
        {
            return $"name: {Member.Phone}, captin: {Captin.Name} start: {DateStart}, end: {DateEnd}, trademile: {TradeMile}, price: {Price}";
        }
    }
}
