/**
 * 338. Counting Bits - Easy
 * Given an integer n, return an array ans of length n + 1 such that for each i
 * (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.
 */

/**
 * @param {number} n
 * @return {number[]}
 */
var countBits = function(n) {
    const ans = [0];
    
    for (let i = 1; i <= n; ++i) {
        hammingWeight(i, ans);
    }
    
    return ans;
};

/**
 * @param {number} n
 * @param {number[]} memo
 * @return {void}
 */
const hammingWeight = function(n, memo) {
    let count = 0;
    
    if ((n & 1) === 1) {
        count = 1;
    }
    
    count += memo[n >>> 1];
    memo[n] = count;
}