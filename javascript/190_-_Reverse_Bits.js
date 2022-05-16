/**
 * 190. Reverse Bits - Easy
 * Reverse bits of a given 32 bits unsigned integer.
 * Note:
 * Note that in some languages, such as Java, there is no unsigned integer type.
 * In this case, both input and output will be given as a signed integer type.
 * They should not affect your implementation, as the integer's internal binary
 * representation is the same, whether it is signed or unsigned.
 * In Java, the compiler represents the signed integers using 2's complement
 * notation.
 */

/**
 * @param {number} n - a positive integer
 * @return {number} - a positive integer
 */
var reverseBits = function(n) {
    let m = 1;
    
    for (let i = 0; i < 32; ++i) {
        m <<= 1;
        
        m |= (n & 1);
        n >>>= 1;
    }
    
    return m >>> 0;
};