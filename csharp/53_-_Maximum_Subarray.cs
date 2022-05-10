/**
 * 53. Maximum Subarray - Easy
 * Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
 * A subarray is a contiguous part of an array.
 */

public class Solution {
    public int MaxSubArray(int[] nums) {
        int left = 0;
        int right = 1;
        int ans = nums[0];
        int currentSum = nums[0];
        
        while (right < nums.Length) {
            if (currentSum + nums[right] > nums[right]) {
                currentSum += nums[right];
            } else {
                left = right;
                currentSum = nums[left];
            }
            
            ans = Math.Max(ans, currentSum);
            ++right;
        }
        
        return ans;
    }
}