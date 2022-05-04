/**
 * 438. Find All Anagrams in a String - Medium
 * Given two strings s and p, return an array of all the start indices of p's anagrams in s.
 * You may return the answer in any order.
 * An Anagram is a word or phrase formed by rearranging the letters of a different word or
 * phrase, typically using all the original letters exactly once.
 */

/**
 * @param {string} s
 * @param {string} p
 * @return {number[]}
 */
var findAnagrams = function(s, p) {
    const freq = new Map();
    const ans = [];

    for (const c of p) {
        if (freq.has(c)) {
            freq.set(c, freq.get(c) + 1);
        } else {
            freq.set(c, 1);
        }
    }

    let begin = 0;
    let end = 0;
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

        // limit the length of our window to the length of p
        if (end - begin === p.length) {
            if (counter === 0) {
                ans.push(begin);
            }

            const beginChar = s.charAt(begin);

            if (freq.has(beginChar)) {
                freq.set(beginChar, freq.get(beginChar) + 1);

                if (freq.get(beginChar) === 1) {
                    ++counter;
                }
            }

            ++begin;
        }
    }

    return ans;
};