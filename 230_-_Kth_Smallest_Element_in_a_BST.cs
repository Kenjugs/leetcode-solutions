/**
 * 230. Kth Smallest Element in a BST - Medium
 * Given the root of a binary search tree, and an integer k, return the kth smallest value (1-indexed) of all the values of the nodes in the tree.
 */

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        return KthSmallestIterative(root, k);
    }
    
    public int KthSmallestIterative(TreeNode root, int k) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        
        while (current != null || stack.Count > 0) {
            while (current != null) {
                stack.Push(current);
                current = current.left;
            }
            
            current = stack.Pop();
            
            --k;
            if (k == 0) {
                return current.val;
            }
            
            current = current.right;
        }
        
        return -1;
    }
}