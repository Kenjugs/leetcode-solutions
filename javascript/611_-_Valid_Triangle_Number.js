/**
 * 611. Valid Triangle Number - Medium
 * Given an integer array nums, return the number of triplets chosen from the
 * array that can make triangles if we take them as side lengths of a triangle.
 */

/**
 * @param {number[]} nums
 * @return {number}
 */
var triangleNumber = function(nums) {
    const sorted = Array.from(nums);
    // need custom compare fn since js converts elements of array to string
    // before applying sort, by default
    sorted.sort((a, b) => a - b);
    
    let ans = 0;
    for (let i = 0; i < sorted.length - 2; ++i) {
        let k = i + 2;
        
        for (let j = i + 1; j < sorted.length - 1 && sorted[i] !== 0; ++j) {
            while (k < sorted.length && sorted[i] + sorted[j] > sorted[k]) {
                ++k;
            }
            
            ans += k - j - 1;
        }
    }
    
    return ans;
};