using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymApp.Logic;
using GymApp.Logic.Entites;
using Guna.UI.WinForms;

namespace GymApplication.UserControls
{
    public partial class UCEmployees : UserControl
    {
        public UCEmployees()
        {
            InitializeComponent();
            GetAllCaptins();
        }

        private void GetAllCaptins()
        {
            var CaptinsInfo = DBObjects_Intializer.CaptinRepository.RetriveAllCaptins();
            dgMemberShipArchieve.DataSource = CaptinsInfo;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                Captin captin = new Captin(txtEmpPhone.Text)
                {
                    Name = txtEmpName.Text,
                    Address = txtEmpAdd.Text,
                    Age = txtEmpAge.Text,
                    Gender = GymApp.Logic.Gender.none,
                    Salary = int.Parse(txtEmpSalary.Text),
                    Password = txtEmpPassword.Text,
                    Privilliges = GlobalFunc.GetPrivilliges(cbxEmpType.GetItemText(cbxEmpType.SelectedItem)),

                };
                try
                {
                    bool captinAdded = DBObjects_Intializer.CaptinRepository.AddCaptin(captin);
                    ClearControls();
                    if (captinAdded) GetAllCaptins();
                }
                catch (Exception)
                {

                    MessageBox.Show("رقم الهاتف موجود بالفعل");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("تأكد من ملئ جميع الحقول");
            }
            
            
        }

        private void dgMemberShipArchieve_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgMemberShipArchieve.RowCount - 1) return;
            var dgv = ((Guna.UI.WinForms.GunaDataGridView)sender);
            string phone = dgv.CurrentRow.Cells["colPhone"].Value.ToString();
            Captin captin = DBObjects_Intializer.CaptinRepository.RetriveOneCaptin(phone);
            txtEmpPhone.Text = captin.Code;
            txtEmpName.Text = captin.Name;
            txtEmpAdd.Text = captin.Address;
            txtEmpSalary.Text = captin.Salary.ToString();
            txtEmpAge.Text = captin.Age;
            cbxEmpType.SelectedItem = GlobalFunc.GetStrPrivilliges(captin.Privilliges);
            
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            var dgv = dgMemberShipArchieve;
            string phone = dgv.CurrentRow.Cells["colPhone"].Value.ToString();
            try
            {
                Captin captin = new Captin(txtEmpPhone.Text)
                {
                    Name = txtEmpName.Text,
                    Address = txtEmpAdd.Text,
                    Age = txtEmpAge.Text,
                    Gender = GymApp.Logic.Gender.none,
                    Salary = int.Parse(txtEmpSalary.Text),
                    Password = txtEmpPassword.Text,
                    Privilliges = GlobalFunc.GetPrivilliges(cbxEmpType.GetItemText(cbxEmpType.SelectedItem)),

                };
                bool captinAdded = DBObjects_Intializer.CaptinRepository.SaveCaptin(captin, phone);
                ClearControls();
                if (captinAdded) GetAllCaptins();
            }
            catch (Exception)
            {

                MessageBox.Show("تأكد من ملئ جميع الحقول");
            }
            
        }

        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            if(txtEmpPhone.Text == "")
            {
                MessageBox.Show("أدخل رقم الهاتف");
                return;
            }
            DialogResult msg = MessageBox.Show( "تأكيد بمسح بيانات!", "تحذير", MessageBoxButtons.YesNo);
            if (msg == DialogResult.No) return;
            var dgv = dgMemberShipArchieve;
            Captin captin = new Captin(dgv.CurrentRow.Cells["colPhone"].Value.ToString());
            bool captinAdded = DBObjects_Intializer.CaptinRepository.DeleteCaptin(captin);
            ClearControls();
            if (captinAdded) GetAllCaptins();

        }

        private void ClearControls()
        {
            foreach (Control control in panelRight.Controls)
            {
                if (control is GunaTextBox c)
                {
                    c.Text = "";
                }
                else if (control is GunaComboBox c2) c2.SelectedIndex = 0;
            }
        }
    }
}
