/**
 * 438. Find All Anagrams in a String - Medium
 * Given two strings s and p, return an array of all the start indices of p's anagrams in s.
 * You may return the answer in any order.
 * An Anagram is a word or phrase formed by rearranging the letters of a different word or
 * phrase, typically using all the original letters exactly once.
 */

public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        Dictionary<char,int> freq = new Dictionary<char,int>();
        IList<int> ans = new List<int>();
        
        foreach (char c in p) {
            if (freq.ContainsKey(c)) {
                freq[c] += 1;
            } else {
                freq[c] = 1;
            }
        }
        
        int begin = 0;
        int end = 0;
        int counter = freq.Count;
        
        while (end < s.Length) {
            char endChar = s[end];
            
            if (freq.ContainsKey(endChar)) {
                freq[endChar] -= 1;
                
                if (freq[endChar] == 0) {
                    --counter;
                }
            }
            
            ++end;
            
            // limit the length of our window to the length of p
            if (end - begin == p.Length) {
                if (counter == 0) {
                    ans.Add(begin);
                }
                
                char beginChar = s[begin];
                
                if (freq.ContainsKey(beginChar)) {
                    freq[beginChar] += 1;
                    
                    if (freq[beginChar] == 1) {
                        ++counter;
                    }
                }
                
                ++begin;
            }
        }
        
        return ans;
    }
}