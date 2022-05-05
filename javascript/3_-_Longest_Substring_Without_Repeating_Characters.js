/**
 * 3. Longest Substring Without Repeating Characters - Medium
 * Given a string s, find the length of the longest substring without repeating characters.
 */

/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function(s) {
    const freq = new Map();
    let ans = 0;

    let begin = 0;
    let end = 0;

    while (end < s.length) {
        const endChar = s.charAt(end);

        if (!freq.has(endChar)) {
            freq.set(endChar, 1);
            ans = Math.max(ans, freq.size);
            ++end;
        } else {
            const beginChar = s.charAt(begin);
            freq.delete(beginChar);
            ++begin;
        }
    }

    return ans;
};