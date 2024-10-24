/* 
************* DECSRIPTION ************

Given an integer x, return true if x is a  palindrome, and false otherwise.

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
*/
using System;


public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0 ) {
            return false;
        }

        int reverse = 0;
        // Copy of the original number so that the original
        // number remains unchanged while finding the reverse
        int temp = x;
        while (temp != 0)
        {
            reverse = (reverse * 10) + (temp % 10);
            temp = temp / 10;
        }
        // If reverse is equal to the original number, the
        // number is palindrome
        return (reverse == x);
    }
}

/* 
TEST CASES
 */

public class Program {
    public static void Main() {
        Solution solution = new Solution();
       
        // Test case 1
        bool result1 = solution.IsPalindrome(121);
        Console.WriteLine(result1); // Output: true

        // Test case 2
        bool result2 = solution.IsPalindrome(-121);
        Console.WriteLine(result2); // Output: false

        // Test case 3
        bool result3 = solution.IsPalindrome(123);
        Console.WriteLine(result3); // Output: false

        // Test case 4
        bool result4 = solution.IsPalindrome(1999991);
        Console.WriteLine(result4); // Output: true

    }
}