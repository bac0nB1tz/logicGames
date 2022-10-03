using System;
using System.Collections.Generic;

namespace twoIntsInArrayEqualGivenSum
{
    class Program
    {
        static bool findSumOfTwo(int[] array, int targetSum)
        {
            HashSet<int> foundValues = new HashSet<int>();
            foreach(int val in array){
                if(foundValues.Contains(targetSum-val)){
                    return true;
                }
                foundValues.Add(val);
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] array = { 5, 7, 1, 2, 8, 4, 3 };
            int[] targetSums = { 3, 20, 1, 2, 7 };
            //Target Sum 10 |7+3=10, 2+8=10
            //Target Sum 19 | No 2 values sum up to 19

            foreach (int targetSum in targetSums)
            {
                Console.WriteLine("{0}:{1}", targetSum, findSumOfTwo(array, targetSum));
            }
        }
    }
}
