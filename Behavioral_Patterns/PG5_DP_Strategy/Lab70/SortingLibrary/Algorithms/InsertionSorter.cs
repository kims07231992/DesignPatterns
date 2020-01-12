using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary.Algorithms
{
    public class InsertionSorter<T> : ISortable<T> where T : IComparable<T>
    {
        public void Sort(T[] elements)
        {
            if (elements == null)
            {
                return;
            }

            for (int i = 1; i < elements.Length; i++)
            {
                T key = elements[i];
                int j = i - 1;

                while (j >= 0 && elements[j].CompareTo(key) > 0)
                {
                    elements[j + 1] = elements[j];
                    j--;
                }
                elements[j + 1] = key;
            }
        }
    }
}
