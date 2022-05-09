/**
 * 238. Product of Array Except Self - Medium
 * Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
 * The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
 * You must write an algorithm that runs in O(n) time and without using the division operation.
 */

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] ans = new int[nums.Length];
        ans[0] = 1;
        
        for (int i = 1; i < nums.Length; ++i) {
            ans[i] = ans[i - 1] * nums[i - 1];
        }
        
        int agg = 1;
        
        for (int i = nums.Length - 2; i >= 0; --i) {
            agg *= nums[i + 1];
            ans[i] *= agg;
        }
        
        return ans;
    }
}