/**
 * 198. House Robber - Medium
 * You are a professional robber planning to rob houses along a street. Each
 * house has a certain amount of money stashed, the only constraint stopping you
 * from robbing each of them is that adjacent houses have security systems
 * connected and it will automatically contact the police if two adjacent houses
 * were broken into on the same night.
 * Given an integer array nums representing the amount of money of each house,
 * return the maximum amount of money you can rob tonight without alerting the
 * police.
 */

public class Solution {
    public int Rob(int[] nums) {
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