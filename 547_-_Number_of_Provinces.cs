/**
 * 547. Number of Provinces - Medium
 * There are n cities. Some of them are connected, while some are not. If city a is connected directly with city b,
 * and city b is connected directly with city c, then city a is connected indirectly with city c.
 * A province is a group of directly or indirectly connected cities and no other cities outside of the group.
 * 
 * You are given an n x n matrix, named isConnected, where isConnected[i][j] = 1 if the ith city and the jth city are
 * directly connected, and isConnected[i][j] = 0 otherwise.
 * Return the total number of provinces.
 */

public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        List<bool> friendZoned = new List<bool>(new bool[isConnected.Length]);
        Stack<int> stack = new Stack<int>();
        
        int ans = 0;
        
        for (int i = 0; i < isConnected.Length; ++i) {
            if (friendZoned[i] == false) {
                ++ans;
                
                stack.Push(i);
                
                while (stack.Count > 0) {
                    int current = stack.Pop();
                    friendZoned[current] = true;
                    
                    for (int j = 0; j < isConnected[current].Length; ++j) {
                        if (friendZoned[j] == false && isConnected[current][j] == 1) {
                            stack.Push(j);
                        }
                    }
                }
            }
        }
        
        return ans;
    }
}