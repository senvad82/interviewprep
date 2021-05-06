using System;
using System.Collections.Generic;
using System.Linq;

namespace ds
{
    class Program
    {
        //Prime Air Route
        public static int[][] TwoSumClosest(int[][] arr1, int[][] arr2, int target)
        {
            // find length of array and assign it to 
            // naive solution would putting in 2 loops.
            // check each combination and maintain min distance
            // Time Complexity O(n)
            int n = arr1.Length;
            int m = arr2.Length;
            int minDistance = Int32.MaxValue;
            int[][] minDistValue = new int[1][]{ new int[] { -1, -1 } };
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //Console.WriteLine(arr1[i][1]);
                    //Console.WriteLine(arr1[j][1]);
                    int temp = arr1[i][1] + arr2[j][1];
                    //Console.WriteLine(temp);
                    if (temp <= target)
                    {
                        if (target - temp < minDistance)
                        {
                            minDistance = target - temp;
                            minDistValue = new int[1][] { new int[] { arr1[i][0], arr2[j][0] } };
                        }
                            
                    }
                }
            }
            
            // Two Pointer Approach
            // Two pointers one pointer each Arry

            return minDistValue;

        }

        //Amazon Fulfilment Center

        public static int FindClosestMatch(int[] availableBoxes, int productSize)
        {
            //Since Array is sorted binary search would provide best efficient solution

            int left = 0;
            int right = availableBoxes.Length-1;           
            while (left < right)
            {
                int mid = (left+right)/2;
                if (availableBoxes[mid] == productSize)
                {
                    return availableBoxes[mid];
                }
                //Console.WriteLine(left);
                //Console.WriteLine(right);
                //Console.WriteLine(mid);
                if(availableBoxes[mid] > productSize) {
                    
                    right = mid-1;
                }
                else if(availableBoxes[mid] < productSize)
                {                    
                    left = mid + 1;
                }                 
                
            }
            if (availableBoxes[left] > productSize)
                return availableBoxes[left];
            else if (left < availableBoxes.Length-1)
                return availableBoxes[left + 1];
            else return -1;

            //return 0;
        }
            public int NumPairsDivisibleBy60(int[] time)
            {

                // maintain map of possibleLoop through all elements 

                int[] map = new int[60];                
                int n = time.Length;
                if (n == 0) return 0;
                int count = 0;
                for (int i = 0; i < n; i++)
                {

                    var remain = time[i] % 60;

                    if (remain == 0)
                    {
                        count += map[0];                        
                        map[0]++;
                    }
                    else
                    {
                        count += map[60 - remain];
                        map[remain]++;
                    }
                }
                return count;

            }

        public static int[] numberOfItems(String s, int[] startIndices, int[] endIndices)
        {
            // Write your code here
            // Walk trhough string and maintain map with how many * were there in left of it
            var m = startIndices.Length;
            var result = 0;
            var final = new List<int>();
            
            for(int i=0; i<m; i++)
            {
                var start = startIndices[i];
                var end = endIndices[i];
                var mystack = new Stack<char>();

                for(int j=start-1; j < end; j++)
                {
                    Console.WriteLine(j);
                    Console.WriteLine(s[j]);

                    if (mystack.Count == 0 && s[j] != '|') continue;
                    else if (s[j] == '*') mystack.Push(s[j]);
                    else if (s[j]=='|')
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

        public static List<string> findCompetitors(int numCompetitors, int topNCompetitors, List<String> competitors,
            int numReviews, List<String> reviews)
        {

            List<string> result = new List<string>();
            //int count = 0;
            SortedDictionary<int, List<string>> map = new SortedDictionary<int, List<string>>();
            Dictionary<int, List<string>> map1 = new Dictionary<int, List<string>>();
            List<int> lst1 = new List<int>();
            for (int i=0; i< numCompetitors; i++)
            {
                int count = 0;
                for (int j=0;j<numReviews;j++)
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
                foreach(var item in lst)
                {
                    result.Add(item);
                    temp++;
                }
                if (temp == topNCompetitors)
                    break;
            }
            
            return result;

        }

        public static bool AmazonFreshPromotion(string[][] codeList, string[] shoppingCart)
        {
            //get each codelist an match pattern with shopping cart
            // codelist = [apple,apple][orange,anything,orange]
            //shopping cart = [orange,apple, apple, orange,banana, orange]
            int codeListCount = codeList.Length; //2
            int shpListCount = shoppingCart.Length; //5
            int currentCodeIndex = 0;
            int currentShoppingCartIndex = 0;
            int count = 0;
            Console.WriteLine($"------------------");
            while (currentCodeIndex < codeListCount && currentShoppingCartIndex < shpListCount)
            {
                string[] currentCode = codeList[currentCodeIndex];// [apple,apple]
                int currentCodeLength = currentCode.Length; //2
                int index = 0;

                while(index < currentCodeLength && currentShoppingCartIndex < shpListCount)
                {
                    Console.WriteLine($"{index},{currentCode[index]}:{currentShoppingCartIndex},{shoppingCart[currentShoppingCartIndex]}");
                    if (currentCode[index] == "anything" || shoppingCart[currentShoppingCartIndex] == currentCode[index])
                    {


                        index++;
                        currentShoppingCartIndex++;

                    }
                    else
                    {
                        currentShoppingCartIndex++;
                        if (index > 0) break;
                    }
                }

                Console.WriteLine($"{index},{count}");
                if (index == currentCodeLength)
                {
                    currentCodeIndex++;
                    count++;
                }                

            }

            return (count == codeListCount)?true:false;

        }


        public static void Main(string[] args)
        {
            //Prime Air Route
            //int[][] arr1 = new int[2][] { new int[]{ 1, 1000 }, new int[]{ 2, 2000 } };
            //int[][] arr2 = new int[3][] { new int[] { 4, 1000 }, new int[] { 5, 2000 }, new int[] { 6, 3000 } };
            //int target = 7000;
            //int[][] result = TwoSumClosest(arr1, arr2, target);
            //Console.WriteLine($"{{{result[0][0]},{result[0][1]}}}");

            //Amazon Fulfilment Center
            //int[] arr3 = new int[6] { 2, 7, 9, 11, 13, 16 };
            //int res1 = FindClosestMatch(arr3, 1);
            //Console.WriteLine(res1.ToString());
            //res1 = FindClosestMatch(arr3, 9);
            //Console.WriteLine(res1.ToString());
            //res1 = FindClosestMatch(arr3, 12);
            //Console.WriteLine(res1.ToString());
            //res1 = FindClosestMatch(arr3, 17);
            //Console.WriteLine(res1.ToString());

            //
            //NumPairsDivisibleBy60
            // https://leetcode.com/problems/pairs-of-songs-with-total-durations-divisible-by-60/

            //Items in Container

            //var s = "*|**|*|*";
            //Console.WriteLine(s);
            //var si = new int[] { 1, 1 };
            //var ei = new int[] { 5, 6 };
            //var result = numberOfItems(s, si, ei);
            //foreach(var i in result)
            //{
            //    Console.Write(i);

            //}
            Console.WriteLine("-------------");

            //s = "*|**|*|****|";
            //Console.WriteLine(s);
            //si = new int[] { 1, 1 };
            //ei = new int[] { 5, 10 };
            //result = numberOfItems(s, si, ei);
            //foreach (var i in result)
            //{
            //    Console.Write(i);

            //}
            //Console.WriteLine("-------------");
            //var s = "*****|**|*|****|****|****";
            //Console.WriteLine(s);
            //var si = new int[] {  1 };
            //var ei = new int[] {  22 };
            //var result = numberOfItems(s, si, ei);
            //foreach (var i in result)
            //{
            //    Console.Write(i);

            //}


            //findCompetitors
            //int numCompetitors = 6;
            //int topNCompetitors = 2;
            //List<string> competitors = new List<string>() { "newshop", "shopnow", "afashion", "fashionbeats", "mymarket", "tcellular" };
            //int numReviews = 6;

            //List<string> reviews = new List<string>() {"newshop is providing good services in the city; everyone should use newshop",
            // "best services by newshop",
            // "fashionbeats has great services in the city",
            //  "I am proud to have fashionbeats",
            //  "mymarket has awesome services",
            //  "Thanks Newshop for the quick delivery" };
            //List<string> resultComp = findCompetitors(numCompetitors, topNCompetitors, competitors, numReviews, reviews);

            //foreach (var i in resultComp)
            //{
            //    Console.WriteLine(i);

            //}

            //Fresh Amazon Promotion


            //String[][] codeList1 = new string[][] { new string[] { "apple", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  String[] shoppingCart1 = new string[] { "orange", "apple", "apple", "banana", "orange", "banana" };
            //  String[][] codeList2 = new string[][] { new string[] { "apple", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  String[] shoppingCart2 = new string[] { "banana", "orange", "banana", "apple", "apple" };
            //  String[][] codeList3 = new string[][] { new string[] { "apple", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  String[] shoppingCart3 = new string[] { "apple", "banana", "apple", "banana", "orange", "banana" };
            //  String[][] codeList4 = new string[][] { new string[] { "apple", "apple" }, new string[] { "apple", "apple", "banana" } };
            //  String[] shoppingCart4 = new string[] { "apple", "apple", "apple", "banana" };
            //  String[][] codeList5 = new string[][] { new string[] { "apple", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  String[] shoppingCart5 = new string[] { "orange", "apple", "apple", "banana", "orange", "banana" };
            //  String[][] codeList6 = new string[][] { new string[] { "apple", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  String[] shoppingCart6 = new string[] { "apple", "apple", "orange", "orange", "banana", "apple", "banana", "banana" };
            //  String[][] codeList7 = new string[][] { new string[] { "anything", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  String[] shoppingCart7 = new string[] { "orange", "grapes", "apple", "orange", "orange", "banana", "apple", "banana", "banana" };
            //  String[][] codeList8 = new string[][] { new string[] { "apple", "orange" }, new string[] { "orange", "banana", "orange" } };
            //  String[] shoppingCart8 = new string[] { "apple", "orange", "banana", "orange", "orange", "banana", "orange", "grape" };
            //  String[][] codeList9 = new string[][] { new string[] { "anything", "anything", "anything", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  String[] shoppingCart9 = new string[] { "orange", "apple", "banana", "orange", "apple", "orange", "orange", "banana", "apple", "banana" };
            //  // test
            //  Console.WriteLine(AmazonFreshPromotion(codeList1, shoppingCart1)); //1
            //  Console.WriteLine(AmazonFreshPromotion(codeList2, shoppingCart2)); //0
            //  Console.WriteLine(AmazonFreshPromotion(codeList3, shoppingCart3)); //0
            //  Console.WriteLine(AmazonFreshPromotion(codeList4, shoppingCart4)); //0
            //  Console.WriteLine(AmazonFreshPromotion(codeList5, shoppingCart5)); //1
            //  Console.WriteLine(AmazonFreshPromotion(codeList6, shoppingCart6)); //1
            //  Console.WriteLine(AmazonFreshPromotion(codeList7, shoppingCart7)); //1
            //  Console.WriteLine(AmazonFreshPromotion(codeList8, shoppingCart8)); //1
            //  Console.WriteLine(AmazonFreshPromotion(codeList9, shoppingCart9)); //1
            // string[][] codeList10 = new string[][] {new string[] { "apple", "apple" },new string[]{ "banana", "anything", "banana" } };
            //  string[] shoppingCart10 = new string[] { "orange", "apple", "apple", "banana", "orange", "banana" };
            //  bool result10 = AmazonFreshPromotion(codeList1, shoppingCart1);
            //  string[][] codeList11 = new string[][] { new string[] { "apple", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  string[] shoppingCart11 = new string[] { "banana", "orange", "banana", "apple", "apple" };
            //  bool result11 = AmazonFreshPromotion(codeList2, shoppingCart2);

            //var arr = new int[] { 14, 1, 160, 8, 210 };
            //var tree = MinimuDistanceInBST.BuildTree(arr);
            //Console.WriteLine(MinimuDistanceInBST.getMinimumDIstance(tree));

            //var ratings = new int[][] { new int[] { 4, 4 }, new int[] { 1, 2 }, new int[] { 3, 6 } };
            //int threshold = 77;
            //int result = FiveStarSeller.GetMinimumReviewsNeeded(ratings, threshold);
            //Console.WriteLine(result);

            //var a = new int[][] { new int[] { 1, 2 }, new int[] { 2, 4 }, new int[] { 3, 6 } };
            //var b = new int[][] { new int[] { 1, 2 } };

            //var a = new int[][] { new int[] { 4, 10 }, new int[] { 1, 3 }, new int[] { 2, 5 }, new int[] { 3, 7 } };
            //var b = new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3,4 }, new int[] { 4,5 } };

            ////var target = 7;
            //var target = 10;
            //var resultarray = OptimalUtilization.GetOptimalUtilization(a, b, target);

            //foreach (var item1 in resultarray)
            //{
            //    Console.WriteLine($"{item1[0]}:{item1[1]}");
            //}
            //Array.Sort(a, (int[] o1, int[] o2) => o1[1] - o1[1]);
            //foreach (var item1 in a)
            //{
            //    Console.WriteLine($"{item1[0]}:{item1[1]}");
            //}

            //var str = "abccdeefge";
            //int length = 3;
            ////var subs = SubstringSizeKDistinctChars.GetSubstringSizeKDistinctChars(str, length);
            //var subs = SubstringSizeKDistinctChars.SlidingWindowTechnique(str, length);
            //foreach (var item1 in subs)
            //{
            //    Console.WriteLine($"{item1}");
            //}

            //var items = new List<PairString>() { new PairString("Item1", "Item2"), new PairString("Item3", "Item4"), new PairString("Item4", "Item5") };
            //var resultAssociation = LargestAssociation.LargestItemAssociation(items);
            //foreach (var item1 in resultAssociation)
            //{
            //    Console.WriteLine($"{item1}");
            //}


            var scores = new int[] { 20, 40, 40, 40, 40, 100 };
            var cutoffRank = 3;
            Console.WriteLine(CutOffRank.GetCutOffRank(scores, cutoffRank));

        }




    }

   
  
  
 
}
