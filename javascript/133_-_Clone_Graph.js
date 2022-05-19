/**
 * 133. Clone Graph - Medium
 * Given a reference of a node in a connected undirected graph.
 * Return a deep copy (clone) of the graph.
 * Each node in the graph contains a value (int) and a list (List[Node]) of its
 * neighbors.
 *   class Node {
         public int val;
         public List<Node> neighbors;
 *   }
 * Test case format:
 * For simplicity, each node's value is the same as the node's index
 * (1-indexed). For example, the first node with val == 1, the second node with
 * val == 2, and so on. The graph is represented in the test case using an
 * adjacency list.
 * An adjacency list is a collection of unordered lists used to represent a
 * finite graph. Each list describes the set of neighbors of a node in the
 * graph.
 * The given node will always be the first node with val = 1. You must return
 * the copy of the given node as a reference to the cloned graph.
 */

/**
 * // Definition for a Node.
 * function Node(val, neighbors) {
 *    this.val = val === undefined ? 0 : val;
 *    this.neighbors = neighbors === undefined ? [] : neighbors;
 * };
 */

/**
 * @param {Node} node
 * @return {Node}
 */
var cloneGraph = function(node) {
    const visited = new Map();
    
    const dfs = function(n) {
        if (n === null || n === undefined) {
            return;
        }
        
        // create clone node and add to a visited set
        // Node.val is unique, so we can use it as a key
        const clone = new Node(n.val);
        visited.set(n.val, clone);
        
        const adjList = [];
        
        // build adjacency list for cloned node by checking
        // for visited neighbors
        for (const neighbor of n.neighbors) {
            if (visited.has(neighbor.val)) {
                adjList.push(visited.get(neighbor.val));
                continue;
            }
            
            adjList.push(dfs(neighbor));
        }
        
        clone.neighbors = adjList;
        return clone;
    };
    
    return dfs(node);
};