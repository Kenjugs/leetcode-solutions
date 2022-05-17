/**
 * 1143. Longest Common Subsequence - Medium
 * Given two strings text1 and text2, return the length of their longest common
 * subsequence. If there is no common subsequence, return 0.
 * A subsequence of a string is a new string generated from the original string
 * with some characters (can be none) deleted without changing the relative
 * order of the remaining characters.
 * For example, "ace" is a subsequence of "abcde".
 * A common subsequence of two strings is a subsequence that is common to both strings.
 */

public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int[][] memo = new int[text1.Length + 1][];
        
        for (int i = 0; i < memo.Length; ++i) {
            memo[i] = new int[text2.Length + 1];
            memo[i][text2.Length] = 0;
            
            if (i == text1.Length) {
                Array.Fill(memo[i], 0);
            }
        }
        
        for (int i = text1.Length - 1; i >= 0; --i) {
            for (int j = text2.Length - 1; j >= 0; --j) {
                if (text1[i] == text2[j]) {
                    memo[i][j] = 1 + memo[i + 1][j + 1];
                } else {
                    memo[i][j] = Math.Max(memo[i][j + 1], memo[i + 1][j]);
                }
            }
        }
        
        return memo[0][0];
    }
}