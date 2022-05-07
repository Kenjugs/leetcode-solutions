/**
 * 658. Find K Closest Elements - Medium
 * Given a sorted integer array arr, two integers k and x, return the k closest
 * integers to x in the array. The result should also be sorted in ascending
 * order.
 * An integer a is closer to x than an integer b if:
 *   |a - x| < |b - x|, or
 *   |a - x| == |b - x| and a < b
 */

/**
 * @param {number[]} arr
 * @param {number} k
 * @param {number} x
 * @return {number[]}
 */
var findClosestElements = function(arr, k, x) {
    const pos = binarySearch(arr, x);
    
    let left = pos - 1;
    let right = pos;
    const ans = [];
    
    while (k > 0) {
        if (left < 0) {
            ans.push(arr[right]);
            ++right;
        } else if (right >= arr.length) {
            ans.push(arr[left]);
            --left;
        } else if (Math.abs(arr[left] - x) <= Math.abs(arr[right] - x)) {
            ans.push(arr[left]);
            --left;
        } else {
            ans.push(arr[right]);
            ++right;
        }
        
        --k;
    }
    
    return arr.slice(left + 1, right);
};

var binarySearch = function(arr, target) {
    let left = 0;
    let right = arr.length - 1;
    
    while (left <= right) {
        const mid = Math.floor((left + right) / 2);
        
        if (arr[mid] < target) {
            left = mid + 1;
        } else {
            right = mid - 1;
        }
    }
    
    return left;
};