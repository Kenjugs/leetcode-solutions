/**
 * 542. 01 Matrix - Medium
 * Given an m x n binary matrix, named mat, return the distance of the nearest 0 for each cell.
 * The distance between two adjacent cells is 1.
 */

public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        Queue<IList<int>> queue = new Queue<IList<int>>();
        
        int dist = 0;
        int m = mat.Length;
        int n = mat[0].Length;
        
        for (int i = 0; i < m; ++i) {
            for (int j = 0; j < n; ++j) {
                if (mat[i][j] == 0) {
                    queue.Enqueue(new List<int>() { i, j });
                } else {
                    // no need for int.MaxValue here
                    // shortest path from top-left to bottom-right is (m - 1) + (n - 1) steps, so m * n should always be larger than that
                    mat[i][j] = m * n;
                }
            }
        }
        
        int[][] directions = new int[][] {
            new int[] { -1, 0 }, // up
            new int[] { 0, 1 },  // right
            new int[] { 1, 0 },  // down
            new int[] { 0, -1 }  // left
        };
        
        while (queue.Count > 0) {
            IList<int> current = queue.Dequeue();
            
            foreach (int[] d in directions) {
                int i = current[0] + d[0];
                int j = current[1] + d[1];
                
                if (i < 0 || i >= m) {
                    continue;
                }
                
                if (j < 0 || j >= n) {
                    continue;
                }
                
                if (mat[i][j] <= mat[current[0]][current[1]] + 1) {
                    continue;
                }
                
                queue.Enqueue(new List<int>() { i, j });
                mat[i][j] = mat[current[0]][current[1]] + 1;
            }
        }
        
        return mat;
    }
}