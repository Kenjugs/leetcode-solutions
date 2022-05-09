/**
 * 121. Best Time to Buy and Sell Stock - Easy
 * You are given an array prices where prices[i] is the price of a given stock on the ith day.
 * You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
 * Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
 */

/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    let left = 0;
    let right = 1;
    let maxProfit = 0;
    
    while (left < prices.length - 1 && right < prices.length) {
        const profit = prices[right] - prices[left];
        
        if (prices[left] > prices[right]) {
            left = right;
            ++right;
        } else {
            maxProfit = Math.max(maxProfit, profit);
            ++right;
        }
    }
    
    return maxProfit;
};