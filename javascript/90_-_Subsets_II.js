/**
 * 90. Subsets II - Medium
 * Given an integer array nums that may contain duplicates, return all possible subsets (the power set).
 * The solution set must not contain duplicate subsets. Return the solution in any order.
 */

/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var subsetsWithDup = function(nums) {
    const ans = [];
    
    const sorted = Array.from(nums);
    sorted.sort();

    backtrack(sorted, 0, [], ans);
    return ans;
};

var backtrack = function(nums, start, subset, powerset) {
    powerset.push(Array.from(subset));
    
    for (let i = start; i < nums.length; ++i) {
        if (i > start && nums[i] === nums[i - 1]) {
            continue;
        }
        
        subset.push(nums[i]);
        backtrack(nums, i + 1, subset, powerset);
        subset.pop();
    }
};