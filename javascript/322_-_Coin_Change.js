/**
 * 322. Coin Change - Medium
 * You are given an integer array coins representing coins of different
 * denominations and an integer amount representing a total amount of money.
 * Return the fewest number of coins that you need to make up that amount. If
 * that amount of money cannot be made up by any combination of the coins,
 * return -1.
 * You may assume that you have an infinite number of each kind of coin.
 */

/**
 * @param {number[]} coins
 * @param {number} amount
 * @return {number}
 */
var coinChange = function(coins, amount) {
    const memo = new Array(amount + 1).fill(amount + 1);
    memo[0] = 0;
    
    for (let a = 1; a <= amount; ++a) {
        for (let c of coins) {
            if (a - c >= 0) {
                memo[a] = Math.min(memo[a], 1 + memo[a - c]);
            }
        }
    }
    
    return memo[amount] === amount + 1 ? -1 : memo[amount];
};