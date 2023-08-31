using gymApp.DAL;
using GymApp.Logic;
using GymApp.Logic.Entites;
using GymApplication.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymApplication
{
    public partial class Form1 : Form
    {
        // Events To Show Member Tab Where thier memberships have been ended
        public delegate void FireNotifactions(string msg);
        public static event FireNotifactions NotifFired;

        #region UserControls Object
        public UserControls.UCMemberInfo UCMemberInfo = new UserControls.UCMemberInfo();
        public UserControls.UCArchieve UCArchieve = new UserControls.UCArchieve();
        public UserControls.UCEmployees UCEmployees = new UserControls.UCEmployees();
        public UserControls.UCPayments UCPayments = new UserControls.UCPayments();
        #endregion

        #region CurrentTab Navigator Handler 
        Guna.UI.WinForms.GunaButton _CurrentTab = new Guna.UI.WinForms.GunaButton();
        Guna.UI.WinForms.GunaButton CurrentTab { 
            get {
                    return _CurrentTab;
                }
            set {
                    _CurrentTab.BaseColor = Color.White;
                    _CurrentTab = value;
                    _CurrentTab.BaseColor = Color.FromArgb(212, 206, 248);
                }
        }
        #endregion
        public Form1(Captin captin)
        {
            Program.captinLogedIN = captin;
            InitializeComponent();
        }

        private void btnShowMembers_Click(object sender, EventArgs e)
        {
            CurrentTab = ((Guna.UI.WinForms.GunaButton)sender);
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UCMemberInfo);
        }

        private void btnShowDashBoard_Click(object sender, EventArgs e)
        {
            CurrentTab = ((Guna.UI.WinForms.GunaButton)sender);
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(new UserControls.UCDashBoard());
        }

        private void btnShowArchieve_Click(object sender, EventArgs e)
        {
            CurrentTab = ((Guna.UI.WinForms.GunaButton)sender);
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UCArchieve);
        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            if (Program.captinLogedIN.Privilliges != Privilliges.admin) return;
            CurrentTab = ((Guna.UI.WinForms.GunaButton)sender);
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UCEmployees);
        }

        private void btnShowTransactions_Click(object sender, EventArgs e)
        {
            if (Program.captinLogedIN.Privilliges != Privilliges.admin) return;
            CurrentTab = ((Guna.UI.WinForms.GunaButton)sender);
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UCPayments);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNotifacations.Hide();
            var members = DBObjects_Intializer.memberRepository.RetriveMembers("ذكر");
            //int count = members.Count(x => x.DateEnd.Date <= DateTime.Today && x.DateEnd.Date >= DateTime.Today.AddDays(-5));
            int count = members.Count(x => x.DateEnd.Date <= DateTime.Today);
            panelNotifications.Hide();
            btnShowDashBoard.PerformClick();
            GetExpiredMemberShips();
            DataTable tblAllCaptinsData = DBObjects_Intializer.CaptinRepository.RetriveAllCaptins();
            for (int x = 0; x < tblAllCaptinsData.Rows.Count; x++)
            {
                var captinPhone = tblAllCaptinsData.Rows[x]["phone"].ToString();
                var caprinName = tblAllCaptinsData.Rows[x]["_name"].ToString();
            }
            if (count == 0) return;
            lblNotificationCount.Text = $"{count} من الاعضاء انتهت مدة اشتراكهم";
            btnNotifacations.Show();
            btnNotifacations.BorderColor = Color.Red;
        }

        private void GetExpiredMemberShips()
        {
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            btnShowMembers.PerformClick();
            NotifFired("Hi from Notifications");
            trPanelNotifications.HideSync(panelNotifications);
        }

        private void btnNotifacations_Click(object sender, EventArgs e)
        {
            if (panelNotifications.Visible) trPanelNotifications.HideSync(panelNotifications);
            else trPanelNotifications.ShowSync(panelNotifications);
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
