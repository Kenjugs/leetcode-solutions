/**
 * 200. Number of Islands - Medium
 * Given an m x n 2D binary grid, named grid, which represents a map of '1's (land) and '0's (water), return the number of islands.
 * An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
 * You may assume all four edges of the grid are all surrounded by water.
 */

public class Solution {
    public int NumIslands(char[][] grid) {
        int m = grid[0].Length;
        int n = grid.Length;
        
        int ans = 0;
        
        for (int i = 0; i < n; ++i) {
            for (int j = 0; j < m; ++j) {
                if (grid[i][j] == '1') {
                    ++ans;
                    DFS(grid, j, i);
                }
            }
        }
        
        return ans;
    }
    
    public void DFS(char[][] grid, int x, int y) {
        if (x < 0 || x >= grid[0].Length) {
            return;
        }
        
        if (y < 0 || y >= grid.Length) {
            return;
        }
        
        if (grid[y][x] != '1') {
            return;
        }
        
        grid[y][x] = '*';
        
        DFS(grid, x, y - 1);
        DFS(grid, x + 1, y);
        DFS(grid, x, y + 1);
        DFS(grid, x - 1, y);
    }
}