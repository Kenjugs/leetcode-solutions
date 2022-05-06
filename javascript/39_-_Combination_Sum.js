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

/**
 * @param {number[]} candidates
 * @param {number} target
 * @return {number[][]}
 */
var combinationSum = function(candidates, target) {
    const ans = [];
    backtrack(candidates, target, 0, [], ans);
    return ans;
};

var backtrack = function(candidates, target, start, subset, powerset) {
    if (target === 0) {
        powerset.push(Array.from(subset));
        return;
    }
    
    if (target < 0) {
        return;
    }
    
    for (let i = start; i < candidates.length; ++i) {
        subset.push(candidates[i]);
        backtrack(candidates, target - candidates[i], i, subset, powerset);
        subset.pop();
    }
};