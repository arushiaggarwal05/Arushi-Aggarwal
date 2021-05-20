using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Interfaces;

namespace WinFormsApp2.Classes
{
    class PrintOnFile : IPrint
    {
        public void Print(string value)
        {
            string path = System.IO.Path.GetFullPath(@"..\..\..\");
            path = string.Concat(path, "\\UserData\\ResultFile.txt" );

            //File.Create(path);

            File.WriteAllText(path, value);

            MessageBox.Show("Data successfully written to " + path);
        }
    }
}
