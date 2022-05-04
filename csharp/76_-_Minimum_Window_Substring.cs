/**
 * 76. Minimum Window Substring - Hard
 * Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that
 * every character in t (including duplicates) is included in the window. If there is no such substring, return
 * the empty string "".
 * The testcases will be generated such that the answer is unique.
 * A substring is a contiguous sequence of characters within the string.
 */

public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char,int> freq = new Dictionary<char,int>();
        
        foreach (char c in t) {
            if (freq.ContainsKey(c)) {
                freq[c] += 1;
            } else {
                freq[c] = 1;
            }
        }
        
        int begin = 0;
        int end = 0;
        int counter = freq.Count;
        int length = int.MaxValue;
        
        string ans = "";
        
        while (end < s.Length) {
            char endChar = s[end];
            
            if (freq.ContainsKey(endChar)) {
                freq[endChar] -= 1;
                
                if (freq[endChar] == 0) {
                    --counter;
                }
            }
            
            ++end;
            
            while (counter == 0) {
                if (end - begin < length) {
                    length = end - begin;
                    ans = s.Substring(begin, end - begin);
                }
                
                char startChar = s[begin];
                
                if (freq.ContainsKey(startChar)) {
                    freq[startChar] += 1;
                    
                    if (freq[startChar] > 0) {
                        ++counter;
                    }
                }
                
                ++begin;
            }
        }
        
        return ans;
    }
}