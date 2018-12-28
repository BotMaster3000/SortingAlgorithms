using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms.Tests
{
    [TestClass]
    public class CountingSortTests
    {
        private void CheckIfInOrder(int[] numberArray)
        {
            for (int i = 1; i < numberArray.Length; ++i)
            {
                if (numberArray[i - 1] > numberArray[i])
                {
                    Assert.Fail($"Array not in order. {numberArray[i - 1]} is bigger than {numberArray[i]}");
                }
            }
        }

        [TestMethod]
        public void SortTest_SingleOccurance_NoGap()
        {
            int[] numberArray = new int[] { 4, 2, 3, 1, 6, 0, 5, 7, 9, 8 };
            CountingSort sorter = new CountingSort();
            int[] returnArray = sorter.Sort(numberArray);
            CheckIfInOrder(returnArray);
        }

        [TestMethod]
        public void SortTest_SingleOccurance_Gap()
        {
            int[] numberArray = new int[] { 4, 2, 9, 19, 500 };
            CountingSort sorter = new CountingSort();
            int[] returnArray = sorter.Sort(numberArray);
            CheckIfInOrder(returnArray);
        }

        [TestMethod]
        public void SortTest_MultipleOccurance_Gap()
        {
            int[] numberArray = new int[] { 5, 5, 10, 10, 7, 8, 20, 1, 0 };
            CountingSort sorter = new CountingSort();
            int[] returnArray = sorter.Sort(numberArray);
            CheckIfInOrder(returnArray);
        }
    }
}