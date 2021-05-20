using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Interfaces;

namespace WinFormsApp2.Classes
{
    class HandlePrinting
    {
        IPrint iprint;
        public void Print(Enum.EnumPrintType printtype, string value)
        {
            try
            {
                iprint = ResolvePrintType.ResolvePrint(printtype);
                iprint.Print(value);
            }
            catch(NotImplementedException ex)
            {
                MessageBox.Show("Method not implemented");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
