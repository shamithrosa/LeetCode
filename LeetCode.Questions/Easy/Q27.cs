using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Questions.Easy
{
    public class Q27
    {
        public int RemoveElement(int[] nums, int val)
        {
            List<int> newNums = new List<int>();

            foreach (var num in nums)
            {
                if (num != val)
                {
                    newNums.Add(num);
                }
            }
            
            return newNums.Count();
        }
    }
}
