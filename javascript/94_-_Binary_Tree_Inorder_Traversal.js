/**
 * 94. Binary Tree Inorder Traversal - Easy
 * Given the root of a binary tree, return the inorder traversal of its nodes' values.
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
var inorderTraversal = function(root) {
    return inorderTraversalIterative(root);
};

var inorderTraversalIterative = function(root) {
    const ans = [];
    const stack = [];
    let current = root;

    while (current || stack.length > 0) {
        while (current) {
            stack.push(current);
            current = current.left;
        }

        current = stack.pop();
        ans.push(current.val);

        current = current.right;
    }
};

var inorderTraversalRecursive = function(root) {
    const ans = [];
    recursiveHelper(root, ans);
    return ans;
};

var recursiveHelper = function(current, list) {
    if (!current) {
        return;
    }

    recursiveHelper(current.left, list);
    list.push(current.val);
    recursiveHelper(current.right, list);
};