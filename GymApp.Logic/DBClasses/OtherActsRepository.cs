using gymApp.DAL;
using GymApp.Logic.Entites;
using System;
using System.Collections.Generic;
using System.Data;

namespace GymApp.Logic.DBClasses
{
    public class OtherActsRepository
    {
        /// <summary>
        /// Retrive all OtherActss data
        /// </summary>
        /// <returns></returns>
        public DataTable RetriveAllOtherActs(DateTime dtFrom, DateTime dtTo)
        {
            DBOperations.db.Open();
            string sql = $"select * from other_activites where _date between '{dtFrom.Date.ToString("yyyy-MM-dd")}' and '{dtTo.Date.ToString("yyyy-MM-dd")}'";
            DataTable tblOtherActs = DBOperations.db.GetData(sql);
            return tblOtherActs;
        }

        /// <summary>
        /// Adding new OtherActs
        /// </summary>
        /// <param name="otherActs"></param>
        /// <returns></returns>
        public bool AddOtherActs(OtherActs otherActs)
        {
            DBOperations.db.Open();
            string sql = $"insert into other_activites(activity,_date,details,price) values('{otherActs.Name}','{otherActs.Date.ToString("yyyy-MM-dd")}',";
            sql += $"'{otherActs.Details}','{otherActs.Price}')";
            bool isOtherActsAdded = true;

            try
            {
                DBOperations.db.Run(sql);
            }
            catch(Exception)
            {
                isOtherActsAdded = false;
                throw;
            }
            DBOperations.db.Close();
            return isOtherActsAdded;
        }

        /// <summary>
        /// Save the current OtherActs new data
        /// </summary>
        /// <returns>bool</returns>
        public bool SaveOtherActs(OtherActs otherActs)
        {
            bool isOtherActsSaved = true;
            DBOperations.db.Open();
            string sql = $"update other_activites set activity='{otherActs.Name}',";
            sql += $"_date='{otherActs.Date.ToString("yyyy-MM-dd")}',details='{otherActs.Details}',price='{otherActs.Price}'";
            sql += $"where ID = {otherActs.ID}";
            try
            {
                DBOperations.db.Run(sql);
            }
            catch(Exception)
            {
                
                isOtherActsSaved = false;
                throw;
            }
            DBOperations.db.Close();
            return isOtherActsSaved;
        }
    }
}
