/**
 * 268. Missing Number - Easy
 * Given an array nums containing n distinct numbers in the range [0, n], return
 * the only number in the range that is missing from the array.
 */

/**
 * @param {number[]} nums
 * @return {number}
 */
var missingNumber = function(nums) {
    const n = nums.length;
    const expectedSum = (n * (n + 1)) / 2;
    let currentSum = 0;
    
    for (let i = 0; i < n; ++i) {
        currentSum += nums[i];
    }
    
    return expectedSum - currentSum;
};