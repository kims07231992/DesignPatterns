using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary.Algorithms
{
    public class QuickSorter<T> : ISortable<T> where T : IComparable<T>
    {
        public void Sort(T[] elements)
        {
            if (elements == null || elements.Length < 1)
            {
                return;
            }

            QuickSort(elements, 0, elements.Length - 1);
        }

        private void QuickSort(T[] elements, int left, int right)
        {
            if (left < right)
            {
                int index = Partition(elements, left, right); // Return partitioned index 

                QuickSort(elements, left, index - 1);
                QuickSort(elements, index + 1, right);
            }
        }

        private int Partition(T[] elements, int left, int right)
        {
            int first = left;
            T pivot = elements[first];

            ++left; // Start with 

            while (left <= right)
            {
                while (elements[left].CompareTo(pivot) <= 0 && left < right)
                {
                    ++left;
                }

                while (elements[right].CompareTo(pivot) > 0 && left <= right)
                {
                    --right;
                }

                if (left < right)
                {
                    Swap(elements, left, right);
                }
                else
                {
                    break;
                }
            }

            Swap(elements, first, right); // Place pivot to end position

            return right;
        }

        private void Swap(T[] elements, int i, int j)
        {
            T temp = elements[i];
            elements[i] = elements[j];
            elements[j] = temp;
        }
    }
}
