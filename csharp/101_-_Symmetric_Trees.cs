/**
 * 101. Symmetric Trees - Easy
 * Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
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
    public bool IsSymmetric(TreeNode root) {
        Queue<TreeNode> left = new Queue<TreeNode>();
        Queue<TreeNode> right = new Queue<TreeNode>();
        
        if (root != null) {
            left.Enqueue(root.left);
            right.Enqueue(root.right);
        }
        
        while (left.Count > 0 || right.Count > 0) {
            int queueCount = left.Count; // left.count should always == right.count
            
            for (int i = 0; i < queueCount; ++i) {
                TreeNode leftCurrent = left.Dequeue();
                TreeNode rightCurrent = right.Dequeue();

                if (leftCurrent == null && rightCurrent != null) {
                    return false;
                }

                if (leftCurrent != null && rightCurrent == null) {
                    return false;
                }

                if (leftCurrent != null && rightCurrent != null && leftCurrent.val != rightCurrent.val) {
                    return false;
                }

                if (leftCurrent != null) {
                    left.Enqueue(leftCurrent.left);
                    left.Enqueue(leftCurrent.right);
                }

                if (rightCurrent != null) {
                    right.Enqueue(rightCurrent.right);
                    right.Enqueue(rightCurrent.left);
                }
            }
        }
        
        return true;
    }
}