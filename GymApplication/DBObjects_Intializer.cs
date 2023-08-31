using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymApp.Logic.DBClasses;

namespace GymApplication
{
    public static class DBObjects_Intializer
    {
        public static CaptinRepository CaptinRepository = new CaptinRepository();
        public static OtherActsRepository otherActsRepository = new OtherActsRepository();
        public static MemberRepository memberRepository = new MemberRepository();
        public static ActivityRepository activityRepository = new ActivityRepository();
        public static MembershipRepository membershipRepository = new MembershipRepository();
        public static LessonRepository lessonRepository = new LessonRepository();
    }
}
