/**
 * 70. Climbing Stairs - Easy
 * You are climbing a staircase. It takes n steps to reach the top.
 * Each time you can either climb 1 or 2 steps. In how many distinct ways can
 * you climb to the top?
 */

/**
 * @param {number} n
 * @return {number}
 */
var climbStairs = function(n) {
    const memo = new Array(n + 1);
    memo[n] = 1;
    
    for (let i = n - 1; i >= 0; --i) {
        let sumWays = 0;
        
        if (i + 1 <= n) {
            sumWays += memo[i + 1];
        }
        if (i + 2 <= n) {
            sumWays += memo[i + 2];
        }
        
        memo[i] = sumWays;
    }
    
    return memo[0];
};