/**
 * 144. Binary Tree Preorder Traversal - Easy
 * Given the root of a binary tree, return the preorder traversal of its nodes' values.
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
using System.Collections.Generic;

public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> ans = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        
        while (stack.Count > 0) {
            TreeNode current = stack.Pop();
            
            if (current != null) {
                stack.Push(current.right);
                stack.Push(current.left);
                
                ans.Add(current.val);
            }
        }
        
        return ans;
    }
}