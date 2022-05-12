/**
 * 371. Sum of Two Integers - Medium
 * Given two integers a and b, return the sum of the two integers without using the operators + and -.
 */

public class Solution {
    public int GetSum(int a, int b) {
        while (b != 0) {
            int carry = a & b;
            a = a ^ b;
            b = carry << 1;
        }
        
        return a;
    }
}