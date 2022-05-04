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
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {boolean}
 */
var isValidBST = function(root) {
    return isValidBSTIterative(root);
};

var isValidBSTIterative = function(root) {
    const stack = [];
    let current = root;
    let previous = null;

    while (current || stack.length > 0) {
        while (current) {
            stack.push(current);
            current = current.left;
        }

        current = stack.pop();

        if (previous && previous.val >= current.val) {
            return false;
        }

        previous = current;
        current = current.right;
    }

    return true;
};

var isValidBSTRecursive = function(root) {
    return recursiveHelper(root, null, null);
};

var recursiveHelper = function(current, minimum, maximum) {
    if (!current) {
        return true;
    }

    if (minimum && current.val <= minimum.val) {
        return false;
    }

    if (maximum && current.val >= maximum.val) {
        return false;
    }

    const left = recursiveHelper(current.left, minimum, current);
    const right = recursiveHelper(current.right, current, maximum);

    return left && right;
};