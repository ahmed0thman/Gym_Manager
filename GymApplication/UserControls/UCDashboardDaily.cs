using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymApplication.UserControls
{
    public partial class UCDashboardDaily : UserControl
    {
        public UCDashboardDaily()
        {
            InitializeComponent();
            panelDtTo.Hide();
        }


        private void cbxReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxReportType.SelectedIndex == 0)
            {
                trPanelDtTo.HideSync(panelDtTo);
            }
            else if (cbxReportType.SelectedIndex == 1)
            {
                trPanelDtTo.ShowSync(panelDtTo);
            }
            GetAllActivities();
        }

        private void UCDashboardDaily_Load(object sender, EventArgs e)
        {
            UCDashBoard.AddLessonClicked += UCDashBoard_AddLessonClicked;
            GetAllActivities();
            

        }

        private void UCDashBoard_AddLessonClicked(string msg)
        {
            GetAllActivities();
        }

        private void GetAllActivities()
        {
            DataTable tblActs;
            if (cbxReportType.SelectedIndex == 0)
            tblActs = DBObjects_Intializer.activityRepository.RetriveAllActivitys(dt1.Value, dt2.Value); 
            else tblActs = DBObjects_Intializer.activityRepository.RetriveAllActivitys(dt1.Value, dt2.Value, 1);
            if (tblActs.Rows.Count == 0) return;
            dgActivities.DataSource = tblActs;
            double lessonsPrice = 0;
            int lessonsCount = 0;
            double newMembersPrice = 0;
            int newMembersCount = 0;
            double renewMembersPrice = 0;
            int renewMembersCount = 0;
            double total = 0;
            for (int i = 0; i < tblActs.Rows.Count; i++)
            {
                if (tblActs.Rows[i]["_type"].ToString() == "إضافة عضو")
                {
                    newMembersCount += 1;
                    newMembersPrice += double.Parse(tblActs.Rows[i]["price"].ToString());
                }
                else if (tblActs.Rows[i]["_type"].ToString() == "تجديد عضوية")
                {
                    renewMembersCount += 1;
                    renewMembersPrice += double.Parse(tblActs.Rows[i]["price"].ToString());
                }
                else if (tblActs.Rows[i]["_type"].ToString() == "إضافة حصة")
                {
                    lessonsCount += 1;
                    lessonsPrice += double.Parse(tblActs.Rows[i]["price"].ToString());
                }
            }
            lblLessonsCount.Text = lessonsCount.ToString();
            lblTotalLessonsPrice.Text = lessonsPrice.ToString();
            lblNewMembershipsCount.Text = newMembersCount.ToString();
            lblTotalMempershipsPrice.Text = newMembersPrice.ToString();
            lblRenewMembershipsCount.Text = renewMembersCount.ToString();
            lblTotalRenewMembershipsPrice.Text = renewMembersPrice.ToString();
            total = lessonsPrice + newMembersPrice + renewMembersPrice;
            lblTotalPrice.Text = total.ToString();
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            GetAllActivities();
        }

        private void dt2_ValueChanged(object sender, EventArgs e)
        {
            GetAllActivities();
        }
    }
}
