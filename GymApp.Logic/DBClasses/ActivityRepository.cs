using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using gymApp.DAL;
using GymApp.Logic.Entites;

namespace GymApp.Logic.DBClasses
{
    public class ActivityRepository
    {
        

        

        private Captin GetCaptinData(string phone)
        {
            var captinData = DBOperations.db.GetData($"select * from captains where phone = {phone}");
            var captin = new Captin(phone)
            {
                Address = captinData.Rows[0]["_address"].ToString(),
                Age = captinData.Rows[0]["age"].ToString(),
                Gender = Gender.none,
                Name = captinData.Rows[0]["_name"].ToString(),
                Code = captinData.Rows[0]["phone"].ToString(),
                Privilliges = GlobalFunc.GetPrivilliges(captinData.Rows[0]["privilliges"].ToString()),
                Salary = int.Parse(captinData.Rows[0]["salary"].ToString())
            };

            return captin;
        }

        public DataTable RetriveAllActivitys(DateTime dt1, DateTime dt2 , int n = 0)
        {
            string sqlCmd = $" _date = '{dt1.Date.ToString("yyyy-MM-dd")}'";
            if (n == 1) sqlCmd = $" _date between '{dt1.Date.ToString("yyyy-MM-dd")}' and '{dt2.Date.ToString("yyyy-MM-dd")}'";

            DBOperations.db.Open();
            try
            {
                var tblAllActivities = DBOperations.db.GetData($"select activities._date,activities._type,captains._name as captin,activities._name,activities.price" +
                    $" from activities inner join captains on activities.captin = captains.phone where {sqlCmd}");
                DBOperations.db.Close();
                return tblAllActivities;
            }
            catch (Exception)
            {
                DBOperations.db.Close();

                throw;
            }
           
            
            
        }

        /// <summary>
        /// Adding new Activity
        /// </summary>
        /// <param name="Activity"></param>
        /// <returns></returns>
        public bool AddActivity(Activity activity)
        {
            DBOperations.db.Open();
            bool isActivityAdded = true;

            try
            {
                string addQuery = $"insert into activities values" +
                    $"('{activity.Date.ToString("yyyy-MM-dd")}', '{GlobalFunc.GetStrActivityType(activity.ActType)}', '{activity.Captin.Code}', '{activity.Name}', '{activity.Price}')";
                DBOperations.db.Run(addQuery);
            }
            catch
            {
                throw;
                isActivityAdded = false;
            }

            DBOperations.db.Close();
            return isActivityAdded;
        }

        
    }
}
