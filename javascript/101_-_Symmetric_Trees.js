/**
 * 101. Symmetric Trees - Easy
 * Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
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
var isSymmetric = function(root) {
    const left = [];
    const right = [];
    
    if (root) {
        left.push(root.left);
        right.push(root.right);
    }
    
    while (left.length > 0 || right.length > 0) {
        const queueCount = left.length;
        
        for (let i = 0; i < queueCount; ++i) {
            const leftCurrent = left.shift();
            const rightCurrent = right.shift();

            if (leftCurrent === null && rightCurrent !== null) {
                return false;
            }

            if (leftCurrent !== null && rightCurrent === null) {
                return false;
            }

            if (leftCurrent && rightCurrent && leftCurrent.val !== rightCurrent.val) {
                return false;
            }
            
            if (leftCurrent) {
                left.push(leftCurrent.left);
                left.push(leftCurrent.right);
            }
            
            if (rightCurrent) {
                right.push(rightCurrent.right);
                right.push(rightCurrent.left);
            }
        }
    }
    
    return true;
};