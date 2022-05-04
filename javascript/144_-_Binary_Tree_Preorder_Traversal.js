/**
 * 144. Binary Tree Preorder Traversal - Easy
 * Given the root of a binary tree, return the preorder traversal of its nodes' values.
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
 * @return {number[]}
 */
var preorderTraversal = function(root) {
    const ans = [];
    const stack = [];
    stack.push(root);

    while (stack.length > 0) {
        const current = stack.pop();

        if (current) {
            stack.push(current.right);
            stack.push(current.left);

            ans.push(current.val);
        }
    }

    return ans;
};