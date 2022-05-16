/**
 * 338. Counting Bits - Easy
 * Given an integer n, return an array ans of length n + 1 such that for each i
 * (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.
 */

public class Solution {
    public int[] CountBits(int n) {
        int[] ans = new int[n + 1];
        
        for (int i = 0; i <= n; ++i) {
            HammingWeight(i, ans);
        }
        
        return ans;
    }
    
    public void HammingWeight(int n, int[] memo) {
        int count = 0;
        
        if ((n & 1) == 1) {
            count = 1;
        }
        
        count += memo[n >> 1];
        memo[n] = count;
    }
}