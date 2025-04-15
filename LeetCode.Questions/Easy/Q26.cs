using System.Collections.Generic;

namespace LeetCode.Questions.Easy
{
    /// <summary>
    /// Given a sorted array nums, remove the duplicates in-place such that each element appears only once and returns the new length.
    /// </summary>
    public class Q26
    {
        List<int> pureArray;

        public Q26()
        {
            pureArray = new List<int>();
        }

        public int RemoveDuplicates(int[] testArray)
        {
            foreach (var num in testArray)
            {
                if (!CheckIfExists(num))
                {
                    pureArray.Add(num);
                    pureArray.RemoveAll(x=>x == num);
                }
            }

            pureArray.Sort();
            return pureArray.ToArray().Length;
        }

        bool CheckIfExists(int num)
        {
            return pureArray.Contains(num);
        }
    }
}
