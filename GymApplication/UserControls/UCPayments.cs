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
    public partial class UCPayments : UserControl
    {
        public UCPayments()
        {
            InitializeComponent();
            dtPayment.Value = DateTime.Now;
            dtPaymentFrom.Value = DateTime.Now;
            dtPaymentTo.Value = DateTime.Now;
            GetAllPayments();
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            try
            {
                OtherActs activity = new OtherActs() { 
                    Name = txtPaymentType.Text,
                    Date = DateTime.Parse(dtPayment.Value.ToString("yyyy-MM-dd")),
                    Price = double.Parse(txtPaymentPrice.Text),
                    Details = txtPaymentDetails.Text
                };
                bool Done = DBObjects_Intializer.otherActsRepository.AddOtherActs(activity);
                GetAllPayments();
                GlobalFunc.ClearControls(panelRight);
            }
            catch (Exception)
            {

                MessageBox.Show("تأكد من ملئ جميع الحقول");
            }
        }

        

        private void dtPaymentFrom_ValueChanged(object sender, EventArgs e)
        {
            GetAllPayments();
        }

        private void GetAllPayments()
        {
            double counter = 0;
            DataTable Payments = DBObjects_Intializer.otherActsRepository.RetriveAllOtherActs(
                                DateTime.Parse(dtPaymentFrom.Value.ToString("yyyy-MM-dd")),
                                DateTime.Parse(dtPaymentTo.Value.ToString("yyyy-MM-dd"))
                            );
            dgPaymentArchieve.DataSource = Payments;
            for (int i = 0; i < Payments.Rows.Count; i++)
            {
                counter += double.Parse(Payments.Rows[i]["price"].ToString());
            }
            lblTotal.Text = counter.ToString();
        }

        private void dtPaymentTo_ValueChanged(object sender, EventArgs e)
        {
            GetAllPayments();
        }

        private void dgPaymentArchieve_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgPaymentArchieve.RowCount - 1) return;
            txtPaymentType.Text = dgPaymentArchieve.CurrentRow.Cells["colPaymentType"].Value.ToString();
            txtPaymentPrice.Text = dgPaymentArchieve.CurrentRow.Cells["colPaymentPrice"].Value.ToString();
            txtPaymentDetails.Text = dgPaymentArchieve.CurrentRow.Cells["colPaymentDetails"].Value.ToString();
            dtPayment.Value = DateTime.Parse(dgPaymentArchieve.CurrentRow.Cells["colDate"].Value.ToString());
        }

        private void btnEditPayment_Click(object sender, EventArgs e)
        {
            try
            {
                OtherActs activity = new OtherActs()
                {
                    
                    ID = int.Parse(dgPaymentArchieve.CurrentRow.Cells["colID"].Value.ToString()),
                    Name = txtPaymentType.Text,
                    Date = DateTime.Parse(dtPayment.Value.ToString("yyyy-MM-dd")),
                    Price = double.Parse(txtPaymentPrice.Text),
                    Details = txtPaymentDetails.Text
                };
                bool Done = DBObjects_Intializer.otherActsRepository.SaveOtherActs(activity);
                GetAllPayments();
                GlobalFunc.ClearControls(panelRight);
            }
            catch (Exception)
            {
                MessageBox.Show("تأكد من ملئ جميع الحقول");
            }
        }
    }
}
