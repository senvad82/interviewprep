using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ds.basicds;
namespace ds
{

    public class SearchSuggestions
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {

            List<IList<string>> list = new List<IList<string>>();
            Trie trie = new Trie();

            foreach (string word in products)
            {
                trie.InsertWord(word);
            }
            string tempWord = String.Empty;
            foreach (char c in searchWord)
            {
                tempWord = tempWord + c;
                var result = trie.SearchSuggestions(trie.root, tempWord);
                list.Add(result);
            }

            return list;

        }


    }

   

   
}
