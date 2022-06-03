using System;
using System.Collections.Generic;

namespace MaxSubArray
{
    public class MaxSubArrayApp
    {
        public static void Main(string[] args)
        {
        }

        public (int, List<int>) MaxSubArray(int[] nums)
        {
            List<int> maxValues = new List<int>();
            int maxSum = nums[0], sum = maxSum;

            maxValues.Add(nums[0]);
            for (var i = 0; i < nums.Length; i++)
            {
                sum = 0;
                for (var j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (maxSum < sum)
                    {
                        maxValues.Clear();
                        for (var y = i; y <= j; y++)
                        {
                            maxValues.Add(nums[y]);
                        }
                        maxSum = sum;
                    }
                }
            }
            return (maxSum, maxValues);
        }
    }
}
