using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Classes;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Handler handlerObj;
        public Form1()
        {
            InitializeComponent();
            handlerObj = new Handler();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Usertype = handlerObj.Login(TxtUsername.Text, TxtPassword.Text);
            if (Usertype == null)
                UnsuccessfullLogin();
            else
                SuccessfullLogin(Usertype);
        }

        private void UnsuccessfullLogin()
        {
            LblLoginError.Visible = true;
            TxtPassword.Text = "";
        }

        private void SuccessfullLogin(string usertype)
        {
            LblLoginError.Visible = false;
            Reset();
            PanelLogin.Visible = false;
            PanelUser.Visible = true;
            LblWelcome.Text = "Welcome " + usertype + " User";
            if(usertype.Equals("Priviledged"))
            {
                LblDiscountP.Visible = true;
                TxtDiscountP.Visible = true;
                TxtDiscountP.Text = handlerObj.GetDiscountPercentage().ToString();
            }
            else
            {
                LblDiscountP.Visible = false;
                TxtDiscountP.Visible = false;
            }
        }

        private void Reset()
        {
            LblLoginError.Visible = false;
            TxtPassword.Text = "";
            TxtUsername.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LblLoginError.Visible = false;
            Reset();
            PanelLogin.Visible = true;
            PanelUser.Visible = false;
            ResetPanel2();
            handlerObj.Logout();
        }

        private void ResetPanel2()
        {
            TxtDiscountP.Text = "";
            TxtGoldPrice.Text = "";
            TxtTotalPrice.Text = "";
            TxtWeight.Text = "";
            LblCorrectData.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            if (Calculate())
                handlerObj.Print(Enum.EnumPrintType.OnScreen);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (Calculate())
                handlerObj.Print(Enum.EnumPrintType.File);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            if(Calculate())
                handlerObj.Print(Enum.EnumPrintType.Paper);
        }

        private bool Calculate()
        {
            LblCorrectData.Visible = false;
            decimal price = 0, weight = 0;
            decimal res = -1;
            if (decimal.TryParse(TxtGoldPrice.Text, out price))
            {
                if (decimal.TryParse(TxtWeight.Text, out weight))
                {
                    res = handlerObj.Calculate(price, weight);
                }
            }
            if (res == -1)
            {
                LblCorrectData.Visible = true;
                return false;
            }
            else
            {
                TxtTotalPrice.Text = res.ToString();
                return true;
            }
        }
    }
}
