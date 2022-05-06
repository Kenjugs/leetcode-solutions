/**
 * 611. Valid Triangle Number - Medium
 * Given an integer array nums, return the number of triplets chosen from the
 * array that can make triangles if we take them as side lengths of a triangle.
 */

public class Solution {
    public int TriangleNumber(int[] nums) {
        int[] sorted = new int[nums.Length];
        Array.Copy(nums, sorted, nums.Length);
        Array.Sort(sorted);
        int count = 0;
        
        for (int i = 0; i < sorted.Length - 2; ++i) {
            int k = i + 2;
            
            for (int j = i + 1; j < sorted.Length - 1 && sorted[i] != 0; ++j) {
                while (k < sorted.Length && sorted[i] + sorted[j] > sorted[k]) {
                    ++k;
                }
                
                count += k - j - 1;
            }
        }
        
        return count;
    }
}