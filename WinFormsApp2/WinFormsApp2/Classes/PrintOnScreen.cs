using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Interfaces;

namespace WinFormsApp2.Classes
{
    class PrintOnScreen : IPrint
    {
        public void Print(string value)
        {
            MessageBox.Show("Total Price is - "+ value.ToString());
        }
    }
}
