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
    public partial class UCArchieve : UserControl
    {
        UserControls.UCMembershipsArchieve UCMembershipsArchieve = new UCMembershipsArchieve();
        UserControls.UCLessonsArchieve UCLessonsArchieve = new UCLessonsArchieve();
        Guna.UI.WinForms.GunaAdvenceButton _CurrentTab = new Guna.UI.WinForms.GunaAdvenceButton();
        Guna.UI.WinForms.GunaAdvenceButton CurrentTab
        {
            get
            {
                return _CurrentTab;
            }
            set
            {
                _CurrentTab.BaseColor = Color.FromArgb(243, 241, 247);
                _CurrentTab.ForeColor = Color.DimGray;
                _CurrentTab.BorderColor = Color.DarkGray;
                _CurrentTab = value;
                _CurrentTab.BaseColor = Color.FromArgb(32, 30, 200);
                _CurrentTab.ForeColor = Color.White;
                _CurrentTab.BorderColor = Color.FromArgb(32, 30, 200); ;
            }
        }
        public UCArchieve()
        {
            InitializeComponent();
        }

        private void btnShowMemberArchieve_Click(object sender, EventArgs e)
        {
            CurrentTab = ((Guna.UI.WinForms.GunaAdvenceButton)sender);
            panelDgContainer.Controls.Clear();
            panelDgContainer.Controls.Add(UCMembershipsArchieve);
        }

        private void btnShowLessosnArechieve_Click(object sender, EventArgs e)
        {
            CurrentTab = ((Guna.UI.WinForms.GunaAdvenceButton)sender);
            panelDgContainer.Controls.Clear();
            panelDgContainer.Controls.Add(UCLessonsArchieve);
        }
    }
}
