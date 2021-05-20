using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Enum;

namespace WinFormsApp2.Interfaces
{
    interface ILoginAbstractFactory
    {
        ILogin CreateLoginObject();
    }
}
