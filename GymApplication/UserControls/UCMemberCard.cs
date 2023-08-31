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

namespace GymApplication.UserControls
{
    public partial class UCMemberCard : UserControl
    {
        Member CardMember;
        public delegate void clickCard(Member member);
        public static event clickCard cardClicked;
        public delegate void EditMember(Member member);
        public static event EditMember EditMemberClicked;
        public delegate void DeleteMember(Member member);
        public static event DeleteMember DeleteMemberClicked;
        public UCMemberCard(Member member)
        {

            InitializeComponent();
            CardMember = member;
            this.lblCardName.Text = member.Name;
            this.lblMemershipCardStatus.Text = GlobalFunc.GetStrMembershipState(member.MembershipState);
            if (member.Image == null)
                member.Image = picCardMember.Image;
            picCardMember.Image = member.Image;
            switch (member.MembershipState)
            {
                case MembershipState.InProgress:
                    lblMemershipCardStatus.ForeColor = Color.FromArgb(0, 192, 0);
                    break;
                case MembershipState.AboutToEnd:
                    lblMemershipCardStatus.ForeColor = Color.DarkGoldenrod;
                    break;
                case MembershipState.Ended:
                    lblMemershipCardStatus.ForeColor = Color.Red;
                    break;
                default:
                    break;
            }
            this.cardOption.Hide();
        }

        private void btnShowCardOption_Click(object sender, EventArgs e)
        {
            trOptionCard.ShowSync(cardOption);
        }

        private void btnHideMemberCard_Click(object sender, EventArgs e)
        {
            trOptionCard.HideSync(cardOption);
        }

        private void gunaCirclePictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.gunaShadowPanel1.BaseColor = Color.FromArgb(174, 215, 232);
        }

        private void gunaCirclePictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.gunaShadowPanel1.BaseColor = Color.White;
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            FireClickedEvent(CardMember);
        }

        public static void FireClickedEvent(Member member)
        {
            cardClicked(member);
        }

        private void btnEditMemberCard_Click(object sender, EventArgs e)
        {
            EditMemberClicked(CardMember);
        }

        private void btnDeleteMemberCard_Click(object sender, EventArgs e)
        {
            DeleteMemberClicked(CardMember);
        }
    }
}
