using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given an array of integers nums and an integer target, return the indices of the two numbers such that they add up to the target.

You may assume that:

Each input has exactly one valid solution.
You may not use the same element twice.
The answer can be returned in any order.
*/

namespace csharp_dsa.tests.Algorithms
{
    public static class TwoSumSolver
    {
        //using brute force approach
        //time complexity O(n^2)
        public static int[] twoSumBruteForce(int[] nums, int target)
        {
            //guard clause
            if (nums == null || nums.Length < 2)
            {
                return [];
            }

            for (int i = 0; i < nums.Length; i++) {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return [ i, j];
                    }
                }
            }
            return [];
        }


        //using Dictionary/Hashmap approach
        //time complexity O(n)
        public static int[] twoSumDictionary(int[] nums, int target)
        {
            //guard clause
            if(nums == null || nums.Length < 2)
            {
                return [];
            }

            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
            }
        }



    }
}
