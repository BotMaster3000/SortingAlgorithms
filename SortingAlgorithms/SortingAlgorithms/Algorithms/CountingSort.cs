using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms.Interfaces;

namespace SortingAlgorithms.Algorithms
{
    public class CountingSort : ISortingAlgorithm
    {
        private Dictionary<int, int> unsortedDictionary;

        public int[] Sort(int[] unsortedArray)
        {
            CountOccurances(unsortedArray);

            int[] dictionaryKeys = SortDictionaryKeys();

            return GetReturnArray(dictionaryKeys);
        }

        private Dictionary<int, int> CountOccurances(int[] unsortedArray)
        {
            unsortedDictionary = new Dictionary<int, int>();
            foreach (int number in unsortedArray)
            {
                if (unsortedDictionary.Keys.Contains(number))
                {
                    ++unsortedDictionary[number];
                }
                else
                {
                    unsortedDictionary.Add(number, 1);
                }
            }
            return unsortedDictionary;
        }

        private int[] SortDictionaryKeys()
        {
            int[] dictionaryKeys = unsortedDictionary.Keys.ToArray();
            for (int i = 0; i < dictionaryKeys.Length; ++i)
            {
                for (int j = i + 1; j < dictionaryKeys.Length; ++j)
                {
                    if (dictionaryKeys[i] > dictionaryKeys[j])
                    {
                        int tempInt = dictionaryKeys[i];
                        dictionaryKeys[i] = dictionaryKeys[j];
                        dictionaryKeys[j] = tempInt;
                    }
                }
            }
            return dictionaryKeys;
        }

        private int[] GetReturnArray(int[] dictionaryKeys)
        {
            List<int> returnList = new List<int>();
            foreach (int key in dictionaryKeys)
            {
                for (int i = 0; i < unsortedDictionary[key]; ++i)
                {
                    returnList.Add(key);
                }
            }
            return returnList.ToArray();
        }
    }
}
