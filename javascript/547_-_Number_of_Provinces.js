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

/**
 * @param {number[][]} isConnected
 * @return {number}
 */
var findCircleNum = function(isConnected) {
    let friendZoned = new Array(isConnected.length);
    let stack = [];
    let ans = 0;

    for (let i = 0; i < isConnected.length; ++i) {
        if (!friendZoned[i]) {
            ++ans;
            stack.push(i);

            while (stack.length > 0) {
                let current = stack.pop();
                friendZoned[current] = true;

                for (let j = 0; j < isConnected[current].length; ++j) {
                    if (!friendZoned[j] && isConnected[current][j] == 1) {
                        stack.push(j);
                    }
                }
            }
        }
    }

    return ans;
};