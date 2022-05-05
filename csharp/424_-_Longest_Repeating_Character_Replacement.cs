/**
 * 424. Longest Repeating Character Replacement - Medium
 * You are given a string s and an integer k. You can choose any character of the string and change it to
 * any other uppercase English character. You can perform this operation at most k times.
 * Return the length of the longest substring containing the same letter you can get after performing the above operations.
 */

public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char,int> freq = new Dictionary<char,int>();
        
        int begin = 0;
        int result = 0;
        int maxFreq = 0;
        
        for (int end = 0; end < s.Length; ++end) {
            char endChar = s[end];
            
            if (freq.ContainsKey(endChar)) {
                freq[endChar] += 1;
            } else {
                freq[endChar] = 1;
            }
            
            maxFreq = Math.Max(maxFreq, freq[endChar]);
            
            int window = end - begin + 1;
            
            if (window - maxFreq > k) {
                char beginChar = s[begin];
                freq[beginChar] -= 1;
                ++begin;
            }
            
            result = Math.Max(result, end - begin + 1);
        }
        
        return result;
    }
}