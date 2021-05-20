using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Enum;

namespace WinFormsApp2.Classes
{
    class Handler
    {
        HandleLogin handleLogin;
        HandleCalculation handleCalculation;
        HandlePrinting handlePrint; 
        User user = null;
        decimal TotalGoldPrice = 0;
        public Handler()
        {
            handleLogin = new HandleLogin();
            handleCalculation = new HandleCalculation();
            handlePrint = new HandlePrinting();
        }

        public string Login(string userName, string pwd)
        {
            user = handleLogin.Login(userName, pwd);
            if(user != null)
                return user.UserType.ToString();
            return null;
        }


        public void Logout()
        {
            user = null;
            handleLogin.logout();
        }

        public decimal Calculate(decimal price, decimal weight)
        {
            decimal discount = 0;
            if (user.UserType == Enum.EnumUserType.Priviledged)
                discount = GetDiscountPercentage();
            TotalGoldPrice = handleCalculation.CalculateTotalPrice(price, weight, discount);
            return TotalGoldPrice;
        }

        public decimal GetDiscountPercentage()
        {
            return handleCalculation.GetDiscountValue();
        }

        public void Print(EnumPrintType printType)
        {
            handlePrint.Print(printType, TotalGoldPrice.ToString());
        } 
    }
}
