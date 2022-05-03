/**
 * 200. Number of Islands - Medium
 * Given an m x n 2D binary grid, named grid, which represents a map of '1's (land) and '0's (water), return the number of islands.
 * An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
 * You may assume all four edges of the grid are all surrounded by water.
 */

/**
 * @param {character[][]} grid
 * @return {number}
 */
var numIslands = function(grid) {
    let m = grid[0].length;
    let n = grid.length;
    let ans = 0;

    for (let i = 0; i < n; ++i) {
        for (let j = 0; j < m; ++j) {
            if (grid[i][j] == '1') {
                ++ans;
                dfs(grid, j, i);
            }
        }
    }

    return ans;
};

var dfs = function(grid, x, y) {
    if (x < 0 || x >= grid[0].length) {
        return;
    }

    if (y < 0 || y >= grid.length) {
        return;
    }

    if (grid[y][x] != '1') {
        return;
    }

    grid[y][x] = '*';

    dfs(grid, x, y - 1);
    dfs(grid, x + 1, y);
    dfs(grid, x, y + 1);
    dfs(grid, x - 1, y);
};