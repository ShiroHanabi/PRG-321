using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShamelessCopy
{
    public class GuiPrinter : IPrinter
    {
        public void Print(string TheMessage)
        {
            MessageBox.Show(TheMessage);
        }
    }
}
