/**
 * 15. 3Sum - Medium
 * Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
 * Notice that the solution set must not contain duplicate triplets.
 */

/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var threeSum = function(nums) {
    const sorted = Array.from(nums);
    sorted.sort((x, y) => x - y);
    
    const ans = [];
    
    for (let i = 0; i < sorted.length - 2; ++i) {
        if (i > 0 && sorted[i] === sorted[i - 1]) {
            continue;
        }
        
        let j = i + 1;
        let k = sorted.length - 1;
        const target = 0 - sorted[i];
        
        while (j < k) {
            const sum = sorted[j] + sorted[k];
            
            if (sum === target) {
                ans.push([sorted[i], sorted[j], sorted[k]]);
            }
            
            if (sum > target) {
                --k;
            } else {
                ++j;
                
                while (j < sorted.length && sorted[j] === sorted[j - 1]) {
                    ++j;
                }
            }
        }
    }
    
    return ans;
};