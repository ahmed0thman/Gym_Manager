using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymApp.Logic.DBClasses;
using GymApp.Logic;
using GymApp.Logic.Entites;

namespace GymApplication.UserControls
{
    public partial class UCMembershipsArchieve : UserControl
    {
        public UCMembershipsArchieve()
        {
            InitializeComponent();
        }

        private void btnArechieveMembershipsMale_Click(object sender, EventArgs e)
        {
            if (Program.captinLogedIN.Privilliges == Privilliges.captinWomen) return;
            var whereCondition = $"members.gender = '{GlobalFunc.getStrGender(Gender.male)}' and memberships.datestart between '{dtMembershipFrom.Value.ToString("yyyy-MM-dd")}' and '{dtMembershipTo.Value.ToString("yyyy-MM-dd")}'";
            try
            {
                var tblArechieveMembershipsMale = DBObjects_Intializer.membershipRepository.RetriveAllMemberships(whereCondition);
                dgvMemberShipArchieve.DataSource = tblArechieveMembershipsMale;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnArechieveMembershipsFemale_Click(object sender, EventArgs e)
        {
            if (Program.captinLogedIN.Privilliges == Privilliges.captinMen) return;
            var whereCondition = $"members.gender = '{GlobalFunc.getStrGender(Gender.female)}' and memberships.datestart between '{dtMembershipFrom.Value.ToString("yyyy-MM-dd")}' and '{dtMembershipTo.Value.ToString("yyyy-MM-dd")}'";
            try
            {
                var tblArechieveMembershipsFemale = DBObjects_Intializer.membershipRepository.RetriveAllMemberships(whereCondition);
                dgvMemberShipArchieve.DataSource = tblArechieveMembershipsFemale;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}