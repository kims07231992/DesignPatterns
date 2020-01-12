using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Iterator.X
{
    public class EvenIterator : IXIterator
    {
        // Fields
        private int _index = 0;
        private List<object> _collection;

        // Delegates
        private Predicate<int> IsEven = s => ((s & 1) == 0); // bit check

        // Constructor
        public EvenIterator(List<object> collection)
        {
            this._collection = collection;
        }

        // Properties
        private bool IsFull
        {
            get { return _index < this._collection.Count ? false : true; }
        }

        // Methods
        public object Current()
        {
            return this._collection[this._index];
        }
        public object Next()
        {
            while (!IsFull)
            {
                if (isEven(this._index))
                {
                    return this._collection[this._index++];
                }
                this._index++;
            }
            return null;
        }
    }
}
