using GymApp.Logic.Entites;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string password = txtPass.Text;
            try
            {
                Captin captin = DBObjects_Intializer.CaptinRepository.RetriveOneCaptin(userName);
                if (captin.Password == password)
                {

                    try
                    {
                        Program.main = new Form1(captin);
                        this.Hide();
                        Program.main.Show();
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show(ec.ToString());
                    }
                }
                else MessageBox.Show("كلمة السر خطأ");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("إسم المستخدم خطأ");
            }
            
        }

        private void LogInWithEnter(KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            btnSignIn.PerformClick();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            LogInWithEnter(e);
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            LogInWithEnter(e);
        }
    }
}
