using System.Collections.Generic;

namespace LeetCode.Questions.Easy
{
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
