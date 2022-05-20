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

/**
 * @param {number} numCourses
 * @param {number[][]} prerequisites
 * @return {boolean}
 */
var canFinish = function(numCourses, prerequisites) {
    const state = new Array(numCourses);
    state.fill(0);
    
    const dependencies = new Array(numCourses);
    for (let i = 0; i < numCourses; ++i) {
        dependencies[i] = [];
    }
    
    for (const p of prerequisites) {
        const course = p[0];
        const required = p[1];
        dependencies[course].push(required);
    }
    
    for (let i = 0; i < numCourses; ++i) {
        if (!dfs(dependencies, i, state)) {
            return false;
        }
    }
    
    return true;
};

const dfs = function(dependencies, start, state) {
    if (state[start] === 1) {
        return false;
    }
    
    if (state[start] === 2) {
        return true;
    }
    
    state[start] = 1;
    
    for (let i = 0; i < dependencies[start].length; ++i) {
        if (!dfs(dependencies, dependencies[start][i], state)) {
            return false;
        }
    }
    
    state[start] = 2;
    return true;
};