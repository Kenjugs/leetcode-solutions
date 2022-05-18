/**
 * 139. Word Break - Medium
 * Given a string s and a dictionary of strings wordDict, return true if s can
 * be segmented into a space-separated sequence of one or more dictionary words.
 * Note that the same word in the dictionary may be reused multiple times in the
 * segmentation.
 */

public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        bool[] memo = new bool[s.Length + 1];
        Array.Fill(memo, false);
        memo[s.Length] = true;
        
        for (int i = s.Length - 1; i >= 0; --i) {
            foreach (string word in wordDict) {
                if (i + word.Length <= s.Length && s.Substring(i, word.Length) == word) {
                    memo[i] = memo[i + word.Length];
                }
                if (memo[i] == true) {
                    break;
                }
            }
        }
        
        return memo[0];
    }
}