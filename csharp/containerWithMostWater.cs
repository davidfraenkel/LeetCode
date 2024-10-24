/* 
************* DECSRIPTION ************

You are given an integer array height of length n.
There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

Find two lines that together with the x-axis form a container, such that the container contains the most water.
Return the maximum amount of water a container can store.
Notice that you may not slant the container.
*/
using System;


public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;
        
        while (left < right) {
            int currentArea = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, currentArea);
            
            if (height[left] < height[right]) {
                left++;
            } else {
                right--;
            }
        }
        
        return maxArea;
    }
}

/* 
TEST CASES
 */

public class Program {
    public static void Main() {
        Solution solution = new Solution();
        
        // Test case 1
        int result1 = solution.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
        Console.WriteLine(result1); // Output: 49
        
        // Test case 2
        int result2 = solution.MaxArea(new int[] { 1, 1 });
        Console.WriteLine(result2); // Output: 1
    }
}