/**
 * 217. Contains Duplicate - Easy
 * Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
 */

/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function(nums) {
    const set = new Set();
    
    for (const n of nums) {
        if (set.has(n)) {
            return true;
        }
        
        set.add(n);
    }
    
    return false;
};