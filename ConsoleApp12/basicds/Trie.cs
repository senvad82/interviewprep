using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ds.basicds
{
    public class TrieNode
    {

        public TrieNode[] children;
        public bool isEndOfWord = false;


        public TrieNode()
        {
            children = new TrieNode[26];
        }


    }

    public class Trie
        {
            public TrieNode root, current;
            public List<string> results = new List<string>();
            public Trie()
            {
                root = new TrieNode();
            }

            public void InsertWord(string word)
            {

                current = root;
                foreach (char c in word)
                {
                    if (current.children[c - 'a'] == null)
                        current.children[c - 'a'] = new TrieNode();
                    current = current.children[c - 'a'];
                }
                current.isEndOfWord = true;
            }

            public void DFSSearchWithPrefix(TrieNode current, string word)
            {

                if (results.Count == 3) return;

                if (current.isEndOfWord)
                {
                    results.Add(word);
                }

                for (char c = 'a'; c <= 'z'; c++)
                {
                    if (current.children[c - 'a'] != null)
                    {
                        DFSSearchWithPrefix(current.children[c - 'a'], word + c);
                    }
                }


            }

            public List<string> SearchSuggestions(TrieNode root, string word)
            {
                //Console.WriteLine(word);

                results = new List<string>();
                current = root;
                //reach that end of node
                foreach (char c in word)
                {
                    if (current.children[c - 'a'] != null)
                        current = current.children[c - 'a'];
                    else
                        return results;
                }
                //dfs search for suggetsions
                DFSSearchWithPrefix(current, word);


                return results;

            }

        }
  }
