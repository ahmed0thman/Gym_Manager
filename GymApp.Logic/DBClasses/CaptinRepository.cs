using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymApp.Logic.Entites;
using gymApp.DAL;
using System.Data;

namespace GymApp.Logic.DBClasses
{
    public class CaptinRepository
    {

        

        /// <summary>
        /// Retrieve one Captin using id
        /// </summary>
        /// <param name="phone"></param>
        /// <returns>Captin</returns>
        public Captin RetriveOneCaptin(string phone)
        {
            DBOperations.db.Open();
            var tblCaptinData = DBOperations.db.GetData($"select * from captains where phone = '{phone}'");

            var captin = new Captin(phone)
            {
                Name = tblCaptinData.Rows[0]["_name"].ToString(),
                Address = tblCaptinData.Rows[0]["_address"].ToString(),
                Age = tblCaptinData.Rows[0]["age"].ToString(),
                Gender = Gender.none,
                Code = tblCaptinData.Rows[0]["phone"].ToString(),
                Salary = int.Parse(tblCaptinData.Rows[0]["salary"].ToString()),
                Privilliges = GlobalFunc.GetPrivilliges(tblCaptinData.Rows[0]["privilliges"].ToString()),
                Password = tblCaptinData.Rows[0]["_password"].ToString()
            };

            DBOperations.db.Close();
            return captin;
        }

        /// <summary>
        /// Retrive all Captins data
        /// </summary>
        /// <returns></returns>
        public DataTable RetriveAllCaptins()
        {
            DBOperations.db.Open();
            var tblAllCaptinsData = DBOperations.db.GetData("select _name, phone, _address, salary, age from captains");

            //var captins = new List<Captin>();
            //for (int x = 0; x < tblAllCaptinsData.Rows.Count; x++)
            //{
            //    var captinPhone = tblAllCaptinsData.Rows[x]["phone"].ToString();
            //    var captin = new Captin(captinPhone);

            //    var caprinName = tblAllCaptinsData.Rows[x]["_name"].ToString();
            //    captin.Name = caprinName;

            //    var captinGender = Gender.none;
            //    captin.Gender = captinGender;

            //    var captinAddress = tblAllCaptinsData.Rows[x]["_address"].ToString();
            //    captin.Address = captinAddress;

            //    var captinSalary = tblAllCaptinsData.Rows[x]["salary"].ToString();
            //    captin.Salary = int.Parse(captinSalary);

            //    var captinAge = tblAllCaptinsData.Rows[x]["age"].ToString();
            //    captin.Age = captinAge;

            //    var captinPrivilliges = tblAllCaptinsData.Rows[x]["privilliges"].ToString();
            //    captin.Privilliges = GetPrivilliges(captinPrivilliges);

            //    captins.Add(captin);
            //}

            DBOperations.db.Close();
            return tblAllCaptinsData;
        }

        /// <summary>
        /// Adding new Captin
        /// </summary>
        /// <param name="Captin"></param>
        /// <returns></returns>
        public bool AddCaptin(Captin captin)
        {
            DBOperations.db.Open();
            bool isCaptinAdded = true;

            try
            {
                string addQuery = $"insert into captains values" +
                    $"('{captin.Name}', '{captin.Code}', '{captin.Address}', {captin.Salary}, {captin.Age}, '{GlobalFunc.GetStrPrivilliges(captin.Privilliges)}', '{captin.Password}')";
                DBOperations.db.Run(addQuery);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
                isCaptinAdded = false;
            }

            DBOperations.db.Close();
            return isCaptinAdded;
        }

        /// <summary>
        /// Delete current Captin
        /// </summary>
        /// <param name="Captin"></param>
        /// <returns>bool</returns>
        public bool DeleteCaptin(Captin captin)
        {
            DBOperations.db.Open();
            bool isCaptinDeleted = true;

            try
            {
                string deleteQuery = $"delete from captains where phone = {captin.Code}";
                DBOperations.db.Run(deleteQuery);
            }
            catch
            {
                isCaptinDeleted = false;
            }

            DBOperations.db.Close();
            return isCaptinDeleted;
        }

        /// <summary>
        /// Save the current Captin new data
        /// </summary>
        /// <returns>bool</returns>
        public bool SaveCaptin(Captin captin, string phone)
        {
            DBOperations.db.Open();
            bool isCaptinSaved = true;

            try
            {
                string updateQuery = $"UPDATE captains SET _name = '{captin.Name}', phone = '{captin.Code}',";
                updateQuery += $" _address = '{captin.Address}', salary = '{captin.Salary}', age = '{captin.Age}',";
                updateQuery += $" privilliges = '{GlobalFunc.GetStrPrivilliges(captin.Privilliges)}', _password = '{captin.Password}' WHERE phone = '{phone}'";
                DBOperations.db.Run(updateQuery);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
                isCaptinSaved = false;
            }

            DBOperations.db.Close();
            return isCaptinSaved;
        }
    }
}
