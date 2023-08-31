using GymApp.Logic.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.Drawing;
using System.IO;

namespace GymApp.Logic
{
    
    public static class GlobalFunc
    {
        private static Random random = new Random();
        public static string RandomCode()
        {
            const string chars = "123456789";
            return new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static byte[] imageToByteArray(Image img)
        {
            
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms.ToArray();
        }
        public static string GetStrMembershipState(MembershipState memState)
        {
            switch (memState)
            {
                case MembershipState.AboutToEnd:
                    return "ينتهى قريبا";
                case MembershipState.InProgress:
                    return "إشتراك جارى";
                case MembershipState.Ended:
                    return "إشتراك منتهى";
                default:
                    throw new ArgumentException("not valid MembershipState");
            }
        }
        public static void ClearControls(GunaShadowPanel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is GunaTextBox c)
                {
                    c.Text = "";
                }
                else if (control is GunaDateTimePicker c2) c2.ResetText();
                else if (control is GunaComboBox c3) c3.SelectedIndex = 0;
            }
        }
        public static Gender GetGender(string strGender)
        {
            switch (strGender)
            {
                case "ذكر":
                    return Gender.male;

                case "أنثى":
                    return Gender.female;

                case "none":
                    return Gender.none;

                default:
                    throw new ArgumentNullException("not valid Gender ..!");
            }
        }
        public static string getStrGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.male:
                    return "ذكر";
                case Gender.female:
                    return "أنثى";
                default:
                    throw new ArgumentNullException("not vaild gender");
            }
        }
        public static string GetStrPrivilliges(Privilliges Privilliges)
        {
            switch (Privilliges)
            {
                case Privilliges.admin:
                    return "مدير";

                case Privilliges.captinMen:
                    return "كابتن رجال";

                case Privilliges.captinWomen:
                    return "كابتن سيدات";

                default:
                    throw new ArgumentNullException("not valid Privilliges");
            }
        }
        public static Privilliges GetPrivilliges(string strPrivilliges)
        {
            switch (strPrivilliges)
            {
                case "مدير":
                    return Privilliges.admin;

                case "كابتن رجال":
                    return Privilliges.captinMen;

                case "كابتن سيدات":
                    return Privilliges.captinWomen;

                default:
                    throw new ArgumentNullException("not valid Privilliges");
            }
        }

        public static ActivityType GetActivityType(string strType)
        {
            switch (strType)
            {
                case "AddMember":
                    return ActivityType.AddMember;

                case "RenewMembership":
                    return ActivityType.RenewMembership;

                case "AddLesson":
                    return ActivityType.AddLesson;

                default:
                    throw new ArgumentNullException("not valid type ..!");
            }
        }

        public static string GetStrActivityType(ActivityType actType)
        {
            switch (actType)
            {
                case ActivityType.AddMember:
                    return"إضافة عضو";
                case ActivityType.RenewMembership:
                    return "تجديد عضوية";
                case ActivityType.AddLesson:
                    return "إضافة حصة";
                case ActivityType.RemoveMemberShip:
                    return "حذف عضوية";
                    case ActivityType.RemoveMember:
                    return "حذف عضو";
                default:
                    throw new ArgumentException("not valid exception");
            }
        }
    }
}
