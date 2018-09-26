using HSDL_IDM_P2.Lib.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HSDL_IDM_P2.Utils
{
    public class Defs
    {
        public static string[] ipAddresses = new string[] { "http://hsdlmain.brta.gov.bd",
                                                  "http://hsdl.brta.gov.bd",
                                                  "http://192.168.220.59",
                                                  "http://172.26.51.59",
                                                  "http://192.168.1.80",
                                                  "http://localhost:7003",
                                                  "http://193.169.101.59"};
        public static String VERSION_NO = "v 1.3";
        public const int EMPTY_VALUE = -1;
        public const String PERMISSION_ROLE = "ROLE";
        public const String TARGET_HSDLCLIENT = "HSDLCLIENT";
        public const String TARGET_SELECT = "SELECT";
        public const String TARGET_ORGANIZATION = "ORGANIZATION";
        public const String TARGET_DIVISION = "DIVISION";
        public const String TARGET_DEPARTMENT = "DEPARTMENT";
        public const String TARGET_TIGERIDM = "TIGERIDM";
        public const String TARGET_API = "API";
        public const String TARGET_UNIFIED = "UNIFIED";
        public const String TARGET_ENROLLMENTCLIENT = "ENROLLMENTCLIENT";
        public const String TARGET_ADMINPORTAL = "ADMINPORTAL";
        public const String TARGET_PERSOCLIENT = "PERSOCLIENT";

        public static DataGridTemplateColumn CHECKBOX_COLUMN = null;

        public static List<LabelName> targetListGenerator()
        {
            List<LabelName> targetList = new List<LabelName>();
            targetList.Add(new LabelName(TARGET_SELECT, "নির্বাচন করুন", ""));
            targetList.Add(new LabelName(TARGET_ADMINPORTAL, "অ্যাডমিন পোর্টাল", TARGET_ADMINPORTAL));
            targetList.Add(new LabelName("ENROLLMENT CLIENT", "এনরোলমেন্ট", TARGET_ENROLLMENTCLIENT));
            targetList.Add(new LabelName("HSDL CLIENT", "এইচ.এস.ডি.এল ক্লাইন্ট", TARGET_HSDLCLIENT));
            targetList.Add(new LabelName("PERSO CLIENT", "পারসোক্লাইন্ট", TARGET_PERSOCLIENT));
            targetList.Add(new LabelName(TARGET_TIGERIDM, "টাইগার আইডিএম", TARGET_TIGERIDM));
            targetList.Add(new LabelName(TARGET_UNIFIED, "ইউনিফাইড", TARGET_UNIFIED));

            return targetList;
        }
        public enum LOOKUP_TYPE
        {
            DISTRICT_LOOKUP=1,
            MUNICIPALITY_LOOKUP,
            WARD_LOOKUP,
            POLLING_STATION_LOOKUP
        }
    }
}
