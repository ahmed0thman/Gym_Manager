using gymApp.DAL;
using GymApp.Logic.Entites;
using System.Collections.Generic;
using System.Data;

namespace GymApp.Logic.DBClasses
{
    public class MembershipRepository
    {

        public DataTable RetriveAllMemberships(string whereCondition)
        {
            DBOperations.db.Open();
            string sql = $"select members._name, captains._name as captin, memberships.datestart, memberships.dateend, memberships.trademile, memberships.price from memberships " +
                $"inner join members on memberships.member = members._phone " +
                $"inner join captains on memberships.captin = captains.phone " +
                $"where {whereCondition}";
            DataTable tblMembers = DBOperations.db.GetData(sql);
            return tblMembers;
        }
        /// <summary>
        /// Retrive all Memberships data
        /// </summary>
        /// <returns></returns>
        public DataTable RetriveAllMemberships()
        {
            DBOperations.db.Open();
            string sql = "selecet * from memberships";
            DataTable tblMembers = DBOperations.db.GetData(sql);
            return tblMembers;
        }

        public DataTable RetriveOneMembership(string phone = null)
        {
            DBOperations.db.Open();
            string memberSql = "";
            if (phone != null) memberSql = $"where member = '{phone}'";
            string sql = $"select captains._name as _name,memberships.datestart as datestart,memberships.dateend as dateend," +
                $"memberships.trademile as trademile,memberships.price as price from memberships ";
            sql += $" inner join captains on memberships.captin = captains.phone {memberSql}";
            DataTable tblMembers = DBOperations.db.GetData(sql);
            return tblMembers;
        }

        /// <summary>
        /// Adding new Membership
        /// </summary>
        /// <param name="Membership"></param>
        /// <returns></returns>
        public bool AddMembership(Membership membership)
        {
            DBOperations.db.Open();
            bool isMembershipAdded = true;
            string sql = $"insert into memberships values('{membership.Member.Code}','{membership.Captin.Code}',";
            sql += $"'{membership.DateStart.ToString("yyyy-MM-dd")}','{membership.DateEnd.ToString("yyyy-MM-dd")}','{membership.TradeMile}','{membership.Price}')";
            try
            {
                DBOperations.db.Run(sql);   
            }
            catch
            {
                throw;
                isMembershipAdded = false;
            }
            DBOperations.db.Close();
            return isMembershipAdded;
        }

        /// <summary>
        /// Adding new Membership
        /// </summary>
        /// <param name="Membership"></param>
        /// <returns></returns>
        public bool RemoveMembership(Membership membership)
        {
            DBOperations.db.Open();
            bool isMembershipAdded = true;
            string sql = $"delete from memberships where member='{membership.Member.Code}' and " +
                $"datestart = '{membership.DateStart.ToString("yyyy-MM-dd")}' and " +
                $"dateend = '{membership.DateEnd.ToString("yyyy-MM-dd")}'";
            try
            {
                DBOperations.db.Run(sql);
            }
            catch
            {
                isMembershipAdded = false;
                throw;
                
            }
            DBOperations.db.Close();
            return isMembershipAdded;
        }
    }
}
