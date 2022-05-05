/**
 * 3. Longest Substring Without Repeating Characters - Medium
 * Given a string s, find the length of the longest substring without repeating characters.
 */

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char,int> freq = new Dictionary<char,int>();
        int ans = 0;
        
        int begin = 0;
        int end = 0;
        
        while (end < s.Length) {
            char endChar = s[end];
            
            if (!freq.ContainsKey(endChar)) {
                freq[endChar] = 1;
                ans = Math.Max(ans, freq.Count);
                ++end;
            } else {
                char beginChar = s[begin];
                freq.Remove(beginChar);
                ++begin;
            }
        }
        
        return ans;
    }
}