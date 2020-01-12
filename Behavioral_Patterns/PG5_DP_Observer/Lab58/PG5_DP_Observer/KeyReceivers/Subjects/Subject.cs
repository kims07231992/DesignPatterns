using PG5_DP_Observer.KeyReceivers.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Observer.KeyReceivers.Subjects
{
    internal class Subject
    {
        public delegate void NumberChangedDelegate(int number);
        public NumberChangedDelegate NumberChanged;

        public void ChangeNumber(int number)
        {
            this.NumberChanged?.Invoke(number);
        }
    }
}
