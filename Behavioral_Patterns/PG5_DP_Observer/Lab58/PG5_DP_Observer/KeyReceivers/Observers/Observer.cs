using PG5_DP_Observer.KeyReceivers.Subjects;
using PG5_DP_Observer.Printers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Observer.KeyReceivers.Observers
{
    internal class Observer
    {
        private Lazy<IPrinter> _printer = new Lazy<IPrinter>(() => new DebugPrinter());
        private string _name;

        public Observer(string name)
        {
            this._name = name;
        }

        public void Subscribe(Subject subject)
        {
            subject.NumberChanged += Print;
        }

        public void Unsubscribe(Subject subject)
        {
            subject.NumberChanged -= Print;
        }

        private void Print(int number)
        {
            this._printer.Value.Print($"{number} Pressed, {this._name}");
        }
    }
}
