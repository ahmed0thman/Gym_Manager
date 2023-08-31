using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymApp.Logic;
using GymApp.Logic.DBClasses;
using GymApp.Logic.Entites;

namespace GymApplication.UserControls
{
    public partial class UCLessonsArchieve : UserControl
    {
        public UCLessonsArchieve()
        {
            InitializeComponent();
        }

        private void btnArechieveLessonsMale_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.captinLogedIN.Privilliges == Privilliges.captinWomen) return;
                var whereCondition = $"lesson.gender = '{GlobalFunc.getStrGender(Gender.male)}' and lesson._date between '{dtMembershipFrom.Value.ToString("yyyy-MM-dd")}' and '{dtMembershipTo.Value.ToString("yyyy-MM-dd")}'";
                var tblArechieveLessonsMale = DBObjects_Intializer.lessonRepository.RetriveAllLessons(whereCondition);
                dgMemberShipArchieve.DataSource = tblArechieveLessonsMale;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnArechieveLessonsFemale_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.captinLogedIN.Privilliges == Privilliges.captinMen) return;
                var whereCondition = $"lesson.gender = '{GlobalFunc.getStrGender(Gender.female)}' and lesson._date between '{dtMembershipFrom.Value.ToString("yyyy-MM-dd")}' and '{dtMembershipTo.Value.ToString("yyyy-MM-dd")}'";
                var tblArechieveLessonsMale = DBObjects_Intializer.lessonRepository.RetriveAllLessons(whereCondition);
                dgMemberShipArchieve.DataSource = tblArechieveLessonsMale;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}