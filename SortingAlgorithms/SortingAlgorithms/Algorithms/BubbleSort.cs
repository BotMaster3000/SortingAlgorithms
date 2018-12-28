using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms.Interfaces;

namespace SortingAlgorithms.Algorithms
{
    public class BubbleSort : ISortingAlgorithm
    {
        public int[] Sort(int[] unsortedArray)
        {
            bool notSorted;
            do
            {
                notSorted = false;
                for (int i = 1; i < unsortedArray.Length; ++i)
                {
                    if (unsortedArray[i] < unsortedArray[i - 1])
                    {
                        notSorted = true;
                        int tempInt = unsortedArray[i];
                        unsortedArray[i] = unsortedArray[i - 1];
                        unsortedArray[i - 1] = tempInt;
                    }
                }
            }
            while (notSorted);
            return unsortedArray;
        }
    }
}
