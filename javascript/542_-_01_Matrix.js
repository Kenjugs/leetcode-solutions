/**
 * 542. 01 Matrix - Medium
 * Given an m x n binary matrix, named mat, return the distance of the nearest 0 for each cell.
 * The distance between two adjacent cells is 1.
 */

/**
 * @param {number[][]} mat
 * @return {number[][]}
 */
var updateMatrix = function(mat) {
    const queue = [];
    const m = mat.length;
    const n = mat[0].length;

    for (let i = 0; i < m; ++i) {
        for (let j = 0; j < n; ++j) {
            if (mat[i][j] == 0) {
                queue.push([i, j]);
            } else {
                // no need for Number.MAX_VALUE here
                // shortest path from top-left to bottom-right is (m - 1) + (n - 1) steps, so m * n should always be larger than that
                mat[i][j] = m * n;
            }
        }
    }

    const directions = [
        [-1, 0], // up
        [0, 1],  // right
        [1, 0],  // down
        [0, -1]  // left
    ];

    while (queue.length > 0) {
        const current = queue.shift();

        for (const d of directions) {
            const i = current[0] + d[0];
            const j = current[1] + d[1];

            if (i < 0 || i >= m) {
                continue;
            }

            if (j < 0 || j >= n) {
                continue;
            }

            if (mat[i][j] <= mat[current[0]][current[1]] + 1) {
                continue;
            }

            queue.push([i, j]);
            mat[i][j] = mat[current[0]][current[1]] + 1;
        }
    }

    return mat;
};