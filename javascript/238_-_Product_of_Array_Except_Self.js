/**
 * 238. Product of Array Except Self - Medium
 * Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
 * The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
 * You must write an algorithm that runs in O(n) time and without using the division operation.
 */

/**
 * @param {number[]} nums
 * @return {number[]}
 */
var productExceptSelf = function(nums) {
    const ans = [];
    ans[0] = 1;
    
    for (let i = 1; i < nums.length; ++i) {
        // use ans array as aggregator for everything that came before i
        ans[i] = ans[i - 1] * nums[i - 1];
    }
    
    // need separate aggregator for everything that comes after i
    let agg = 1;
    
    for (let i = nums.length - 2; i >= 0; --i) {
        agg *= nums[i + 1];
        ans[i] *= agg;
    }
    
    return ans;
};