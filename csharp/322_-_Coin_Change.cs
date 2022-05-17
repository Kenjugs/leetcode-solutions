/**
 * 322. Coin Change - Medium
 * You are given an integer array coins representing coins of different
 * denominations and an integer amount representing a total amount of money.
 * Return the fewest number of coins that you need to make up that amount. If
 * that amount of money cannot be made up by any combination of the coins,
 * return -1.
 * You may assume that you have an infinite number of each kind of coin.
 */

public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] memo = new int[amount + 1];
        Array.Fill(memo, amount + 1);
        memo[0] = 0;
        
        for (int a = 1; a <= amount; ++a) {
            foreach (int c in coins) {
                if (a - c >= 0) {
                    memo[a] = Math.Min(memo[a], 1 + memo[a - c]);
                }
            }
        }
        
        return memo[amount] == amount + 1 ? -1 : memo[amount];
    }
}