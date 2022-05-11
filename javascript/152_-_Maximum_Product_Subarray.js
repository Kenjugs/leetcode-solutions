/**
 * 152. Maximum Product Subarray - Medium
 * Given an integer array nums, find a contiguous non-empty subarray within the array that has the largest product, and return the product.
 * The test cases are generated so that the answer will fit in a 32-bit integer.
 * A subarray is a contiguous subsequence of the array.
 */

/**
 * @param {number[]} nums
 * @return {number}
 */
var maxProduct = function(nums) {
    let ans = nums[0];
    let maxProduct = nums[0];
    let minProduct = nums[0];
    
    for (let i = 1; i < nums.length; ++i) {
        if (nums[i] < 0) {
            const temp = maxProduct;
            maxProduct = minProduct;
            minProduct = temp;
        }
        
        maxProduct = Math.max(nums[i], maxProduct * nums[i]);
        minProduct = Math.min(nums[i], minProduct * nums[i]);
        
        ans = Math.max(ans, maxProduct);
    }
    
    return ans;
};