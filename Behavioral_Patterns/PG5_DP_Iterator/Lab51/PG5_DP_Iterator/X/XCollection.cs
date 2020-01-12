using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Iterator.X
{
    public class XCollection : IXCollection
    {
        // Fields
        private Lazy<List<object>> _myList;
        private Lazy<EvenIterator> _myEvenIterator;

        // Constructor
        public XCollection()
        {
            this._myList = new Lazy<List<object>>();
            this._myEvenIterator = new Lazy<EvenIterator>(() => new EvenIterator(this._myList.Value));
        }

        // Methods
        public IXIterator GetIterator()
        {
            return this._myEvenIterator.Value;
        }
        public void Add(object o)
        {   
            this._myList.Value.Add(o);
        }
    }
}
