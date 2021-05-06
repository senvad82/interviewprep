using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ds
{
    
    public static class SubstringSizeKDistinctChars
    {

        static HashSet<string> substrings = new HashSet<string>();
        static HashSet<char> chars = new HashSet<char>();
        public static string[] GetSubstringSizeKDistinctChars(string s, int k)
        {
            int l = s.Length;
            
            for(int i = 0; i + k < l; i++)
            {
                //var str = "abcabbcd";
                int subIndex = i;
                int charCount = 0;
                StringBuilder sb = new StringBuilder("", k);                
                Console.WriteLine("-----------------");
                while (subIndex < l)
                {
                    Console.WriteLine(subIndex);

                    if (chars.Contains(s[subIndex]))
                    {
                        subIndex = subIndex+1;
                        sb.Clear();
                        charCount = 0;
                        chars.Clear();

                    }
                    sb.Append(s[subIndex]);                    
                    chars.Add(s[subIndex]);
                    Console.WriteLine(sb.ToString());
                    
                    subIndex++;
                    charCount++;

                    if (charCount == k)
                    {
                        substrings.Add(sb.ToString());
                        sb.Clear();
                        charCount = 0;
                        chars.Clear();

                    }

                }

                
                Console.WriteLine("-----------------");



            }

            return substrings.ToArray();


        }

        public static string[] SlidingWindowTechnique(string s, int k)
        {
            int l = s.Length;

            int left = 0;
            int right = 0;
            HashSet<char> set = new HashSet<char>();
            char c;
            while (right < s.Length)
            {
                c = s[right];
                while (left< right && set.Contains(c))
                {                    
                    set.Remove(s[left]);
                    left++;
                }
                set.Add(c);
                
                if (set.Count == k)
                {
                    substrings.Add(s.Substring(left, k));
                    set.Remove(s[left]);
                    left = left + 1;
                    
                }
                right = right + 1;
            }

            

            //while (left <= right && !set.Contains(s[left]))
            //{
            //    set.Add(s[left]);
                
            //    if (set.Count == k)
            //    {
            //        substrings.Add(s.Substring(windowstart, k));
            //        left = right+1;
            //        right = left + k - 1;
            //        set.Clear();
            //        windowstart = left;
            //    }
            //    else
            //    {
            //        left++;
            //    }
                
            //}
            
            return substrings.ToArray();


        }



    }
}
