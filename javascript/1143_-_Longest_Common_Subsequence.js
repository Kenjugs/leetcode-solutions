/**
 * 1143. Longest Common Subsequence - Medium
 * Given two strings text1 and text2, return the length of their longest common
 * subsequence. If there is no common subsequence, return 0.
 * A subsequence of a string is a new string generated from the original string
 * with some characters (can be none) deleted without changing the relative
 * order of the remaining characters.
 * For example, "ace" is a subsequence of "abcde".
 * A common subsequence of two strings is a subsequence that is common to both strings.
 */

/**
 * @param {string} text1
 * @param {string} text2
 * @return {number}
 */
var longestCommonSubsequence = function(text1, text2) {
    const memo = new Array(text1.length + 1);
    for (let i = 0; i < memo.length; ++i) {
        memo[i] = new Array(text2.length + 1);
        memo[i][text2.length] = 0;
        
        if (i === text1.length) {
            memo[i].fill(0);
        }
    }
    
    for (let i = text1.length - 1; i >= 0; --i) {
        for (let j = text2.length - 1; j >= 0; --j) {
            if (text1.charAt(i) === text2.charAt(j)) {
                memo[i][j] = 1 + memo[i + 1][j + 1];
            } else {
                memo[i][j] = Math.max(memo[i + 1][j], memo[i][j + 1]);
            }
        }
    }
    
    return memo[0][0];
};