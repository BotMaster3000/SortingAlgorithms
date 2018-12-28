using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms.Interfaces;

namespace SortingAlgorithms.Algorithms
{
    public class InsertionSort : ISortingAlgorithm
    {
        public int[] Sort(int[] unsortedArray)
        {
            for(int i = 0; i < unsortedArray.Length; ++i)
            {
                for(int j = i + 1; j < unsortedArray.Length; ++j)
                {
                    if(unsortedArray[i] > unsortedArray[j])
                    {
                        int tempInt = unsortedArray[i];
                        unsortedArray[i] = unsortedArray[j];
                        unsortedArray[j] = tempInt;
                    }
                }
            }
            return unsortedArray;
        }
    }
}
