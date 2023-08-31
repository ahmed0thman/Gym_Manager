using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymApp.Logic.Entites;
using gymApp.DAL;
using System.Dynamic;
using System.Data;
using System.Windows.Forms;

namespace GymApp.Logic.DBClasses
{
    public class MemberRepository
    {
        
        private MembershipState GetMembershipState(DateTime str)
        {
            if (DateTime.Now.Date < str.Date)
            {
                TimeSpan t = str.Date.Subtract(DateTime.Now.Date);
                if (t < new TimeSpan(5, 0, 0, 0))
                    return MembershipState.AboutToEnd;
                else return MembershipState.InProgress;
            }
            else
                return MembershipState.Ended;
            
        }


         
        public DateTime? GetDateEnd(string phone)
        {
            var tbldata = DBOperations.db.GetData($"select max(dateend) from memberships where member='{phone}'");
            if (tbldata.Rows[0][0].ToString() == "") return null;
            return DateTime.Parse(tbldata.Rows[0][0].ToString());
        }

        public List<string> GetAllCodes()
        {
            DBOperations.db.Open();
            string sql = $"select _phone from members";
            var tblCodes = DBOperations.db.GetData(sql);
            List<string> listCodes = new List<string>();
            foreach (var row in tblCodes.AsEnumerable())
            {
                listCodes.Add(row[0].ToString());
            }
            return listCodes;
        }
        /// <summary>
        /// Retrive Members data
        /// </summary>
        /// <returns></returns>
        ///
        public List<Member> RetriveMembers(string gender, string memNamePhoneCode = null)
        {
            DBOperations.db.Open();
            string memNamePhoneCodeSql = "";
            if (memNamePhoneCode != null)
            {
                if (memNamePhoneCode[0] == '0' )
                    memNamePhoneCodeSql = $"and phone2 like '%{memNamePhoneCode}%'";
                else if (Char.IsDigit(memNamePhoneCode[0]))
                    memNamePhoneCodeSql = $"and _phone like '%{memNamePhoneCode}%'";
                else memNamePhoneCodeSql = $"and _name like '%{memNamePhoneCode}%'";
            }
            string sql = "select * from members";
            sql += $" where gender = '{gender}' {memNamePhoneCodeSql}";

            // Code to get required Members
            // ..
            var tblMembers = DBOperations.db.GetData(sql);
            var MemberList = new List<Member>();
            for (int i = 0; i < tblMembers.Rows.Count; i++)
            {
                var Code = tblMembers.Rows[i]["_phone"].ToString();
                var dtend = GetDateEnd(Code) ?? DateTime.Parse(tblMembers.Rows[i]["date_start"].ToString());
                var member = new Member(Code)
                {
                    Name = tblMembers.Rows[i]["_name"].ToString(),
                    Address = tblMembers.Rows[i]["_address"].ToString(),
                    Tall = tblMembers.Rows[i]["_tall"].ToString(),
                    Weigth = tblMembers.Rows[i]["_weight"].ToString(),
                    Age = tblMembers.Rows[i]["age"].ToString(),
                    Gender = GlobalFunc.GetGender(tblMembers.Rows[i]["gender"].ToString()),
                    DateStart = DateTime.Parse(tblMembers.Rows[i]["date_start"].ToString()),
                    DateEnd = dtend,
                    MembershipState = GetMembershipState(dtend),
                    Phone = tblMembers.Rows[i]["phone2"].ToString()
                };
                if(tblMembers.Rows[i]["image"].ToString() != "")
                {
                    member.Image = GlobalFunc.byteArrayToImage((byte[])(tblMembers.Rows[i]["image"]));
                }
                MemberList.Add(member);
            }
            DBOperations.db.Close();
            return MemberList;
        }

        /// <summary>
        /// Adding new Member
        /// </summary>
        /// <param name="Member"></param>
        /// <returns></returns>
        public bool AddMember(Member member)
        {
            bool isMemberAdded = true;
            DBOperations.db.Open();
            try
            {       
                string sql = $"insert into members(_name,_phone,_address,_tall,_weight,age,gender,date_start,phone2,image) values('{member.Name}',";
                sql += $"'{member.Code}','{member.Address}','{member.Tall}','{member.Weigth}',";
                sql += $"'{member.Age}','{GlobalFunc.getStrGender(member.Gender)}'," +
                    $"'{member.DateStart.ToString("yyyy-MM-dd")}','{member.Phone}',@{member.Code})";
                    DBOperations.db.Run(sql, $"@{member.Code}", GlobalFunc.imageToByteArray(member.Image));
            }
            catch(MySql.Data.MySqlClient.MySqlException)
            {
                isMemberAdded = false;
                MessageBox.Show("تكرار تعديل الصور اكثر من مرة قد يسبب فقدا ف البنات \n" +
                    " يمكنك تغير صورة كل عضو بحد اقصى مرة واحدة خلال تشغيل البرنامج");
            }
            DBOperations.db.Close();
            return isMemberAdded;
        }

        /// <summary>
        /// Delete current Member
        /// </summary>
        /// <param name="Member"></param>
        /// <returns>bool</returns>
        public bool DeleteMember(Member member)
        {
            bool isMemberDeleted = true;
            DBOperations.db.Open();
            try
            {
                // Code to delete data
                // ..
                
                string sql = $"delete from members where _phone = '{member.Code}'";
                DBOperations.db.Run(sql);
            }
            catch
            {
                DBOperations.db.Close();
                throw;
                isMemberDeleted = false;
            }
            DBOperations.db.Close();
            return isMemberDeleted;
        }

        /// <summary>
        /// Save the current Member new data
        /// </summary>
        /// <returns>bool</returns>
        public bool SaveMember(Member member)
        {
            string imgsql = "";
            if (member.Image != null)
                imgsql = $", image = @{member.Code} ";
            DBOperations.db.Open();
            bool isMemberSaved = true;
            string sql = $"update members set _name = '{member.Name}',";
            sql += $"_tall = '{member.Tall}',";
            sql += $"_address = '{member.Address}',";
            sql += $"_weight = '{member.Weigth}',";
            sql += $"age = '{member.Age}',";
            sql += $"date_start = '{member.DateStart.Date}',";
            sql += $"gender = '{GlobalFunc.getStrGender(member.Gender)}',";
            sql += $"phone2 = '{member.Phone}'";
            sql += $"{imgsql} ";
            sql += $"where _phone = '{member.Code}'";

            try
            {
                if (member.Image != null)
                    DBOperations.db.Run(sql, $"@{member.Code}", GlobalFunc.imageToByteArray(member.Image));
                else
                    DBOperations.db.Run(sql);
            }
            catch
            {
                MessageBox.Show("تكرار تعديل الصور اكثر من مرة قد يسبب فقدا ف البنات \n" +
                     " يمكنك تغير صورة كل عضو بحد اقصى مرة واحدة خلال تشغيل البرنامج");
                isMemberSaved = false;
            }
            DBOperations.db.Close();
            return isMemberSaved;
        }
        
    }
}
