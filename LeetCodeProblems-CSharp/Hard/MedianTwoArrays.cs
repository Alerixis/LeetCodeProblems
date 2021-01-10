using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    public class MedianTwoArrays
    {
        /*Instructions: 
          Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
          Follow up: The overall run time complexity should be O(log (m+n)).

         Example 1:
             Input: nums1 = [1,3], nums2 = [2]
             Output: 2.00000
             Explanation: merged array = [1,2,3] and median is 2.
         
         Example 2:
             Input: nums1 = [1,2], nums2 = [3,4]
             Output: 2.50000
             Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
         
         Example 3:
             Input: nums1 = [0,0], nums2 = [0,0]
             Output: 0.00000
         
         Example 4:
             Input: nums1 = [], nums2 = [1]
             Output: 1.00000
         
         Example 5:
             Input: nums1 = [2], nums2 = []
             Output: 2.00000
         
         Constraints:
             nums1.length == m
             nums2.length == n
             0 <= m <= 1000
             0 <= n <= 1000
             1 <= m + n <= 2000
             -106 <= nums1[i], nums2[i] <= 106
        */
        public void Run()
        {
            int[] nums1 = new int[2] { 0, 0 };
            int[] nums2 = new int[3] { 0, 0, 1 };
            double result = FindMedianSortedArrays(nums1, nums2);
        }

        struct thing {
            int valu1;
            int vlue1l;
        }
        public thing DoMath(int value)
        {

        }


        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double median = 0;

            if(nums1.Length < nums2.Length)
            {
                int[] temp = nums1;
                nums1 = nums2;
                nums2 = temp;
            }

            double fullLength = nums1.Length + nums2.Length;
            bool isEven = fullLength % 2 == 0;
            
            int medianIndex = (int)Math.Ceiling(fullLength / 2) - 1;
            int maxIndex = isEven ? medianIndex + 1 : medianIndex;
            
            int index1 = 0;
            int index2 = 0;
            
            int currentMergeIndex = 0;
            int currentValue = 0;

            while(currentMergeIndex <= maxIndex)
            {
                if (index1 >= nums1.Length && index2 < nums2.Length)
                {
                    currentValue = nums2[index2];
                    index2++;
                }
                else if (index2 >= nums2.Length && index1 < nums1.Length)
                {
                    currentValue = nums1[index1];
                    index1++;
                } 
                else
                {
                    if(nums1[index1] <= nums2[index2])
                    {
                        currentValue = nums1[index1];
                        index1++;
                    }
                    else
                    {
                        currentValue = nums2[index2];
                        index2++;
                    }
                }

                if(isEven && currentMergeIndex == maxIndex - 1)
                {
                    median += currentValue;
                }
                currentMergeIndex++;
            }
            return isEven ? (median + currentValue) / 2 : currentValue;
        }
    }
}
