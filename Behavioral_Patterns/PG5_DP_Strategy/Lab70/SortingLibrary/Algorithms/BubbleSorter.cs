using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary.Algorithms
{
    public class BubbleSorter<T> : ISortable<T> where T : IComparable<T>
    {
        public void Sort(T[] elements)
        {
            if (elements == null)
            {
                return;
            }

            int endIndex = elements.Length - 1;
            bool flag = true; // Flag to prevent unnecessary loop
            while (endIndex >= 0)
            {
                if (!flag) // If looped without swapping
                {
                    break;
                }

                flag = false;
                for (int i = 0; i < endIndex; i++)
                {
                    if (elements[i].CompareTo(elements[i + 1]) > 0)
                    {
                        Swap(elements, i, i + 1);
                        flag = true;
                    }
                }
                endIndex--;
            }
        }

        private void Swap(T[] elements, int i, int j)
        {
            T temp = elements[i];
            elements[i] = elements[j];
            elements[j] = temp;
        }
    }
}
