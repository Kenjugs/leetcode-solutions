/**
 * 44. Wildcard Matching - Hard
 * Given an input string (s) and a pattern (p), implement wildcard pattern matching with support for '?' and '*' where:
 * '?' Matches any single character.
 * '*' Matches any sequence of characters (including the empty sequence).
 * The matching should cover the entire input string (not partial).
 */

/**
 * @param {string} s
 * @param {string} p
 * @return {boolean}
 */
var isMatch = function(s, p) {
    return dfsMemo(s, p, 0, 0, []);
};

var dfsMemo = function(s, p, i, j, memo) {
    if (i === s.length && j === p.length) {
        return true;
    }
    
    // reached the end of s
    // only valid characters in p that can match are '*' (representing 0-length match)
    if (i === s.length) {
        for (let k = j; k < p.length; ++k) {
            if (p.charAt(k) !== '*') {
                return false;
            }
        }
        
        return true;
    }
    
    // haven't reached the end of the input string
    // but have no pattern characters to match against
    if (j >= p.length) {
        return false;
    }
    
    // memoization - return what we computed already
    if (memo[i] !== undefined && memo[i][j] !== undefined) {
        return memo[i][j];
    }
    
    let matched = false;
    
    if (p.charAt(j) !== '*') {
        if (s.charAt(i) === p.charAt(j) || p.charAt(j) === '?') {
            matched = true;
        }
        
        matched = matched && dfsMemo(s, p, i + 1, j + 1, memo);
    } else {
        // i + 1, j = greedy matching
        matched = dfsMemo(s, p, i + 1, j, memo);
        
        // i, j + 1 = 0-length matching
        matched = matched || dfsMemo(s, p, i, j + 1, memo);
    }
    
    if (memo[i] === undefined) {
        memo[i] = [];
    }
    
    memo[i][j] = matched;
    return memo[i][j];
};