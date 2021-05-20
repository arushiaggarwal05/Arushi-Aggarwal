using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Enum;
using WinFormsApp2.Interfaces;

namespace WinFormsApp2.Classes
{
    static class ResolvePrintType
    {
        public static IPrint ResolvePrint(EnumPrintType type)
        {
            if (type == EnumPrintType.OnScreen)
                return new PrintOnScreen();
            else if (type == EnumPrintType.File)
                return new PrintOnFile();
            else if (type == EnumPrintType.Paper)
                return new PrintOnPaper();
            else
                return null;
        }
    }
}
