/**
 * 213. House Robber II - Medium
 * You are a professional robber planning to rob houses along a street. Each
 * house has a certain amount of money stashed. All houses at this place are
 * arranged in a circle. That means the first house is the neighbor of the last
 * one. Meanwhile, adjacent houses have a security system connected, and it will
 * automatically contact the police if two adjacent houses were broken into on
 * the same night.
 * Given an integer array nums representing the amount of money of each house,
 * return the maximum amount of money you can rob tonight without alerting the
 * police.
 */

public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1) {
            return nums[0];
        }
        
        int[] optA = new int[nums.Length];
        int[] optB = new int[nums.Length];
        
        Array.Copy(nums, 0, optA, 0, nums.Length - 1);
        Array.Copy(nums, 1, optB, 0, nums.Length - 1);
        
        return Math.Max(Helper(optA), Helper(optB));
    }
    
    public int Helper(int[] nums) {
        int n = nums.Length;
        int[] memo = new int[n + 1];
        memo[n] = 0;
        memo[n - 1] = nums[n - 1];
        
        for (int i = n - 2; i >= 0; --i) {
            memo[i] = Math.Max(nums[i] + memo[i + 2], memo[i + 1]);
        }
        
        return memo[0];
    }
}