using System;
using System.Collections.Generic;
using GymApp.Logic.Entites;
using gymApp.DAL;
using System.Data;

namespace GymApp.Logic.DBClasses
{
    public class LessonRepository
    {
        private Gender GetGender(string strGender)
        {
            switch (strGender)
            {
                case "ذكر":
                    return Gender.male;

                case "أنثى":
                    return Gender.female;

                case "none":
                    return Gender.none;

                default:
                    throw new ArgumentNullException("not valid Gender ..!");
            }
        }

        public DataTable RetriveAllLessons(string whereCondition)
        {
            var captin = new CaptinRepository();

            DBOperations.db.Open();

            var query = $"select lesson._date, lesson._name, lesson.phone, lesson.trademile, captains._name as captin, lesson.price from lesson " +
                $"inner join captains on lesson.captin = captains.phone " +
                $"where {whereCondition}";

            var tblAllLessonsData = DBOperations.db.GetData(query);
            /*var lessons = new List<Lesson>();

            for (int x = 0; x < tblAllLessonsData.Rows.Count; x++)
            {
                var lesson = new Lesson
                {
                    person = new Person(tblAllLessonsData.Rows[x]["phone"].ToString())
                    {
                        Name = tblAllLessonsData.Rows[x]["_name"].ToString(),
                        Gender = GetGender(tblAllLessonsData.Rows[x]["gender"].ToString())
                    },
                    Captin = captin.RetriveOneCaptin(tblAllLessonsData.Rows[x]["captin"].ToString()),
                    Date = DateTime.Parse(tblAllLessonsData.Rows[x]["_date"].ToString()),
                    TradeMile = bool.Parse(tblAllLessonsData.Rows[x]["trademile"].ToString()),
                    Price = double.Parse(tblAllLessonsData.Rows[x]["price"].ToString())
                };
                lessons.Add(lesson);
            }*/

            DBOperations.db.Close();
            return tblAllLessonsData;
        }


        /// <summary>
        /// Adding new Lesson
        /// </summary>
        /// <param name="lesson"></param>
        /// <returns></returns>
        public bool AddLesson(Lesson lesson)
        {
            DBOperations.db.Open();
            bool isLessonAdded = true;

            try
            {
                string addQuery = $"insert into lesson(_name, captin, _date, trademile, price, phone, gender) values" +
                    $"('{lesson.person.Name}', '{lesson.Captin.Code}', '{lesson.Date.ToString("yyyy-MM-dd")}', '{lesson.TradeMile}', " +
                    $"'{lesson.Price}', '{lesson.person.Code}', '{GlobalFunc.getStrGender(lesson.person.Gender)}')";

                DBOperations.db.Run(addQuery);
            }
            catch
            {
                throw;
                isLessonAdded = false;
            }

            DBOperations.db.Close();
            return isLessonAdded;
        }
    }
}