/**
 * 55. Jump Game - Medium
 * You are given an integer array nums. You are initially positioned at the
 * array's first index, and each element in the array represents your maximum
 * jump length at that position.
 * Return true if you can reach the last index, or false otherwise.
 */

public class Solution {
    public bool CanJump(int[] nums) {
        int lastPos = nums.Length - 1;
        
        for (int i = nums.Length - 2; i >= 0; --i) {
            if (i + nums[i] >= lastPos) {
                lastPos = i;
            }
        }
        
        return lastPos == 0;
    }
}