/**
 * 78. Subsets - Medium
 * Given an integer array nums of unique elements, return all possible subsets (the power set).
 * The solution set must not contain duplicate subsets. Return the solution in any order.
 */

/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var subsets = function(nums) {
    const ans = [];
    backtrack(nums, 0, [], ans);
    return ans;
};

var backtrack = function(nums, start, subset, powerset) {
    powerset.push(Array.from(subset));
    
    for (let i = start; i < nums.length; ++i) {
        subset.push(nums[i]);
        backtrack(nums, i + 1, subset, powerset);
        subset.pop();
    }
};