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

/**
 * @param {number[]} nums
 * @return {number}
 */
var rob = function(nums) {
    if (nums.length === 1) {
        return nums[0];
    }
    
    // two arrays representing which houses we can rob depending on
    // if we rob house at i=0 or not
    const optA = nums.slice(0, nums.length - 1);
    const optB = nums.slice(1);
    
    return Math.max(helper(optA), helper(optB));
};

// solution to original House Robber
const helper = function(nums) {
    const n = nums.length;
    const memo = new Array(n + 1);
    memo[n] = 0;
    memo[n - 1] = nums[n - 1];
    
    for (let i = n - 2; i >= 0; --i) {
        memo[i] = Math.max(nums[i] + memo[i + 2], memo[i + 1]);
    }
    
    return memo[0];
};