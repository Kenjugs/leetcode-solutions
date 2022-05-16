/**
 * 268. Missing Number - Easy
 * Given an array nums containing n distinct numbers in the range [0, n], return
 * the only number in the range that is missing from the array.
 */

public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int expectedSum = (n * (n + 1)) / 2;
        int currentSum = 0;
        
        for (int i = 0; i < n; ++i) {
            currentSum += nums[i];
        }
        
        return expectedSum - currentSum;
    }
}