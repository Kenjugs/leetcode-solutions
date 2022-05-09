/**
 * 217. Contains Duplicate - Easy
 * Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
 */

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> hashset = new HashSet<int>();
        
        foreach (int n in nums) {
            if (!hashset.Add(n)) {
                return true;
            }
        }
        
        return false;
    }
}