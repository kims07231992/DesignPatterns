using SortingLibrary.Algorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary
{
    public class Sorter<T> where T : IComparable
    {
        private ISortable<T> _algorithm;

        public Sorter(ISortable<T> algorithm)
        {
            this._algorithm = algorithm;
        }

        public TimeSpan GetSortingTime(T[] elements)
        {
            if (this._algorithm == null)
            {
                throw new ArgumentNullException();
            }

            var stopWatch = new Stopwatch();

            stopWatch.Start();
            this._algorithm.Sort(elements);
            stopWatch.Stop();

            var ts = stopWatch.Elapsed; // Get the elapsed time as a TimeSpan value.

            return ts;
        }
    }
}
