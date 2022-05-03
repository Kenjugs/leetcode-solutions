/**
 * 98. Validate Binary Search Tree - Medium
 * Given the root of a binary tree, determine if it is a valid binary search tree (BST).
 * A valid BST is defined as follows:
 *   - The left subtree of a node contains only nodes with keys less than the node's key
 *   - The right subtree of a node contains only nodes with keys greater than the node's key
 *   - Both the left and right subtrees must also be binary search trees.
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
    public bool IsValidBST(TreeNode root) {
        return IsValidBSTRecursive(root);
    }
    
    public bool IsValidBSTIterative(TreeNode root) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        TreeNode previous = null;
        
        while (current != null || stack.Count > 0) {
            while (current != null) {
                stack.Push(current);
                current = current.left;
            }
            
            current = stack.Pop();
            
            if (previous != null && previous.val >= current.val) {
                return false;
            }
            
            previous = current;
            current = current.right;
        }
        
        return true;
    }
    
    public bool IsValidBSTRecursive(TreeNode root) {
        return RecursiveHelper(root, null, null);
    }
    
    public bool RecursiveHelper(TreeNode current, TreeNode minimum, TreeNode maximum) {
        if (current == null) {
            return true;
        }
        
        if (minimum != null && current.val <= minimum.val) {
            return false;
        }
        
        if (maximum != null && current.val >= maximum.val) {
            return false;
        }
        
        bool left = RecursiveHelper(current.left, minimum, current);
        bool right = RecursiveHelper(current.right, current, maximum);
        
        return (left && right);
    }
}