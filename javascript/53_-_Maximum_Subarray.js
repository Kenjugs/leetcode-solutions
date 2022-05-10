/**
 * 53. Maximum Subarray - Easy
 * Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
 * A subarray is a contiguous part of an array.
 */

/**
 * @param {number[]} nums
 * @return {number}
 */
var maxSubArray = function(nums) {
    let left = 0;
    let right = 1;
    let ans = nums[0];
    let currentSum = nums[0];
    
    while (right < nums.length) {
        if (currentSum + nums[right] > nums[right]) {
            currentSum += nums[right];
        } else {
            left = right;
            currentSum = nums[left];
        }
        
        ans = Math.max(ans, currentSum);
        ++right;
    }
    
    return ans;
};