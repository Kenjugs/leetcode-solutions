/**
 * 209. Minimum Size Subarray Sum - Medium
 * Given an array of positive integers, named nums, and a positive integer,
 * named target, return the minimal length of a contiguous subarray
 * [nums_l, nums_l+1, ..., nums_r-1, nums_r] of which the sum is greater than or
 * equal to target. If there is no such subarray, return 0 instead.
 */

/**
 * @param {number} target
 * @param {number[]} nums
 * @return {number}
 */
var minSubArrayLen = function(target, nums) {
    let left = 0;
    let sum = 0;
    let ans = nums.length + 1;
    
    for (let right = 0; right < nums.length; ++right) {
        sum += nums[right];
        
        while (sum >= target) {
            ans = Math.min(ans, right - left + 1);
            sum -= nums[left];
            ++left;
        }
    }
    
    return (ans === nums.length + 1 ? 0 : ans);
};