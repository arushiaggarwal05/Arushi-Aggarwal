using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Classes
{
    class HandleCalculation
    {
        Decimal PriviledgeDiscount = 0;
        public HandleCalculation()
        {
            string path = System.IO.Path.GetFullPath(@"..\..\..\");
            path = string.Concat(path, "\\UserData\\Discount.txt");

            string discount = File.ReadAllText(path);
            PriviledgeDiscount = Convert.ToDecimal(discount);
        }

        public decimal GetDiscountValue()
        {
            return PriviledgeDiscount;
        }

        public Decimal CalculateTotalPrice(decimal price, decimal weight, decimal dis)
        {
            decimal res = price * weight;
            res = res - (res * dis / 100);
            return res;
        }
    }
}
