/**
 * 377. Combination Sum IV - Medium
 * Given an array of distinct integers nums and a target integer target, return
 * the number of possible combinations that add up to target.
 * The test cases are generated so that the answer can fit in a 32-bit integer.
 */

public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        int[] memo = new int[target + 1];
        memo[0] = 1;
        
        for (int i = 1; i <= target; ++i) {
            for (int j = 0; j < nums.Length; ++j) {
                if (i - nums[j] >= 0) {
                    memo[i] = memo[i] + memo[i - nums[j]];
                }
            }
        }
        
        return memo[target];
    }
}