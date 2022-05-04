/**
 * 30. Substring with Concatenation of All Words - Hard
 * You are given a string s and an array of strings words of the same length.
 * Return all starting indices of substring(s) in s that is a concatenation of each word in words
 * exactly once, in any order, and without any intervening characters.
 * You can return the answer in any order.
 */

public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        Dictionary<string,int> freq = new Dictionary<string,int>();
        IList<int> ans = new List<int>();
        
        foreach (string w in words) {
            if (freq.ContainsKey(w)) {
                freq[w] += 1;
            } else {
                freq[w] = 1;
            }
        }
        
        int wordLength = words[0].Length;
        int windowSize = wordLength * words.Length;
        
        for (int i = 0; i < wordLength; ++i) {
            int begin = i;
            int end = i;
            Dictionary<string,int> copy = new Dictionary<string,int>(freq);
            int counter = copy.Count;
        
            while (end + wordLength - 1 < s.Length) {
                string endWord = s.Substring(end, wordLength);

                if (copy.ContainsKey(endWord)) {
                    copy[endWord] -= 1;
                    
                    if (copy[endWord] == 0) {
                        --counter;
                    }
                }

                if (end + wordLength - begin == windowSize) {
                    if (counter == 0) {
                        ans.Add(begin);
                    }

                    string beginWord = s.Substring(begin, wordLength);

                    if (copy.ContainsKey(beginWord)) {
                        copy[beginWord] += 1;

                        if (copy[beginWord] == 1) {
                            ++counter;
                        }
                    }

                    begin += wordLength;
                }
                
                end += wordLength;
            }
        }
        
        return ans;
    }
}