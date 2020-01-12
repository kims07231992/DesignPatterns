using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary.Algorithms
{
    public interface ISortable<T>
    {
        void Sort(T[] elements);
    }
}
