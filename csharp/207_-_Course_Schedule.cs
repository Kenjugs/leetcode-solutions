/**
 * 207. Course Scheduling - Medium
 * There are a total of numCourses courses you have to take, labeled from 0 to
 * numCourses - 1. You are given an array prerequisites where
 * prerequisites[i] = [ai, bi] indicates that you must take course bi first if
 * you want to take course ai.
 * For example, the pair [0, 1], indicates that to take course 0 you have to
 * first take course 1.
 * Return true if you can finish all courses. Otherwise, return false.
 */

public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        // state[i] = 0, 1, or 2
        // where 0 = unvisited, 1 = visiting, 2 = complete
        int[] state = new int[numCourses];
        
        // build dependency list
        // dependency[i] = array of courses required before course i can be taken
        List<List<int>> dependencies = new List<List<int>>(numCourses);
        
        for (int i = 0; i < numCourses; ++i) {
            dependencies.Add(new List<int>());
        }
        
        foreach (int[] p in prerequisites) {
            int course = p[0];
            int require = p[1];
            
            dependencies[course].Add(require);
        }
        
        for (int i = 0; i < numCourses; ++i) {
            if (!DFS(dependencies, i, state)) {
                return false;
            }
        }
        
        return true;
    }
    
    public bool DFS(List<List<int>> dependencies, int start, int[] state) {
        if (state[start] == 2) {
            return true;
        }

        if (state[start] == 1) {
            return false;
        }

        state[start] = 1;

        for (int i = 0; i < dependencies[start].Count; ++i) {
            if (!DFS(dependencies, dependencies[start][i], state)) {
                return false;
            }
        }
        
        state[start] = 2;
        return true;
    }
}