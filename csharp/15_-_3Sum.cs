/**
 * 15. 3Sum - Medium
 * Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
 * Notice that the solution set must not contain duplicate triplets.
 */

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        int[] sorted = new int[nums.Length];
        Array.Copy(nums, sorted, nums.Length);
        Array.Sort(sorted);
        
        IList<IList<int>> ans = new List<IList<int>>();
        
        for (int i = 0; i < sorted.Length - 2; ++i) {
            if (i > 0 && sorted[i] == sorted[i - 1]) {
                continue;
            }
            
            int j = i + 1;
            int k = sorted.Length - 1;
            int target = 0 - sorted[i];
            
            while (j < k) {
                int sum = sorted[j] + sorted[k];
                
                if (sum == target) {
                    ans.Add(new List<int> { sorted[i], sorted[j], sorted[k] });
                }
                
                if (sum > target) {
                    --k;
                } else {
                    ++j;
                    
                    while (j < sorted.Length && sorted[j] == sorted[j - 1]) {
                        ++j;
                    }
                }
            }
        }
        
        return ans;
    }
}