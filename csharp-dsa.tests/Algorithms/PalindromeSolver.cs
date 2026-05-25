using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters 
and removing all non-alphanumeric characters, 
it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.
*/

namespace csharp_dsa.tests.Algorithms
{
    internal class PalindromeSolver
    {
        //two pointer solution
        public static bool isPalindromeTwoPointer(String s)
        {
            //remove non-alphanumeric characters and make all characters lower case
            char[] str = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower().ToCharArray();

            int left = 0;
            int right = str.Length - 1;

            while(left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }


    }
}
