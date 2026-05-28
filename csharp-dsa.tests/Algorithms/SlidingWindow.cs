using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_dsa.tests.Algorithms
{
    internal class SlidingWindow
    {

        /*
         * Given an array of integers nums and a positive integer k, 
         * find the maximum sum of any contiguous subarray of size k.
         */
        public int MaxSumSubarray(int[] nums, int k)
        {
            if (nums.Length < k) return 0;

            int left = 0;
            int right = 0;
            int currentSum = 0;
            int maxSum = 0;

            // 1. Expand the window to size k initially
            while (right < k)
            {
                currentSum += nums[right];
                right++;
            }
            maxSum = currentSum;

            // 2. Now slide both pointers together across the rest of the array
            while (right < nums.Length)
            {
                currentSum += nums[right];  // Add the new element entering on the right
                currentSum -= nums[left];   // Subtract the old element leaving on the left

                maxSum = Math.Max(currentSum, maxSum);

                left++;  // Move left pointer forward
                right++; // Move right pointer forward
            }

            return maxSum;
        }



    }
}
