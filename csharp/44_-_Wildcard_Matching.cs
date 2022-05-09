/**
 * 44. Wildcard Matching - Hard
 * Given an input string (s) and a pattern (p), implement wildcard pattern matching with support for '?' and '*' where:
 * '?' Matches any single character.
 * '*' Matches any sequence of characters (including the empty sequence).
 * The matching should cover the entire input string (not partial).
 */

public class Solution {
    public bool IsMatch(string s, string p) {
        int[][] memo = new int[s.Length][];
        
        for (int i = 0; i < memo.Length; ++i) {
            memo[i] = new int[p.Length];
        }
        
        return DFSMemo(s, p, 0, 0, memo);
    }
    
    public bool DFSMemo(string s, string p, int i, int j, int[][] memo) {
        if (i == s.Length && j == p.Length) {
            return true;
        }
        
        if (j >= p.Length) {
            return false;
        }
        
        if (i == s.Length) {
            for (int k = j; k < p.Length; ++k) {
                if (p[k] != '*') {
                    return false;
                }
            }
            
            return true;
        }
        
        // memo[i][j] values can be
        // 0=unchecked, 1=match, 2=no match
        if (memo[i][j] != 0) {
            return memo[i][j] == 1;
        }
        
        bool matched = false;
        
        if (p[j] == '*') {
            // i + 1, j = greedy matching
            matched = DFSMemo(s, p, i + 1, j, memo);
            
            // i, j + 1 = 0-length matching
            matched = matched || DFSMemo(s, p, i, j + 1, memo);
        } else {
            if (s[i] == p[j] || p[j] == '?') {
                matched = true;
            }
            
            matched = matched && DFSMemo(s, p, i + 1, j + 1, memo);
        }
        
        memo[i][j] = (matched ? 1 : 2);
        return memo[i][j] == 1;
    }
}