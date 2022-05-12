/**
 * 371. Sum of Two Integers - Medium
 * Given two integers a and b, return the sum of the two integers without using the operators + and -.
 */

/**
 * @param {number} a
 * @param {number} b
 * @return {number}
 */
var getSum = function(a, b) {
    while (b !== 0) {
        const carry = a & b;
        a = a ^ b;
        b = carry << 1;
    }
    
    return a;
};