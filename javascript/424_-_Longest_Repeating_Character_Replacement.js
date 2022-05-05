/**
 * 424. Longest Repeating Character Replacement - Medium
 * You are given a string s and an integer k. You can choose any character of the string and change it to
 * any other uppercase English character. You can perform this operation at most k times.
 * Return the length of the longest substring containing the same letter you can get after performing the above operations.
 */

/**
 * @param {string} s
 * @param {number} k
 * @return {number}
 */
var characterReplacement = function(s, k) {
    const freq = new Map();
    let begin = 0;
    let ans = 0;
    let maxFreq = 0;
    
    for (let end = 0; end < s.length; ++end) {
        const endChar = s.charAt(end);
        
        if (freq.has(endChar)) {
            freq.set(endChar, freq.get(endChar) + 1);
        } else {
            freq.set(endChar, 1);
        }
        
        maxFreq = Math.max(maxFreq, freq.get(endChar));
        const window = end - begin + 1;
        
        if (window - maxFreq > k) {
            const beginChar = s.charAt(begin);
            freq.set(beginChar, freq.get(beginChar) - 1);
            ++begin;
        }
        
        ans = Math.max(ans, end - begin + 1);
    }
    
    return ans;
};