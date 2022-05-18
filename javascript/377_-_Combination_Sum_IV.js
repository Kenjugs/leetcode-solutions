/**
 * 377. Combination Sum IV - Medium
 * Given an array of distinct integers nums and a target integer target, return
 * the number of possible combinations that add up to target.
 * The test cases are generated so that the answer can fit in a 32-bit integer.
 */

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var combinationSum4 = function(nums, target) {
    const memo = new Array(target + 1);
    memo.fill(0);
    memo[0] = 1;
    
    for (let i = 1; i <= target; ++i) {
        for (let j = 0; j < nums.length; ++j) {
            if (i - nums[j] >= 0) {
                memo[i] = memo[i] + memo[i - nums[j]];
            }
        }
    }
    
    return memo[target];
};