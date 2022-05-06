/**
 * 78. Subsets - Medium
 * Given an integer array nums of unique elements, return all possible subsets (the power set).
 * The solution set must not contain duplicate subsets. Return the solution in any order.
 */

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> powerset = new List<IList<int>>();
        IList<int> subset = new List<int>();
        
        Backtrack(nums, 0, subset, powerset);
        return powerset;
    }
    
    public void Backtrack(int[] nums, int start, IList<int> subset, IList<IList<int>> powerset) {
        powerset.Add(new List<int>(subset));
        
        for (int i = start; i < nums.Length; ++i) {
            subset.Add(nums[i]);
            Backtrack(nums, i + 1, subset, powerset);
            subset.RemoveAt(subset.Count - 1);
        }
    }
}