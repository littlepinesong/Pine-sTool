using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pine_sTool
{
    static class PineConn
    {
        // static string SqlConn = "server=192.168.10.203;database=hb_Auto_Mng;user=cshadmin;pwd=57Ki)j9-";
        static string hbzcdb = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4awI97SYV9XbCsW3vyX108LTo9WTK65ijTUsZnbsJt9V5kwZwxjVyX7";
        static string hbswdb = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4ayLJjtTSdIir/2jwxRfXOOumF4+CiP0egMKFACME085FoPLDne2nTu";
        static string hbcshdb = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4bnkc3LLd+S6Gg7cEznpp+6zu9nbVY3bDcWMDa0VZywyfN/UEmB/MT6";
        static string hbAutodb = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4YRlR7SuY5SE+nENpY6tc4ctXsJDLe1uZaMJd/XYyUDD3yvvxoTRHn1";
        static string hbFlowdb = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4bsHCkJ0rJtfxwSyYdklGKADNQaEjGeH/zbrqgBUvhztPdckY6/Ls8L";
        static string hbDrawingMng = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4biaZd5yvLSDTb2j9JBgyMjpbeqjEKeHEd12wgnUpynTUDGvTqvyCOVnYvF0IjpU00=";
        static string hbNoDrawingMng = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4Ysb75Mr8L2yOB6aLp4vWegf9g/YIpMkXgwPhEyL6n88q0FgNICn3v1QEfI8SN7fhQ=";
        static string hbPlmdb = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4bkM89lSAowfVohX5zbLxCoM1HhgCtBk+9hyM618jZ9XGqsktdfQZAG";
        public static string SqlConnPlmdb
        {
            get
            {
                string str = "";
                str = DESEncrypt.Decrypt(hbPlmdb, "CP181224");
                return str;
            }
        }
        public static string SqlConnNoDrawingMng
        {
            get
            {
                string str = "";
                str = DESEncrypt.Decrypt(hbNoDrawingMng, "CP181224");
                return str;
            }
        }
        public static string SqlConnDrawingMng
        {
            get
            {
                string str = "";
                str = DESEncrypt.Decrypt(hbDrawingMng, "CP181224");
                return str;
            }
        }
        public static string SqlConnSW
        {
            get
            {
                string str = "";
                str = DESEncrypt.Decrypt(hbswdb, "CP181224");
                return str;
            }
        }
        public static string SqlConnZC
        {
            get
            {
                string str = "";
                str = DESEncrypt.Decrypt(hbzcdb, "CP181224");
                return str;
            }
        }
        public static string SqlConnAuto
        {
            get
            {
                string str = "";
                str = DESEncrypt.Decrypt(hbAutodb, "CP181224");
                return str;
            }
        }
        public static string SqlConnCSH
        {
            get
            {
                string str = "";
                str = DESEncrypt.Decrypt(hbcshdb, "CP181224");
                return str;
            }
        }
        public static string SqlConnFlow
        {
            get
            {
                string str = "";
                str = DESEncrypt.Decrypt(hbFlowdb, "CP181224");
                return str;
            }
        }

    }
}
