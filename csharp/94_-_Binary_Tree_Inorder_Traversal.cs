/**
 * 94. Binary Tree Inorder Traversal - Easy
 * Given the root of a binary tree, return the inorder traversal of its nodes' values.
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
    public IList<int> InorderTraversal(TreeNode root) {
        return InorderTraversalRecursive(root);
    }
    
    public IList<int> InorderTraversalIterative(TreeNode root) {
        IList<int> ans = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        
        while (current != null || stack.Count > 0) {
            while (current != null) {
                stack.Push(current);
                current = current.left;
            }
            
            current = stack.Pop();
            ans.Add(current.val);
            
            current = current.right;
        }
        
        return ans;
    }
    
    public IList<int> InorderTraversalRecursive(TreeNode root) {
        IList<int> ans = new List<int>();
        RecursiveHelper(root, ans);
        return ans;
    }
    
    public void RecursiveHelper(TreeNode current, IList<int> list) {
        if (current == null) {
            return;
        }
        
        RecursiveHelper(current.left, list);
        list.Add(current.val);
        RecursiveHelper(current.right, list);
    }
}