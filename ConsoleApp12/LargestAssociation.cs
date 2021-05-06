using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ds
{
    public class PairString
    {
        public String first;
        public String second;

        public PairString(String first, String second)
        {
            this.first = first;
            this.second = second;
        }
    }
    public static class LargestAssociation
    {


        public static List<String> LargestItemAssociation(List<PairString> itemAssociation)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            foreach(var item in itemAssociation)
            {
                if (map.ContainsKey(item.first))
                {
                    map[item.first].Add(item.second);
                }
                else
                {
                    map.Add(item.first, new List<string>() { item.second });

                }
                if (map.ContainsKey(item.second))
                {
                    map[item.second].Add(item.first);
                }
                else
                {
                    map.Add(item.second, new List<string>() { item.first });

                }
            }
            int connectedComponents = 0;
            List<string> maxResult = new List<string>();
            HashSet<string> visited = new HashSet<string>();
            foreach (var item in map.Keys.OrderBy(x=>x))
            {                
                List<string> result = new List<string>();
                int maxCount = -1;
                if (visited.Contains(item)) continue;
                DFS(item, map, visited, result);
                connectedComponents++;
                if (result.Count > maxCount)
                {
                    maxResult = result;
                    maxResult.Sort();
                }
            }
            Console.WriteLine(connectedComponents);
            return maxResult;
        }

        private static void DFS(string currentNode, Dictionary<string, List<string>> map, HashSet<string> visited, List<string> connected)
        {
            if (connected.Contains(currentNode)) return;
            visited.Add(currentNode);
            connected.Add(currentNode);
            foreach (var item in map[currentNode]) {               
                
                DFS(item, map, visited, connected);

            }
        }



    }
}
