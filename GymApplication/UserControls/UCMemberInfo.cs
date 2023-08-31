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
using System.IO;
using Guna.UI.WinForms;
using GymApp.Logic.DBClasses;

namespace GymApplication.UserControls
{
    public partial class UCMemberInfo : UserControl
    {
        #region intial members
        List<Member> CurrentMembers = new List<Member>();
        Member CurrentMember;
        string imgLoc =  "Ico\\person.png";
        DataTable tblMemberShipInfo = new DataTable();
        bool flag = false;
        #endregion

        #region Constructor
        public UCMemberInfo()
        {
            InitializeComponent();
            ClearControl();
            panelOverlayMemberInfo.BackColor= Color.Transparent;
            panelOverlayMemberInfo.Hide();
            txtSearchMember.Hide();
            panelRenewMembership.Hide();
            panelOverlayMemberInfo.BringToFront();
            Form1.NotifFired += Form1_NotifFired;
            UCMemberCard.cardClicked += UCMemberCard_cardClicked;
            UCMemberCard.EditMemberClicked += UCMemberCard_EditMemberClicked;
            UCMemberCard.DeleteMemberClicked += UCMemberCard_DeleteMemberClicked;
            dtMembershipFrom.Value = DateTime.Now;
            dtMembershipTo.Value = DateTime.Now;
            dtMembershipStart.Value = DateTime.Now;
            dtMembershipEnd.Value = DateTime.Now;
            Fillcbx();
        }

        private void UCMemberCard_DeleteMemberClicked(Member member)
        {
            DeleteMember(member);
        }

        private void Fillcbx()
        {
            DataTable tblAllCaptinsData = DBObjects_Intializer.CaptinRepository.RetriveAllCaptins();
            if (tblAllCaptinsData.Rows.Count == 0) return;

            Dictionary<string, string> dictCaptin = new Dictionary<string, string>();
            for (int x = 0; x < tblAllCaptinsData.Rows.Count; x++)
            {
                var captinPhone = tblAllCaptinsData.Rows[x]["phone"].ToString();
                var caprinName = tblAllCaptinsData.Rows[x]["_name"].ToString();
                dictCaptin.Add(captinPhone, caprinName);
            }
            cbxCouche.DataSource = new BindingSource(dictCaptin, null);
            cbxCouche.DisplayMember = "Value";
            cbxCouche.ValueMember = "key";
            cbxCouch.DataSource = new BindingSource(dictCaptin, null);
            cbxCouch.DisplayMember = "Value";
            cbxCouch.ValueMember = "key";
        }

        private void UCMemberCard_EditMemberClicked(Member member)
        {
            txtSearchMember.Text = "";
            if (member == null) return;
            flag = true;
            bntAddMember.PerformClick();
            txtMemberName.Text = member.Name;
            txtMemberCode.Text = member.Code;
            txtMemberPhone.Text = member.Phone;
            txtMemberAddress.Text = member.Address;
            txtMemberTall.Text = member.Tall;
            txtMemberWeight.Text = member.Weigth;
            txtMemberAge.Text = member.Age;
            cbxMemberGender.SelectedIndex = member.Gender == Gender.male ? 0 : 1;
            dtMembershipStart.Value = member.DateStart.Date;
            picMember.Image = CurrentMember.Image;
        }
        #endregion

        #region CurrentTab Navigator Handler 
        Guna.UI.WinForms.GunaButton _CurrentTab = new Guna.UI.WinForms.GunaButton();
        Guna.UI.WinForms.GunaButton CurrentTab
        {
            get
            {
                return _CurrentTab;
            }
            set
            {
                _CurrentTab.BaseColor = Color.White;
                _CurrentTab = value;
                _CurrentTab.BaseColor = Color.FromArgb(212, 206, 248);
            }
        }
        #endregion

        private void UCMemberCard_cardClicked(Member member)
        {
            CurrentMember = member;
            lblMemberCode.Text = member.Code;
            lblMemberName.Text = member.Name;
            lblMemberPhone.Text = member.Phone;
            lblMemberAddress.Text = member.Address;
            lblMemberAge.Text = member.Age;
            lblMemberTall.Text = member.Tall + " CM";
            lblWeight.Text = member.Weigth + " KG";
            lblMembershipStatus.Text = GlobalFunc.GetStrMembershipState(member.MembershipState);
            pcBxMember.Image = CurrentMember.Image;
            switch (member.MembershipState)
            {
                case MembershipState.InProgress:
                    lblMembershipStatus.ForeColor = Color.FromArgb(0, 192, 0);
                    break;
                case MembershipState.AboutToEnd:
                    lblMembershipStatus.ForeColor = Color.DarkGoldenrod;
                    break;
                case MembershipState.Ended:
                    lblMembershipStatus.ForeColor = Color.Red;
                    break;
                default:
                    break;
            }
            lbldtMemberStart.Text = member.DateStart.Date.ToString("yyyy-MM-dd");
            lbldtMemberEnd.Text = member.DateEnd.Date.ToString("yyyy-MM-dd");
            tblMemberShipInfo = DBObjects_Intializer.membershipRepository.RetriveOneMembership(member.Code);
            dgMemberShipInfo.DataSource = tblMemberShipInfo;
        }

