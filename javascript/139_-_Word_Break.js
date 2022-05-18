/**
 * 139. Word Break - Medium
 * Given a string s and a dictionary of strings wordDict, return true if s can
 * be segmented into a space-separated sequence of one or more dictionary words.
 * Note that the same word in the dictionary may be reused multiple times in the
 * segmentation.
 */

/**
 * @param {string} s
 * @param {string[]} wordDict
 * @return {boolean}
 */
var wordBreak = function(s, wordDict) {
    const memo = new Array(s.length + 1);
    memo.fill(false);
    memo[s.length] = true;
    
    for (let i = s.length - 1; i >= 0; --i) {
        for (const word of wordDict) {
            if (i + word.length <= s.length && word === s.substring(i, i + word.length)) {
                memo[i] = memo[i + word.length];
            }
            if (memo[i]) {
                break;
            }
        }
    }
    
    return memo[0];
};