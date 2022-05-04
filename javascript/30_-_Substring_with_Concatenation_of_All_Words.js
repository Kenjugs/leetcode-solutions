/**
 * 30. Substring with Concatenation of All Words - Hard
 * You are given a string s and an array of same-length strings words.
 * Return all starting indices of substring(s) in s that is a concatenation of each word in words
 * exactly once, in any order, and without any intervening characters.
 * You can return the answer in any order.
 */

/**
 * @param {string} s
 * @param {string[]} words
 * @return {number[]}
 */
var findSubstring = function(s, words) {
    const freq = new Map();
    const ans = [];

    for (const w of words) {
        if (freq.has(w)) {
            freq.set(w, freq.get(w) + 1);
        } else {
            freq.set(w, 1);
        }
    }

    const wordLength = words[0].length;
    const windowSize = words.length * wordLength;

    for (let i = 0; i < wordLength; ++i) {
        const copy = new Map(freq);
        
        let begin = i;
        let end = i;
        let counter = copy.size;
        
        while (end + wordLength <= s.length) {
            const endWord = s.substring(end, end + wordLength);
            
            if (copy.has(endWord)) {
                copy.set(endWord, copy.get(endWord) - 1);
                
                if (copy.get(endWord) === 0) {
                    --counter;
                }
            }
            
            end += wordLength;
            
            if (end - begin === windowSize) {
                if (counter === 0) {
                    ans.push(begin);
                }
                
                const beginWord = s.substring(begin, begin + wordLength);
                
                if (copy.has(beginWord)) {
                    copy.set(beginWord, copy.get(beginWord) + 1);
                    
                    if (copy.get(beginWord) === 1) {
                        ++counter;
                    }
                }
                
                begin += wordLength;
            }
        }
    }
    
    return ans;
};