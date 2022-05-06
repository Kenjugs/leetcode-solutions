/**
 * 209. Minimum Size Subarray Sum - Medium
 * Given an array of positive integers, named nums, and a positive integer,
 * named target, return the minimal length of a contiguous subarray
 * [nums_l, nums_l+1, ..., nums_r-1, nums_r] of which the sum is greater than or
 * equal to target. If there is no such subarray, return 0 instead.
 */

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0;
        int sum = 0;
        int ans = nums.Length + 1;
        
        for (int right = 0; right < nums.Length; ++right) {
            sum += nums[right];
            
            while (sum >= target) {
                ans = Math.Min(ans, right + 1 - left);
                sum -= nums[left];
                ++left;
            }
        }
        
        return (ans == nums.Length + 1 ? 0 : ans);
    }
}