        private void Form1_NotifFired(string msg)
        {
            this.cbxMemberFitler.SelectedIndex = 2;
        }

        private void bntAddMember_Click(object sender, EventArgs e)
        {
            GlobalFunc.ClearControls(panelInfo);
            picMember.Image = Image.FromFile(imgLoc);
            trOverlayPanel.ShowSync(panelOverlayMemberInfo);
            
        }

        private void btnHideOverLayPanel_Click(object sender, EventArgs e)
        {
            trOverlayPanel.HideSync(panelOverlayMemberInfo);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (txtSearchMember.Visible) trTxtSearchMember.HideSync(txtSearchMember);
            else trTxtSearchMember.ShowSync(txtSearchMember);
        }

        private void cbxMemberFitler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentMembers.Count == 0) return;
            IEnumerable<Member> members = CurrentMembers;
            if (cbxMemberFitler.SelectedIndex == 1)
                members = from member in CurrentMembers
                          where member.MembershipState == MembershipState.InProgress 
                          select member;
            if (cbxMemberFitler.SelectedIndex == 2)
                members = from member in CurrentMembers
                        where member.MembershipState == MembershipState.Ended &&
                        (member.DateEnd.Date <= DateTime.Today )//&& member.DateEnd.Date > DateTime.Today.AddDays(-5))
                        select member;
            if (cbxMemberFitler.SelectedIndex == 3)
                members = from member in CurrentMembers
                          where member.MembershipState == MembershipState.AboutToEnd
                          select member;
            PanelListMembersCards.Controls.Clear();
            foreach (Member member in members)
                PanelListMembersCards.Controls.Add(new UCMemberCard(member));

        }

        

        private void btnShowRenewMembership_Click(object sender, EventArgs e)
        {
            if (CurrentMember is null)
            {
                MessageBox.Show("اختر احد الاعضاء!");
                return;
            }
            if (panelRenewMembership.Visible) trRenewMembershipPanel.HideSync(panelRenewMembership);
            else trRenewMembershipPanel.ShowSync(panelRenewMembership);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                Member member = new Member(txtMemberCode.Text)
                {
                    Name = txtMemberName.Text,
                    Address = txtMemberAddress.Text,
                    Age = txtMemberAge.Text,
                    Gender = GlobalFunc.GetGender(cbxMemberGender.Text),
                    Tall = txtMemberTall.Text,
                    Weigth = txtMemberWeight.Text,
                    DateStart = dtMembershipStart.Value.Date,
                    Phone = txtMemberPhone.Text,
                    Image = picMember.Image,
                };
                try
                {
                    bool memberAdded;
                    if (flag == false)
                    {
                        memberAdded = DBObjects_Intializer.memberRepository.AddMember(member);
                        if (!memberAdded)
                        {
                            MessageBox.Show("لم يتم اضافة جميع البيانات تأكد من صحتها يصاحبى عشان خاطرى");
                            return;
                        }
                        Membership membership = new Membership(
                            member,
                            new Captin(cbxCouch.SelectedValue.ToString()),
                            dtMembershipStart.Value.Date,
                            dtMembershipEnd.Value.Date,
                            cbxTradeMile2.Checked ? "نعم" : "لا",
                            double.Parse(txtPaid.Text)
                        );
                        bool isAdded = DBObjects_Intializer.membershipRepository.AddMembership(membership);
                        var act = new Activity()
                        {
                            ActType = ActivityType.RenewMembership,
                            Captin = new Captin(cbxCouch.SelectedValue.ToString()),
                            Date = DateTime.Now,
                            Name = member.Name,
                            Price = double.Parse(txtPaid.Text),
                        };
                        if (isAdded) DBObjects_Intializer.activityRepository.AddActivity(act);
                        DataTable tblMemberShipInfo = DBObjects_Intializer.membershipRepository.RetriveOneMembership(member.Phone);
                        dgMemberShipInfo.DataSource = tblMemberShipInfo;
                        CurrentTab.PerformClick();
                       
                    }
                    else
                    {
                        if (picMember.Image == member.Image)
                            member.Image = null;
                        memberAdded = DBObjects_Intializer.memberRepository.SaveMember(member);
                        if (!memberAdded) return;
                        flag = false;
                        btnHideOverLayPanel.PerformClick();
                    }
                    
                    ClearControl();
                    
                    CurrentTab.PerformClick();
                    GlobalFunc.ClearControls(panelInfo);
                }
                catch (Exception)
                {
                    MessageBox.Show("رقم اللاعب موجود بالفعل");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("تأكد من ملئ جميع الحقول");
            }

        }

        private void btnListMale_Click(object sender, EventArgs e)
        {
            if (Program.captinLogedIN.Privilliges == Privilliges.captinWomen) return;
            CurrentTab = btnListMale;
            try
            {
                GetAllMenMembersAndShowOnlyInProgress();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GetAllMenMembersAndShowOnlyInProgress()
        {
            var members = DBObjects_Intializer.memberRepository.RetriveMembers("ذكر");
            CurrentMembers = members;
            PanelListMembersCards.Controls.Clear();
            cbxMemberFitler.SelectedIndex = -1;
            cbxMemberFitler.SelectedIndex = 1;
        }

        private void ShowListOFMembersCard(List<Member> members)
        {
            CurrentMembers = members;
            PanelListMembersCards.Controls.Clear();
            foreach(Member member in members)
            {
                PanelListMembersCards.Controls.Add(new UCMemberCard(member));

            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            FD.Filter = "All Files (*.*)|*.*";
            FD.Title = "إختر صورة العضو";
            if (FD.ShowDialog() == DialogResult.OK)
            {
                imgLoc = FD.FileName;
                var byteimg = GlobalFunc.imageToByteArray(Image.FromFile(imgLoc));
                if(byteimg.Length >= 15000000)
                {
                    MessageBox.Show("اقصى حجم للصورة 14MB");
                    return;
                }
                var image = GlobalFunc.byteArrayToImage(byteimg);
                picMember.Image = image;
                
            }
            
        }

        private void btnListFemale_Click(object sender, EventArgs e)
        {
            if (Program.captinLogedIN.Privilliges == Privilliges.captinMen) return;
            CurrentTab = btnListFemale;
            var members = DBObjects_Intializer.memberRepository.RetriveMembers("أنثى");
            ShowListOFMembersCard(members);
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            PanelListMembersCards.Controls.Clear();
        }

        private void btnRenewMembership_Click(object sender, EventArgs e)
        {
            try
            {
                Membership membership = new Membership(
                CurrentMember,
                new Captin(cbxCouche.SelectedValue.ToString()),
                dtMembershipFrom.Value,
                dtMembershipTo.Value,
                chkbxTradeMile.Checked ? "نعم" : "لا",
                double.Parse(txtMembershipPrice.Text)
                );
                bool isAdded = DBObjects_Intializer.membershipRepository.AddMembership(membership);
                var act = new Activity()
                {
                    ActType = ActivityType.RenewMembership,
                    Captin = new Captin(cbxCouche.SelectedValue.ToString()),
                    Date = DateTime.Now,
                    Name = CurrentMember.Name,
                    Price = double.Parse(txtMembershipPrice.Text),
                };
                if (isAdded) DBObjects_Intializer.activityRepository.AddActivity(act);
                DataTable tblMemberShipInfo = DBObjects_Intializer.membershipRepository.RetriveOneMembership(CurrentMember.Phone);
                dgMemberShipInfo.DataSource = tblMemberShipInfo;
                CurrentTab.PerformClick(); 
                
                ClearControl();
                btnShowRenewMembership.PerformClick();
            }

            catch (Exception)
            {
                MessageBox.Show("تأكد من صحة البيانات المدخلة");
            }

        }
        private void ClearControl()
        {
            lblMemberPhone.Text = "";
            lblMemberAddress.Text = "";
            lblMemberAge.Text = "";
            lbldtMemberStart.Text = "";
            lbldtMemberEnd.Text = "";
            lblMemberName.Text = "";
            lblMembershipStatus.Text = "";
            lblMemberTall.Text = "";
            lblWeight.Text = "";
            tblMemberShipInfo.Clear();
            dgMemberShipInfo.DataSource = tblMemberShipInfo;
            txtMembershipPrice.Text = "";
            lblMemberCode.Text = "";
            picMember.Image = Image.FromFile("Ico\\person.png");
            pcBxMember.Image = Image.FromFile("Ico\\person.png");
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            txtSearchMember.Text = "";
            if (CurrentMember == null) return;
            flag = true;
            bntAddMember.PerformClick();
            txtMemberName.Text = CurrentMember.Name;
            txtMemberCode.Text = CurrentMember.Code;
            txtMemberPhone.Text = CurrentMember.Phone;
            txtMemberAddress.Text = CurrentMember.Address;
            txtMemberTall.Text = CurrentMember.Tall;
            txtMemberWeight.Text = CurrentMember.Weigth;
            txtMemberAge.Text = CurrentMember.Age;
            cbxMemberGender.SelectedIndex = CurrentMember.Gender == Gender.male ? 0 : 1;
            dtMembershipStart.Value = CurrentMember.DateStart.Date;
            picMember.Image = CurrentMember.Image;
        }

        private void cbxDurationMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtMembershipTo.Value = dtMembershipFrom.Value.AddMonths(int.Parse(cbxDurationMonth.Text));
        }

        private void txtSearchMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter)
                return;
            if (txtSearchMember.Text == "") return;
            if (CurrentTab == btnListMale)
            {
                try
                {

                    var members = DBObjects_Intializer.memberRepository.RetriveMembers("ذكر", txtSearchMember.Text);
                    ShowListOFMembersCard(members);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else if (CurrentTab == btnListFemale)
            {
                try
                {
                    var members = DBObjects_Intializer.memberRepository.RetriveMembers("أنثى", txtSearchMember.Text);
                    ShowListOFMembersCard(members);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void cbxDurationInMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtMembershipEnd.Value = dtMembershipStart.Value.AddMonths(cbxDurationInMonth.SelectedIndex + 1);
        }

        private void UCMemberInfo_Load(object sender, EventArgs e)
        {
            btnListMale.PerformClick();
        }

        private void dgMemberShipInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row == dgMemberShipInfo.RowCount - 1) return;
            DialogResult msg = MessageBox.Show("تأكيد حذف العضوية!", "رسالة تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg != DialogResult.Yes) return;
            Membership membership = new Membership()
            {
                Member = CurrentMember,
                DateStart = DateTime.Parse(dgMemberShipInfo.Rows[row].Cells["dtColRenewMembership"].Value.ToString()),
                DateEnd = DateTime.Parse(dgMemberShipInfo.Rows[row].Cells["dtColEndMembership"].Value.ToString()),
                Price = double.Parse(dgMemberShipInfo.Rows[row].Cells["ColPrice"].Value.ToString()),
            };
            DBObjects_Intializer.membershipRepository.RemoveMembership(membership);
            Activity act = new Activity()
            {
                ActType = ActivityType.RemoveMemberShip,
                Name = membership.Member.Name,
                Captin = Program.captinLogedIN,
                Date = DateTime.Now,
                Price = membership.Price * -1
            };
            DBObjects_Intializer.activityRepository.AddActivity(act);
            tblMemberShipInfo = DBObjects_Intializer.membershipRepository.RetriveOneMembership(CurrentMember.Phone);
            dgMemberShipInfo.DataSource = tblMemberShipInfo;
            GetAllMenMembersAndShowOnlyInProgress();
        }

        private void btnGenerateMemberCode_Click(object sender, EventArgs e)
        {
            string randomCode = GlobalFunc.RandomCode();
            var listCodes = DBObjects_Intializer.memberRepository.GetAllCodes();
            if(listCodes.Contains(randomCode)) randomCode = GlobalFunc.RandomCode();
            txtMemberCode.Text = randomCode;
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if(CurrentMember is null)
            {
                MessageBox.Show("اختر احد الاعضاء!");
                return;
            }
            DeleteMember(CurrentMember);
        }

        private void DeleteMember(Member member)
        {
            DialogResult msg = MessageBox.Show(
                            "اذا قمت بتأكيد الحذف سوف تفقد جميع البينات الخاصة بالعضو بما فيها الاشتراكات السابقة \n تأكيد الحذف؟",
                            "تحذير حذف احد الاعظاء",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Asterisk
                            );
            if (msg != DialogResult.Yes) return;
            DBObjects_Intializer.memberRepository.DeleteMember(member);
            Activity act = new Activity()
            {
                ActType = ActivityType.RemoveMember,
                Name = member.Name,
                Captin = Program.captinLogedIN,
                Date = DateTime.Now,
                Price = 0
            };
            DBObjects_Intializer.activityRepository.AddActivity(act);
            GetAllMenMembersAndShowOnlyInProgress();
            CurrentMember = CurrentMembers.Find(x => x.MembershipState == MembershipState.InProgress);
            UCMemberCard.FireClickedEvent(CurrentMember);
        }
    }
}
