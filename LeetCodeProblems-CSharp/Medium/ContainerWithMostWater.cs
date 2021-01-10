using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    /*Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai).
     * n vertical lines are drawn such that the two endpoints of the line i is at (i, ai) and (i, 0). Find two lines, which, together with the x-axis forms a container,
     * such that the container contains the most water.
       
       Notice that you may not slant the container.
      
     Interesting one. Heres the url: https://leetcode.com/problems/container-with-most-water/
     */

    public class ContainerWithMostWater
    {
        public void Run()
        {
            int[] height = new int[9] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int result = MaxArea(height);
        }

        public int MaxArea(int[] height)
        {
            int startIndex = 0;
            int endIndex = height.Length - 1;
            int maxArea = 0;

            while(startIndex != endIndex)
            {
                maxArea = Math.Max(maxArea, GetMaxArea(height[startIndex], height[endIndex], endIndex - startIndex));
                if(height[startIndex] <= height[endIndex])
                {
                    startIndex++;
                }
                else
                {
                    endIndex--;
                }
            }
            return maxArea;
        }

        public int GetMaxArea(int leftHeight, int rightHeight, int length)
        {
            return Math.Min(leftHeight, rightHeight) * length;
        }
    }
}
