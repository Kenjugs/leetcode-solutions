/**
 * 70. Climbing Stairs - Easy
 * You are climbing a staircase. It takes n steps to reach the top.
 * Each time you can either climb 1 or 2 steps. In how many distinct ways can
 * you climb to the top?
 */

public class Solution {
    public int ClimbStairs(int n) {
        int[] memo = new int[n + 1];
        memo[n] = 1;
        
        for (int i = n - 1; i >= 0; --i) {
            int sumWays = 0;
            
            if (i + 1 <= n) {
                sumWays += memo[i + 1];
            }
            if (i + 2 <= n) {
                sumWays += memo[i + 2];
            }
            
            memo[i] = sumWays;
        }
        
        return memo[0];
    }
}