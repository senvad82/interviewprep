using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    public static class NumberOfItemInContainer
    {


        public static int[] numberOfItems(String s, int[] startIndices, int[] endIndices)
        {
            // Write your code here
            // Walk trhough string and maintain map with how many * were there in left of it
            var m = startIndices.Length;
            var result = 0;
            var final = new List<int>();

            for (int i = 0; i < m; i++)
            {
                var start = startIndices[i];
                var end = endIndices[i];
                var mystack = new Stack<char>();

                for (int j = start - 1; j < end; j++)
                {
                    Console.WriteLine(j);
                    Console.WriteLine(s[j]);

                    if (mystack.Count == 0 && s[j] != '|') continue;
                    else if (s[j] == '*') mystack.Push(s[j]);
                    else if (s[j] == '|')
                    {
                        var count1 = 0;
                        while (mystack.Count > 0)
                        {
                            mystack.Pop();
                            count1++;
                        }
                        if (count1 > 0)
                        {
                            result = result + count1 - 1;
                            final.Add(count1 - 1);
                            Console.WriteLine("--------------");
                            Console.WriteLine(count1 - 1);
                            Console.WriteLine("--------------");

                        }

                        mystack.Push(s[j]);
                    }

                }

            }

            return final.ToArray();

        }



    }
}
