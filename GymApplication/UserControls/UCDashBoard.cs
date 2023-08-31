using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymApp.Logic.Entites;
using GymApp.Logic;

namespace GymApplication.UserControls
{
    public partial class UCDashBoard : UserControl
    {
        public delegate void clickAddLesson(string msg);
        public static event clickAddLesson AddLessonClicked;
        public UCDashBoard()
        {
            InitializeComponent();
            panelLessonInfo.Hide();
        }

        private void UCDashBoard_Load(object sender, EventArgs e)
        {
            panelDashboardContainer.Controls.Clear();
            if (Program.captinLogedIN.Privilliges == Privilliges.admin)
            panelDashboardContainer.Controls.Add(new UserControls.UCDashboardDaily());
            DataTable tblAllCaptinsData = DBObjects_Intializer.CaptinRepository.RetriveAllCaptins();
            if (tblAllCaptinsData.Rows.Count == 0) return;
            Dictionary<string, string> dictCaptin = new Dictionary<string, string>();
            for (int x = 0; x < tblAllCaptinsData.Rows.Count; x++)
            {
                var captinPhone = tblAllCaptinsData.Rows[x]["phone"].ToString();
                var caprinName = tblAllCaptinsData.Rows[x]["_name"].ToString();
                dictCaptin.Add(captinPhone, caprinName);
            }
            cbxCaptinName.DataSource = new BindingSource(dictCaptin, null);
            cbxCaptinName.DisplayMember = "Value";
            cbxCaptinName.ValueMember = "key";
            dtLesson.MinDate = DateTime.Now;
        }

        private void btnShowPanelLesson_Click(object sender, EventArgs e)
        {
            if (panelLessonInfo.Visible)
                trPanelLesson.HideSync(panelLessonInfo);
            else trPanelLesson.ShowSync(panelLessonInfo);

        }

        private void btnSaveLesson_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtVisitorName.Text.Trim() == "" || txtPhone.Text.Trim() == "")
                {
                    MessageBox.Show("تأكد من ادخال الاسم ورقم الهاتف");
                    return;
                }
                var lesson = new Lesson()
                {
                    Captin = new Captin(cbxCaptinName.SelectedValue.ToString()),
                    Date = dtLesson.Value,
                    person = new Person() { Name = txtVisitorName.Text, Code = txtPhone.Text, Gender = GlobalFunc.GetGender(cbxGender.Text) },
                    TradeMile = chkbxTradeMile.Checked ? "نعم" : "لا",
                    
                };
                bool validPrice = double.TryParse(txtPrice.Text.Trim(), out double price);
                if (!validPrice)
                {
                    MessageBox.Show("أدخل قيمة صحيحة للسعر");
                    txtPrice.SelectAll();
                    txtPrice.Focus();
                    return;
                }
                lesson.Price = price;
                try
                {
                    bool isAdded =  DBObjects_Intializer.lessonRepository.AddLesson(lesson);
                    var act = new Activity()
                    {
                        ActType = ActivityType.AddLesson,
                        Captin = new Captin(cbxCaptinName.SelectedValue.ToString()),
                        Date = DateTime.Now,
                        Name = txtVisitorName.Text,
                        Price = double.Parse(txtPrice.Text),
                    };
                    if (isAdded) DBObjects_Intializer.activityRepository.AddActivity(act);
                    GlobalFunc.ClearControls(panelLessonInfo);
                    btnShowPanelLesson.PerformClick();
                    AddLessonClicked("lessonAdd");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //throw;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }
        
    }
}
