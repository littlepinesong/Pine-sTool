﻿namespace Pine_sTool
{
    internal static class PineConn
    {
        // static string SqlConn = "server=192.168.10.203;database=hb_Auto_Mng;user=cshadmin;pwd=57Ki)j9-";
        private static string hbzcdb = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4awI97SYV9XbCsW3vyX108LTo9WTK65ijTUsZnbsJt9V5kwZwxjVyX7";

        private static string hbswdb = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4ayLJjtTSdIir/2jwxRfXOOumF4+CiP0egMKFACME085FoPLDne2nTu";
        private static string hbcshdb = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4bnkc3LLd+S6Gg7cEznpp+6zu9nbVY3bDcWMDa0VZywyfN/UEmB/MT6";
        private static string hbAutodb = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4YRlR7SuY5SE+nENpY6tc4ctXsJDLe1uZaMJd/XYyUDD3yvvxoTRHn1";
        private static string hbFlowdb = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4bsHCkJ0rJtfxwSyYdklGKADNQaEjGeH/zbrqgBUvhztPdckY6/Ls8L";
        private static string hbDrawingMng = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4biaZd5yvLSDTb2j9JBgyMjpbeqjEKeHEd12wgnUpynTUDGvTqvyCOVnYvF0IjpU00=";
        private static string hbNoDrawingMng = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4Ysb75Mr8L2yOB6aLp4vWegf9g/YIpMkXgwPhEyL6n88q0FgNICn3v1QEfI8SN7fhQ=";
        private static string hbPlmdb = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL9klxZRgJn4bkM89lSAowfVohX5zbLxCoM1HhgCtBk+9hyM618jZ9XGqsktdfQZAG";
        private static string hbswcqdb = "s34MpWdDScQ0dCeebvIBXbyvm7GFKbfL/Zm2iap4xvwl9ygPVXregcKSH/dsMhEeT+mqa9FZwow5Yx0zGwU0q+2t+EDN5lM+";
        
        public static string SqlConnSwcq
        {
            get
            {
                string str = "";
                str = DESEncrypt.Decrypt(hbswcqdb, "CP181224");
                return str;
            }
        }


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