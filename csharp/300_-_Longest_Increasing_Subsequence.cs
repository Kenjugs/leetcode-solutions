/**
 * 300. Longest Increasing Subsequence - Medium
 * Given an integer array nums, return the length of the longest strictly
 * increasing subsequence.
 * A subsequence is a sequence that can be derived from an array by deleting
 * some or no elements without changing the order of the remaining elements. For
 * example, [3,6,2,7] is a subsequence of the array [0,3,1,6,2,2,7].
 */

public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] memo = new int[nums.Length];
        Array.Fill(memo, 1);
        
        for (int i = nums.Length - 2; i >= 0; --i) {
            for (int j = i + 1; j < nums.Length; ++j) {
                if (nums[i] < nums[j]) {
                    memo[i] = Math.Max(memo[i], 1 + memo[j]);
                }
            }
        }
        
        int maxCount = 0;
        foreach (int count in memo) {
            maxCount = Math.Max(maxCount, count);
        }
        return maxCount;
    }
}