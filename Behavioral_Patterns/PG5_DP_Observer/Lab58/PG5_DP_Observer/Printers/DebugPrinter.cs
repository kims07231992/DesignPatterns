using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Observer.Printers
{
    internal class DebugPrinter : IPrinter
    {
        public void Print(string message)
        {
            Debug.Print(message);
        }
    }
}
