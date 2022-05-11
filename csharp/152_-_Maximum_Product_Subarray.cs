/**
 * 152. Maximum Product Subarray - Medium
 * Given an integer array nums, find a contiguous non-empty subarray within the array that has the largest product, and return the product.
 * The test cases are generated so that the answer will fit in a 32-bit integer.
 * A subarray is a contiguous subsequence of the array.
 */

public class Solution {
    public int MaxProduct(int[] nums) {
        int ans = nums[0];
        int maxProduct = nums[0];
        int minProduct = nums[0];
        
        for (int i = 1; i < nums.Length; ++i) {
            if (nums[i] < 0) {
                int temp = maxProduct;
                maxProduct = minProduct;
                minProduct = temp;
            }
            
            maxProduct = Math.Max(nums[i], maxProduct * nums[i]);
            minProduct = Math.Min(nums[i], minProduct * nums[i]);
            
            ans = Math.Max(ans, maxProduct);
        }
        
        return ans;
    }
}