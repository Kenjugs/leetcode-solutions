/**
 * 300. Longest Increasing Subsequence - Medium
 * Given an integer array nums, return the length of the longest strictly
 * increasing subsequence.
 * A subsequence is a sequence that can be derived from an array by deleting
 * some or no elements without changing the order of the remaining elements. For
 * example, [3,6,2,7] is a subsequence of the array [0,3,1,6,2,2,7].
 */

/**
 * @param {number[]} nums
 * @return {number}
 */
var lengthOfLIS = function(nums) {
    const memo = new Array(nums.length).fill(1);
    
    for (let i = nums.length - 2; i >= 0; --i) {
        for (let j = i + 1; j < nums.length; ++j) {
            if (nums[j] > nums[i]) {
                memo[i] = Math.max(memo[i], 1 + memo[j])
            }
        }
    }
    
    let max = 0;
    for (const count of memo) {
        max = Math.max(max, count);
    }
    return max;
};