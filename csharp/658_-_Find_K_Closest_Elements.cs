/**
 * 658. Find K Closest Elements - Medium
 * Given a sorted integer array arr, two integers k and x, return the k closest
 * integers to x in the array. The result should also be sorted in ascending
 * order.
 * An integer a is closer to x than an integer b if:
 *   |a - x| < |b - x|, or
 *   |a - x| == |b - x| and a < b
 */

public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        int pos = BinarySearch(arr, x);
        
        int left = pos - 1;
        int right = pos;
        
        while (k > 0) {
            if (left < 0) {
                ++right;
            } else if (right >= arr.Length) {
                --left;
            } else if (Math.Abs(arr[left] - x) <= Math.Abs(arr[right] - x)) {
                --left;
            } else {
                ++right;
            }
            
            --k;
        }
        
        int[] ans = new int[right - (left + 1)];
        Array.Copy(arr, left + 1, ans, 0, ans.Length);
        return ans;
    }
    
    public int BinarySearch(int[] arr, int target) {
        int left = 0;
        int right = arr.Length - 1;
        
        while (left <= right) {
            int mid = (left + right) / 2;
            
            if (arr[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        
        return left;
    }
}