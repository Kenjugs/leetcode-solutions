/**
 * 39. Combination Sum - Medium
 * Given an array of distinct integers, named candidates, and a target integer, named target,
 * return a list of all unique combinations of candidates where the chosen numbers sum to target.
 * You may return the combinations in any order.
 * The same number may be chosen from candidates an unlimited number of times. Two combinations
 * are unique if the frequency of at least one of the chosen numbers is different.
 * It is guaranteed that the number of unique combinations that sum up to target is less than 150
 * combinations for the given input.
 */

public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> ans = new List<IList<int>>();
        IList<int> subset = new List<int>();
        
        Backtrack(candidates, target, 0, subset, ans);
        return ans;
    }
    
    public void Backtrack(int[] candidates, int target, int start, IList<int> subset, IList<IList<int>> solutions) {
        if (target == 0) {
            solutions.Add(new List<int>(subset));
            return;
        }
        
        if (target < 0) {
            return;
        }
        
        for (int i = start; i < candidates.Length; ++i) {
            subset.Add(candidates[i]);
            Backtrack(candidates, target - candidates[i], i, subset, solutions);
            subset.RemoveAt(subset.Count - 1);
        }
    }
}