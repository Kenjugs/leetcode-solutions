/**
 * 102. Binary Tree Level Order Traversal - Medium
 * Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> ans = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        
        if (root != null) {
            queue.Enqueue(root);
        }
        
        while (queue.Count > 0) {
            IList<int> currentLevel = new List<int>();
            int queueCount = queue.Count;
            
            for (int i = 0; i < queueCount; ++i) {
                TreeNode current = queue.Dequeue();
                
                if (current.left != null) {
                    queue.Enqueue(current.left);
                }
                
                if (current.right != null) {
                    queue.Enqueue(current.right);
                }
                
                currentLevel.Add(current.val);
            }
            
            ans.Add(currentLevel);
        }
        
        return ans;
    }
}