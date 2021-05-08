using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ds
{
    
    public static class FindCompetitors
    {


        public static List<string> findCompetitors(int numCompetitors, int topNCompetitors, List<String> competitors,
           int numReviews, List<String> reviews)
        {

            List<string> result = new List<string>();
            //int count = 0;
            SortedDictionary<int, List<string>> map = new SortedDictionary<int, List<string>>();
            Dictionary<int, List<string>> map1 = new Dictionary<int, List<string>>();
            List<int> lst1 = new List<int>();
            for (int i = 0; i < numCompetitors; i++)
            {
                int count = 0;
                for (int j = 0; j < numReviews; j++)
                {
                    if (reviews[j].ToLower().Contains(competitors[i].ToLower())) count++;
                }
                Console.WriteLine($"{competitors[i].ToLower()}:{count}");
                if (map.ContainsKey(count))
                {
                    var lst = map[count];
                    lst.Add(competitors[i].ToLower());
                    map.Remove(count);
                    map.Add(count, lst);
                }
                else
                {
                    map.Add(count, new List<string>() { competitors[i].ToLower() });
                }
                lst1.Add(count);

            }
            int temp = 0;

            foreach (int key in map.Keys.Reverse())
            {
                var lst = map[key];
                foreach (var item in lst)
                {
                    result.Add(item);
                    temp++;
                }
                if (temp == topNCompetitors)
                    break;
            }

            return result;

        }



    }
}
