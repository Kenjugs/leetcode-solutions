/**
 * 76. Minimum Window Substring - Hard
 * Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that
 * every character in t (including duplicates) is included in the window. If there is no such substring, return
 * the empty string "".
 * The testcases will be generated such that the answer is unique.
 * A substring is a contiguous sequence of characters within the string.
 */

/**
 * @param {string} s
 * @param {string} t
 * @return {string}
 */
var minWindow = function(s, t) {
    const freq = new Map();
    let ans = '';
    
    for (const c of t) {
        if (freq.has(c)) {
            freq.set(c, freq.get(c) + 1);
        } else {
            freq.set(c, 1);
        }
    }
    
    let begin = 0;
    let end = 0;
    let length = s.length + 1;
    let counter = freq.size;
    
    while (end < s.length) {
        const endChar = s.charAt(end);
        
        if (freq.has(endChar)) {
            freq.set(endChar, freq.get(endChar) - 1);
            
            if (freq.get(endChar) === 0) {
                --counter;
            }
        }
        
        ++end;
        
        while (counter === 0) {
            if (end - begin < length) {
                length = end - begin;
                ans = s.substring(begin, end);
            }
            
            const beginChar = s.charAt(begin);
            
            if (freq.has(beginChar)) {
                freq.set(beginChar, freq.get(beginChar) + 1);
                
                if (freq.get(beginChar) > 0) {
                    ++counter;
                }
            }
            
            ++begin;
        }
    }
    
    return ans;
};