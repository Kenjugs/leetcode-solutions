/**
 * 62. Unique Paths - Medium
 * There is a robot on an m x n grid. The robot is initially located at the
 * top-left corner (i.e., grid[0][0]). The robot tries to move to the
 * bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move
 * either down or right at any point in time.
 * Given the two integers m and n, return the number of possible unique paths
 * that the robot can take to reach the bottom-right corner.
 * The test cases are generated so that the answer will be less than or equal to 2 * 109.
 */

public class Solution {
    public int UniquePaths(int m, int n) {
        int[][] memo = new int[m][];
        for (int i = 0; i < m; ++i) {
            memo[i] = new int[n];
            memo[i][n - 1] = 1;
        }
        
        for (int i = 0; i < n; ++i) {
            memo[m - 1][i] = 1;
        }
        
        for (int r = m - 2; r >= 0; --r) {
            for (int c = n - 2; c >= 0; --c) {
                memo[r][c] = memo[r + 1][c] + memo[r][c + 1];
            }
        }
        
        return memo[0][0];
    }
}