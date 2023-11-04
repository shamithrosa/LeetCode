using System.Collections.Generic;

namespace LeetCode.Questions.Easy
{
    public class Q1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> indices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (indices.ContainsKey(complement))
                {
                    return new int[] { indices[complement], i };
                }
                indices[nums[i]] = i;
            }

            return new int[] { -1, -1 };
        }
    }
}
