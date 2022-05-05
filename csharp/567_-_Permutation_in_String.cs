/**
 * 567. Permutation in String - Medium
 * Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
 * In other words, return true if one of s1's permutations is the substring of s2.
 */

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        Dictionary<char,int> freq = new Dictionary<char,int>();
        
        foreach (char c in s1) {
            if (freq.ContainsKey(c)) {
                freq[c] += 1;
            } else {
                freq[c] = 1;
            }
        }
        
        int begin = 0;
        int end = 0;
        int counter = freq.Count;
        int windowSize = s1.Length;
        
        while (end < s2.Length) {
            char endChar = s2[end];
            
            if (freq.ContainsKey(endChar)) {
                freq[endChar] -= 1;
                
                if (freq[endChar] == 0) {
                    --counter;
                }
            }
            
            if (end - begin + 1 == windowSize) {
                if (counter == 0) {
                    return true;
                }
                
                char beginChar = s2[begin];
                
                if (freq.ContainsKey(beginChar)) {
                    freq[beginChar] += 1;
                    
                    if (freq[beginChar] == 1) {
                        ++counter;
                    }
                }
                
                ++begin;
            }
            
            ++end;
        }
        
        return false;
    }
}