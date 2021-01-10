using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
    public class TwoSum
    {
        /*Instructions: Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        You can return the answer in any order.

        Example 1: 
            Input: nums = [2,7,11,15], target = 9
            Output: [0,1]
            Output: Because nums[0] + nums[1] == 9, we return [0, 1].
        
        Example 2:
            Input: nums = [3,2,4], target = 6
            Output: [1,2]
        
        Example 3:
            Input: nums = [3,3], target = 6
            Output: [0,1]
         
        Constraints:
            2 <= nums.length <= 103
            -109 <= nums[i] <= 109
            -109 <= target <= 109
            Only one valid answer exists.
        */

        public void Run()
        {
            int[] input = new int[4] { 2, 7, 11, 15 };
            int target = 9;
            int[] result = SolveTwoSum(input, target);
        }

        private int[] SolveTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> valuesAndIndices = new Dictionary<int, int>();
            
            //Do a single pass of the array. Adding newly found elements to the dictionary.
            //Check against the target and see if the remainder is in the array with it's index.
            for(int i = 0; i < nums.Length; i++)
            {
                int remainder = target - nums[i];
                if (valuesAndIndices.TryGetValue(remainder, out int index) && index != i)
                {
                    return new int[2] { i, index };
                }

                if (!valuesAndIndices.ContainsKey(nums[i]))
                {
                    valuesAndIndices.Add(nums[i], i);
                }
            }
            Console.WriteLine("ERROR: No valid two sum was found.");
            return null;
        }
    }
}
