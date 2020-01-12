using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary.Algorithms
{
    public class MergeSorter<T> : ISortable<T> where T : IComparable<T>
    {
        public void Sort(T[] elements)
        {
            if (elements == null || elements.Length < 1)
            {
                return;
            }

            MergeSort(elements, 0, elements.Length - 1);
        }

        private void MergeSort(T[] elements, int start, int end)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;
                MergeSort(elements, start, middle);
                MergeSort(elements, middle + 1, end);
                Merge(elements, start, middle, end);
            }
        }

        private void Merge(T[] elements, int start, int middle, int end)
        {
            int left = start;
            int right = middle + 1;
            int size = end - start + 1;
            T[] temp = new T[size];

            int index = 0;
            while (left <= middle && right <= end)
            {
                if (elements[left].CompareTo(elements[right]) <= 0)
                {
                    temp[index] = elements[left];
                    left++;
                }
                else
                {
                    temp[index] = elements[right];
                    right++;
                }
                index++;
            }

            Array.Copy(elements, left, temp, index, middle - left + 1); // If while loop ended without copying left part to temp
            Array.Copy(elements, right, temp, index, end - right + 1); // If while loop ended without copying right part to temp
            Array.Copy(temp, 0, elements, start, size);
        }
    }
}
