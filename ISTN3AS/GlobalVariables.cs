using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
        public static double AccDiscount = 0;

        //Customer Details
        public static string customerName_Order;
        public static string customerCellNo_Order;
        public static bool isMemeber = false;

        public static void Clear()
        {
            cartTotal = 0;
            productCart_ProductID.Clear();
            productCart_Quantity.Clear();
            productCart_UnitPrice.Clear();
            TransactionType = "";
            MemberID = -1;
            //StaffID = new int();
            customerCellNo_Order = "";
            customerName_Order = "";
            isMemeber = false;
        }

    }
}
