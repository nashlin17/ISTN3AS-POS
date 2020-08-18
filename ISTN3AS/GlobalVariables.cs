using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ISTN3AS
{
    public static class GlobalVariables
    {
        public static double cartTotal;
        //Added to Order and OrderLine Tables
        public static List<string> productCart_ProductID = new List<string>();
        public static List<int> productCart_Quantity = new List<int>();
        public static List<double> productCart_UnitPrice = new List<double>();

        public static string TransactionType;
        public static int MemberID;
        public static int StaffID;
        public static double AccDiscount = 0.05;

    }
}
