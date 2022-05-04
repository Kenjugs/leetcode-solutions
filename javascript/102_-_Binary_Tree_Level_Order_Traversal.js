/**
 * 102. Binary Tree Level Order Traversal - Medium
 * Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
 */

/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[][]}
 */
 var levelOrder = function(root) {
    let queue = [];
    let ans = [];
    
    if (root) {
        queue.push(root);
    }
    
    while (queue.length > 0) {
        let queueCount = queue.length;
        let level = [];
        
        for (let i = 0; i < queueCount; ++i) {
            let current = queue.shift();
            
            if (current.left) {
                queue.push(current.left);
            }
            
            if (current.right) {
                queue.push(current.right);
            }
            
            level.push(current.val);
        }
        
        ans.push(level);
    }
    
    return ans;
};