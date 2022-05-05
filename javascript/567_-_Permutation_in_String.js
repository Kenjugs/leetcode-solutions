/**
 * 567. Permutation in String - Medium
 * Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
 * In other words, return true if one of s1's permutations is the substring of s2.
 */

/**
 * @param {string} s1
 * @param {string} s2
 * @return {boolean}
 */
var checkInclusion = function(s1, s2) {
    const freq = new Map();
    
    for (const c of s1) {
        if (freq.has(c)) {
            freq.set(c, freq.get(c) + 1);
        } else {
            freq.set(c, 1);
        }
    }
    
    let begin = 0;
    let end = 0;
    let counter = freq.size;
    let windowSize = s1.length;
    
    while (end < s2.length) {
        const endChar = s2.charAt(end);
        
        if (freq.has(endChar)) {
            freq.set(endChar, freq.get(endChar) - 1);
            
            if (freq.get(endChar) === 0) {
                --counter;
            }
        }
        
        ++end;
        
        if (end - begin === windowSize) {
            if (counter === 0) {
                return true;
            }
            
            const beginChar = s2.charAt(begin);
            
            if (freq.has(beginChar)) {
                freq.set(beginChar, freq.get(beginChar) + 1);
                
                if (freq.get(beginChar) === 1) {
                    ++counter;
                }
            }
            
            ++begin;
        }
    }
    
    return false;
};